using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace SuikodenPSP.Tools
{
    public static class FileHandler
    {
        public static List<GSDText_File> Init_Files()
        {
            // initialize files
            List<GSDText_File> files = new List<GSDText_File>();

            // parse text and translation files into jarrays
            JArray array1 = JArray.Parse(GZIP.Extract("output_text.json.gz"));
            JArray array2 = JArray.Parse(GZIP.Extract("output_translation.json.gz"));
            JArray array3 = JArray.Parse(GZIP.Extract("output_notes.json.gz"));

            // merge jarray's
            array1.Merge(array2, new JsonMergeSettings { MergeArrayHandling = MergeArrayHandling.Merge });
            array1.Merge(array3, new JsonMergeSettings { MergeArrayHandling = MergeArrayHandling.Merge });
            // convert merged array into GSDText_File list
            files = array1.ToObject<List<GSDText_File>>();
            foreach (GSDText_File file in files)
            {
                // for each file, set the filename on all the GSDText_Items
                file.Set_File_Names();
                // change null texts to blank strings
                file.Remove_Nulls();
            }
            // identify and set duplicates

            return files;
        }

        public static void Save_All_Files(List<GSDText_File> files)
        {
            Save_Translation(files);
            Save_Hacking_Notes(files);
        }
        public static void Save_Translation(List<GSDText_File> files)
        {
            var settings = new JsonSerializerSettings
            {
                ContractResolver = new TranslateResolver()
            };
            string json = JsonConvert.SerializeObject(files, Formatting.Indented, settings);
            GZIP.Compress(json, @"output_translation.json.gz");
        }


        public static void Save_Hacking_Notes(List<GSDText_File> files)
        {
            var settings = new JsonSerializerSettings
            {
                ContractResolver = new HackingNotesResolver()
            };
            string json = JsonConvert.SerializeObject(files, Formatting.Indented, settings);
            GZIP.Compress(json, @"output_notes.json.gz");
        }
    }

    // There is probably a better way to split up the json files, but this worked.
    public class TranslateResolver : DefaultContractResolver
    {
        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
        {
            JsonProperty prop = base.CreateProperty(member, memberSerialization);
            if (prop.UnderlyingName == "Hacking_Notes")
            {
                // drop hacking notes when saving translation
                return null;
            }
            return prop;
        }
    }

    public class HackingNotesResolver : DefaultContractResolver
    {
        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
        {
            JsonProperty prop = base.CreateProperty(member, memberSerialization);
            if (prop.UnderlyingName == "Translated_Text" || prop.UnderlyingName == "Translation_Notes")
            {
                // drop translation and translation notes when saving hacking notes
                return null;
            }
            return prop;
        }
    }
}

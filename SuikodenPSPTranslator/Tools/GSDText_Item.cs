using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace SuikodenPSP.Tools
{
    public class GSDText_Item
    {
        public int id { get; set; }
        [JsonIgnore]
        public string Filename { get; set; }
        public int table { get; set; }
        public int table_index { get; set; }
        public String PSP_Text { get; set; }
        public String Translated_Text { get; set; }
        public String PSX_Text { get; set; }
        public String Translation_Notes { get; set; }
        public String Hacking_Notes { get; set; }
        [JsonIgnore]
        public List<GSDText_Item> duplicates { get; set; }
        public bool ShouldSerializetable() { return false; }
        public bool ShouldSerializetable_index() { return false; }
        public bool ShouldSerializePSP_Text() { return false; }
        public bool ShouldSerializePSX_Text() { return false; }

        public GSDText_Item()
        {
            duplicates = new List<GSDText_Item>();
        }

        public String Check_Errors() 
        {
            
            // replace [Control Character]'s with a string representing the max possible width
            string test = Translated_Text.Replace("[HERO]", "WWWWWWWW");
            test = test.Replace("[CASTLE]", "WWWWWWWW");
            test = test.Replace("[MCDOHL]", "WWWWWWWW");
            test = test.Replace("[TORAN]", "WWWWWWWW");
            test = test.Replace("[ARMY]", "WWWWWWWW");
            test = test.Replace("[FAUXNANAMI]", "WWWWWWWW");
            test = test.Replace("[FAUXHERO]", "WWWWWWWW");
            test = test.Replace("[Orb]", "W");
            test = test.Replace("[Talisman]", "W");
            test = test.Replace("[Rune]", "W");
            test = test.Replace("[Orb]", "W");
            test = test.Replace("[Trade]", "W");
            test = test.Replace("[Inn]", "W");
            test = test.Replace("[Appraiser]", "W");
            test = test.Replace("[Blacksmith]", "W");
            test = test.Replace("[Item]", "W");
            test = test.Replace("[Helmet]", "W");
            test = test.Replace("[Armor]", "W");
            test = test.Replace("[Shield]", "W");
            test = test.Replace("[Acc]", "W");
            test = test.Replace("[SPACE]", "W");
            // Replace prompt w/ new line
            test = test.Replace("[PROMPT]", "{LINE}");
            // Convert newline to use not-brackets
            test = test.Replace("[LINE]", "{LINE}");
            
            // regex to remove anything else inbetween brackets that have no impact on length
            var pattern = @"\[(.*?)\]";
            test = Regex.Replace(test, pattern, string.Empty);
            
            // split on {LINE}
            List<string> strings = test.Split(new string[] { "{LINE}" }, StringSplitOptions.None).ToList();
            int i = 1;
            foreach(string str in strings)
            {
                // check each string from the split
                // if length > 40, return error message
                if (str.Length > 40)
                {
                    return $"Line {i} is too long - {str.Length} characters. ({str.Length - 40} too long.)";
                }
                // only increment counter if string is > 0 length
                if (str.Length > 0)
                {
                    i++;
                }
            }
            // no errors, return blank string
            return "";
        }

    }
}

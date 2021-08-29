using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

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

    }
}

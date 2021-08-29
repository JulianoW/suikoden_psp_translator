﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Newtonsoft.Json;

namespace SuikodenPSP.Tools
{
    public class GSDText_File
    {
        public string Filename { get; set; }
        public List<GSDText_Item> Text_Items { get; set; }
        // display text showing how many items have a translation - do not include in json
        [JsonIgnore]
        public string Display { get { return $"{Filename} - {Text_Items.Where(x => x.Translated_Text != null && x.Translated_Text != "").Count()}/{Text_Items.Count-1}"; } }

        public GSDText_File()
        {
            Text_Items = new List<GSDText_Item>();
        }

        public void Set_File_Names()
        {
            foreach(GSDText_Item item in Text_Items)
            {
                item.Filename = Filename;
            }
        }
    }
}

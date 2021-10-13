using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
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

        private String Placeholder_Text()
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
            test = test.Replace("[PROMPT]", "{PROMPT}");
            // Convert newline to use not-brackets
            test = test.Replace("[LINE]", "{LINE}");

            // regex to remove anything else inbetween brackets that have no impact on length
            var pattern = @"\[(.*?)\]";
            test = Regex.Replace(test, pattern, string.Empty);

            return test;
        }

        public void DrawStuff(Graphics G, string p)
        {
            G.Clear(Color.Gray);
            string test = Placeholder_Text();
            Dictionary<char, int> widths = Get_Dict();
            List<string> prompts = test.Split(new string[] { "{PROMPT}" }, StringSplitOptions.None).ToList();
            //foreach (String prompt in prompts)
            //{
            int p_num = 1;
            int a_num = prompts.Count();
            int.TryParse(p, out p_num);
            if (p_num <= a_num && p_num > 0)
            {
                List<string> strings = prompts[p_num - 1].Split(new string[] { "{LINE}" }, StringSplitOptions.None).ToList();

                int x = 0;
                int y = 0;


                foreach (String str in strings)
                {
                    SolidBrush black = new SolidBrush(Color.Black);
                    SolidBrush red = new SolidBrush(Color.Red);
                    x = 0;
                    foreach (char c in str)
                    {
                        if (c == ' ')
                        {
                            x += 8;
                        }
                        else
                        {
                            int width = 12;
                            if (widths.ContainsKey(c))
                            {
                                width = widths[c];
                            }

                            Rectangle rec = new Rectangle(x, y, width, 12);
                            G.FillRectangle(black, rec);
                            x += width;
                        }
                    }
                    y += 12;
                }
            }
        }
        private Dictionary<char, int> Get_Dict()
        {
            return new Dictionary<char, int>()
            {
                {'A',7},
                {'B',7},
                {'C',7},
                {'D',7},
                {'E',7},
                {'F',7},
                {'G',7},
                {'H',8},
                {'I',6},
                {'J',4},
                {'K',8},
                {'L',7},
                {'M',8},
                {'N',7},
                {'O',8},
                {'P',7},
                {'Q',8},
                {'R',8},
                {'S',7},
                {'T',8},
                {'U',8},
                {'V',8},
                {'W',8},
                {'X',8},
                {'Y',8},
                {'Z',7},
                {'a',7},
                {'b',6},
                {'c',7},
                {'d',8},
                {'e',6},
                {'f',5},
                {'g',7},
                {'h',6},
                {'i',4},
                {'j',4},
                {'k',6},
                {'l',4},
                {'m',8},
                {'n',6},
                {'o',6},
                {'p',6},
                {'q',7},
                {'r',6},
                {'s',6},
                {'t',4},
                {'u',7},
                {'v',6},
                {'w',8},
                {'x',6},
                {'y',7},
                {'z',7},
                {'0',8},
                {'1',8},
                {'2',8},
                {'3',8},
                {'4',8},
                {'5',8},
                {'6',8},
                {'7',8},
                {'8',8},
                {'9',8},
                {'?',7},
                {'!',5},
                {'\"',7},
                {'#',7},
                {':',5},
                {'%',8},
                {'&',7},
                {'\'',5},
                {'(',6},
                {')',5},
                {';',5},
                {'+',8},
                {',',4},
                {'-',8},
                {'.',4},
                {'/',8},
                {'*',8}

            };
        }

        public String Check_Errors()
        {

            string test = Placeholder_Text();

            test = test.Replace("{PROMPT}", "{LINE}");
            // split on {LINE}
            List<string> strings = test.Split(new string[] { "{LINE}" }, StringSplitOptions.None).ToList();
            int i = 1;
            foreach (string str in strings)
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

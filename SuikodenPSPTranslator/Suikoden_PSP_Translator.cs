using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuikodenPSP.Tools;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SuikodenPSPTranslator
{
    public partial class Suikoden_PSP_Translator : Form
    {
        public List<GSDText_File> files { get; set; }
        public GSDText_File current_file { get; set; }
        public GSDText_Item current_item { get; set; }
        public Suikoden_PSP_Translator()
        {
            files = FileHandler.Init_Files();
            ID_Duplicates();
            InitializeComponent();

            ddl_Files.DataSource = files;
            ddl_Files.DisplayMember = "Display";
            ddl_Files.ValueMember = "Filename";

            ddl_Search_Type.SelectedIndex = 0;
        }

        private void ID_Duplicates()
        {
            // Need to identify all duplicates for each GSDText_Item and add references to property "duplicates" (list)

            // create a single list of all text item
            List<GSDText_Item> items = new List<GSDText_Item>();
            // loop through all files
            foreach (GSDText_File file in files)
            {
                // loop through each text item
                foreach (GSDText_Item item in file.Text_Items)
                {
                    // ignore any blank or null items
                    if (item.PSP_Text != null && item.PSP_Text != "")
                    {
                        items.Add(item);
                    }
                }
            }

            // linq query on list of all items
            // group by the text - select ones where count > 1 (duplicated items)
            var has_duplicates = items.GroupBy(x => x.PSP_Text)
                        .Where(x => x.Count() > 1)
                        .Select(x => new { duplicates = x.ToList() });

            // creates a list where each node has a duplicates property which is a list of the duplicated items
            // ex:
            // [0]
            // - duplicates
            //   [0] - reference to GSDText_Item #1
            //   [1] - reference to GSDText_Item #2
            //   [2] - reference to GSDText_Item #3
            // need to loop through all those and assign the duplicates to each item's duplicate property

            // loop through all nodes w/ grouped duplicates
            foreach (var a in has_duplicates)
            {
                // loop through all the duplicates
                foreach (var item in a.duplicates)
                {
                    // assign the other items in the node (excluding themselves)
                    item.duplicates = a.duplicates.Where(x => x != item).ToList();
                }
            }
        }

        private void update_item()
        {
            // update UI objects with data from GSDText_Item
            int current = 1;
            if (int.TryParse(tbx_Current.Text, out current)) // tbx current has the item id (plus one so it starts at 1)
            {
                if (current < current_file.Text_Items.Count())
                {
                    // find the item in the current file with given id
                    current_item = current_file.Text_Items.Where(x => x.id == current - 1).FirstOrDefault();
                }
            }
            if (current_item != null)
            {
                // if we found an item, update text boxes - replace [LINE] w/ NewLine
                tbx_PSP_Text.Text = current_item.PSP_Text.Replace("[LINE]", Environment.NewLine);
                tbx_Translate.Text = current_item.Translated_Text.Replace("[LINE]", Environment.NewLine);
                tbx_PSX_Text.Text = current_item.PSX_Text.Replace("[LINE]", Environment.NewLine);
                tbx_Translation_Notes.Text = current_item.Translation_Notes;
                tbx_Hacking_Notes.Text = current_item.Hacking_Notes;

                // adjust dupe display
                if (current_item.duplicates.Count() > 0)
                {
                    // if dupes identified, set the current and total #'s
                    tbx_Dupe_Current.Text = "1";
                    tbx_Dupe_Total.Text = current_item.duplicates.Count().ToString();
                    // update dupe ui objects
                    update_dupe();
                }
                else
                {
                    // if no dupes, set objects accordingly
                    tbx_Dupe_Current.Text = "0";
                    tbx_Dupe_Total.Text = "0";
                    lbl_Dupe_Name.Text = "Duplicate File: None";
                    tbx_Dupe_PSP_Text.Text = "";
                    tbx_Dupe_Translate.Text = "";
                }

            }
            lbl_Current_File.Text = $"Current File: {current_file.Display}";
            lbl_error.Text = current_item.Check_Errors();
            tbx_Prompt.Text = "1";
            Draw_Text();
        }

        private void update_dupe()
        {
            // make sure there are dupes
            if (tbx_Dupe_Total.Text != "0" && tbx_Dupe_Current.Text != "0")
            {
                // grab the GSDText_item in the current item's duplicate list that matches the id-1
                GSDText_Item dupe = current_item.duplicates[int.Parse(tbx_Dupe_Current.Text) - 1];
                
                // update text boxes and labels; replace [LINE] w/ \n
                lbl_Dupe_Name.Text = $"Duplicate File: {dupe.Filename} - #{dupe.id + 1}";
                tbx_Dupe_PSP_Text.Text = dupe.PSP_Text.Replace("[LINE]", Environment.NewLine);
                tbx_Dupe_Translate.Text = dupe.Translated_Text.Replace("[LINE]", Environment.NewLine);
            }
        }

        private void Save_Translation()
        {
            FileHandler.Save_Translation(files);
        }

        // UI OBJECTS 

        private void ddl_Files_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Load new file from ddl_Files
            current_file = (GSDText_File)ddl_Files.SelectedItem;
            // set first item
            tbx_Current.Text = "1";
            tbx_Total.Text = (current_file.Text_Items.Count() - 1).ToString();
            // Update UI
            update_item();
        }

        private void tbx_Current_TextChanged(object sender, EventArgs e)
        {
            // Change Current Item
            // Update UI
            update_item();
            // Save Changes
            //Save_Translation();
        }

        // Translation Updates
        private void tbx_Translate_Leave(object sender, EventArgs e)
        {
            // When leaving translation tbx, save
            Save_Translation();
        }


        private void tbx_Translate_TextChanged(object sender, EventArgs e)
        {
            // When translation txt changed, update Translated Text property of current item
            // change newline back to [LINE]
            current_item.Translated_Text = tbx_Translate.Text.Replace(Environment.NewLine, "[LINE]");
            // code to validate line sizes
            lbl_error.Text = current_item.Check_Errors();
            Draw_Text();

        }
        private void tbx_Translation_Notes_Leave(object sender, EventArgs e)
        {
            // When leaving notes tbx, save
            FileHandler.Save_Translation(files);
        }
        private void tbx_Translation_Notes_TextChanged(object sender, EventArgs e)
        {
            // When notes txt changed, update Notes Text property of current item
            current_item.Translation_Notes = tbx_Translation_Notes.Text;
        }
        private void tbx_Hacking_Notes_Leave(object sender, EventArgs e)
        {
            // When leaving notes tbx, save
            FileHandler.Save_Hacking_Notes(files);
        }
        private void tbx_Hacking_Notes_TextChanged(object sender, EventArgs e)
        {
            // When notes txt changed, update Notes Text property of current item
            current_item.Hacking_Notes = tbx_Hacking_Notes.Text;
        }

        // Navigation - All trigger tbx_current_textchanged - don't need to save twice
        private void btn_Start_Click(object sender, EventArgs e)
        {
            // Go to 1st Item
            tbx_Current.Text = "1";
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            // Go Back 1 Item
            int new_no = 1;
            if (int.TryParse(tbx_Current.Text, out new_no))
            {
                // make sure in bounds
                if (new_no > 1)
                {
                    tbx_Current.Text = (new_no - 1).ToString();
                }
            }
        }

        private void btn_Forward_Click(object sender, EventArgs e)
        {
            // Go Forward 1 Item
            int new_no = 1;
            if (int.TryParse(tbx_Current.Text, out new_no))
            {
                // make sure in bounds
                if (new_no < (current_file.Text_Items.Count() - 1))
                {
                    tbx_Current.Text = (new_no + 1).ToString();
                }
            }
        }

        private void btn_End_Click(object sender, EventArgs e)
        {
            // Go to Last Item
            tbx_Current.Text = (current_file.Text_Items.Count() - 1).ToString();
        }

        // Duplicate UI
        private void tbx_Dupe_Current_TextChanged(object sender, EventArgs e)
        {
            // Changed to a different duplicate item - update UI
            update_dupe();
        }

        // Dupe Navigation
        private void btn_Dupe_Start_Click(object sender, EventArgs e)
        {
            // Go to 1st Item
            if (tbx_Dupe_Total.Text != "0" && tbx_Dupe_Current.Text != "0")
            {
                tbx_Dupe_Current.Text = "1";
            }
        }

        private void btn_Dupe_Back_Click(object sender, EventArgs e)
        {
            // Go Back 1 Item
            if (tbx_Dupe_Total.Text != "0" && tbx_Dupe_Current.Text != "0")
            {
                int new_no = 1;
                if (int.TryParse(tbx_Dupe_Current.Text, out new_no))
                {
                    // make sure in bounds
                    if (new_no > 1)
                    {
                        tbx_Dupe_Current.Text = (new_no - 1).ToString();
                    }
                }
            }
        }

        private void btn_Dupe_Forward_Click(object sender, EventArgs e)
        {
            // Go Forward 1 Item
            if (tbx_Dupe_Total.Text != "0" && tbx_Dupe_Current.Text != "0")
            {
                int new_no = 1;
                if (int.TryParse(tbx_Dupe_Current.Text, out new_no))
                {
                    // make sure in bounds
                    if (new_no < int.Parse(tbx_Dupe_Total.Text))
                    {
                        tbx_Dupe_Current.Text = (new_no + 1).ToString();
                    }
                }
            }
        }

        private void btn_Dupe_End_Click(object sender, EventArgs e)
        {
            // Go to Last Item
            if (tbx_Dupe_Total.Text != "0" && tbx_Dupe_Current.Text != "0")
            {
                tbx_Dupe_Current.Text = tbx_Dupe_Total.Text;
            }
        }

        // Duplicate Management
        private void btn_copy_Click(object sender, EventArgs e)
        {
            // Copy to current duplicate
            if (tbx_Dupe_Total.Text != "0" && tbx_Dupe_Current.Text != "0")
            {
                // get duplicate GSDText_Item and update translated text w/ current translation
                GSDText_Item dupe = current_item.duplicates[int.Parse(tbx_Dupe_Current.Text) - 1];
                dupe.Translated_Text = tbx_Translate.Text.Replace(Environment.NewLine, "[LINE]");
            }
            // update dupe ui to reflect updated text and save file
            update_dupe();
            Save_Translation();
        }

        private void btn_copy_all_Click(object sender, EventArgs e)
        {
            // Copy translation to all duplicates
            foreach (GSDText_Item item in current_item.duplicates)
            {
                // loop through all dupes, set translated text for each one
                item.Translated_Text = tbx_Translate.Text.Replace(Environment.NewLine, "[LINE]");
            }
            // update dupe ui to reflect updated text and save file
            update_dupe();
            Save_Translation();
        }



        // Search
        private void btn_Search_Click(object sender, EventArgs e)
        {
            // search current list for tbx_Search.txt in psp_text

            int curr_no = 1;
            int total_no = 1;
            // get current and total numbers - make sure they're valid
            if (int.TryParse(tbx_Current.Text, out curr_no))
            {
                if (int.TryParse(tbx_Total.Text, out total_no))
                {
                    // get a list of items in file that match search criteria
                    // order them in ascending order following the current item id
                    List<GSDText_Item> results = new List<GSDText_Item>();

                    // check which search type we're using to determine which property to search
                    if (ddl_Search_Type.SelectedIndex == 0)
                    {
                        // Japanese
                        results = current_file.Text_Items.Where(x => x.PSP_Text.Contains(tbx_Search.Text)).OrderBy(x => Mod((x.id + 1 - curr_no), total_no)).ToList();
                    }
                    if (ddl_Search_Type.SelectedIndex == 1)
                    {
                        // Translated
                        results = current_file.Text_Items.Where(x => x.Translated_Text.Contains(tbx_Search.Text)).OrderBy(x => Mod((x.id + 1 - curr_no), total_no)).ToList();
                    }
                    if (ddl_Search_Type.SelectedIndex == 2)
                    {
                        // PSX Text
                        results = current_file.Text_Items.Where(x => x.PSX_Text.Contains(tbx_Search.Text)).OrderBy(x => Mod((x.id + 1 - curr_no), total_no)).ToList();
                    }


                    foreach (GSDText_Item item in results)
                    {
                        // go through result list, make sure not picking up the current item
                        if ((item.id + 1) != curr_no)
                        {
                            // set id to the next one and break out of loop
                            tbx_Current.Text = (item.id + 1).ToString();
                            break;
                        }
                    }
                }
            }
        }

        private void Draw_Text()
        {
            if (cbx_Preview.Checked)
            {
                Graphics g = pnl_Preview.CreateGraphics();

                //Image sourceImage = Image.FromFile(@"D:\Suikoden\PSP\font_new\35.png");
                //Rectangle sourceRect = new Rectangle(0, 0, 16, 16);
                //g.DrawImage(sourceImage, 0, 0, sourceRect, GraphicsUnit.Pixel);
                // Pen pen = new Pen(Color.Blue, 1);
                //Rectangle r = new Rectangle(1, 1, 10, 10);
                //g.DrawRectangle(pen, r);
                current_item.DrawStuff(g, tbx_Prompt.Text);
            }
        }

        private float Mod(float a, float b)
        {
            float c = a % b;
            if ((c < 0 && b > 0) || (c > 0 && b < 0))
            {
                c += b;
            }
            return c;
        }

        private void btn_save_all_Click(object sender, EventArgs e)
        {
            FileHandler.Save_All_Files(files);
        }

        private void cbx_Preview_CheckedChanged(object sender, EventArgs e)
        {
            tbx_h_w_changed(sender, e);
            pnl_Preview.Visible = cbx_Preview.Checked;
            tbx_Prompt.Text = "1";
            Draw_Text();
        }

        private void tbx_h_w_changed(object sender, EventArgs e)
        {
            int x1, x2, x3, y1, y2, y3 = -1;
            int.TryParse(tbx_h1.Text, out y1);
            int.TryParse(tbx_h2.Text, out y2);
            int.TryParse(tbx_h3.Text, out y3);
            int.TryParse(tbx_w1.Text, out x1);
            int.TryParse(tbx_w2.Text, out x2);
            int.TryParse(tbx_w3.Text, out x3);
            if (y3 > 0)
            {
                pnl_Preview.Height = y3;
            }
            else
            {
                if (y1 > 0 && y2 > 0)
                {
                    pnl_Preview.Height = y1 * y2;
                }
            }
            if (x3 > 0)
            {
                pnl_Preview.Width = x3;
            }
            else
            {
                if (x1 > 0 && x2 > 0)
                {
                    pnl_Preview.Width = x1 * x2;
                }
            }
            Draw_Text();
        }

        private void tbx_Prompt_TextChanged(object sender, EventArgs e)
        {

            Draw_Text();
        }
    }
}

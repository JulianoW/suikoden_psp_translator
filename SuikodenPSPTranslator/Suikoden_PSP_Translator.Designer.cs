using System.Windows.Forms;

namespace SuikodenPSPTranslator
{
    partial class Suikoden_PSP_Translator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbx_PSP_Text = new System.Windows.Forms.TextBox();
            this.tbx_Current = new System.Windows.Forms.TextBox();
            this.tbx_Total = new System.Windows.Forms.TextBox();
            this.ddl_Files = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Forward = new System.Windows.Forms.Button();
            this.btn_End = new System.Windows.Forms.Button();
            this.tbx_Translate = new System.Windows.Forms.TextBox();
            this.tbx_Dupe_Translate = new System.Windows.Forms.TextBox();
            this.btn_Dupe_End = new System.Windows.Forms.Button();
            this.btn_Dupe_Forward = new System.Windows.Forms.Button();
            this.btn_Dupe_Back = new System.Windows.Forms.Button();
            this.btn_Dupe_Start = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_Dupe_Total = new System.Windows.Forms.TextBox();
            this.tbx_Dupe_Current = new System.Windows.Forms.TextBox();
            this.lbl_Dupe_Name = new System.Windows.Forms.Label();
            this.tbx_Dupe_PSP_Text = new System.Windows.Forms.TextBox();
            this.tbx_Search = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_copy = new System.Windows.Forms.Button();
            this.btn_copy_all = new System.Windows.Forms.Button();
            this.lbl_Current_File = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_PSX_Text = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ddl_Search_Type = new System.Windows.Forms.ComboBox();
            this.tbx_Translation_Notes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbx_Hacking_Notes = new System.Windows.Forms.TextBox();
            this.btn_save_all = new System.Windows.Forms.Button();
            this.lbl_error = new System.Windows.Forms.Label();
            this.cbx_Preview = new System.Windows.Forms.CheckBox();
            this.pnl_Preview = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbx_w1 = new System.Windows.Forms.TextBox();
            this.tbx_w2 = new System.Windows.Forms.TextBox();
            this.tbx_w3 = new System.Windows.Forms.TextBox();
            this.tbx_h3 = new System.Windows.Forms.TextBox();
            this.tbx_h2 = new System.Windows.Forms.TextBox();
            this.tbx_h1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbx_Prompt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_TranslNotes_Back = new System.Windows.Forms.Button();
            this.btn_TranslNotes_Forward = new System.Windows.Forms.Button();
            this.btn_HackNotes_Back = new System.Windows.Forms.Button();
            this.btn_HackNotes_Forward = new System.Windows.Forms.Button();
            this.lbl_table_field = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbx_PSP_Text
            // 
            this.tbx_PSP_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_PSP_Text.Location = new System.Drawing.Point(174, 90);
            this.tbx_PSP_Text.Multiline = true;
            this.tbx_PSP_Text.Name = "tbx_PSP_Text";
            this.tbx_PSP_Text.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbx_PSP_Text.Size = new System.Drawing.Size(423, 214);
            this.tbx_PSP_Text.TabIndex = 0;
            this.tbx_PSP_Text.WordWrap = false;
            // 
            // tbx_Current
            // 
            this.tbx_Current.Location = new System.Drawing.Point(277, 45);
            this.tbx_Current.Name = "tbx_Current";
            this.tbx_Current.Size = new System.Drawing.Size(58, 20);
            this.tbx_Current.TabIndex = 2;
            this.tbx_Current.TextChanged += new System.EventHandler(this.tbx_Current_TextChanged);
            // 
            // tbx_Total
            // 
            this.tbx_Total.Enabled = false;
            this.tbx_Total.Location = new System.Drawing.Point(363, 45);
            this.tbx_Total.Name = "tbx_Total";
            this.tbx_Total.Size = new System.Drawing.Size(58, 20);
            this.tbx_Total.TabIndex = 3;
            // 
            // ddl_Files
            // 
            this.ddl_Files.FormattingEnabled = true;
            this.ddl_Files.Location = new System.Drawing.Point(12, 12);
            this.ddl_Files.Name = "ddl_Files";
            this.ddl_Files.Size = new System.Drawing.Size(153, 823);
            this.ddl_Files.TabIndex = 4;
            this.ddl_Files.SelectedIndexChanged += new System.EventHandler(this.ddl_Files_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "of";
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(185, 43);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(40, 23);
            this.btn_Start.TabIndex = 6;
            this.btn_Start.Text = "<<";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(231, 43);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(40, 23);
            this.btn_Back.TabIndex = 7;
            this.btn_Back.Text = "<";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Forward
            // 
            this.btn_Forward.Location = new System.Drawing.Point(427, 43);
            this.btn_Forward.Name = "btn_Forward";
            this.btn_Forward.Size = new System.Drawing.Size(40, 23);
            this.btn_Forward.TabIndex = 8;
            this.btn_Forward.Text = ">";
            this.btn_Forward.UseVisualStyleBackColor = true;
            this.btn_Forward.Click += new System.EventHandler(this.btn_Forward_Click);
            // 
            // btn_End
            // 
            this.btn_End.Location = new System.Drawing.Point(473, 43);
            this.btn_End.Name = "btn_End";
            this.btn_End.Size = new System.Drawing.Size(40, 23);
            this.btn_End.TabIndex = 9;
            this.btn_End.Text = ">>";
            this.btn_End.UseVisualStyleBackColor = true;
            this.btn_End.Click += new System.EventHandler(this.btn_End_Click);
            // 
            // tbx_Translate
            // 
            this.tbx_Translate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Translate.Location = new System.Drawing.Point(606, 90);
            this.tbx_Translate.Multiline = true;
            this.tbx_Translate.Name = "tbx_Translate";
            this.tbx_Translate.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbx_Translate.Size = new System.Drawing.Size(423, 214);
            this.tbx_Translate.TabIndex = 10;
            this.tbx_Translate.WordWrap = false;
            this.tbx_Translate.TextChanged += new System.EventHandler(this.tbx_Translate_TextChanged);
            this.tbx_Translate.Leave += new System.EventHandler(this.tbx_Translate_Leave);
            // 
            // tbx_Dupe_Translate
            // 
            this.tbx_Dupe_Translate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Dupe_Translate.Location = new System.Drawing.Point(609, 387);
            this.tbx_Dupe_Translate.Multiline = true;
            this.tbx_Dupe_Translate.Name = "tbx_Dupe_Translate";
            this.tbx_Dupe_Translate.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbx_Dupe_Translate.Size = new System.Drawing.Size(422, 171);
            this.tbx_Dupe_Translate.TabIndex = 11;
            this.tbx_Dupe_Translate.WordWrap = false;
            // 
            // btn_Dupe_End
            // 
            this.btn_Dupe_End.Location = new System.Drawing.Point(473, 334);
            this.btn_Dupe_End.Name = "btn_Dupe_End";
            this.btn_Dupe_End.Size = new System.Drawing.Size(40, 23);
            this.btn_Dupe_End.TabIndex = 18;
            this.btn_Dupe_End.Text = ">>";
            this.btn_Dupe_End.UseVisualStyleBackColor = true;
            this.btn_Dupe_End.Click += new System.EventHandler(this.btn_Dupe_End_Click);
            // 
            // btn_Dupe_Forward
            // 
            this.btn_Dupe_Forward.Location = new System.Drawing.Point(427, 334);
            this.btn_Dupe_Forward.Name = "btn_Dupe_Forward";
            this.btn_Dupe_Forward.Size = new System.Drawing.Size(40, 23);
            this.btn_Dupe_Forward.TabIndex = 17;
            this.btn_Dupe_Forward.Text = ">";
            this.btn_Dupe_Forward.UseVisualStyleBackColor = true;
            this.btn_Dupe_Forward.Click += new System.EventHandler(this.btn_Dupe_Forward_Click);
            // 
            // btn_Dupe_Back
            // 
            this.btn_Dupe_Back.Location = new System.Drawing.Point(231, 334);
            this.btn_Dupe_Back.Name = "btn_Dupe_Back";
            this.btn_Dupe_Back.Size = new System.Drawing.Size(40, 23);
            this.btn_Dupe_Back.TabIndex = 16;
            this.btn_Dupe_Back.Text = "<";
            this.btn_Dupe_Back.UseVisualStyleBackColor = true;
            this.btn_Dupe_Back.Click += new System.EventHandler(this.btn_Dupe_Back_Click);
            // 
            // btn_Dupe_Start
            // 
            this.btn_Dupe_Start.Location = new System.Drawing.Point(185, 334);
            this.btn_Dupe_Start.Name = "btn_Dupe_Start";
            this.btn_Dupe_Start.Size = new System.Drawing.Size(40, 23);
            this.btn_Dupe_Start.TabIndex = 15;
            this.btn_Dupe_Start.Text = "<<";
            this.btn_Dupe_Start.UseVisualStyleBackColor = true;
            this.btn_Dupe_Start.Click += new System.EventHandler(this.btn_Dupe_Start_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "of";
            // 
            // tbx_Dupe_Total
            // 
            this.tbx_Dupe_Total.Enabled = false;
            this.tbx_Dupe_Total.Location = new System.Drawing.Point(363, 336);
            this.tbx_Dupe_Total.Name = "tbx_Dupe_Total";
            this.tbx_Dupe_Total.Size = new System.Drawing.Size(58, 20);
            this.tbx_Dupe_Total.TabIndex = 13;
            // 
            // tbx_Dupe_Current
            // 
            this.tbx_Dupe_Current.Location = new System.Drawing.Point(277, 336);
            this.tbx_Dupe_Current.Name = "tbx_Dupe_Current";
            this.tbx_Dupe_Current.Size = new System.Drawing.Size(58, 20);
            this.tbx_Dupe_Current.TabIndex = 12;
            this.tbx_Dupe_Current.TextChanged += new System.EventHandler(this.tbx_Dupe_Current_TextChanged);
            // 
            // lbl_Dupe_Name
            // 
            this.lbl_Dupe_Name.AutoSize = true;
            this.lbl_Dupe_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Dupe_Name.Location = new System.Drawing.Point(177, 364);
            this.lbl_Dupe_Name.Name = "lbl_Dupe_Name";
            this.lbl_Dupe_Name.Size = new System.Drawing.Size(129, 16);
            this.lbl_Dupe_Name.TabIndex = 19;
            this.lbl_Dupe_Name.Text = "Duplicate File: None";
            // 
            // tbx_Dupe_PSP_Text
            // 
            this.tbx_Dupe_PSP_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Dupe_PSP_Text.Location = new System.Drawing.Point(174, 387);
            this.tbx_Dupe_PSP_Text.Multiline = true;
            this.tbx_Dupe_PSP_Text.Name = "tbx_Dupe_PSP_Text";
            this.tbx_Dupe_PSP_Text.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbx_Dupe_PSP_Text.Size = new System.Drawing.Size(423, 171);
            this.tbx_Dupe_PSP_Text.TabIndex = 20;
            this.tbx_Dupe_PSP_Text.WordWrap = false;
            // 
            // tbx_Search
            // 
            this.tbx_Search.Location = new System.Drawing.Point(690, 40);
            this.tbx_Search.Name = "tbx_Search";
            this.tbx_Search.Size = new System.Drawing.Size(173, 20);
            this.tbx_Search.TabIndex = 55;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(867, 39);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 56;
            this.btn_Search.Text = "Find Next";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_copy
            // 
            this.btn_copy.Location = new System.Drawing.Point(714, 336);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(75, 23);
            this.btn_copy.TabIndex = 23;
            this.btn_copy.Text = "Copy";
            this.btn_copy.UseVisualStyleBackColor = true;
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            // 
            // btn_copy_all
            // 
            this.btn_copy_all.Location = new System.Drawing.Point(845, 336);
            this.btn_copy_all.Name = "btn_copy_all";
            this.btn_copy_all.Size = new System.Drawing.Size(75, 23);
            this.btn_copy_all.TabIndex = 24;
            this.btn_copy_all.Text = "Copy All";
            this.btn_copy_all.UseVisualStyleBackColor = true;
            this.btn_copy_all.Click += new System.EventHandler(this.btn_copy_all_Click);
            // 
            // lbl_Current_File
            // 
            this.lbl_Current_File.AutoSize = true;
            this.lbl_Current_File.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Current_File.Location = new System.Drawing.Point(177, 17);
            this.lbl_Current_File.Name = "lbl_Current_File";
            this.lbl_Current_File.Size = new System.Drawing.Size(114, 16);
            this.lbl_Current_File.TabIndex = 25;
            this.lbl_Current_File.Text = "Current File: None";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(177, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Japanese Text";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(611, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Translated Text";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(604, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Search:";
            // 
            // tbx_PSX_Text
            // 
            this.tbx_PSX_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_PSX_Text.Location = new System.Drawing.Point(1041, 90);
            this.tbx_PSX_Text.Multiline = true;
            this.tbx_PSX_Text.Name = "tbx_PSX_Text";
            this.tbx_PSX_Text.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbx_PSX_Text.Size = new System.Drawing.Size(423, 214);
            this.tbx_PSX_Text.TabIndex = 29;
            this.tbx_PSX_Text.WordWrap = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1038, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 30;
            this.label6.Text = "PSX Script Text";
            // 
            // ddl_Search_Type
            // 
            this.ddl_Search_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_Search_Type.FormattingEnabled = true;
            this.ddl_Search_Type.Items.AddRange(new object[] {
            "Japanese",
            "Translated",
            "PSX Script"});
            this.ddl_Search_Type.Location = new System.Drawing.Point(606, 40);
            this.ddl_Search_Type.Name = "ddl_Search_Type";
            this.ddl_Search_Type.Size = new System.Drawing.Size(79, 21);
            this.ddl_Search_Type.TabIndex = 54;
            // 
            // tbx_Translation_Notes
            // 
            this.tbx_Translation_Notes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Translation_Notes.Location = new System.Drawing.Point(174, 592);
            this.tbx_Translation_Notes.Multiline = true;
            this.tbx_Translation_Notes.Name = "tbx_Translation_Notes";
            this.tbx_Translation_Notes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbx_Translation_Notes.Size = new System.Drawing.Size(676, 243);
            this.tbx_Translation_Notes.TabIndex = 57;
            this.tbx_Translation_Notes.TextChanged += new System.EventHandler(this.tbx_Translation_Notes_TextChanged);
            this.tbx_Translation_Notes.Leave += new System.EventHandler(this.tbx_Translation_Notes_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(177, 568);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 16);
            this.label7.TabIndex = 58;
            this.label7.Text = "Translation Notes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(862, 568);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 16);
            this.label8.TabIndex = 60;
            this.label8.Text = "Hacking Notes";
            // 
            // tbx_Hacking_Notes
            // 
            this.tbx_Hacking_Notes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Hacking_Notes.Location = new System.Drawing.Point(858, 592);
            this.tbx_Hacking_Notes.Multiline = true;
            this.tbx_Hacking_Notes.Name = "tbx_Hacking_Notes";
            this.tbx_Hacking_Notes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbx_Hacking_Notes.Size = new System.Drawing.Size(606, 243);
            this.tbx_Hacking_Notes.TabIndex = 61;
            this.tbx_Hacking_Notes.TextChanged += new System.EventHandler(this.tbx_Hacking_Notes_TextChanged);
            this.tbx_Hacking_Notes.Leave += new System.EventHandler(this.tbx_Hacking_Notes_Leave);
            // 
            // btn_save_all
            // 
            this.btn_save_all.Location = new System.Drawing.Point(1201, 15);
            this.btn_save_all.Name = "btn_save_all";
            this.btn_save_all.Size = new System.Drawing.Size(93, 23);
            this.btn_save_all.TabIndex = 62;
            this.btn_save_all.Text = "Force Save All";
            this.btn_save_all.UseVisualStyleBackColor = true;
            this.btn_save_all.Click += new System.EventHandler(this.btn_save_all_Click);
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(614, 311);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(0, 20);
            this.lbl_error.TabIndex = 63;
            // 
            // cbx_Preview
            // 
            this.cbx_Preview.AutoSize = true;
            this.cbx_Preview.Location = new System.Drawing.Point(1043, 318);
            this.cbx_Preview.Name = "cbx_Preview";
            this.cbx_Preview.Size = new System.Drawing.Size(100, 17);
            this.cbx_Preview.TabIndex = 64;
            this.cbx_Preview.Text = "Enable Preview";
            this.cbx_Preview.UseVisualStyleBackColor = true;
            this.cbx_Preview.CheckedChanged += new System.EventHandler(this.cbx_Preview_CheckedChanged);
            // 
            // pnl_Preview
            // 
            this.pnl_Preview.Location = new System.Drawing.Point(1047, 420);
            this.pnl_Preview.Name = "pnl_Preview";
            this.pnl_Preview.Size = new System.Drawing.Size(412, 138);
            this.pnl_Preview.TabIndex = 65;
            this.pnl_Preview.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1068, 344);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 73;
            this.label9.Text = "# of Chars";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1132, 344);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 74;
            this.label10.Text = "Char Size";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1196, 344);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 75;
            this.label11.Text = "Pixel Override";
            // 
            // tbx_w1
            // 
            this.tbx_w1.Location = new System.Drawing.Point(1071, 364);
            this.tbx_w1.Name = "tbx_w1";
            this.tbx_w1.Size = new System.Drawing.Size(58, 20);
            this.tbx_w1.TabIndex = 76;
            this.tbx_w1.Text = "23";
            this.tbx_w1.TextChanged += new System.EventHandler(this.tbx_h_w_changed);
            // 
            // tbx_w2
            // 
            this.tbx_w2.Location = new System.Drawing.Point(1135, 364);
            this.tbx_w2.Name = "tbx_w2";
            this.tbx_w2.Size = new System.Drawing.Size(58, 20);
            this.tbx_w2.TabIndex = 77;
            this.tbx_w2.Text = "12";
            this.tbx_w2.TextChanged += new System.EventHandler(this.tbx_h_w_changed);
            // 
            // tbx_w3
            // 
            this.tbx_w3.Location = new System.Drawing.Point(1199, 364);
            this.tbx_w3.Name = "tbx_w3";
            this.tbx_w3.Size = new System.Drawing.Size(58, 20);
            this.tbx_w3.TabIndex = 78;
            this.tbx_w3.Text = "0";
            this.tbx_w3.TextChanged += new System.EventHandler(this.tbx_h_w_changed);
            // 
            // tbx_h3
            // 
            this.tbx_h3.Location = new System.Drawing.Point(1199, 390);
            this.tbx_h3.Name = "tbx_h3";
            this.tbx_h3.Size = new System.Drawing.Size(58, 20);
            this.tbx_h3.TabIndex = 81;
            this.tbx_h3.Text = "0";
            this.tbx_h3.TextChanged += new System.EventHandler(this.tbx_h_w_changed);
            // 
            // tbx_h2
            // 
            this.tbx_h2.Location = new System.Drawing.Point(1135, 390);
            this.tbx_h2.Name = "tbx_h2";
            this.tbx_h2.Size = new System.Drawing.Size(58, 20);
            this.tbx_h2.TabIndex = 80;
            this.tbx_h2.Text = "12";
            this.tbx_h2.TextChanged += new System.EventHandler(this.tbx_h_w_changed);
            // 
            // tbx_h1
            // 
            this.tbx_h1.Location = new System.Drawing.Point(1071, 390);
            this.tbx_h1.Name = "tbx_h1";
            this.tbx_h1.Size = new System.Drawing.Size(58, 20);
            this.tbx_h1.TabIndex = 79;
            this.tbx_h1.Text = "4";
            this.tbx_h1.TextChanged += new System.EventHandler(this.tbx_h_w_changed);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1050, 366);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 13);
            this.label12.TabIndex = 82;
            this.label12.Text = "W";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1050, 393);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(15, 13);
            this.label13.TabIndex = 83;
            this.label13.Text = "H";
            // 
            // tbx_Prompt
            // 
            this.tbx_Prompt.Location = new System.Drawing.Point(1292, 364);
            this.tbx_Prompt.Name = "tbx_Prompt";
            this.tbx_Prompt.Size = new System.Drawing.Size(58, 20);
            this.tbx_Prompt.TabIndex = 85;
            this.tbx_Prompt.Text = "1";
            this.tbx_Prompt.TextChanged += new System.EventHandler(this.tbx_Prompt_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1289, 344);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 13);
            this.label14.TabIndex = 84;
            this.label14.Text = "Prompt #";
            // 
            // btn_TranslNotes_Back
            // 
            this.btn_TranslNotes_Back.Location = new System.Drawing.Point(290, 564);
            this.btn_TranslNotes_Back.Name = "btn_TranslNotes_Back";
            this.btn_TranslNotes_Back.Size = new System.Drawing.Size(40, 23);
            this.btn_TranslNotes_Back.TabIndex = 86;
            this.btn_TranslNotes_Back.Text = "<";
            this.btn_TranslNotes_Back.UseVisualStyleBackColor = true;
            this.btn_TranslNotes_Back.Click += new System.EventHandler(this.btn_TranslNotes_Back_Click);
            // 
            // btn_TranslNotes_Forward
            // 
            this.btn_TranslNotes_Forward.Location = new System.Drawing.Point(336, 564);
            this.btn_TranslNotes_Forward.Name = "btn_TranslNotes_Forward";
            this.btn_TranslNotes_Forward.Size = new System.Drawing.Size(40, 23);
            this.btn_TranslNotes_Forward.TabIndex = 87;
            this.btn_TranslNotes_Forward.Text = ">";
            this.btn_TranslNotes_Forward.UseVisualStyleBackColor = true;
            this.btn_TranslNotes_Forward.Click += new System.EventHandler(this.btn_TranslNotes_Forward_Click);
            // 
            // btn_HackNotes_Back
            // 
            this.btn_HackNotes_Back.Location = new System.Drawing.Point(960, 564);
            this.btn_HackNotes_Back.Name = "btn_HackNotes_Back";
            this.btn_HackNotes_Back.Size = new System.Drawing.Size(40, 23);
            this.btn_HackNotes_Back.TabIndex = 88;
            this.btn_HackNotes_Back.Text = "<";
            this.btn_HackNotes_Back.UseVisualStyleBackColor = true;
            this.btn_HackNotes_Back.Click += new System.EventHandler(this.btn_HackNotes_Back_Click);
            // 
            // btn_HackNotes_Forward
            // 
            this.btn_HackNotes_Forward.Location = new System.Drawing.Point(1006, 564);
            this.btn_HackNotes_Forward.Name = "btn_HackNotes_Forward";
            this.btn_HackNotes_Forward.Size = new System.Drawing.Size(40, 23);
            this.btn_HackNotes_Forward.TabIndex = 89;
            this.btn_HackNotes_Forward.Text = ">";
            this.btn_HackNotes_Forward.UseVisualStyleBackColor = true;
            this.btn_HackNotes_Forward.Click += new System.EventHandler(this.btn_HackNotes_Forward_Click);
            // 
            // lbl_table_field
            // 
            this.lbl_table_field.AutoSize = true;
            this.lbl_table_field.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_table_field.Location = new System.Drawing.Point(323, 71);
            this.lbl_table_field.Name = "lbl_table_field";
            this.lbl_table_field.Size = new System.Drawing.Size(0, 16);
            this.lbl_table_field.TabIndex = 90;
            // 
            // Suikoden_PSP_Translator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1471, 843);
            this.Controls.Add(this.lbl_table_field);
            this.Controls.Add(this.btn_HackNotes_Forward);
            this.Controls.Add(this.btn_HackNotes_Back);
            this.Controls.Add(this.btn_TranslNotes_Forward);
            this.Controls.Add(this.btn_TranslNotes_Back);
            this.Controls.Add(this.tbx_Prompt);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbx_h3);
            this.Controls.Add(this.tbx_h2);
            this.Controls.Add(this.tbx_h1);
            this.Controls.Add(this.tbx_w3);
            this.Controls.Add(this.tbx_w2);
            this.Controls.Add(this.tbx_w1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pnl_Preview);
            this.Controls.Add(this.cbx_Preview);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.btn_save_all);
            this.Controls.Add(this.tbx_Hacking_Notes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbx_Translation_Notes);
            this.Controls.Add(this.ddl_Search_Type);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbx_PSX_Text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_Current_File);
            this.Controls.Add(this.btn_copy_all);
            this.Controls.Add(this.btn_copy);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tbx_Search);
            this.Controls.Add(this.tbx_Dupe_PSP_Text);
            this.Controls.Add(this.lbl_Dupe_Name);
            this.Controls.Add(this.btn_Dupe_End);
            this.Controls.Add(this.btn_Dupe_Forward);
            this.Controls.Add(this.btn_Dupe_Back);
            this.Controls.Add(this.btn_Dupe_Start);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_Dupe_Total);
            this.Controls.Add(this.tbx_Dupe_Current);
            this.Controls.Add(this.tbx_Dupe_Translate);
            this.Controls.Add(this.tbx_Translate);
            this.Controls.Add(this.btn_End);
            this.Controls.Add(this.btn_Forward);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ddl_Files);
            this.Controls.Add(this.tbx_Total);
            this.Controls.Add(this.tbx_Current);
            this.Controls.Add(this.tbx_PSP_Text);
            this.Name = "Suikoden_PSP_Translator";
            this.Text = "Suikoden PSP Translator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_PSP_Text;
        private System.Windows.Forms.TextBox tbx_Current;
        private System.Windows.Forms.TextBox tbx_Total;
        private System.Windows.Forms.ListBox ddl_Files;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Forward;
        private System.Windows.Forms.Button btn_End;
        private System.Windows.Forms.TextBox tbx_Translate;
        private System.Windows.Forms.TextBox tbx_Dupe_Translate;
        private System.Windows.Forms.Button btn_Dupe_End;
        private System.Windows.Forms.Button btn_Dupe_Forward;
        private System.Windows.Forms.Button btn_Dupe_Back;
        private System.Windows.Forms.Button btn_Dupe_Start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_Dupe_Total;
        private System.Windows.Forms.TextBox tbx_Dupe_Current;
        private System.Windows.Forms.Label lbl_Dupe_Name;
        private System.Windows.Forms.TextBox tbx_Dupe_PSP_Text;
        private System.Windows.Forms.TextBox tbx_Search;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_copy;
        private System.Windows.Forms.Button btn_copy_all;
        private System.Windows.Forms.Label lbl_Current_File;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_PSX_Text;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ddl_Search_Type;
        private System.Windows.Forms.TextBox tbx_Translation_Notes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbx_Hacking_Notes;
        private System.Windows.Forms.Button btn_save_all;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.CheckBox cbx_Preview;
        private System.Windows.Forms.Panel pnl_Preview;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbx_w1;
        private System.Windows.Forms.TextBox tbx_w2;
        private System.Windows.Forms.TextBox tbx_w3;
        private System.Windows.Forms.TextBox tbx_h3;
        private System.Windows.Forms.TextBox tbx_h2;
        private System.Windows.Forms.TextBox tbx_h1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbx_Prompt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_TranslNotes_Back;
        private System.Windows.Forms.Button btn_TranslNotes_Forward;
        private System.Windows.Forms.Button btn_HackNotes_Back;
        private System.Windows.Forms.Button btn_HackNotes_Forward;
        private System.Windows.Forms.Label lbl_table_field;
    }

}


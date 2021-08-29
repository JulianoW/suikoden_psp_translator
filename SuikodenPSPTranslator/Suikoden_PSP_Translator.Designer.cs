﻿namespace SuikodenPSPTranslator
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
            this.SuspendLayout();
            // 
            // tbx_PSP_Text
            // 
            this.tbx_PSP_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_PSP_Text.Location = new System.Drawing.Point(224, 135);
            this.tbx_PSP_Text.Multiline = true;
            this.tbx_PSP_Text.Name = "tbx_PSP_Text";
            this.tbx_PSP_Text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbx_PSP_Text.Size = new System.Drawing.Size(350, 214);
            this.tbx_PSP_Text.TabIndex = 0;
            // 
            // tbx_Current
            // 
            this.tbx_Current.Location = new System.Drawing.Point(327, 90);
            this.tbx_Current.Name = "tbx_Current";
            this.tbx_Current.Size = new System.Drawing.Size(58, 20);
            this.tbx_Current.TabIndex = 2;
            this.tbx_Current.TextChanged += new System.EventHandler(this.tbx_Current_TextChanged);
            // 
            // tbx_Total
            // 
            this.tbx_Total.Enabled = false;
            this.tbx_Total.Location = new System.Drawing.Point(413, 90);
            this.tbx_Total.Name = "tbx_Total";
            this.tbx_Total.Size = new System.Drawing.Size(58, 20);
            this.tbx_Total.TabIndex = 3;
            // 
            // ddl_Files
            // 
            this.ddl_Files.FormattingEnabled = true;
            this.ddl_Files.Location = new System.Drawing.Point(12, 12);
            this.ddl_Files.Name = "ddl_Files";
            this.ddl_Files.Size = new System.Drawing.Size(191, 641);
            this.ddl_Files.TabIndex = 4;
            this.ddl_Files.SelectedIndexChanged += new System.EventHandler(this.ddl_Files_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(392, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "of";
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(235, 88);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(40, 23);
            this.btn_Start.TabIndex = 6;
            this.btn_Start.Text = "<<";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(281, 88);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(40, 23);
            this.btn_Back.TabIndex = 7;
            this.btn_Back.Text = "<";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Forward
            // 
            this.btn_Forward.Location = new System.Drawing.Point(477, 88);
            this.btn_Forward.Name = "btn_Forward";
            this.btn_Forward.Size = new System.Drawing.Size(40, 23);
            this.btn_Forward.TabIndex = 8;
            this.btn_Forward.Text = ">";
            this.btn_Forward.UseVisualStyleBackColor = true;
            this.btn_Forward.Click += new System.EventHandler(this.btn_Forward_Click);
            // 
            // btn_End
            // 
            this.btn_End.Location = new System.Drawing.Point(523, 88);
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
            this.tbx_Translate.Location = new System.Drawing.Point(628, 135);
            this.tbx_Translate.Multiline = true;
            this.tbx_Translate.Name = "tbx_Translate";
            this.tbx_Translate.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbx_Translate.Size = new System.Drawing.Size(350, 214);
            this.tbx_Translate.TabIndex = 10;
            this.tbx_Translate.TextChanged += new System.EventHandler(this.tbx_Translate_TextChanged);
            this.tbx_Translate.Leave += new System.EventHandler(this.tbx_Translate_Leave);
            // 
            // tbx_Dupe_Translate
            // 
            this.tbx_Dupe_Translate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Dupe_Translate.Location = new System.Drawing.Point(628, 439);
            this.tbx_Dupe_Translate.Multiline = true;
            this.tbx_Dupe_Translate.Name = "tbx_Dupe_Translate";
            this.tbx_Dupe_Translate.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbx_Dupe_Translate.Size = new System.Drawing.Size(350, 214);
            this.tbx_Dupe_Translate.TabIndex = 11;
            // 
            // btn_Dupe_End
            // 
            this.btn_Dupe_End.Location = new System.Drawing.Point(523, 386);
            this.btn_Dupe_End.Name = "btn_Dupe_End";
            this.btn_Dupe_End.Size = new System.Drawing.Size(40, 23);
            this.btn_Dupe_End.TabIndex = 18;
            this.btn_Dupe_End.Text = ">>";
            this.btn_Dupe_End.UseVisualStyleBackColor = true;
            this.btn_Dupe_End.Click += new System.EventHandler(this.btn_Dupe_End_Click);
            // 
            // btn_Dupe_Forward
            // 
            this.btn_Dupe_Forward.Location = new System.Drawing.Point(477, 386);
            this.btn_Dupe_Forward.Name = "btn_Dupe_Forward";
            this.btn_Dupe_Forward.Size = new System.Drawing.Size(40, 23);
            this.btn_Dupe_Forward.TabIndex = 17;
            this.btn_Dupe_Forward.Text = ">";
            this.btn_Dupe_Forward.UseVisualStyleBackColor = true;
            this.btn_Dupe_Forward.Click += new System.EventHandler(this.btn_Dupe_Forward_Click);
            // 
            // btn_Dupe_Back
            // 
            this.btn_Dupe_Back.Location = new System.Drawing.Point(281, 386);
            this.btn_Dupe_Back.Name = "btn_Dupe_Back";
            this.btn_Dupe_Back.Size = new System.Drawing.Size(40, 23);
            this.btn_Dupe_Back.TabIndex = 16;
            this.btn_Dupe_Back.Text = "<";
            this.btn_Dupe_Back.UseVisualStyleBackColor = true;
            this.btn_Dupe_Back.Click += new System.EventHandler(this.btn_Dupe_Back_Click);
            // 
            // btn_Dupe_Start
            // 
            this.btn_Dupe_Start.Location = new System.Drawing.Point(235, 386);
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
            this.label2.Location = new System.Drawing.Point(392, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "of";
            // 
            // tbx_Dupe_Total
            // 
            this.tbx_Dupe_Total.Enabled = false;
            this.tbx_Dupe_Total.Location = new System.Drawing.Point(413, 388);
            this.tbx_Dupe_Total.Name = "tbx_Dupe_Total";
            this.tbx_Dupe_Total.Size = new System.Drawing.Size(58, 20);
            this.tbx_Dupe_Total.TabIndex = 13;
            // 
            // tbx_Dupe_Current
            // 
            this.tbx_Dupe_Current.Location = new System.Drawing.Point(327, 388);
            this.tbx_Dupe_Current.Name = "tbx_Dupe_Current";
            this.tbx_Dupe_Current.Size = new System.Drawing.Size(58, 20);
            this.tbx_Dupe_Current.TabIndex = 12;
            this.tbx_Dupe_Current.TextChanged += new System.EventHandler(this.tbx_Dupe_Current_TextChanged);
            // 
            // lbl_Dupe_Name
            // 
            this.lbl_Dupe_Name.AutoSize = true;
            this.lbl_Dupe_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Dupe_Name.Location = new System.Drawing.Point(227, 416);
            this.lbl_Dupe_Name.Name = "lbl_Dupe_Name";
            this.lbl_Dupe_Name.Size = new System.Drawing.Size(129, 16);
            this.lbl_Dupe_Name.TabIndex = 19;
            this.lbl_Dupe_Name.Text = "Duplicate File: None";
            // 
            // tbx_Dupe_PSP_Text
            // 
            this.tbx_Dupe_PSP_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Dupe_PSP_Text.Location = new System.Drawing.Point(224, 439);
            this.tbx_Dupe_PSP_Text.Multiline = true;
            this.tbx_Dupe_PSP_Text.Name = "tbx_Dupe_PSP_Text";
            this.tbx_Dupe_PSP_Text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbx_Dupe_PSP_Text.Size = new System.Drawing.Size(350, 214);
            this.tbx_Dupe_PSP_Text.TabIndex = 20;
            // 
            // tbx_Search
            // 
            this.tbx_Search.Location = new System.Drawing.Point(290, 27);
            this.tbx_Search.Name = "tbx_Search";
            this.tbx_Search.Size = new System.Drawing.Size(173, 20);
            this.tbx_Search.TabIndex = 21;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(469, 26);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 22;
            this.btn_Search.Text = "Find Next";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_copy
            // 
            this.btn_copy.Location = new System.Drawing.Point(694, 385);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(75, 23);
            this.btn_copy.TabIndex = 23;
            this.btn_copy.Text = "Copy";
            this.btn_copy.UseVisualStyleBackColor = true;
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            // 
            // btn_copy_all
            // 
            this.btn_copy_all.Location = new System.Drawing.Point(825, 385);
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
            this.lbl_Current_File.Location = new System.Drawing.Point(227, 62);
            this.lbl_Current_File.Name = "lbl_Current_File";
            this.lbl_Current_File.Size = new System.Drawing.Size(114, 16);
            this.lbl_Current_File.TabIndex = 25;
            this.lbl_Current_File.Text = "Current File: None";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(227, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Japanese Text";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(633, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Translated Text";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(231, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Search:";
            // 
            // tbx_PSX_Text
            // 
            this.tbx_PSX_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_PSX_Text.Location = new System.Drawing.Point(1036, 135);
            this.tbx_PSX_Text.Multiline = true;
            this.tbx_PSX_Text.Name = "tbx_PSX_Text";
            this.tbx_PSX_Text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbx_PSX_Text.Size = new System.Drawing.Size(350, 214);
            this.tbx_PSX_Text.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1033, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 30;
            this.label6.Text = "PSX Script Text";
            // 
            // Suikoden_2_Translator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1398, 669);
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
    }
}

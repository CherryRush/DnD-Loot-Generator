namespace LootGenerator
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.grpHoards = new System.Windows.Forms.GroupBox();
            this.chkHoardManualItems = new System.Windows.Forms.CheckBox();
            this.chkHoardStaticValues = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbHoardCR = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grpClasses = new System.Windows.Forms.GroupBox();
            this.chkWizard = new System.Windows.Forms.CheckBox();
            this.chkWarlock = new System.Windows.Forms.CheckBox();
            this.chkSorcerer = new System.Windows.Forms.CheckBox();
            this.chkRanger = new System.Windows.Forms.CheckBox();
            this.chkPaladin = new System.Windows.Forms.CheckBox();
            this.chkDruid = new System.Windows.Forms.CheckBox();
            this.chkCleric = new System.Windows.Forms.CheckBox();
            this.chkBard = new System.Windows.Forms.CheckBox();
            this.txtInspect = new System.Windows.Forms.TextBox();
            this.lstTreasure = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkXanathar = new System.Windows.Forms.CheckBox();
            this.grpHoards.SuspendLayout();
            this.grpClasses.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(12, 473);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(127, 23);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate Treasure!";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // grpHoards
            // 
            this.grpHoards.Controls.Add(this.chkHoardManualItems);
            this.grpHoards.Controls.Add(this.chkHoardStaticValues);
            this.grpHoards.Controls.Add(this.label1);
            this.grpHoards.Controls.Add(this.cmbHoardCR);
            this.grpHoards.Location = new System.Drawing.Point(12, 13);
            this.grpHoards.Name = "grpHoards";
            this.grpHoards.Size = new System.Drawing.Size(175, 150);
            this.grpHoards.TabIndex = 2;
            this.grpHoards.TabStop = false;
            this.grpHoards.Text = "Hoard Settings";
            // 
            // chkHoardManualItems
            // 
            this.chkHoardManualItems.AutoSize = true;
            this.chkHoardManualItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHoardManualItems.Location = new System.Drawing.Point(6, 111);
            this.chkHoardManualItems.Name = "chkHoardManualItems";
            this.chkHoardManualItems.Size = new System.Drawing.Size(163, 19);
            this.chkHoardManualItems.TabIndex = 3;
            this.chkHoardManualItems.Text = "No Random Magic Items";
            this.toolTip1.SetToolTip(this.chkHoardManualItems, "When this is checked, the program will not\r\ngenerate random magic items from tabl" +
        "es\r\nF, G, H, or I. Instead, it will return placeholders\r\nsuch as \"Uncommon Magic" +
        " Item\".");
            this.chkHoardManualItems.UseVisualStyleBackColor = true;
            // 
            // chkHoardStaticValues
            // 
            this.chkHoardStaticValues.AutoSize = true;
            this.chkHoardStaticValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHoardStaticValues.Location = new System.Drawing.Point(6, 86);
            this.chkHoardStaticValues.Name = "chkHoardStaticValues";
            this.chkHoardStaticValues.Size = new System.Drawing.Size(121, 19);
            this.chkHoardStaticValues.TabIndex = 2;
            this.chkHoardStaticValues.Text = "Use Static Values";
            this.toolTip1.SetToolTip(this.chkHoardStaticValues, "When this is checked, the program will use average\r\nquantities for gold, gemstone" +
        "s, and art objects.\r\nIt will still generate a random number of magic items\r\nwhen" +
        " called to do so by the loot tables.");
            this.chkHoardStaticValues.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Challenge Rating (Required)";
            // 
            // cmbHoardCR
            // 
            this.cmbHoardCR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHoardCR.FormattingEnabled = true;
            this.cmbHoardCR.Items.AddRange(new object[] {
            "0-4",
            "5-10",
            "11-16",
            "17-20"});
            this.cmbHoardCR.Location = new System.Drawing.Point(9, 41);
            this.cmbHoardCR.Name = "cmbHoardCR";
            this.cmbHoardCR.Size = new System.Drawing.Size(121, 21);
            this.cmbHoardCR.TabIndex = 0;
            this.toolTip1.SetToolTip(this.cmbHoardCR, "Match the challenge rating for the Treasure\r\nHoard to the CR of the monster(s) co" +
        "ntrolling\r\nthe hoard. If there are multiple CRs of monster,\r\nuse the highest-CR " +
        "monster in the dungeon.");
            // 
            // grpClasses
            // 
            this.grpClasses.Controls.Add(this.chkWizard);
            this.grpClasses.Controls.Add(this.chkWarlock);
            this.grpClasses.Controls.Add(this.chkSorcerer);
            this.grpClasses.Controls.Add(this.chkRanger);
            this.grpClasses.Controls.Add(this.chkPaladin);
            this.grpClasses.Controls.Add(this.chkDruid);
            this.grpClasses.Controls.Add(this.chkCleric);
            this.grpClasses.Controls.Add(this.chkBard);
            this.grpClasses.Location = new System.Drawing.Point(12, 169);
            this.grpClasses.Name = "grpClasses";
            this.grpClasses.Size = new System.Drawing.Size(175, 224);
            this.grpClasses.TabIndex = 4;
            this.grpClasses.TabStop = false;
            this.grpClasses.Text = "Spell Lists";
            this.toolTip1.SetToolTip(this.grpClasses, "Check all spell lists to generate scrolls from.\r\nIf no lists are checked, scrolls" +
        " will not\r\nbe generated.");
            // 
            // chkWizard
            // 
            this.chkWizard.AutoSize = true;
            this.chkWizard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkWizard.Location = new System.Drawing.Point(9, 194);
            this.chkWizard.Name = "chkWizard";
            this.chkWizard.Size = new System.Drawing.Size(64, 19);
            this.chkWizard.TabIndex = 8;
            this.chkWizard.Text = "Wizard";
            this.chkWizard.UseVisualStyleBackColor = true;
            // 
            // chkWarlock
            // 
            this.chkWarlock.AutoSize = true;
            this.chkWarlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkWarlock.Location = new System.Drawing.Point(9, 169);
            this.chkWarlock.Name = "chkWarlock";
            this.chkWarlock.Size = new System.Drawing.Size(70, 19);
            this.chkWarlock.TabIndex = 7;
            this.chkWarlock.Text = "Warlock";
            this.chkWarlock.UseVisualStyleBackColor = true;
            // 
            // chkSorcerer
            // 
            this.chkSorcerer.AutoSize = true;
            this.chkSorcerer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSorcerer.Location = new System.Drawing.Point(9, 144);
            this.chkSorcerer.Name = "chkSorcerer";
            this.chkSorcerer.Size = new System.Drawing.Size(73, 19);
            this.chkSorcerer.TabIndex = 6;
            this.chkSorcerer.Text = "Sorcerer";
            this.chkSorcerer.UseVisualStyleBackColor = true;
            // 
            // chkRanger
            // 
            this.chkRanger.AutoSize = true;
            this.chkRanger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRanger.Location = new System.Drawing.Point(9, 119);
            this.chkRanger.Name = "chkRanger";
            this.chkRanger.Size = new System.Drawing.Size(67, 19);
            this.chkRanger.TabIndex = 5;
            this.chkRanger.Text = "Ranger";
            this.chkRanger.UseVisualStyleBackColor = true;
            // 
            // chkPaladin
            // 
            this.chkPaladin.AutoSize = true;
            this.chkPaladin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPaladin.Location = new System.Drawing.Point(9, 94);
            this.chkPaladin.Name = "chkPaladin";
            this.chkPaladin.Size = new System.Drawing.Size(68, 19);
            this.chkPaladin.TabIndex = 4;
            this.chkPaladin.Text = "Paladin";
            this.chkPaladin.UseVisualStyleBackColor = true;
            // 
            // chkDruid
            // 
            this.chkDruid.AutoSize = true;
            this.chkDruid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDruid.Location = new System.Drawing.Point(9, 69);
            this.chkDruid.Name = "chkDruid";
            this.chkDruid.Size = new System.Drawing.Size(56, 19);
            this.chkDruid.TabIndex = 3;
            this.chkDruid.Text = "Druid";
            this.chkDruid.UseVisualStyleBackColor = true;
            // 
            // chkCleric
            // 
            this.chkCleric.AutoSize = true;
            this.chkCleric.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCleric.Location = new System.Drawing.Point(9, 44);
            this.chkCleric.Name = "chkCleric";
            this.chkCleric.Size = new System.Drawing.Size(57, 19);
            this.chkCleric.TabIndex = 2;
            this.chkCleric.Text = "Cleric";
            this.chkCleric.UseVisualStyleBackColor = true;
            // 
            // chkBard
            // 
            this.chkBard.AutoSize = true;
            this.chkBard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBard.Location = new System.Drawing.Point(9, 19);
            this.chkBard.Name = "chkBard";
            this.chkBard.Size = new System.Drawing.Size(52, 19);
            this.chkBard.TabIndex = 1;
            this.chkBard.Text = "Bard";
            this.chkBard.UseVisualStyleBackColor = true;
            // 
            // txtInspect
            // 
            this.txtInspect.Location = new System.Drawing.Point(527, 181);
            this.txtInspect.Multiline = true;
            this.txtInspect.Name = "txtInspect";
            this.txtInspect.ReadOnly = true;
            this.txtInspect.Size = new System.Drawing.Size(235, 286);
            this.txtInspect.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txtInspect, "Select items in the Treasure List, and their descriptions\r\nwill appear here.");
            // 
            // lstTreasure
            // 
            this.lstTreasure.FormattingEnabled = true;
            this.lstTreasure.Location = new System.Drawing.Point(196, 31);
            this.lstTreasure.Name = "lstTreasure";
            this.lstTreasure.ScrollAlwaysVisible = true;
            this.lstTreasure.Size = new System.Drawing.Size(325, 472);
            this.lstTreasure.TabIndex = 5;
            this.lstTreasure.SelectedIndexChanged += new System.EventHandler(this.lstTreasure_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(296, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Treasure List";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(613, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Item Inspect";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkXanathar);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(12, 399);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 68);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Expansions";
            this.groupBox1.Visible = false;
            // 
            // chkXanathar
            // 
            this.chkXanathar.AutoSize = true;
            this.chkXanathar.Location = new System.Drawing.Point(6, 19);
            this.chkXanathar.Name = "chkXanathar";
            this.chkXanathar.Size = new System.Drawing.Size(107, 17);
            this.chkXanathar.TabIndex = 0;
            this.chkXanathar.Text = "Xanathar\'s Guide";
            this.toolTip1.SetToolTip(this.chkXanathar, "When this is checked, the program will use content\r\nfrom Xanathar\'s Guide to Ever" +
        "ything.");
            this.chkXanathar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 510);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtInspect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstTreasure);
            this.Controls.Add(this.grpClasses);
            this.Controls.Add(this.grpHoards);
            this.Controls.Add(this.btnGenerate);
            this.Name = "Form1";
            this.Text = "Dungeons & Dragons Treasure Generator (5e)";
            this.grpHoards.ResumeLayout(false);
            this.grpHoards.PerformLayout();
            this.grpClasses.ResumeLayout(false);
            this.grpClasses.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.GroupBox grpHoards;
        private System.Windows.Forms.ComboBox cmbHoardCR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox chkHoardManualItems;
        private System.Windows.Forms.CheckBox chkHoardStaticValues;
        private System.Windows.Forms.GroupBox grpClasses;
        private System.Windows.Forms.CheckBox chkWizard;
        private System.Windows.Forms.CheckBox chkWarlock;
        private System.Windows.Forms.CheckBox chkSorcerer;
        private System.Windows.Forms.CheckBox chkRanger;
        private System.Windows.Forms.CheckBox chkPaladin;
        private System.Windows.Forms.CheckBox chkDruid;
        private System.Windows.Forms.CheckBox chkCleric;
        private System.Windows.Forms.CheckBox chkBard;
        private System.Windows.Forms.ListBox lstTreasure;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInspect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkXanathar;
    }
}


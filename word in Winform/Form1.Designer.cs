﻿namespace word_in_Winform
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelFontstyle = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.textboxLoad = new System.Windows.Forms.TextBox();
            this.textBoxSave = new System.Windows.Forms.TextBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.checkBoxBold = new System.Windows.Forms.CheckBox();
            this.checkBoxUnderLine = new System.Windows.Forms.CheckBox();
            this.checkBoxItalic = new System.Windows.Forms.CheckBox();
            this.checkLeft = new System.Windows.Forms.CheckBox();
            this.checkBoxCenter = new System.Windows.Forms.CheckBox();
            this.checkBoxRight = new System.Windows.Forms.CheckBox();
            this.comboBoxFont = new System.Windows.Forms.ComboBox();
            this.comboBoxSize = new System.Windows.Forms.ComboBox();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(27, 97);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(733, 352);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Font";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelSize
            // 
            this.labelSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSize.Location = new System.Drawing.Point(131, 19);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(65, 23);
            this.labelSize.TabIndex = 1;
            this.labelSize.Text = "Size";
            // 
            // labelFontstyle
            // 
            this.labelFontstyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFontstyle.Location = new System.Drawing.Point(222, 19);
            this.labelFontstyle.Name = "labelFontstyle";
            this.labelFontstyle.Size = new System.Drawing.Size(100, 23);
            this.labelFontstyle.TabIndex = 1;
            this.labelFontstyle.Text = "FontStyle";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(328, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Alignment";
            // 
            // labelColor
            // 
            this.labelColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelColor.Location = new System.Drawing.Point(456, 19);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(91, 23);
            this.labelColor.TabIndex = 1;
            this.labelColor.Text = "Color";
            // 
            // textboxLoad
            // 
            this.textboxLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textboxLoad.ForeColor = System.Drawing.Color.Gray;
            this.textboxLoad.Location = new System.Drawing.Point(564, 22);
            this.textboxLoad.Name = "textboxLoad";
            this.textboxLoad.Size = new System.Drawing.Size(140, 20);
            this.textboxLoad.TabIndex = 2;
            this.textboxLoad.Text = "Load some data from file .rtf";
            this.textboxLoad.Enter += new System.EventHandler(this.textboxLoad_Enter_1);
            this.textboxLoad.Leave += new System.EventHandler(this.textboxLoad_Leave);
            // 
            // textBoxSave
            // 
            this.textBoxSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSave.ForeColor = System.Drawing.Color.Gray;
            this.textBoxSave.Location = new System.Drawing.Point(564, 48);
            this.textBoxSave.Name = "textBoxSave";
            this.textBoxSave.Size = new System.Drawing.Size(140, 20);
            this.textBoxSave.TabIndex = 2;
            this.textBoxSave.Text = "Save some data to file .rtf";
            this.textBoxSave.Enter += new System.EventHandler(this.textBoxSave_Enter);
            this.textBoxSave.Leave += new System.EventHandler(this.textBoxSave_Leave);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLoad.Location = new System.Drawing.Point(713, 20);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 3;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(713, 45);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // checkBoxBold
            // 
            this.checkBoxBold.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxBold.Location = new System.Drawing.Point(215, 48);
            this.checkBoxBold.Name = "checkBoxBold";
            this.checkBoxBold.Size = new System.Drawing.Size(29, 27);
            this.checkBoxBold.TabIndex = 4;
            this.checkBoxBold.Text = "B";
            this.checkBoxBold.UseVisualStyleBackColor = true;
            // 
            // checkBoxUnderLine
            // 
            this.checkBoxUnderLine.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxUnderLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxUnderLine.Location = new System.Drawing.Point(250, 48);
            this.checkBoxUnderLine.Name = "checkBoxUnderLine";
            this.checkBoxUnderLine.Size = new System.Drawing.Size(29, 27);
            this.checkBoxUnderLine.TabIndex = 4;
            this.checkBoxUnderLine.Text = "U";
            this.checkBoxUnderLine.UseVisualStyleBackColor = true;
            this.checkBoxUnderLine.CheckedChanged += new System.EventHandler(this.checkBoxUnderLine_CheckedChanged);
            // 
            // checkBoxItalic
            // 
            this.checkBoxItalic.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxItalic.Location = new System.Drawing.Point(285, 48);
            this.checkBoxItalic.Name = "checkBoxItalic";
            this.checkBoxItalic.Size = new System.Drawing.Size(29, 27);
            this.checkBoxItalic.TabIndex = 4;
            this.checkBoxItalic.Text = "I";
            this.checkBoxItalic.UseVisualStyleBackColor = true;
            this.checkBoxItalic.CheckedChanged += new System.EventHandler(this.CheckBoxItalic_CheckedChanged);
            // 
            // checkLeft
            // 
            this.checkLeft.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkLeft.Location = new System.Drawing.Point(324, 48);
            this.checkLeft.Name = "checkLeft";
            this.checkLeft.Size = new System.Drawing.Size(29, 27);
            this.checkLeft.TabIndex = 4;
            this.checkLeft.Text = "L";
            this.checkLeft.UseVisualStyleBackColor = true;
            this.checkLeft.CheckedChanged += new System.EventHandler(this.checkLeft_CheckedChanged);
            // 
            // checkBoxCenter
            // 
            this.checkBoxCenter.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxCenter.Location = new System.Drawing.Point(359, 48);
            this.checkBoxCenter.Name = "checkBoxCenter";
            this.checkBoxCenter.Size = new System.Drawing.Size(29, 27);
            this.checkBoxCenter.TabIndex = 4;
            this.checkBoxCenter.Text = "C";
            this.checkBoxCenter.UseVisualStyleBackColor = true;
            this.checkBoxCenter.CheckedChanged += new System.EventHandler(this.checkBoxCenter_CheckedChanged);
            // 
            // checkBoxRight
            // 
            this.checkBoxRight.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxRight.Location = new System.Drawing.Point(394, 48);
            this.checkBoxRight.Name = "checkBoxRight";
            this.checkBoxRight.Size = new System.Drawing.Size(29, 27);
            this.checkBoxRight.TabIndex = 4;
            this.checkBoxRight.Text = "R";
            this.checkBoxRight.UseVisualStyleBackColor = true;
            this.checkBoxRight.CheckedChanged += new System.EventHandler(this.checkBoxRight_CheckedChanged);
            // 
            // comboBoxFont
            // 
            this.comboBoxFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFont.FormattingEnabled = true;
            this.comboBoxFont.Location = new System.Drawing.Point(16, 52);
            this.comboBoxFont.Name = "comboBoxFont";
            this.comboBoxFont.Size = new System.Drawing.Size(97, 21);
            this.comboBoxFont.TabIndex = 5;
           
            // 
            // comboBoxSize
            // 
            this.comboBoxSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSize.FormattingEnabled = true;
            this.comboBoxSize.Location = new System.Drawing.Point(119, 52);
            this.comboBoxSize.Name = "comboBoxSize";
            this.comboBoxSize.Size = new System.Drawing.Size(66, 21);
            this.comboBoxSize.TabIndex = 5;
            // 
            // buttonSelect
            // 
            this.buttonSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSelect.Location = new System.Drawing.Point(442, 50);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(83, 25);
            this.buttonSelect.TabIndex = 6;
            this.buttonSelect.Text = "Select";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.comboBoxSize);
            this.Controls.Add(this.comboBoxFont);
            this.Controls.Add(this.checkBoxRight);
            this.Controls.Add(this.checkBoxItalic);
            this.Controls.Add(this.checkBoxCenter);
            this.Controls.Add(this.checkLeft);
            this.Controls.Add(this.checkBoxUnderLine);
            this.Controls.Add(this.checkBoxBold);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.textBoxSave);
            this.Controls.Add(this.textboxLoad);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelFontstyle);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Word";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelFontstyle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.TextBox textboxLoad;
        private System.Windows.Forms.TextBox textBoxSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.CheckBox checkBoxBold;
        private System.Windows.Forms.CheckBox checkBoxUnderLine;
        private System.Windows.Forms.CheckBox checkBoxItalic;
        private System.Windows.Forms.CheckBox checkLeft;
        private System.Windows.Forms.CheckBox checkBoxCenter;
        private System.Windows.Forms.CheckBox checkBoxRight;
        private System.Windows.Forms.ComboBox comboBoxFont;
        private System.Windows.Forms.ComboBox comboBoxSize;
        private System.Windows.Forms.Button buttonSelect;
    }
}


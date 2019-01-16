using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace word_in_Winform
{
    public partial class Form1 : Form
    {
        public int MyProperty { get; set; }
        public Form1()
        {
            InitializeComponent();
            oldstyle = richTextBox1.SelectionFont.Style;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxFont.Items.AddRange(FontFamily.Families);
            comboBoxFont.DisplayMember = "Name";
            for (int i = 14; i < 100; i += 5)
            {
                comboBoxSize.Items.Add(i);
            }
            comboBoxSize.SelectedIndexChanged += ComboBoxSize_SelectedIndexChanged;
            comboBoxFont.SelectedIndexChanged += ComboBoxFont_SelectedIndexChanged;
            checkBoxBold.CheckedChanged += CheckBoxBold_CheckedChanged;
            checkBoxItalic.CheckedChanged += CheckBoxItalic_CheckedChanged;
            comboBoxSize.SelectedIndex = 1;
            comboBoxFont.SelectedIndex = 1;
        }
        private void CheckBoxItalic_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxItalic.Checked)
            {
                oldstyle = oldstyle | FontStyle.Italic;
            }
            else
            {
                oldstyle = oldstyle & ~FontStyle.Italic;
            }
            richTextBox1.SelectionFont = new Font(comboBoxFont.Text, int.Parse(comboBoxSize.Text),
                oldstyle);
            var array = richTextBox1.Text.ToCharArray();
            for (int i = richTextBox1.SelectionStart; i < richTextBox1.SelectionLength; i++)
            {

            }
        }
        FontStyle oldstyle = FontStyle.Regular;
        FontStyle oldstyle2 = FontStyle.Regular;
        private void CheckBoxBold_CheckedChanged(object sender, EventArgs e)
        {
            oldstyle2 = richTextBox1.SelectionFont.Style;
            if (checkBoxBold.Checked)
            {
                oldstyle = oldstyle | FontStyle.Bold;
            }
            else
            {
                oldstyle = oldstyle & ~FontStyle.Bold;
            }
            for (int i = richTextBox1.SelectionStart; i < richTextBox1.SelectionLength+ richTextBox1.SelectionStart; i++)
            {
                richTextBox1.Select(i, 1);
                if (!richTextBox1.SelectionFont.Bold)
                {
                    richTextBox1.SelectionFont = new Font(comboBoxFont.Text, int.Parse(comboBoxSize.Text), oldstyle2 | FontStyle.Bold);
                }
            }

            richTextBox1.SelectionFont = new Font(comboBoxFont.Text, int.Parse(comboBoxSize.Text),
                oldstyle);
        }
        private void ComboBoxFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(comboBoxFont.Text, int.Parse(comboBoxSize.Text));
        }
        private void ComboBoxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(comboBoxFont.Text, int.Parse(comboBoxSize.Text));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            var result = colorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog.Color;
            }
        }
        public string Filename { get; set; }
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = File.ReadAllText(Filename);
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            Filename = textBoxSave.Text;
            File.WriteAllText(Filename, richTextBox1.Text);
        }
        private void checkBoxUnderLine_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxUnderLine.Checked)
            {
                oldstyle = oldstyle | FontStyle.Underline;
            }
            else
            {
                oldstyle = oldstyle & ~FontStyle.Underline;
            }
            richTextBox1.SelectionFont = new Font(comboBoxFont.Text, int.Parse(comboBoxSize.Text),
                oldstyle);
        }

        private void checkLeft_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void checkBoxCenter_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void checkBoxRight_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }


        private void textboxLoad_Enter_1(object sender, EventArgs e)
        {
            if (textboxLoad.Text != String.Empty)
            {
                textboxLoad.Text = String.Empty;
            }
            else
            {
                textboxLoad.Text = "Load some data from file rtf";
            }
        }

        private void textboxLoad_Leave(object sender, EventArgs e)
        {
            if (textboxLoad.Text == String.Empty)
            {
                textboxLoad.Text = "Load some data from file rtf";
            }
        }
        private void textBoxSave_Enter(object sender, EventArgs e)
        {
            if (textBoxSave.Text != String.Empty)
            {
                textBoxSave.Text = String.Empty;
            }
            else
            {
                textBoxSave.Text = "Save some data to file .rtf";
            }
        }

        private void textBoxSave_Leave(object sender, EventArgs e)
        {
            if (textBoxSave.Text == String.Empty)
            {
                textBoxSave.Text = "Save some data to file .rtf";
            }
        }
    }
}

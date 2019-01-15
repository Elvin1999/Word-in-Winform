using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace word_in_Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
                //richTextBox1.Font = new Font(comboBoxFont.Text, int.Parse(comboBoxSize.Text), FontStyle.Bold);
            
            comboBoxFont.Items.AddRange(FontFamily.Families);
            comboBoxFont.DisplayMember = "Name";
            for (int i = 14; i < 100; i += 5)
            {
                comboBoxSize.Items.Add(i);
            }
            comboBoxSize.SelectedIndexChanged += ComboBoxSize_SelectedIndexChanged;
            comboBoxFont.SelectedIndexChanged += ComboBoxFont_SelectedIndexChanged;
            checkBoxBold.CheckedChanged += CheckBoxBold_CheckedChanged;
            comboBoxSize.SelectedIndex = 1;
            comboBoxFont.SelectedIndex = 1;

        }

        private void CheckBoxBold_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBold.Checked == true)
            {
                richTextBox1.SelectionFont = new Font(comboBoxFont.Text, int.Parse(comboBoxSize.Text), FontStyle.Bold);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(comboBoxFont.Text, int.Parse(comboBoxSize.Text));
            }

            
            
            
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

        private void checkBoxBold_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

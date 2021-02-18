using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace VO_Framework_testing_generator_v1p0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox13.Enabled = false;
            textBox20.Enabled = false;
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = (DataGridViewRow)dataGridView2.Rows[0].Clone();
            row.Cells[0].Value = textBox1.Text;
            row.Cells[1].Value = textBox11.Text;
            row.Cells[2].Value = textBox15.Text;
            if (checkBox1.Checked)
                row.Cells[3].Value = 1;
            else
                row.Cells[3].Value = 0;

            row.Cells[4].Value = textBox13.Text;
            row.Cells[5].Value = comboBox1.SelectedIndex;
            row.Cells[6].Value = textBox10.Text;
            row.Cells[7].Value = textBox9.Text;

            dataGridView2.Rows.Add(row);

            // =======================================================================
            // =======================================================================
            DataGridViewRow row2 = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            row2.Cells[0].Value = textBox1.Text;
            row2.Cells[1].Value = textBox18.Text;
            row2.Cells[2].Value = textBox22.Text;
            if (checkBox2.Checked)
                row2.Cells[3].Value = 1;
            else
                row2.Cells[3].Value = 0;

            row2.Cells[4].Value = textBox20.Text;
            row2.Cells[5].Value = comboBox2.SelectedIndex;
            row2.Cells[6].Value = textBox17.Text;
            row2.Cells[7].Value = textBox16.Text;

            dataGridView1.Rows.Add(row2);

            // =======================================================================
            // =======================================================================
            DataGridViewRow row3 = (DataGridViewRow)dataGridView3.Rows[0].Clone();
            row3.Cells[0].Value = textBox1.Text;
            row3.Cells[1].Value = textBox2.Text;
            row3.Cells[2].Value = textBox3.Text;
            row3.Cells[3].Value = textBox4.Text;
            row3.Cells[4].Value = textBox5.Text;
            row3.Cells[5].Value = textBox6.Text;
            row3.Cells[6].Value = comboBox3.SelectedIndex;

            dataGridView3.Rows.Add(row3);

            int numParsed = Int32.Parse(textBox1.Text);
            textBox1.Text = (numParsed + 1).ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String fileName = textBox8.Text;

            StreamWriter sW = new StreamWriter(fileName);

            

            for (int row = 0; row < dataGridView1.Rows.Count-1 ; row++)
            {
                string lines = "";

                // general settings
                for (int col = 0; col < 7; col++)
                {
                    lines += dataGridView3.Rows[row].Cells[col].Value.ToString() + (string.IsNullOrEmpty(lines) ? " " : "   ");
                }

                // fast 
                for (int col = 1; col <= 7; col++)
                {
                    lines += dataGridView2.Rows[row].Cells[col].Value.ToString() + (string.IsNullOrEmpty(lines) ? " " : "   ");
                }

                // slow
                for (int col = 1; col <= 7; col++)
                {
                    lines += dataGridView1.Rows[row].Cells[col].Value.ToString() + (string.IsNullOrEmpty(lines) ? " " : "   ");
                }


                sW.WriteLine(lines);
            }

            sW.Close();

            MessageBox.Show("File written successfully !",
                            "Done!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                textBox13.Enabled = true; 
            else
                textBox13.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                textBox20.Enabled = true;
            else
                textBox20.Enabled = false;
        }
    }
}

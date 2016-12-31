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


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool text = true;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedItem.ToString() == "plugin_init")
            {
                text = false;
                Console.WriteLine("Bool text = " + text.ToString());
                label1.Text = "id=";
                label1.Show();
                textBox1.Show();
                numericUpDown1.Hide();
                numericUpDown2.Hide();
                comboBox2.Hide();
                label2.Hide();
                label3.Hide();
                comboBox3.Hide();
                comboBox4.Hide();
                comboBox5.Hide();
                comboBox6.Hide();
                comboBox7.Hide();
                comboBox8.Hide();
                comboBox9.Hide();
                comboBox10.Hide();
                comboBox11.Hide();
                comboBox12.Hide();
                numericUpDown3.Hide();
                numericUpDown4.Hide();
                numericUpDown5.Hide();
                numericUpDown6.Hide();
                numericUpDown7.Hide();
                numericUpDown8.Hide();
                numericUpDown9.Hide();
                numericUpDown10.Hide();
                numericUpDown11.Hide();

            }
            if (comboBox1.SelectedItem.ToString() == "properties")
            {
                text = false;
                label1.Text = "spawnrate=";
                textBox1.Hide();
                numericUpDown2.Show();
                comboBox2.Show();
                label2.Show();
                label3.Show();
                numericUpDown1.Show();
                comboBox3.Hide();
                comboBox4.Hide();
                comboBox5.Hide();
                comboBox6.Hide();
                comboBox7.Hide();
                comboBox8.Hide();
                comboBox9.Hide();
                comboBox10.Hide();
                comboBox11.Hide();
                comboBox12.Hide();
                numericUpDown3.Hide();
                numericUpDown4.Hide();
                numericUpDown5.Hide();
                numericUpDown6.Hide();
                numericUpDown7.Hide();
                numericUpDown8.Hide();
                numericUpDown9.Hide();
                numericUpDown10.Hide();
                numericUpDown11.Hide();
            }
            if (comboBox1.SelectedItem.ToString() == "luck_crafting")
            {
                text = false;
                label1.Text = "Parameter";
                textBox1.Hide();
                numericUpDown2.Hide();
                comboBox2.Hide();
                label2.Hide();
                label3.Hide();
                numericUpDown1.Hide();
                comboBox3.Show();
                comboBox4.Show();
                comboBox5.Show();
                comboBox6.Show();
                comboBox7.Show();
                comboBox8.Show();
                comboBox9.Show();
                comboBox10.Show();
                comboBox11.Show();
                comboBox12.Show();
                numericUpDown3.Show();
                numericUpDown4.Show();
                numericUpDown5.Show();
                numericUpDown6.Show();
                numericUpDown7.Show();
                numericUpDown8.Show();
                numericUpDown9.Show();
                numericUpDown10.Show();
                numericUpDown11.Show();
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (text == true)
            {
                textBox1.Hide();
                numericUpDown1.Hide();
                numericUpDown2.Hide();
                comboBox2.Hide();
                label1.Hide();
                label2.Hide();
                label3.Hide();
                comboBox3.Hide();
                comboBox4.Hide();
                comboBox5.Hide();
                comboBox6.Hide();
                comboBox7.Hide();
                comboBox8.Hide();
                comboBox9.Hide();
                comboBox10.Hide();
                comboBox11.Hide();
                comboBox12.Hide();
                numericUpDown3.Hide();
                numericUpDown4.Hide();
                numericUpDown5.Hide();
                numericUpDown6.Hide();
                numericUpDown7.Hide();
                numericUpDown8.Hide();
                numericUpDown9.Hide();
                numericUpDown10.Hide();
                numericUpDown11.Hide();
                Console.WriteLine("Bool text = " + text.ToString());
            }
            
            }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
        private void setbrowserdialog()
        {
            string path = openFileDialog1.FileName.ToString();
            textBox2.Text = path;
        }

        private void folderBrowserDialog1_HelpRequest_1(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            setbrowserdialog();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "plugin_init")
            {

                System.IO.StreamWriter file = new System.IO.StreamWriter(@textBox2.Text);
                    file.WriteLine(label1.Text + textBox1.Text);
                
                file.Flush();
                file.Close();
                MessageBox.Show("Datei erstellt: " + textBox2.Text);
            }
            if (comboBox1.SelectedItem.ToString() == "properties")
            {
                System.IO.StreamWriter file = new System.IO.StreamWriter(@textBox2.Text);
                file.WriteLine(label1.Text + numericUpDown1.Value.ToString());
                file.WriteLine(label2.Text + numericUpDown2.Value.ToString());
                file.WriteLine(label3.Text + comboBox2.SelectedItem.ToString());
                file.Flush();
                file.Close();
                MessageBox.Show("Datei erstellt: " + textBox2.Text);
            }
            
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (text == true)
            {
                textBox1.Hide();
                numericUpDown1.Hide();
                numericUpDown1.Hide();
                numericUpDown2.Hide();
                comboBox2.Hide();
                label1.Hide();
                label2.Hide();
                comboBox3.Hide();
                comboBox4.Hide();
                comboBox5.Hide();
                comboBox6.Hide();
                comboBox7.Hide();
                comboBox8.Hide();
                comboBox9.Hide();
                comboBox10.Hide();
                comboBox11.Hide();
                comboBox12.Hide();
                numericUpDown3.Hide();
                numericUpDown4.Hide();
                numericUpDown5.Hide();
                numericUpDown6.Hide();
                numericUpDown7.Hide();
                numericUpDown8.Hide();
                numericUpDown9.Hide();
                numericUpDown10.Hide();
                numericUpDown11.Hide();
                label3.Hide();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (text == true)
            {
                textBox1.Hide();
                numericUpDown2.Hide();
                numericUpDown1.Hide();
                numericUpDown2.Hide();
                comboBox2.Hide();
                comboBox3.Hide();
                label1.Hide();
                comboBox4.Hide();
                comboBox5.Hide();
                comboBox6.Hide();
                comboBox7.Hide();
                comboBox8.Hide();
                comboBox9.Hide();
                comboBox10.Hide();
                comboBox11.Hide();
                comboBox12.Hide();
                numericUpDown3.Hide();
                numericUpDown4.Hide();
                numericUpDown5.Hide();
                numericUpDown6.Hide();
                numericUpDown7.Hide();
                numericUpDown8.Hide();
                numericUpDown9.Hide();
                numericUpDown10.Hide();
                numericUpDown11.Hide();
                label2.Hide();
                label3.Hide();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (text == true)
            {
                textBox1.Hide();
                comboBox2.Hide();
                numericUpDown1.Hide();
                numericUpDown2.Hide();
                comboBox2.Hide();
                label1.Hide();
                comboBox3.Hide();
                label2.Hide();
                label3.Hide();
                comboBox4.Hide();
                comboBox5.Hide();
                comboBox6.Hide();
                comboBox7.Hide();
                comboBox8.Hide();
                comboBox9.Hide();
                comboBox10.Hide();
                comboBox11.Hide();
                comboBox12.Hide();
                numericUpDown3.Hide();
                numericUpDown4.Hide();
                numericUpDown5.Hide();
                numericUpDown6.Hide();
                numericUpDown7.Hide();
                numericUpDown8.Hide();
                numericUpDown9.Hide();
                numericUpDown10.Hide();
                numericUpDown11.Hide();

            }
        }
      
    }
    
}

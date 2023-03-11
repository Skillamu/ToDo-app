using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDo_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            // If input is empty, do nothing.
            if (textBox1.Text == "") { return; }

            // Add task to label1, if not occupied.
            else if (!task1.Visible)
            {
                checkBox1.Visible = true;
                task1.Visible = true;
                editTask1.Visible = true;
                removeTask1.Visible = true;

                task1.Text = textBox1.Text;

                // Clear the input
                textBox1.Text = "";
            }
            else if (!task2.Visible)
            {
                checkBox2.Visible = true;
                task2.Visible = true;
                editTask2.Visible = true;
                removeTask2.Visible = true;

                task2.Text = textBox1.Text;
     
                textBox1.Text = "";
            }
            else if (!task3.Visible)
            {
                checkBox3.Visible = true;
                task3.Visible = true;
                editTask3.Visible = true;
                removeTask3.Visible = true;

                task3.Text = textBox1.Text;

                textBox1.Text = "";
            }
            else
            {

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                task1.Font = new Font(FontFamily.GenericSansSerif, 12.00F, FontStyle.Strikeout);
            }
            else
            {
                task1.Font = new Font(FontFamily.GenericSansSerif, 12.00F, FontStyle.Regular);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                task2.Font = new Font(FontFamily.GenericSansSerif, 12.00F, FontStyle.Strikeout);
            }
            else
            {
                task2.Font = new Font(FontFamily.GenericSansSerif, 12.00F, FontStyle.Regular);
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                task3.Font = new Font(FontFamily.GenericSansSerif, 12.00F, FontStyle.Strikeout);
            }
            else
            {
                task3.Font = new Font(FontFamily.GenericSansSerif, 12.00F, FontStyle.Regular);
            }
        }

        private void removeTask1_Click(object sender, EventArgs e)
        {
            // Remove task1
            checkBox1.Visible = false;
            checkBox1.Checked = false;
            task1.Visible = false;
            removeTask1.Visible = false;
            editTask1.Visible = false;
            textBoxTask1.Visible = false;
            confirmButtonTask1.Visible = false;
        }

        private void removeTask2_Click(object sender, EventArgs e)
        {
            checkBox2.Visible = false;
            checkBox2.Checked = false;
            task2.Visible = false;
            removeTask2.Visible = false;
            editTask2.Visible = false;
            textBoxTask2.Visible = false;
            confirmButtonTask2.Visible = false;
        }

        private void removeTask3_Click(object sender, EventArgs e)
        {
            checkBox3.Visible = false;
            checkBox3.Checked = false;
            task3.Visible = false;
            removeTask3.Visible = false;
            editTask3.Visible = false;
            textBoxTask3.Visible = false;
            confirmButtonTask3.Visible = false;
        }

        private void editTask1_Click(object sender, EventArgs e)
        {
            // Edit task1
            editTask1.Visible = false;
            textBoxTask1.Visible = true;
            textBoxTask1.Text = task1.Text;
            confirmButtonTask1.Visible = true;
        }

        private void editTask2_Click(object sender, EventArgs e)
        {
            editTask2.Visible = false;
            textBoxTask2.Visible = true;
            textBoxTask2.Text = task2.Text;
            confirmButtonTask2.Visible = true;
        }

        private void editTask3_Click(object sender, EventArgs e)
        {
            editTask3.Visible = false;
            textBoxTask3.Visible = true;
            textBoxTask3.Text = task3.Text;
            confirmButtonTask3.Visible = true;
        }

        private void confirmButtonTask1_Click(object sender, EventArgs e)
        {
            // Confirm new input task1
            task1.Text = textBoxTask1.Text;
            textBoxTask1.Visible = false;
            confirmButtonTask1.Visible = false;
            editTask1.Visible = true;
        }

        private void confirmButtonTask2_Click(object sender, EventArgs e)
        {
            task2.Text = textBoxTask2.Text;
            textBoxTask2.Visible = false;
            confirmButtonTask2.Visible = false;
            editTask2.Visible = true;
        }

        private void confirmButtonTask3_Click(object sender, EventArgs e)
        {
            task3.Text = textBoxTask3.Text;
            textBoxTask3.Visible = false;
            confirmButtonTask3.Visible = false;
            editTask3.Visible = true;
        }
    }
}

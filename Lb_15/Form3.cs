using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lb_15
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public int rowSelectedIndex;
        private void button1_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.Rows.Add();

            dataGridView1.Rows[rowSelectedIndex].Cells[0].Value = textBox1.Text;
            dataGridView1.Rows[rowSelectedIndex].Cells[1].Value = textBox2.Text;
            dataGridView1.Rows[rowSelectedIndex].Cells[2].Value = textBox2.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 1)
                dataGridView1.Rows.RemoveAt(dataGridView1.RowCount - 1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[rowSelectedIndex].Cells[0].Value = textBox1.Text;
            dataGridView1.Rows[rowSelectedIndex].Cells[1].Value = textBox2.Text;
            dataGridView1.Rows[rowSelectedIndex].Cells[2].Value = textBox3.Text;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowSelectedIndex = e.RowIndex;

            textBox1.Text = dataGridView1.Rows[rowSelectedIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[rowSelectedIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[rowSelectedIndex].Cells[2].Value.ToString();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string[] UserTXT = File.ReadAllLines("User.TXT");

            for (int i = 0, user = 0; i < UserTXT.Length; i++)
            {
                if (UserTXT[i] == "/")
                {
                    i++;
                    dataGridView1.Rows[user].Cells[0].Value = UserTXT[i];
                    i++;
                    dataGridView1.Rows[user].Cells[1].Value = UserTXT[i];
                    i++;
                    dataGridView1.Rows[user].Cells[2].Value = UserTXT[i];
                    i++;

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}

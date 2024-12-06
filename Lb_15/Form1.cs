using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lb_15
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }
        public int rowSelectedIndex; //Index row selected

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Login = new Form2();
            if (Login.ShowDialog() == DialogResult.OK)
            {
                switch (Login.userRoleId)
                {
                    //admin
                    case 5:

                        break;
                    //user
                    case 4:

                        break;

                }
            }

        }

        private void button1_Click_1(object sender, EventArgs e)//Add row in dataGridView1
        {

            int rowIndex = dataGridView1.Rows.Add();

            dataGridView1.Rows[rowIndex].Cells[0].Value = comboBox1.Text;
            dataGridView1.Rows[rowIndex].Cells[1].Value = textBox1.Text;
            dataGridView1.Rows[rowIndex].Cells[2].Value = textBox2.Text;
            dataGridView1.Rows[rowIndex].Cells[3].Value = textBox2.Text;
        }

        private void button2_Click(object sender, EventArgs e)    //Deletr row in dataGridView1
        {
            if (dataGridView1.RowCount > 0 && !dataGridView1.Rows[dataGridView1.Rows.Count - 1].IsNewRow)
                dataGridView1.Rows.RemoveAt(rowSelectedIndex);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[rowSelectedIndex].Cells[0].Value = comboBox1.Text;
            dataGridView1.Rows[rowSelectedIndex].Cells[1].Value = textBox1.Text;
            dataGridView1.Rows[rowSelectedIndex].Cells[2].Value = textBox2.Text;
            dataGridView1.Rows[rowSelectedIndex].Cells[3].Value = textBox2.Text;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowSelectedIndex = e.RowIndex;
            if (rowSelectedIndex >= 0)
            {


                if (dataGridView1.Rows[rowSelectedIndex].Cells[0].Value != null)
                    comboBox1.Text = dataGridView1.Rows[rowSelectedIndex].Cells[0].Value.ToString();

                if (dataGridView1.Rows[rowSelectedIndex].Cells[1].Value != null)
                    textBox1.Text = dataGridView1.Rows[rowSelectedIndex].Cells[1].Value.ToString();

                if (dataGridView1.Rows[rowSelectedIndex].Cells[2].Value != null)
                    textBox2.Text = dataGridView1.Rows[rowSelectedIndex].Cells[2].Value.ToString();

                if (dataGridView1.Rows[rowSelectedIndex].Cells[3].Value != null)
                    textBox3.Text = dataGridView1.Rows[rowSelectedIndex].Cells[3].Value.ToString();
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 UserEdit = new Form3();
            if (UserEdit.ShowDialog() == DialogResult.OK)
            {
                switch (rowSelectedIndex)
                {
                    //admin
                    case 5:

                        break;
                    //user
                    case 4:

                        break;

                }
            }
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 UserEdit = new Form3();
            if (UserEdit.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 UserEdit = new Form3();
            if (UserEdit.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}


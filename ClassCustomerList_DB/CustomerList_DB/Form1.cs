using System;
using System.Windows.Forms;

namespace CustomerList_DB
{
    public partial class Form1 : Form
    {
        DateTime BirthDay;
        int CusAge;
        string Name1;

        GridWithDB GWD = new GridWithDB("localhost", "3306", "test", "root", "1234");

        public Form1()
        {
            InitializeComponent();
        }

        #region TextClear, CusInfo
        public void TextClear()
        {
            textBox1.Text = "";
            Birth.Text = "";
            Address.Text = "";
            Description.Text = "";
            FirstName.Text = "";
            LastName.Text = "";
        }

        public bool CusInfo()
        {
            try
            {
                BirthDay = DateTime.Parse(Birth.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            CusAge = Age(BirthDay);
            Name1 = (FirstName.Text + " " + LastName.Text);
            return true;
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                GWD.SetGridTable(dataGridView1, "cuslist");
                GWD.GetDataDB();
                dataGridView1.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
                textBox2.AutoSize = false;
                textBox2.Size = new System.Drawing.Size(180, 28);
            }
            catch 
            {
                MessageBox.Show("The server connection fail.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CusInfo())
            {
                GWD.InsertDB(dataGridView1.RowCount+1, Name1, BirthDay, CusAge, Address.Text, Description.Text, FirstName.Text, LastName.Text);
                TextClear();
            }
        }

     

        private void button1_Click_1(object sender, EventArgs e)
        {
            GWD.GetDataDB();
        }

        private void DeleteDB_Click(object sender, EventArgs e)
        {
            GWD.DeleteDB();
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == System.Windows.Forms.Keys.Delete)
            {
                GWD.DeleteDB();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(CusInfo())
            {
                GWD.UpdateDB(Convert.ToInt32(textBox1.Text), Name1, BirthDay, CusAge, Address.Text, Description.Text, FirstName.Text, LastName.Text, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                TextClear();
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int IndexGrid = dataGridView1.CurrentRow.Index;
            textBox1.Text = dataGridView1.Rows[IndexGrid].Cells[0].Value.ToString();
            Birth.Text = dataGridView1.Rows[IndexGrid].Cells[2].Value.ToString().Substring(0,10);
            Address.Text = dataGridView1.Rows[IndexGrid].Cells[4].Value.ToString();
            Description.Text = dataGridView1.Rows[IndexGrid].Cells[5].Value.ToString(); 
            FirstName.Text = dataGridView1.Rows[IndexGrid].Cells[6].Value.ToString();
            LastName.Text = dataGridView1.Rows[IndexGrid].Cells[7].Value.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GWD.GetDataDB(textBox2.Text);
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == System.Windows.Forms.Keys.Enter)
                GWD.GetDataDB(textBox2.Text);
        }
        public int Age(DateTime Birthday)
        {
            return DateTime.Now.Year - Birthday.Year - (Birthday.DayOfYear < DateTime.Now.DayOfYear ? 0 : 1);
        }

        private void contectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }
    }
}

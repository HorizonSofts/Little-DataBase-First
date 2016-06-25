using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase_Application
{
    public partial class Form2 : Form
    {
        
        string con;
            
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection sqlcon = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=Skill_Db;Integrated Security=True");
                sqlcon.Open();
                String saving = "INSERT into Skill_Tb VALUES('" + Convert.ToInt32(textBox1.Text) + "','" + textBox2.Text + "','" + textBox3.Text + "')";
                SqlCommand sqlcom = new SqlCommand(saving, sqlcon);
                sqlcom.ExecuteNonQuery();
                MessageBox.Show("Data Saved Succesfully!!!!");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            catch (Exception er) {
                MessageBox.Show("You Must Have Write Some Thing to Save","Error!",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con = @"Data Source=.\SQLExpress;Initial Catalog=Skill_Db;Integrated Security=True";
            string qry = "SELECT * FROM Skill_Tb";
            SqlDataAdapter da = new SqlDataAdapter(qry, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string up = "UPDATE Skill_Tb SET Id='" + Convert.ToInt32(textBox1.Text) + "', Name='" + textBox2.Text + "', Skill = '" + textBox3.Text + "' WHERE Id='" + Convert.ToInt32(textBox1.Text) + "'";
                SqlConnection sqlupdater = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=Skill_Db;Integrated Security=True");
                sqlupdater.Open();
                SqlCommand sqlup = new SqlCommand(up, sqlupdater);
                sqlup.ExecuteNonQuery();
                MessageBox.Show("Updated!");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            catch (Exception up) {
                MessageBox.Show("Write Some Record with the Previous ID to Update","Error!",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection delcon = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=Skill_Db;Integrated Security=True");
                delcon.Open();
                string delq = " DELETE FROM Skill_Tb WHERE Id='" + Convert.ToInt32(textBox4.Text) + "'";
                SqlCommand delcom = new SqlCommand(delq, delcon);
                delcom.ExecuteNonQuery();
                MessageBox.Show("ID Record Deleted Succesfully");
                textBox4.Clear();
            }
            catch (Exception Deeeeel) {
                MessageBox.Show("Enter ID to Delete the Data!","Error!",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlSrch = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=Skill_Db;Integrated Security=True");
                sqlSrch.Open();
                string search = "SELECT * FROM Skill_Tb WHERE name='" + textBox5.Text + "';";
                SqlCommand serchcmnd = new SqlCommand(search, sqlSrch);
                serchcmnd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(search, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                MessageBox.Show("Serched!!");
                textBox5.Clear();
            }
            catch (Exception deeel) {
                MessageBox.Show("There is No Name to Search The Data for","Error!",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
               // Form1 obj = new Form1();
                //obj.Show();
            
                panel1.Visible = true;
                button6.Visible = false;
        }
    }
}

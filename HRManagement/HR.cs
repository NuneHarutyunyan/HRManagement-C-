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

namespace HRManagement
{
    public partial class HR : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OQHU914;Initial Catalog=HR;Integrated Security=True");
        SqlCommand com;
        int id;
        public HR()
        {
            InitializeComponent();
            DisplayProductGroup();
        }

        private void HR_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (HRFName.Text != "" || HRLName.Text != ""  || HRBirthDate.Text != "" || HRGender.Text != "" || HRContactNum.Text != "" || HREmail.Text != "")
            {
                try
                {
                    com = new SqlCommand(
                        "Insert into HRTbl values(@En,@Eln,@Eb,@Eg,@Ec,@Ee)", con
                        );
                    con.Open();
                    com.Parameters.AddWithValue("@En", HRFName.Text);
                    com.Parameters.AddWithValue("@Eln", HRLName.Text);
                    com.Parameters.AddWithValue("@Eb", HRBirthDate.Text);
                    com.Parameters.AddWithValue("@Eg", HRGender.Text);
                    com.Parameters.AddWithValue("@Ec", HRContactNum.Text);
                    com.Parameters.AddWithValue("@Ee", HREmail.Text);

                    com.ExecuteNonQuery();
                    con.Close();
                    DisplayMessage("HR-ի տվյալները հաջողությամբ մուտքագրվել են։");
                    CleanAll();
                    DisplayProductGroup();


                }
                catch (Exception ex)
                {

                    DisplayMessage(ex.Message);
                }
            }
            else
            {
                DisplayMessage("Խնդրում ենք լրացնել բոլոր դաշտերը։");
            }
        }

        private void CleanAll()
        {
            HRFName.Text="";
            HRLName.Text="";
            HRBirthDate.Text="";
            HRGender.Text="";
            HRContactNum.Text="";
            HREmail.Text="";

        }

        private void DisplayProductGroup()
        {
            con.Open();
            string Query = "Select * From HRTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void DisplayMessage(string txt)
        {
            MessageBox.Show(txt, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (HRFName.Text != "" || HRLName.Text != "" || HRBirthDate.Text != "" || HRGender.Text != "" || HRContactNum.Text != "" || HREmail.Text != "")
            {
                try
                {
                    com = new SqlCommand(
                        "Update HRTbl set HRFName=@bc, HRLName=@fn, HRBirthDate=@bf, HRGender=@bd, HRContactNum=@ec, HREmail=@ee where HRId=@id ", con
                        );
                    con.Open();
                    com.Parameters.AddWithValue("@bc", HRFName.Text);
                    com.Parameters.AddWithValue("@fn", HRLName.Text);
                    com.Parameters.AddWithValue("@bf", HRBirthDate.Text);
                    com.Parameters.AddWithValue("@bd", HRGender.Text);
                    com.Parameters.AddWithValue("@ec", HRContactNum.Text);
                    com.Parameters.AddWithValue("@ee", HREmail.Text);
                    com.Parameters.AddWithValue("@id", id);
                    com.ExecuteNonQuery();
                    con.Close();
                    CleanAll();
                    DisplayMessage("HR-ի տվյալները թարմեցված է։");
                    DisplayProductGroup();

                }
                catch (Exception ex)
                {

                    DisplayMessage(ex.Message);
                }

            }
            else
            {
                DisplayMessage("Խնդրում ենք  տող ընրել։");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (HRFName.Text != "" || HRLName.Text != "" || HRBirthDate.Text != "" || HRGender.Text != "" || HRContactNum.Text != "" || HREmail.Text != "")
            {
                try
                {
                    com = new SqlCommand(
                        "Delete  from HRTbl where HRId=@id", con
                        );
                    con.Open();
                    com.Parameters.AddWithValue("@id", id);
                    com.ExecuteNonQuery();
                    con.Close();
                    CleanAll();
                    DisplayMessage("Տվյալը հաջողությամբ ջնջվել է։");
                    DisplayProductGroup();

                }
                catch (Exception ex)
                {

                    DisplayMessage(ex.Message);
                }

            }
            else
            {
                DisplayMessage("Խնդրում ենք տող ընրել։");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                HRFName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                HRLName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                HRBirthDate.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                HRGender.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                HRContactNum.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                HREmail.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

            }
            else
            {
                DisplayMessage("Խնդրում ենք տող ընտրել։");
            }
        }

        private void Del_Click(object sender, EventArgs e)
        {
            CleanAll();
        }
    }
}

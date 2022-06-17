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
    public partial class Employee : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OQHU914;Initial Catalog=HR;Integrated Security=True");
        SqlCommand com;
        int id;
        public Employee()
        {
            InitializeComponent();
            DisplayProductGroup();
        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (EmpName.Text != "" || EmpLName.Text != "" || EmpindentNum.Text != "" || EmpBirthDate.Text!= "" || EmpGender.Text != "" || EmpContactNum.Text != "" || EmpEmail.Text != "")
            {
                try
                {
                    com = new SqlCommand(
                        "Insert into Employee values(@En,@Eln,@Ei,@Eb,@Eg,@Ec,@Ee)", con
                        );
                    con.Open();
                    com.Parameters.AddWithValue("@En", EmpName.Text);
                    com.Parameters.AddWithValue("@Eln", EmpLName.Text);
                    com.Parameters.AddWithValue("@Ei", EmpindentNum.Text);
                    com.Parameters.AddWithValue("@Eb", EmpBirthDate.Text);
                    com.Parameters.AddWithValue("@Eg", EmpGender.Text);
                    com.Parameters.AddWithValue("@Ec", EmpContactNum.Text);
                    com.Parameters.AddWithValue("@Ee", EmpEmail.Text);

                    com.ExecuteNonQuery();
                    con.Close();
                    DisplayMessage("Աշխատակցի տվյալները հաջողությամբ մուտքագրվել են։");
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

        private void DisplayProductGroup()
        {
            con.Open();
            string Query = "Select * From Employee";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void CleanAll()
        {
            EmpName.Text="";
            EmpLName.Text="";
            EmpindentNum.Text="";
            EmpBirthDate.Text="";
            EmpGender.Text="";
            EmpContactNum.Text = "";
            EmpEmail.Text="";
        }

        private void DisplayMessage(string txt)
        {

            MessageBox.Show(txt, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (EmpName.Text != "" || EmpLName.Text != "" || EmpindentNum.Text != "" || EmpBirthDate.Text != "" || EmpGender.Text != "" || EmpContactNum.Text != "" || EmpEmail.Text != "")
            {
                try
                {
                    com = new SqlCommand(
                        "Update Employee set EmpFName=@bc, EmpLName=@fn, EmpIndentNum=@bln, EmpBirthDate=@bf, EmpGender=@bd, EmpContactNum=@ec, EmpEmail=@ee where EmpId=@id ", con
                        );
                    con.Open();
                    com.Parameters.AddWithValue("@bc", EmpName.Text);
                    com.Parameters.AddWithValue("@fn",  EmpLName.Text);
                    com.Parameters.AddWithValue("@bln",EmpindentNum.Text);
                    com.Parameters.AddWithValue("@bf", EmpBirthDate.Text);
                    com.Parameters.AddWithValue("@bd", EmpGender.Text);
                    com.Parameters.AddWithValue("@ec", EmpContactNum.Text);
                    com.Parameters.AddWithValue("@ee", EmpEmail.Text);
                    com.Parameters.AddWithValue("@id", id);
                    com.ExecuteNonQuery();
                    con.Close();
                    CleanAll();
                    DisplayMessage("Աշխատակցի տվյալները թարմեցված է։");
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

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (EmpName.Text != "" || EmpLName.Text != "" || EmpindentNum.Text != "" || EmpBirthDate.Text != "" || EmpGender.Text != "" || EmpContactNum.Text != "" || EmpEmail.Text != "")
            {
                try
                {
                    com = new SqlCommand(
                        "Delete  from Employee where EmpId=@id", con
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
                EmpName.Text= dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                 EmpLName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
               EmpindentNum.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                EmpBirthDate.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                EmpGender.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                EmpContactNum.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                EmpEmail.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
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

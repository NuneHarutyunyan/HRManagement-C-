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
    public partial class Salary : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OQHU914;Initial Catalog=HR;Integrated Security=True");
        SqlCommand com;
        int id;
        public Salary()
        {
            InitializeComponent();
            DisplayProductGroup();
            fillcombo1();
            fillcombo2();
        }

        private void EmpLName1_Click(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (HRIdCombo.Text != "" || EmpSalary.Text != "" || EmpIdCombo.Text != "")
            {
                try
                {
                    com = new SqlCommand(
                        "Insert into HRDataTbl values(@En,@Eln,@Ei)", con
                        );
                    con.Open();
                    com.Parameters.AddWithValue("@En", EmpSalary.Text);
                    com.Parameters.AddWithValue("@Eln", EmpIdCombo.Text);
                    com.Parameters.AddWithValue("@Ei",HRIdCombo.Text);
                   
                    com.ExecuteNonQuery();
                    con.Close();
                    DisplayMessage("Տվյալները հաջողությամբ մուտքագրվել են։");
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

        private void DisplayMessage(string txt)
        {
            MessageBox.Show(txt, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DisplayProductGroup()
        {
            con.Open();
            string Query = "Select * From HRDataTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void CleanAll()
        {
            EmpSalary.Text = "";
             EmpIdCombo.Text="";
            HRIdCombo.Text="";
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (EmpSalary.Text != "" || EmpIdCombo.Text != "" || HRIdCombo.Text != "")
            {
                try
                {
                    com = new SqlCommand(
                        "Update HRDataTbl set EmpSalary=@bc, EmpId=@fn, HRId=@bln where HRDataId=@id ", con
                        );
                    con.Open();
                    com.Parameters.AddWithValue("@bc", EmpSalary.Text);
                    com.Parameters.AddWithValue("@fn", EmpIdCombo.Text);
                    com.Parameters.AddWithValue("@bln", HRIdCombo.Text);
                   
                    com.Parameters.AddWithValue("@id", id);
                    com.ExecuteNonQuery();
                    con.Close();
                    CleanAll();
                    DisplayMessage("Տվյալները թարմեցված է։");
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
            if (EmpSalary.Text != "" || EmpIdCombo.Text != "" || HRIdCombo.Text != "")
            {
                try
                {
                    com = new SqlCommand(
                        "Delete  from HRDataTbl where HRDataId=@id", con
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
                EmpSalary.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                EmpIdCombo.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                HRIdCombo.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
               
                id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

            }
            else
            {
                DisplayMessage("Խնդրում ենք տող ընտրել։");
            }
        }

        
        private void fillcombo1()
        {
            con.Open();
            com = new SqlCommand("Select EmpId from Employee", con);
            SqlDataReader rdr;
            rdr = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("EmpId", typeof(int));
            dt.Load(rdr);
            EmpIdCombo.ValueMember = "EmpId";
            EmpIdCombo.DataSource = dt;
            con.Close();
        }
        private void fillcombo2()
        {
            con.Open();
            com = new SqlCommand("Select HRId from HRTbl", con);
            SqlDataReader rdr;
            rdr = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("HRId", typeof(int));
            dt.Load(rdr);
            HRIdCombo.ValueMember = "HRId";
            HRIdCombo.DataSource = dt;
            con.Close();
        }

        private void Del_Click(object sender, EventArgs e)
        {
            CleanAll();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void label1_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Show();
            this.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Մանրամասների համար խնդրում ենք զանգահարել նշված հեռախոսահամարով՝ 010111111", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            HR hr = new HR();
            hr.Show();
            this.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Salary salary=new Salary();
            salary.Show();
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            HR hr = new HR();
            hr.Show();
            this.Show();

        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            Salary salary = new Salary();
            salary.Show();
            this.Show();
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Մանրամասների համար խնդրում ենք զանգահարել նշված հեռախոսահամարով՝ 010111111", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

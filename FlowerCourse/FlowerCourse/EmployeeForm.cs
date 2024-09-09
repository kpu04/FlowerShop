using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowerCourse
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void SalaryButton_Click(object sender, EventArgs e)
        {
            SalaryForm salary = new SalaryForm();
            salary.Show();
            this.Hide();
        }

        private void EmployeeButton_Click(object sender, EventArgs e)
        {
            EmployeeInfoForm employee = new EmployeeInfoForm();
            employee.Show();
            this.Hide();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            AdministratorForm administrator = new AdministratorForm();
            administrator.Show();
            this.Hide();
        }

        private void DepartmentButton_Click(object sender, EventArgs e)
        {
            DepartmentForm department = new DepartmentForm();
            department.Show();
            this.Hide();
        }
    }
}

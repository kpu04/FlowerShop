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
    public partial class AdministratorForm : Form
    {
        public AdministratorForm()
        {
            InitializeComponent();
        }

        private void CheckOrders_Click(object sender, EventArgs e)
        {
            OrderForm orders = new OrderForm();
            orders.Show();
            this.Hide();
        }

        private void ComponentButton_Click(object sender, EventArgs e)
        {
            ComponentForm component = new ComponentForm();
            component.Show();
            this.Hide();
        }

        private void CustomerButton_Click(object sender, EventArgs e)
        {
            CustomerForm customer = new CustomerForm();
            customer.Show();
            this.Hide();
        }

        private void CompositionButton_Click(object sender, EventArgs e)
        {
            CompositionForm composition = new CompositionForm();
            composition.Show();
            this.Hide();
        }

        private void EmployeeButton_Click(object sender, EventArgs e)
        {
            EmployeeForm employee = new EmployeeForm();
            employee.Show();
            this.Hide();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            AuthorizationForm authorization = new AuthorizationForm();
            authorization.Show();
            this.Hide();
        }

        private void AccountButton_Click(object sender, EventArgs e)
        {
            AccountForm account = new AccountForm();
            account.Show();
            this.Hide();
        }

        private void MakeRep_Click(object sender, EventArgs e)
        {
            ReportsForm rep = new ReportsForm();
            rep.Show();
            this.Hide();
        }
    }
}

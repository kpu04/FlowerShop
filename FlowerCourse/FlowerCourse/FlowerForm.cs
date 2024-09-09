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
    public partial class FlowerForm : Form
    {
        public event EventHandler<int> UserIdPassed;

        private int userId;
        private int idCustomer;


        public FlowerForm(int userId, int idCustomer)
        {
            InitializeComponent();
            this.userId = userId;
            this.idCustomer = idCustomer;
        }

        private void FlowersButton_Click(object sender, EventArgs e)
        {
            Catalog catalog = new Catalog(userId, idCustomer);
            catalog.Show();
            this.Hide();
        }

        private void PersonalAcc_Click(object sender, EventArgs e)
        {
         //   OnUserIdPassed(userId); 
            PersonalAcc pa = new PersonalAcc(userId, idCustomer);
            pa.Show();
            this.Hide();
        }


        private void ExitButton_Click(object sender, EventArgs e)
        {
            AuthorizationForm auth = new AuthorizationForm();
            auth.Show();
            this.Hide();
        }

        private void MyOrderButton_Click(object sender, EventArgs e)
        {
            MyOrder order = new MyOrder(idCustomer);
            order.Show();
            this.Hide();
        }
    }
}

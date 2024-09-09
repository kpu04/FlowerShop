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
    public partial class ComponentForm : Form
    {
        public ComponentForm()
        {
            InitializeComponent();
        }

        private void ComponentButton_Click(object sender, EventArgs e)
        {
            ComponentInfoForm component = new ComponentInfoForm();
            component.Show();
            this.Hide();
        }

        private void ShipmentButton_Click(object sender, EventArgs e)
        {
            ShipmentForm shipment = new ShipmentForm();
            shipment.Show(); 
            this.Hide();
        }

        private void ProviderButton_Click(object sender, EventArgs e)
        {
            ProviderForm provider = new ProviderForm();
            provider.Show();
            this.Hide();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            AdministratorForm administrator = new AdministratorForm();
            administrator.Show();
            this.Hide();
        }
    }
}

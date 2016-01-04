using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunescapeFlippingTracker
{
    public partial class BuyForm : Form
    {
        public BuyForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewItemForm NIF = new NewItemForm();

            NIF.Show();
        }
    }
}

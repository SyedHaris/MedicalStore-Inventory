using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MedicalStoreInventory
{
    public partial class Delete_Manufacturer : Form
    {
        int id;
        public Delete_Manufacturer()
        {
            InitializeComponent();
        }

        private void Delete_Manufacturer_Load(object sender, EventArgs e)
        {

        }

        private void dmtb_TextChanged(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dmtb.Text.ToString());
        }

        private void dmbtn_Click(object sender, EventArgs e)
        {
            DataBase.del_mf(id);
            MessageBox.Show("Manufacturer deleted");
        }
    }
}

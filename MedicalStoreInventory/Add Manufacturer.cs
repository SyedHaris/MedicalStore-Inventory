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
    public partial class Add_Manufacturer : Form
    {
        int id;
        String name;
        public Add_Manufacturer()
        {
            InitializeComponent();
        }

        private void adm_tb1_TextChanged(object sender, EventArgs e)
        {
                id = Convert.ToInt32(adm_tb1.Text.ToString());
        }

        private void admtb2_TextChanged(object sender, EventArgs e)
        {
            name = admtb2.Text.ToString();
        }

        private void admbtn_Click(object sender, EventArgs e)
        {
            DataBase.add_mf(id,name);
            MessageBox.Show("Manufacturer Added");
        }
    }
}

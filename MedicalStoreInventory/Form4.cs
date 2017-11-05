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
    public partial class Form4 : Form
    {
        int id;
        String str,name,tel,address;
        public Form4(int id,String str)
        {
            InitializeComponent();
            if(str=="Update")
                DataBase.filltb(id,ref nametb,ref teltb,ref adtb);
            this.str = str;
            this.id = id;
            this.Text = str+" Customer";
            button12.Text = str;

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
        private void button12_Click(object sender, EventArgs e)
        {
            
            try
            {
                switch (str)
                {
                    case "Add":
                        {
                            DataBase.add_cust(id,name,tel,address);
                            MessageBox.Show("Customer added");
                            break;
                        }
                    case "Update":
                            {
                                name = nametb.Text.ToString();
                                tel = teltb.Text.ToString();
                                address = adtb.Text.ToString();
                                DataBase.upd_cust(id,name,tel,address);
                                MessageBox.Show("Customer Updated");
                                break;
                            }
                }
            }
          catch (Exception)
            {
               MessageBox.Show("Field is empty");
            }
        }

        private void nametb_TextChanged(object sender, EventArgs e)
        {
            name = nametb.Text.ToString();
        }

        private void teltb_TextChanged(object sender, EventArgs e)
        {
            tel = teltb.Text.ToString();
        }

        private void adtb_TextChanged(object sender, EventArgs e)
        {
            address = adtb.Text.ToString();
        }
    }
}

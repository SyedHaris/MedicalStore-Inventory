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
    public partial class Form6 : Form
    {
        int id, quantity, mfid;
        String str, name;
        float price;
        public Form6(int id, String str)
        {
            InitializeComponent();
            if (str == "Update")
                DataBase.filltb(id, ref form6tb1, ref form6tb2, ref form6tb3, ref form6tb4);
            this.id = id;
            this.str = str;
            this.Text = str;
            form6btn.Text = str;
        }

        private void form6tb1_TextChanged(object sender, EventArgs e)
        {
            name = form6tb1.Text.ToString();
        }

        private void form6tb2_TextChanged(object sender, EventArgs e)
        {
            price = (float)Convert.ToDecimal(form6tb2.Text.ToString());
        }

        private void form6tb3_TextChanged(object sender, EventArgs e)
        {
            quantity = Convert.ToInt32(form6tb3.Text.ToString());
        }

        private void form6tb4_TextChanged(object sender, EventArgs e)
        {
            mfid = Convert.ToInt32(form6tb4.Text.ToString());
        }

        private void form6btn_Click(object sender, EventArgs e)
        {

            try
            {
                switch (str)
                {
                    case "Add":
                        {
                            DataBase.add_item(id, name, price, quantity, mfid);
                            MessageBox.Show("Item added");
                            break;
                        }
                    case "Update":
                        {
                            name = form6tb1.Text.ToString();
                            price = float.Parse(form6tb2.Text.ToString());
                            quantity = Convert.ToInt32(form6tb3.Text.ToString());
                            mfid = Convert.ToInt32(form6tb4.Text.ToString());
                            DataBase.update_item(id, name, price, quantity, mfid);
                            MessageBox.Show("Item updated");
                            break;
                        }
                }
            }
                        catch(Exception exp)
                        {
                            //MessageBox.Show("Field empty");
                            MessageBox.Show(exp.Message);
                        }
        }
    }
}

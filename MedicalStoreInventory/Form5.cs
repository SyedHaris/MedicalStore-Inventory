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
    public partial class Form5 : Form
    {
        int id;
        String str,name,address,tel,pwd;
        public Form5(int id,String str)
        {
            InitializeComponent();
            if (str == "Update")
                DataBase.filltb(id,ref userpwd_tb,ref user_nametb,ref user_teltb,ref add_usertb);
            this.str = str;
            this.id = id;
            this.Text=str;
            OK_btn.Text = str;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            
        }

        private void userpwd_tb_TextChanged(object sender, EventArgs e)
        {
            pwd = userpwd_tb.Text.ToString();
        }

        private void user_nametb_TextChanged(object sender, EventArgs e)
        {
            name = user_nametb.Text.ToString();
        }

        private void user_teltb_TextChanged(object sender, EventArgs e)
        {
            tel = user_teltb.Text.ToString();
        }

        private void OK_btn_Click(object sender, EventArgs e)
        {
            try
            {
                switch (str)
                {
                    case "Add":
                        {
                            try
                            {
                                DataBase.add_user(id, name, pwd, tel, address);
                            }
                            catch (Exception exp)
                            {
                                MessageBox.Show(exp.Message);
                            }
                            MessageBox.Show("User added");
                            break;
                        }
                    case "Update":
                        {
                            pwd = userpwd_tb.Text.ToString();
                            address = add_usertb.Text.ToString();
                            tel = user_teltb.Text.ToString();
                            name = user_nametb.Text.ToString();
                            DataBase.update_user(id, name, pwd, tel, address);
                            MessageBox.Show("User updated");
                            break;
                        }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                //MessageBox.Show("Feild is empty");
            }
        }

        private void add_usertb_TextChanged_1(object sender, EventArgs e)
        {
            address = add_usertb.Text.ToString();
        }

        
    }
}

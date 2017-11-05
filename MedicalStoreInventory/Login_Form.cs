using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MedicalStoreInventory
{
    public partial class Login_Form : Form
    {
        public static String pwd;
        String role;

        public Login_Form(String role)
        {
            InitializeComponent();
            this.role = role;
        }
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            
            
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
                pwd = password.Text.ToString();
        }

        private void login_Click(object sender, EventArgs e)
        {
            try
            {
                switch(role)
                {
                    case "user":
                        {
                            if (DataBase.validate(pwd,role))
                            {
                                User user = new User();
                                user.Show();
                                this.Close();
                                break;
                            }
                            else
                            {
                                MessageBox.Show("Invalid password");
                                break;
                            }
                        }
                    case "admin":
                        {
                            if (DataBase.validate(pwd,role))
                            {
                                Adminstrator admin = new Adminstrator();
                                admin.Show();
                                this.Close();
                                break;
                            }
                            else
                            {
                                MessageBox.Show("Invalid password");
                                break;
                            }
                        }
            }
        }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      
        }
    static class DataBase
    {
        static String connstr = "server=localhost;user id=root;password=harispc;database=medicalstore";
        static MySqlConnection conn=new MySqlConnection(connstr);
        static MySqlCommand cmd;
        static MySqlDataReader rdr;
        static String command;
        static int quantity2 = 0;
        public static bool validate(string pwd,String role)
        {
            conn.Open();
            if(role=="user")
                command = "SELECT password From user WHERE password='" + pwd + "';";
            else
                command = "SELECT password From administrator WHERE password='" + pwd + "';";
                cmd = new MySqlCommand(command, conn);
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    rdr.Close();
                    conn.Close();
                    return true;
                }
                else
                {
                    rdr.Close();
                    conn.Close();
                    return false;
                }
        }
        public static void update_llogin(int id)
        {
            conn.Open();
            command = "UPDATE user SET lastlogin='"+DateTime.Now.ToString("yyy-MM-dd HH:mm:ss")+"'WHERE id='" + id + "';";
            cmd = new MySqlCommand(command, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

        }
        public static int getid(String pwd,String role)
        {
            String id="";
            conn.Open();
            if(role=="user")
                command = "SELECT * FROM user WHERE password='" + pwd + "';";
            else
                command = "SELECT * FROM administrator WHERE password='" + pwd + "';";
            cmd = new MySqlCommand(command, conn);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
                id = rdr["id"].ToString();
            rdr.Close();
            conn.Close();
            return Convert.ToInt32(id);
        }
        public static void user_info(ref TextBox t1, ref TextBox t2, ref TextBox t3, ref TextBox t4, ref Label l,String pwd)
        {
            conn.Open();
            command = "SELECT * FROM user WHERE password='"+pwd+"';";
            cmd = new MySqlCommand(command,conn);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                t1.Text = rdr["id"].ToString();
                t2.Text = rdr["tel"].ToString();
                t3.Text = rdr["address"].ToString();
                t4.Text = rdr["lastlogin"].ToString();
                l.Text = rdr["name"].ToString();
            }
            rdr.Close();
            conn.Close();
        }
        public static void admin_info(ref TextBox t1, ref TextBox t2, ref TextBox t3, ref Label l, String pwd)
        {
            conn.Open();
            command = "SELECT * FROM administrator WHERE password='" + pwd + "';";
            cmd = new MySqlCommand(command, conn);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                t1.Text = rdr["id"].ToString();
                t2.Text = rdr["tel"].ToString();
                t3.Text = rdr["address"].ToString();
                l.Text = rdr["name"].ToString();
            }
            rdr.Close();
            conn.Close();
        }
        public static void itemsearch(String search,ref DataGridView dg)
        {
            conn.Open();
            command = "SELECT * FROM items WHERE name='"+search+"';";
            cmd.CommandText = command;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt=new DataTable();
            adapter.Fill(dt);
            dg.DataSource = dt;
            conn.Close();
        }
        public static void mfsearch(String search,ref DataGridView dg)
        {
            int id=0;
            conn.Open();
            command = "SELECT id FROM manufacturer WHERE name='" + search + "';";
            cmd.CommandText = command;
            rdr = cmd.ExecuteReader();
            while(rdr.Read())
                id=Convert.ToInt32(rdr["id"]);
            rdr.Close();
            command = "SELECT * FROM items WHERE mfid='" + id + "';";
            cmd.CommandText = command;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dg.DataSource = dt;
            adapter.DeleteCommand = cmd;
            conn.Close();
        }
        public static void searchall(ref DataGridView dg) 
        {
            conn.Open();
            command = "SELECT * FROM items";
            cmd = new MySqlCommand(command,conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dg.DataSource = dt;
            adapter.DeleteCommand = cmd;
            conn.Close();
        }
        public static int get_uniqueid()
        {
            int[] id=new int[100];
            Random rand = new Random();
            int unique_id=1000,idx=0;
            conn.Open();
            command = "SELECT id FROM bills";
            cmd = new MySqlCommand(command, conn);
            rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                int i=0;
                while (rdr.Read())
                {
                    id[i] = Convert.ToInt32(rdr["id"]);
                    i++;
                }
                rdr.Close();
                while (idx == 0)
                {
                    idx = 1;
                    unique_id = rand.Next(1000, 10000);
                    for (int count = 0; count <= i; count++)
                    {
                        if (unique_id == id[count])
                            idx = 0;
                    }
                }
            }
            else
            {
                conn.Close();
                return unique_id;
            }
            conn.Close();
            return unique_id;
        }
        public static void createbill(int bill_id,int userid)
        {
            conn.Open();
            try
            {
                command = "INSERT INTO bills(date,total,discount,uid,id) VALUES('" + DateTime.Now.ToString("yyy-MM-dd HH:mm:ss") + "','" + 0.0 + "','" + 0.0 + "','" + userid + "','" + bill_id + "');";
                cmd = new MySqlCommand(command, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        public static void bill_detail(int bid,String name,int quantity)
        {
            reducequantity(name, quantity);
            float price=0;
            int iid=0;
            conn.Open();
            command = "SELECT id,price FROM items WHERE name='"+name+"';";
            cmd = new MySqlCommand(command, conn);
            rdr=cmd.ExecuteReader();
            while (rdr.Read())
            {
                iid = Convert.ToInt32(rdr["id"].ToString());
                price = (float)Convert.ToDouble(rdr["price"].ToString());
            }
            rdr.Close();
            command = "INSERT INTO billsdetial(bid,iid,price,quantity) VALUES('" + bid + "','" + iid + "','" + price + "','" + quantity +"');" ;
            cmd = new MySqlCommand(command,conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            
        }
        public static bool checkquantity(String name,int quantity)
        {
            conn.Open();
            command = "SELECT quantity FROM items WHERE name='" + name + "';";
            cmd = new MySqlCommand(command, conn);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
                quantity2 = Convert.ToInt32(rdr["quantity"].ToString());
            rdr.Close();
            if (quantity2 >= quantity)
            {
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }
        }
        public static void reducequantity(String name,int quantity)
        {
            conn.Open();
            try
            {
                command = "UPDATE items SET  quantity='" + (quantity2 - quantity) + "'WHERE name='" + name + "';";
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Data.ToString());
            }
            cmd = new MySqlCommand(command,conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void total(ref TextBox t,int bid)
        {
            float total;
            conn.Open();
            command = "SELECT SUM(price*quantity) AS total FROM billsdetial WHERE bid='"+bid+"';";
            cmd = new MySqlCommand(command,conn);
            total=(float)Convert.ToDouble(cmd.ExecuteScalar());
            t.Text = total.ToString();
            conn.Close();
        }
        public static void makebill(int bid,float total, float discount, String payment)
        {
            conn.Open();
            command = "UPDATE bills SET total='" + total +"',discount='"+discount+"',payment='"+payment+"'WHERE id='" + bid + "';";
            cmd = new MySqlCommand(command,conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void del_bill(int bid)
        {
            conn.Open();
            command = "DELETE FROM bills WHERE id='"+bid+"';";
            cmd = new MySqlCommand(command,conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void make_bill(int bid,ref DataGridView d)
        {
            conn.Open();
            command = "SELECT billsdetial.bid,items.name,billsdetial.price,billSdetial.quantity FROM billsdetial INNER JOIN items ON billsdetial.iid=items.id AND billsdetial.bid='"+bid+"';";
            cmd = new MySqlCommand(command,conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            d.DataSource = dt;
            conn.Close();
        }
    
        public static void search_bill(int bid, ref DataGridView dg,String sortby)
        {
            conn.Open();

            if (sortby == "id")
                command = "SELECT * FROM bills WHERE id='" + bid + "'ORDER BY id";
            else if (sortby == "total")
                command = "SELECT * FROM bills WHERE id='" + bid + "'ORDER BY total";
            else
                command = "SELECT * FROM bills WHERE id='" + bid + "'ORDER BY date";
            cmd = new MySqlCommand(command,conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dg.DataSource = dt;
            conn.Close();
        }
        public static void search_bill(ref DataGridView dg, String sortby)
        {
            conn.Open();
            if (sortby == "id")
                command = "SELECT * FROM bills ORDER BY id";
            else if (sortby == "total")
                command = "SELECT * FROM bills ORDER BY total";
            else
                command = "SELECT * FROM bills ORDER BY date";
            cmd = new MySqlCommand(command, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dg.DataSource = dt;
            conn.Close();
        }

        public static void search_bill(DateTime date,ref DataGridView dg,String sortby)
        {
            conn.Open();
            if(sortby=="id")
                command = "SELECT * FROM bills WHERE date='" + date.ToString("yyy-MM-dd") +"'ORDER BY id";
            else if(sortby=="total")
                command ="SELECT * FROM bills WHERE date='" + date.ToString("yyy-MM-dd") + "'ORDER BY total";
            else
                command = "SELECT * FROM bills WHERE date='" + date.ToString("yyy-MM-dd") + "'ORDER BY date";
            cmd = new MySqlCommand(command, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dg.DataSource = dt;
            conn.Close();
        }
        public static void filltb(int cid,ref TextBox t1,ref TextBox t2,ref RichTextBox rtb)
        {
            conn.Open();
            command = "SELECT name,tel,address FROM customer WHERE id='"+cid+"';";
            cmd = new MySqlCommand(command,conn);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                t1.Text = rdr["name"].ToString();
                t2.Text = rdr["tel"].ToString();
                rtb.Text = rdr["address"].ToString();
            }
            rdr.Close();
            conn.Close();
        }
        public static void filltb(int id, ref TextBox t1, ref TextBox t2,ref TextBox t3, ref RichTextBox rtb)
        {
            conn.Open();
            command = "SELECT password,name,tel,address FROM user WHERE id='" + id + "';";
            cmd = new MySqlCommand(command, conn);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                t1.Text = rdr["password"].ToString();
                t2.Text = rdr["name"].ToString();
                t3.Text=rdr["tel"].ToString();
                rtb.Text = rdr["address"].ToString();
            }
            rdr.Close();
            conn.Close();
        }
        public static void filltb(int id, ref TextBox t1, ref TextBox t2, ref TextBox t3, ref TextBox t4)
        {
            conn.Open();
            command = "SELECT name,price ,quantity,mfid FROM items WHERE id='" + id + "';";
            cmd = new MySqlCommand(command, conn);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                t1.Text = rdr["name"].ToString();
                t2.Text = rdr["price"].ToString();
                t3.Text = rdr["quantity"].ToString();
                t4.Text = rdr["mfid"].ToString();
            }
            rdr.Close();
            conn.Close();
        }
        public static void add_cust(int cid,String name,String tel,String address)
        {
            conn.Open();
            command = "INSERT INTO customer(id,name,tel,address) VALUES('"+cid+"','"+name+"','"+tel+"','"+address+"');";
            cmd = new MySqlCommand(command,conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void del_cust(int cid)
        {
            conn.Open();
            command = "DELETE  FROM customer WHERE id='"+cid+"';";
            cmd = new MySqlCommand(command, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void upd_cust(int cid, String name, String tel, String address)
        {
            conn.Open();
            command = "UPDATE  customer SET name='"+name+"',tel='"+tel+"',address='"+address+"' WHERE id='"+cid+"';";
            cmd = new MySqlCommand(command, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void search_cust(int cid,ref DataGridView dg,String sortby)
        {
            conn.Open();
            if (sortby == "id")
                command = "SELECT customer.id,customer.name,customer.tel,customer.address,COUNT(*) AS orders FROM customer,orders WHERE orders.cid=customer.id AND customer.id='" + cid + "'ORDER BY customer.id";
            else
                command = "SELECT customer.id,customer.name,customer.tel,customer.address,COUNT(*) AS orders FROM customer,orders WHERE orders.cid=customer.id AND customer.id='" + cid + "'ORDER BY customer.name";
            cmd = new MySqlCommand(command, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dg.DataSource = dt;
            conn.Close();
        }
        public static void search_cust(String name, ref DataGridView dg, String sortby)
        {
            conn.Open();
            if (sortby == "id")
                command = "SELECT customer.id,customer.name,customer.tel,customer.address,COUNT(*) AS orders FROM customer,orders WHERE orders.cid=customer.id AND customer.name='" + name + "'ORDER BY customer.id";
            else
                command = "SELECT customer.id,customer.name,customer.tel,customer.address,COUNT(*) AS orders FROM customer,orders WHERE orders.cid=customer.id AND customer.name='" + name + "'ORDER BY customer.name";
            cmd = new MySqlCommand(command, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dg.DataSource = dt;
            conn.Close();
        }
        public static void search_cust(ref DataGridView dg,String sortby)
        {
                      conn.Open();
            if (sortby == "id")
                command = "SELECT customer.id,customer.name,customer.tel,customer.address,COUNT(*) AS orders FROM customer,orders WHERE orders.cid=customer.id GROUP BY customer.name ORDER BY customer.id";
            else
                command = "SELECT customer.id,customer.name,customer.tel,customer.address,COUNT(*) AS orders FROM customer,orders WHERE orders.cid=customer.id GROUP BY customer.name ORDER BY customer.name";
            cmd = new MySqlCommand(command, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dg.DataSource = dt;
            conn.Close();
        }
        public static void place_order(int cid,int bid)
        {
            conn.Open();
            command = "INSERT INTO orders(cid,bid) VALUES('" + cid + "','" + bid + "');";
            cmd = new MySqlCommand(command,conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void search_order(int cid,ref DataGridView dg)
        {
            conn.Open();
            command = "SELECT orders.no,orders.cid,orders.bid,bills.date FROM orders INNER JOIN bills ON orders.bid=bills.id AND orders.cid='"+cid+"';";
            cmd = new MySqlCommand(command,conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dg.DataSource = dt;
            conn.Close();
        }
        public static void add_user(int id,String name,String password,String tel,String address)
        {
            conn.Open();
            command = "INSERT INTO user(id,password,name,tel,address) VALUES('"+id+"','"+password+"','"+name+"','"+tel+"','"+address+"');";
            cmd = new MySqlCommand(command,conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void update_user(int id, String name, String password, String tel, String address)
        {
            conn.Open();
            command = "UPDATE user SET name='"+name+"',password='"+password+"',tel='"+tel+"',address='"+address+"'WHERE id='"+id+"';";
            cmd = new MySqlCommand(command, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void del_user(int id)
        {
            conn.Open();
            command = "DELETE FROM user WHERE id='"+id+"';";
            cmd = new MySqlCommand(command, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void add_item(int id,String name,float price,int quantity,int mfid)
        {
            conn.Open();
            command = "INSERT INTO items(id,name,price,quantity,mfid) VALUES('" + id + "','" + name + "','" + price + "','" + quantity +"','"+mfid+ "');";
            cmd = new MySqlCommand(command, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void update_item(int id,String name,float price,int quantity,int mfid)
        {
            conn.Open();
            command = "UPDATE items SET name='" + name + "',price='" + price + "',quantity='" + quantity + "',mfid='" + mfid + "'WHERE id='" + id + "';";
            cmd = new MySqlCommand(command, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void del_item(int id)
        {
            conn.Open();
            command = "DELETE FROM items WHERE id='" + id + "';";
            cmd = new MySqlCommand(command, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void add_mf(int id,String name)
        {
            conn.Open();
            command = "INSERT INTO manufacturer(id,name) VALUES('" + id + "','" + name + "');";
            cmd = new MySqlCommand(command, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void del_mf(int id)
        {
            conn.Open();
            command = "DELETE FROM manufacturer WHERE id='" + id + "';";
            cmd = new MySqlCommand(command, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void search_users(ref DataGridView dg)
        {
            conn.Open();
            command = "SELECT * FROM user";
            cmd = new MySqlCommand(command,conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dg.DataSource = dt;
            conn.Close();
        }
        public static void search_mf(ref DataGridView dg)
        {
            conn.Open();
            command = "SELECT * FROM manufacturer";
            cmd = new MySqlCommand(command, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dg.DataSource = dt;
            conn.Close();
        }
        public static void autocomp_source(ref AutoCompleteStringCollection auto)
        {
            conn.Open();
            command = "SELECT name FROM items";
            cmd = new MySqlCommand(command,conn);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
                auto.Add(rdr["name"].ToString());
            rdr.Close();
            conn.Close();
        }
    }
}

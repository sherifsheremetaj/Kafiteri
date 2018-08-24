using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading;


namespace Kafiteri
{
    public partial class Form1 : Form
    {
        Thread th;
        int togmove; private string conn;
        private MySqlConnection connect;
        int mvalx; DataTable data;
        int mvaly;
        public static int i = 0;
        double iloy;
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            togmove = 1; mvalx = e.X;
            mvaly = e.Y;
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            togmove = 0;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (togmove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mvalx, MousePosition.Y - mvaly);
            }
        }
        private void db_connection()
        {
            try
            {
                conn = "Server=localhost;Database=kafiteri;Uid=root;Pwd=;Convert Zero Datetime=True;default command timeout=360;";
                connect = new MySqlConnection(conn);
                connect.Open();
            }
            catch (MySqlException e)
            {
                throw;
            }
        }
        void openmenu()
        {
            Application.Run(new Form2());
        }
        private bool validates(string user, string pass)
        {
            db_connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "Select * from login where username=@user and password=@pass";
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@pass", pass);
            cmd.Connection = connect;
            MySqlDataReader login = cmd.ExecuteReader();
            if (login.Read())
            {
                connect.Close();
                return true;
            }
            else
            {
                connect.Close();
                return false;
            }
        }
        private bool validatek(string user, string pass)
        {
            db_connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "Select * from klogin where username=@user and password=@pass";
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@pass", pass);
            cmd.Connection = connect;
            MySqlDataReader login = cmd.ExecuteReader();
            if (login.Read())
            {
                connect.Close();
                return true;
            }
            else
            {
                connect.Close();
                return false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
             string user = username.Text;
               string pass = password.Text;
            bool r = validates(user, pass);
            
            if(r&& menaxheri.Checked){
                
              

               
                    th = new Thread(openmenu);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                    this.Hide();
            }
               

            bool k = validatek(user, pass);
            if (k && staffi.Checked)
            {

                th = new Thread(openmenu);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
                this.Hide();
            }
            }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        }
    
}

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

namespace Kafiteri
{
    public partial class Form2 : Form
    {
        int togmove; private string conn;
        private MySqlConnection connect;
        int mvalx; DataTable data;
        int mvaly;
        public static int i = 0;
        double iloy;
        public Form2()
        {
            InitializeComponent(); this.ActiveControl = sasia; lista.View = View.Details; rowselect(); alkoolp.Visible = false; picatp.Visible = false; embelsirap.Visible = false; pijetp.Visible = false;
            birratp.Visible = false; ushqimetp.Visible = false;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void TextBoxPalceHolder_Load(object sender, EventArgs e)
        {
         
           sasia.GotFocus += new EventHandler(this.TextGotFocus);
            sasia.LostFocus += new EventHandler(this.TextLostFocus);

        }

        public void TextGotFocus(object sender, EventArgs e)
        {
            TextBox sasia = (TextBox)sender;
            if (sasia.Text == "Sasia")
            {
                sasia.Text = "";
                sasia.ForeColor = Color.Black;
            }
        }

        public void TextLostFocus(object sender, EventArgs e)
        {
            TextBox sasia = (TextBox)sender;
            if (sasia.Text == "")
            {
                sasia.Text = "Sasia";
                sasia.ForeColor = Color.LightGray;
            }
        }
        private void db_connection()
        {
            try
            {
                conn = "Server=localhost;Database=kafiteri;Uid=root;Pwd=;";
                connect = new MySqlConnection(conn);


                connect.Open();
            }
            catch (MySqlException e)
            {
                throw;
            }
        }
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
           
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

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            embelsirap.Visible = false; ushqimetp.Visible = false; picatp.Visible = false; birratp.Visible = false; pijetp.Visible = true;
            Kafep.Visible = false;
            indicator2.Left = ((Control)sender).Left;
            indicator2.Width = ((Control)sender).Width;
            alkoolp.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            embelsirap.Visible = false; ushqimetp.Visible = false; picatp.Visible = false; birratp.Visible = true;
            pijetp.Visible = false; Kafep.Visible = false; 
            indicator2.Left = ((Control)sender).Left;
            indicator2.Width = ((Control)sender).Width;
            alkoolp.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            embelsirap.Visible = false;
            ushqimetp.Visible = false; picatp.Visible = false;
            alkoolp.Visible = true;
            birratp.Visible = false; pijetp.Visible = false; Kafep.Visible = false; indicator2.Left = ((Control)sender).Left;
            indicator2.Width = ((Control)sender).Width;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            embelsirap.Visible = true;
            ushqimetp.Visible = false; picatp.Visible = false; alkoolp.Visible = false; birratp.Visible = false; pijetp.Visible = false; Kafep.Visible = false; indicator2.Left = ((Control)sender).Left;
            indicator2.Width = ((Control)sender).Width;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            embelsirap.Visible = false;
            ushqimetp.Visible = true;
            picatp.Visible = false; alkoolp.Visible = false; birratp.Visible = false; pijetp.Visible = false; Kafep.Visible = false; indicator2.Left = ((Control)sender).Left;
            indicator2.Width = ((Control)sender).Width;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            embelsirap.Visible = false;
            ushqimetp.Visible = false;
            alkoolp.Visible = false;
            birratp.Visible = false;
            pijetp.Visible = false; picatp.Visible = false; 
            Kafep.Visible = true;
            indicator2.Left = ((Control)sender).Left;
            indicator2.Width = ((Control)sender).Width;
        }

        private void indicator2_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            embelsirap.Visible = false; ushqimetp.Visible = false; picatp.Visible = true; alkoolp.Visible = false;
            birratp.Visible = false;
            pijetp.Visible = false;
            Kafep.Visible = false;
            indicator2.Left = ((Control)sender).Left;
            indicator2.Width = ((Control)sender).Width;
        }

        void rowselect()
        {
           
        }
        private void bunifuImageButton87_Click(object sender, EventArgs e)
        {
            if (lista.SelectedItems.Count > 0)
            {
                string name = lista.SelectedItems[0].SubItems[1].ToString();

                lista.SelectedItems[0].Remove();
            }
            else
            {
                MessageBox.Show("Selektoje një rresht");
            }
            decimal sum = 0;
            for (int z = 0; z < lista.Items.Count; z++)
            {
                sum += decimal.Parse(lista.Items[z].SubItems[4].Text);
            }
            tot.Text = sum.ToString();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
         
            i = i + 1;
            string sql = "SELECT Emri,Cmimi from kafestok where Emri='Espressoshkurt'";
         
            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Espresso e Shkurtë";
            double llog;
            string sm;
            try
            {

                   db_connection();
                   MySqlCommand es = new MySqlCommand(sql, connect);
            MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
           cmimi=Convert.ToDouble(rd["Cmimi"]);
llog=Convert.ToDouble(sasia.Text)*cmimi;

                     lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }
                
                
            }

                catch(Exception iu){

                }

          
            

              
               

            
        
              
            
        }
        private void bunifuImageButton86_Click(object sender, EventArgs e)
        {
           
         



        }

        private void bunifuImageButton45_Click(object sender, EventArgs e)
        {
            db_connection();
            i = i + 1;
            string sql = "SELECT Emri,Cmimi from kafestok where Emri='EspressoGjate'";
            MySqlCommand es = new MySqlCommand(sql, connect);
            MySqlDataReader rd = es.ExecuteReader();
            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            while (rd.Read())
            {
                emri = "Espresso e Gjatë";
                cmimi = Convert.ToDouble(rd["Cmimi"]);
                double llog;
                llog = Convert.ToDouble(sasia.Text) * cmimi;

                lv.SubItems.Add(emri);
                lv.SubItems.Add(sasia.Text);
                lv.SubItems.Add(cmimi.ToString());
                lv.SubItems.Add(llog.ToString());

                lista.Items.Add(lv);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            

        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            i = i + 1;
            string sql = "SELECT Emri,Cmimi from kafestok where Emri='NessKlasik'";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Ness Klasik";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

           

        }

        private void bunifuImageButton47_Click(object sender, EventArgs e)
        {

            i = i + 1;
            string sql = "SELECT Emri,Cmimi from kafestok where Emri='MakiatoVogel'";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Makiato e Vogel";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }
        }

        private void bunifuImageButton46_Click(object sender, EventArgs e)
        {

            i = i + 1;
            string sql = "SELECT Emri,Cmimi from kafestok where Emri='EspressoMesme'";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Espresso e Mesme";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {

            i = i + 1;
            string sql = "SELECT Emri,Cmimi from kafestok where Emri='MakiatoMadhe'";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Makiato e Madhe";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            i = i + 1;
            string sql = "SELECT Emri,Cmimi from kafestok where Emri='Amerikane'";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Amerikane";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }
        }

        private void bunifuImageButton48_Click(object sender, EventArgs e)
        {
            i = i + 1;
            string sql = "SELECT Emri,Cmimi from kafestok where Emri='NessVanille'";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Ness Vanille";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            i = i + 1;
            string sql = "SELECT Emri,Cmimi from kafestok where Emri='Cappuccino'";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Cappuccino";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            i = i + 1;
            string sql = "SELECT Emri,Cmimi from kafestok where Emri='Bambi'";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Bambi";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tot.ResetText();
            this.lista.Items.Clear();
            this.lista.Update();
            this.lista.Refresh();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            int k;
            string name, cuantity, price, total;
            for (k = 0; k < lista.Items.Count; k++)
            {



                string insert = "INSERT INTO shitja (Emri,Sasia,Cmimi,Totali,Data) values('" + lista.Items[k].SubItems[1].Text + "','" + lista.Items[k].SubItems[2].Text + "','" + lista.Items[k].SubItems[3].Text + "','" + lista.Items[k].SubItems[4].Text + "',NOW())";
                try
                {
                    db_connection();
                    MySqlCommand ins = new MySqlCommand(insert, connect);
                    if (ins.ExecuteNonQuery() == 1)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Gabim");
                    }
                }
                catch (Exception o)
                {

                }
                connect.Close();
            }


            decimal sum = 0;
            for (int z = 0; z < lista.Items.Count; z++)
            {
                sum += decimal.Parse(lista.Items[z].SubItems[4].Text);
            }
            tot.Text = sum.ToString();
            

        }

        private void bunifuImageButton14_Click(object sender, EventArgs e)
        {
            i = i + 1;
            string sql = "SELECT Emri,Cmimi from pijetstok where Emri='CocaCola'AND Sasia>0";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Coca Cola";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }
            string sqlu = "Update pijetstok set Sasia=Sasia-'" + this.sasia.Text + "'WHERE Emri='CocaCola'";
         
            try
            {
                db_connection();
                MySqlCommand cu = new MySqlCommand(sqlu, connect);
                cu.ExecuteNonQuery();
            }
            catch (Exception uuu)
            {

            }
        }

        private void bunifuImageButton11_Click(object sender, EventArgs e)
        {
            i = i + 1;
            string sql = "SELECT Emri,Cmimi from pijetstok where Emri='CocaColaZero'AND Sasia>0";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Coca Cola Zero";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }
            string sqlu = "Update pijetstok set Sasia=Sasia-'" + this.sasia.Text + "'WHERE Emri='CocaColaZero'";

            try
            {
                db_connection();
                MySqlCommand cu = new MySqlCommand(sqlu, connect);
                cu.ExecuteNonQuery();
            }
            catch (Exception uuu)
            {

            }
        }

        private void bunifuImageButton13_Click(object sender, EventArgs e)
        {
            i = i + 1;
            string sql = "SELECT Emri,Cmimi from pijetstok where Emri='Fanta'AND Sasia>0";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Fanta";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }
            string sqlu = "Update pijetstok set Sasia=Sasia-'" + this.sasia.Text + "'WHERE Emri='Fanta'";

            try
            {
                db_connection();
                MySqlCommand cu = new MySqlCommand(sqlu, connect);
                cu.ExecuteNonQuery();
            }
            catch (Exception uuu)
            {

            }
        }

        private void bunifuImageButton12_Click(object sender, EventArgs e)
        {
            i = i + 1;
            string sql = "SELECT Emri,Cmimi from pijetstok where Emri='Sprite'And Sasia>0";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Sprite";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }
            string sqlu = "Update pijetstok set Sasia=Sasia-'" + this.sasia.Text + "'WHERE Emri='Sprite'";

            try
            {
                db_connection();
                MySqlCommand cu = new MySqlCommand(sqlu, connect);
                cu.ExecuteNonQuery();
            }
            catch (Exception uuu)
            {

            }
        }

        private void bunifuImageButton49_Click(object sender, EventArgs e)
        {
            i = i + 1;
            string sql = "SELECT Emri,Cmimi from pijetstok where Emri='DoubleForce'And Sasia>0";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Double Force";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }


            string sqlu = "Update pijetstok set Sasia=Sasia-'" + this.sasia.Text + "'WHERE Emri='DoubleForce'";

            try
            {
                db_connection();
                MySqlCommand cu = new MySqlCommand(sqlu, connect);
                cu.ExecuteNonQuery();
            }
            catch (Exception uuu)
            {

            }
        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {

            i = i + 1;
            string sql = "SELECT Emri,Cmimi from pijetstok where Emri='Pepsi'And Sasia>0";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Pepsi";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }
            
            
            string sqlu = "Update pijetstok set Sasia=Sasia-'" + this.sasia.Text + "'WHERE Emri='Pepsi'";

            try
            {
                db_connection();
                MySqlCommand cu = new MySqlCommand(sqlu, connect);
                cu.ExecuteNonQuery();
            }
            catch (Exception uuu)
            {

            }
        }

        private void bunifuImageButton18_Click(object sender, EventArgs e)
        {
            i = i + 1;
            string sql = "SELECT Emri,Cmimi from pijetstok where Emri='Shweps'And Sasia>0";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Shweps";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }


            string sqlu = "Update pijetstok set Sasia=Sasia-'" + this.sasia.Text + "'WHERE Emri='Shweps'";

            try
            {
                db_connection();
                MySqlCommand cu = new MySqlCommand(sqlu, connect);
                cu.ExecuteNonQuery();
            }
            catch (Exception uuu)
            {

            }
        }

        private void bunifuImageButton19_Click(object sender, EventArgs e)
        {
            i = i + 1;
            string sql = "SELECT Emri,Cmimi from pijetstok where Emri='Sola'And Sasia>0";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Sola";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }


            string sqlu = "Update pijetstok set Sasia=Sasia-'" + this.sasia.Text + "'WHERE Emri='Sola'";

            try
            {
                db_connection();
                MySqlCommand cu = new MySqlCommand(sqlu, connect);
                cu.ExecuteNonQuery();
            }
            catch (Exception uuu)
            {

            }
        }

        private void bunifuImageButton10_Click(object sender, EventArgs e)
        {
            i = i + 1;
            string sql = "SELECT Emri,Cmimi from pijetstok where Emri='RedBull'And Sasia>0";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "RedBull";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }


            string sqlu = "Update pijetstok set Sasia=Sasia-'" + this.sasia.Text + "'WHERE Emri='Pepsi'";

            try
            {
                db_connection();
                MySqlCommand cu = new MySqlCommand(sqlu, connect);
                cu.ExecuteNonQuery();
            }
            catch (Exception uuu)
            {

            }
        }

        private void bunifuImageButton15_Click(object sender, EventArgs e)
        {
            i = i + 1;
            string sql = "SELECT Emri,Cmimi from pijetstok where Emri='GoldenEagle'And Sasia>0";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Golden Eagle";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }


            string sqlu = "Update pijetstok set Sasia=Sasia-'" + this.sasia.Text + "'WHERE Emri='GoldenEagle'";

            try
            {
                db_connection();
                MySqlCommand cu = new MySqlCommand(sqlu, connect);
                cu.ExecuteNonQuery();
            }
            catch (Exception uuu)
            {

            }
        }

        private void bunifuImageButton20_Click(object sender, EventArgs e)
        {
            i = i + 1;
            string sql = "SELECT Emri,Cmimi from pijetstok where Emri='RedRain'And Sasia>0";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "RedRain";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }


            string sqlu = "Update pijetstok set Sasia=Sasia-'" + this.sasia.Text + "'WHERE Emri='RedRain'";

            try
            {
                db_connection();
                MySqlCommand cu = new MySqlCommand(sqlu, connect);
                cu.ExecuteNonQuery();
            }
            catch (Exception uuu)
            {

            }
        }

        private void bunifuImageButton50_Click(object sender, EventArgs e)
        {
            i = i + 1;
            string sql = "SELECT Emri,Cmimi from pijetstok where Emri='Relax'And Sasia>0";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Relax";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }


            string sqlu = "Update pijetstok set Sasia=Sasia-'" + this.sasia.Text + "'WHERE Emri='Relax'";

            try
            {
                db_connection();
                MySqlCommand cu = new MySqlCommand(sqlu, connect);
                cu.ExecuteNonQuery();
            }
            catch (Exception uuu)
            {

            }
        }

        private void bunifuImageButton16_Click(object sender, EventArgs e)
        {
            i = i + 1;
            string sql = "SELECT Emri,Cmimi from pijetstok where Emri='CocaColaShishe'And Sasia>0";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Coca Cola ";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }


            string sqlu = "Update pijetstok set Sasia=Sasia-'" + this.sasia.Text + "'WHERE Emri='CocaColaShishe'";

            try
            {
                db_connection();
                MySqlCommand cu = new MySqlCommand(sqlu, connect);
                cu.ExecuteNonQuery();
            }
            catch (Exception uuu)
            {

            }
        }

        private void bunifuImageButton17_Click(object sender, EventArgs e)
        {
            i = i + 1;
            string sql = "SELECT Emri,Cmimi from pijetstok where Emri='FantaShishe'And Sasia>0";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Fanta ";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }


            string sqlu = "Update pijetstok set Sasia=Sasia-'" + this.sasia.Text + "'WHERE Emri='FantaShishe'";

            try
            {
                db_connection();
                MySqlCommand cu = new MySqlCommand(sqlu, connect);
                cu.ExecuteNonQuery();
            }
            catch (Exception uuu)
            {

            }
        }

        private void bunifuImageButton21_Click(object sender, EventArgs e)
        {
            i = i + 1;
            string sql = "SELECT Emri,Cmimi from pijetstok where Emri='ShwepsShishe'And Sasia>0";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Shweps";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }


            string sqlu = "Update pijetstok set Sasia=Sasia-'" + this.sasia.Text + "'WHERE Emri='ShwepsShishe'";

            try
            {
                db_connection();
                MySqlCommand cu = new MySqlCommand(sqlu, connect);
                cu.ExecuteNonQuery();
            }
            catch (Exception uuu)
            {

            }
        }

        private void bunifuImageButton22_Click(object sender, EventArgs e)
        {
            i = i + 1;
            string sql = "SELECT Emri,Cmimi from pijetstok where Emri='SpriteShishe'And Sasia>0";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Sprite Shishe";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }


            string sqlu = "Update pijetstok set Sasia=Sasia-'" + this.sasia.Text + "'WHERE Emri='SpriteShishe'";

            try
            {
                db_connection();
                MySqlCommand cu = new MySqlCommand(sqlu, connect);
                cu.ExecuteNonQuery();
            }
            catch (Exception uuu)
            {

            }
        }

        private void bunifuImageButton31_Click(object sender, EventArgs e)
        {
            i = i + 1;
            string sql = "SELECT Emri,Cmimi from pijetstok where Emri='Laçin'And Sasia>0";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Laçin";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }


            string sqlu = "Update pijetstok set Sasia=Sasia-'" + this.sasia.Text + "'WHERE Emri='Laçin'";

            try
            {
                db_connection();
                MySqlCommand cu = new MySqlCommand(sqlu, connect);
                cu.ExecuteNonQuery();
            }
            catch (Exception uuu)
            {

            }
        }

        private void bunifuImageButton44_Click(object sender, EventArgs e)
        {
            i = i + 1;
            string sql = "SELECT Emri,Cmimi from pijetstok where Emri='Monster'And Sasia>0";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Monster";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }


            string sqlu = "Update pijetstok set Sasia=Sasia-'" + this.sasia.Text + "'WHERE Emri='Monster'";

            try
            {
                db_connection();
                MySqlCommand cu = new MySqlCommand(sqlu, connect);
                cu.ExecuteNonQuery();
            }
            catch (Exception uuu)
            {

            }
        }

        private void bunifuImageButton52_Click(object sender, EventArgs e)
        {
            i = i + 1;
            string sql = "SELECT Emri,Cmimi from pijetstok where Emri='UjëGazuar'And Sasia>0";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Ujë i Gazuar";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }


            string sqlu = "Update pijetstok set Sasia=Sasia-'" + this.sasia.Text + "'WHERE Emri='UjëGazuar'";

            try
            {
                db_connection();
                MySqlCommand cu = new MySqlCommand(sqlu, connect);
                cu.ExecuteNonQuery();
            }
            catch (Exception uuu)
            {

            }
        }

        private void bunifuImageButton23_Click(object sender, EventArgs e)
        {
            i = i + 1;
            string sql = "SELECT Emri,Cmimi from pijetstok where Emri='UjëThjeshtë'And Sasia>0";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Ujë i Thjeshtë";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }


            string sqlu = "Update pijetstok set Sasia=Sasia-'" + this.sasia.Text + "'WHERE Emri='UjëThjeshtë'";

            try
            {
                db_connection();
                MySqlCommand cu = new MySqlCommand(sqlu, connect);
                cu.ExecuteNonQuery();
            }
            catch (Exception uuu)
            {

            }
        }

        private void bunifuImageButton40_Click(object sender, EventArgs e)
        {
            i = i + 1;
            string sql = "SELECT Emri,Cmimi from pijetstok where Emri='Koktell'And Sasia>0";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Koktell";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }


            string sqlu = "Update pijetstok set Sasia=Sasia-'" + this.sasia.Text + "'WHERE Emri='Koktell'";

            try
            {
                db_connection();
                MySqlCommand cu = new MySqlCommand(sqlu, connect);
                cu.ExecuteNonQuery();
            }
            catch (Exception uuu)
            {

            }
        }

        private void bunifuImageButton51_Click(object sender, EventArgs e)
        {
            i = i + 1;
            string sql = "SELECT Emri,Cmimi from pijetstok where Emri='Fruktall'And Sasia>0";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Fruktall";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }


            string sqlu = "Update pijetstok set Sasia=Sasia-'" + this.sasia.Text + "'WHERE Emri='Fruktall'";

            try
            {
                db_connection();
                MySqlCommand cu = new MySqlCommand(sqlu, connect);
                cu.ExecuteNonQuery();
            }
            catch (Exception uuu)
            {

            }
        }

        private void bunifuImageButton25_Click(object sender, EventArgs e)
        {
            i = i + 1;
            string sql = "SELECT Emri,Cmimi from birratstok where Emri='BirraPeja'And Sasia>0";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Birra Peja";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }


            string sqlu = "Update birratstok set Sasia=Sasia-'" + this.sasia.Text + "'WHERE Emri='BirraPeja'";

            try
            {
                db_connection();
                MySqlCommand cu = new MySqlCommand(sqlu, connect);
                cu.ExecuteNonQuery();
            }
            catch (Exception uuu)
            {

            }
        }

        private void bunifuImageButton24_Click(object sender, EventArgs e)
        {
            i = i + 1;
            string sql = "SELECT Emri,Cmimi from birratstok where Emri='BirraTirana'And Sasia>0";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Birra Tirana";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }


            string sqlu = "Update birratstok set Sasia=Sasia-'" + this.sasia.Text + "'WHERE Emri='BirraTirana'";

            try
            {
                db_connection();
                MySqlCommand cu = new MySqlCommand(sqlu, connect);
                cu.ExecuteNonQuery();
            }
            catch (Exception uuu)
            {

            }
        }

        private void bunifuImageButton30_Click(object sender, EventArgs e)
        {
            i = i + 1;
            string sql = "SELECT Emri,Cmimi from birratstok where Emri='BirraLasko'And Sasia>0";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Birra Lasko";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }


            string sqlu = "Update birratstok set Sasia=Sasia-'" + this.sasia.Text + "'WHERE Emri='BirraLasko'";

            try
            {
                db_connection();
                MySqlCommand cu = new MySqlCommand(sqlu, connect);
                cu.ExecuteNonQuery();
            }
            catch (Exception uuu)
            {

            }
        }

        private void bunifuImageButton34_Click(object sender, EventArgs e)
        {
            i = i + 1;
            string sql = "SELECT Emri,Cmimi from birratstok where Emri='BirraMiller'And Sasia>0";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Birra Miller";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }


            string sqlu = "Update birratstok set Sasia=Sasia-'" + this.sasia.Text + "'WHERE Emri='BirraMiller'";

            try
            {
                db_connection();
                MySqlCommand cu = new MySqlCommand(sqlu, connect);
                cu.ExecuteNonQuery();
            }
            catch (Exception uuu)
            {

            }
        }

        private void bunifuImageButton56_Click(object sender, EventArgs e)
        {
            i = i + 1;
            string sql = "SELECT Emri,Cmimi from birratstok where Emri='BirraCarlsberg'And Sasia>0";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Birra Carlsberg";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }


            string sqlu = "Update birratstok set Sasia=Sasia-'" + this.sasia.Text + "'WHERE Emri='BirraCarlsberg'";

            try
            {
                db_connection();
                MySqlCommand cu = new MySqlCommand(sqlu, connect);
                cu.ExecuteNonQuery();
            }
            catch (Exception uuu)
            {

            }
        }

        private void bunifuImageButton35_Click(object sender, EventArgs e)
        {
            i = i + 1;
            string sql = "SELECT Emri,Cmimi from birratstok where Emri='BirraShkup'And Sasia>0";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Birra Shkup";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }


            string sqlu = "Update birratstok set Sasia=Sasia-'" + this.sasia.Text + "'WHERE Emri='BirraShkup'";

            try
            {
                db_connection();
                MySqlCommand cu = new MySqlCommand(sqlu, connect);
                cu.ExecuteNonQuery();
            }
            catch (Exception uuu)
            {

            }
        }

        private void bunifuImageButton38_Click(object sender, EventArgs e)
        {
            i = i + 1;
            string sql = "SELECT Emri,Cmimi from birratstok where Emri='BirraSomersby'And Sasia>0";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Birra Somersby";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }


            string sqlu = "Update birratstok set Sasia=Sasia-'" + this.sasia.Text + "'WHERE Emri='BirraSomersby'";

            try
            {
                db_connection();
                MySqlCommand cu = new MySqlCommand(sqlu, connect);
                cu.ExecuteNonQuery();
            }
            catch (Exception uuu)
            {

            }
        }

        private void bunifuImageButton39_Click(object sender, EventArgs e)
        {
            i = i + 1;
            string sql = "SELECT Emri,Cmimi from birratstok where Emri='BirraKorça'And Sasia>0";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Birra Korça";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);

                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }


            string sqlu = "Update birratstok set Sasia=Sasia-'" + this.sasia.Text + "'WHERE Emri='BirraKorça'";

            try
            {
                db_connection();
                MySqlCommand cu = new MySqlCommand(sqlu, connect);
                cu.ExecuteNonQuery();
            }
            catch (Exception uuu)
            {

            }
        }

        private void bunifuImageButton43_Click(object sender, EventArgs e)
        {
            i = i + 1;
            string sql = "SELECT Emri,Cmimi from birratstok where Emri='BirraPeroni'And Sasia>0";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Birra Peroni";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);

                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }


            string sqlu = "Update birratstok set Sasia=Sasia-'" + this.sasia.Text + "'WHERE Emri='BirraPeroni'";

            try
            {
                db_connection();
                MySqlCommand cu = new MySqlCommand(sqlu, connect);
                cu.ExecuteNonQuery();
            }
            catch (Exception uuu)
            {

            }
        }

        private void bunifuImageButton55_Click(object sender, EventArgs e)
        {
            i = i + 1;
            string sql = "SELECT Emri,Cmimi from birratstok where Emri='BirraElbar'And Sasia>0";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Birra Elbar";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);

                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }


            string sqlu = "Update birratstok set Sasia=Sasia-'" + this.sasia.Text + "'WHERE Emri='BirraElbar'";

            try
            {
                db_connection();
                MySqlCommand cu = new MySqlCommand(sqlu, connect);
                cu.ExecuteNonQuery();
            }
            catch (Exception uuu)
            {

            }
        }

        private void bunifuImageButton26_Click(object sender, EventArgs e)
        {
            i = i + 1;
            string sql = "SELECT Emri,Cmimi from birratstok where Emri='BirraPejaShishe'And Sasia>0";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Birra Peja";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);

                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }


            string sqlu = "Update birratstok set Sasia=Sasia-'" + this.sasia.Text + "'WHERE Emri='BirraPeja'";

            try
            {
                db_connection();
                MySqlCommand cu = new MySqlCommand(sqlu, connect);
                cu.ExecuteNonQuery();
            }
            catch (Exception uuu)
            {

            }
        }

        private void bunifuImageButton27_Click(object sender, EventArgs e)
        {
            i = i + 1;
            string sql = "SELECT Emri,Cmimi from birratstok where Emri='BirraPrishtinaShishe'And Sasia>0";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Birra Prishtina";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);

                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }


            string sqlu = "Update birratstok set Sasia=Sasia-'" + this.sasia.Text + "'WHERE Emri='BirraPrishtinaShishe'";

            try
            {
                db_connection();
                MySqlCommand cu = new MySqlCommand(sqlu, connect);
                cu.ExecuteNonQuery();
            }
            catch (Exception uuu)
            {

            }
        }

        private void bunifuImageButton32_Click(object sender, EventArgs e)
        {
            i = i + 1;
            string sql = "SELECT Emri,Cmimi from birratstok where Emri='BirraTuborgShishe'And Sasia>0";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Birra Tuborg";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);

                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }


            string sqlu = "Update birratstok set Sasia=Sasia-'" + this.sasia.Text + "'WHERE Emri='BirraTuborgShishe";

            try
            {
                db_connection();
                MySqlCommand cu = new MySqlCommand(sqlu, connect);
                cu.ExecuteNonQuery();
            }
            catch (Exception uuu)
            {

            }
        }

        private void bunifuImageButton33_Click(object sender, EventArgs e)
        {
            i = i + 1;
            string sql = "SELECT Emri,Cmimi from birratstok where Emri='BirraMillerShishe'And Sasia>0";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Birra Miller";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);

                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }


            string sqlu = "Update birratstok set Sasia=Sasia-'" + this.sasia.Text + "'WHERE Emri='BirraMillerShishe'";

            try
            {
                db_connection();
                MySqlCommand cu = new MySqlCommand(sqlu, connect);
                cu.ExecuteNonQuery();
            }
            catch (Exception uuu)
            {

            }
        }

        private void bunifuImageButton53_Click(object sender, EventArgs e)
        {
            i = i + 1;
            string sql = "SELECT Emri,Cmimi from birratstok where Emri='BirraNikshiq'And Sasia>0";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Birra Nikshiq";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);

                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }


            string sqlu = "Update birratstok set Sasia=Sasia-'" + this.sasia.Text + "'WHERE Emri='BirraNikshiq'";

            try
            {
                db_connection();
                MySqlCommand cu = new MySqlCommand(sqlu, connect);
                cu.ExecuteNonQuery();
            }
            catch (Exception uuu)
            {

            }
        }

        private void bunifuImageButton28_Click(object sender, EventArgs e)
        {
            i = i + 1;
            string sql = "SELECT Emri,Cmimi from birratstok where Emri='BirraHeinekenShishe'And Sasia>0";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Birra Heineken";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);

                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }


            string sqlu = "Update birratstok set Sasia=Sasia-'" + this.sasia.Text + "'WHERE Emri='BirraHeineken'";

            try
            {
                db_connection();
                MySqlCommand cu = new MySqlCommand(sqlu, connect);
                cu.ExecuteNonQuery();
            }
            catch (Exception uuu)
            {

            }
        }

        private void bunifuImageButton29_Click(object sender, EventArgs e)
        {
            i = i + 1;
            string sql = "SELECT Emri,Cmimi from birratstok where Emri='BirraCoronaShishe'And Sasia>0";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Birra Corona";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);

                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }


            string sqlu = "Update birratstok set Sasia=Sasia-'" + this.sasia.Text + "'WHERE Emri='BirraCoronaShishe'";

            try
            {
                db_connection();
                MySqlCommand cu = new MySqlCommand(sqlu, connect);
                cu.ExecuteNonQuery();
            }
            catch (Exception uuu)
            {

            }
        }

        private void bunifuImageButton36_Click(object sender, EventArgs e)
        {
            i = i + 1;
            string sql = "SELECT Emri,Cmimi from birratstok where Emri='BirraShkupShishe'And Sasia>0";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Birra Shkup";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);

                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }


            string sqlu = "Update birratstok set Sasia=Sasia-'" + this.sasia.Text + "'WHERE Emri='BirraShkupShishe'";

            try
            {
                db_connection();
                MySqlCommand cu = new MySqlCommand(sqlu, connect);
                cu.ExecuteNonQuery();
            }
            catch (Exception uuu)
            {

            }
        }

        private void bunifuImageButton37_Click(object sender, EventArgs e)
        {
            i = i + 1;
            string sql = "SELECT Emri,Cmimi from birratstok where Emri='BirraAmsteelShishe'And Sasia>0";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Birra Amsteel";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);

                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }


            string sqlu = "Update birratstok set Sasia=Sasia-'" + this.sasia.Text + "'WHERE Emri='BirraAmsteelShishe'";

            try
            {
                db_connection();
                MySqlCommand cu = new MySqlCommand(sqlu, connect);
                cu.ExecuteNonQuery();
            }
            catch (Exception uuu)
            {

            }
        }

        private void bunifuImageButton54_Click(object sender, EventArgs e)
        {
            i = i + 1;
            string sql = "SELECT Emri,Cmimi from birratstok where Emri='BirraPeroniShishe'And Sasia>0";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Birra Peroni";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);

                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }


            string sqlu = "Update birratstok set Sasia=Sasia-'" + this.sasia.Text + "'WHERE Emri='BirraPeroniShishe'";

            try
            {
                db_connection();
                MySqlCommand cu = new MySqlCommand(sqlu, connect);
                cu.ExecuteNonQuery();
            }
            catch (Exception uuu)
            {

            }
        }

        private void bunifuImageButton79_Click(object sender, EventArgs e)
        {
            i = i + 1;
            string sql = "SELECT Emri,Cmimi from picat where Emri='PicëShpisë'";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Picë e Shpisë";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }

          
            

              
               

           
        }

        private void bunifuImageButton77_Click(object sender, EventArgs e)
        {
            i = i + 1;
            string sql = "SELECT Emri,Cmimi from picat where Emri='PicëNapolitane'";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Picë Napolitane";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }

          
            

              
               

        }

        private void bunifuImageButton82_Click(object sender, EventArgs e)
        {
            i = i + 1;
            string sql = "SELECT Emri,Cmimi from picat where Emri='PicëVieneze'";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Picë Vieneze";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }

        }

        private void bunifuImageButton80_Click(object sender, EventArgs e)
        {
            i = i + 1;
            string sql = "SELECT Emri,Cmimi from picat where Emri='PicëMargarita'";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Picë Margarita";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }

        }

        private void bunifuImageButton81_Click(object sender, EventArgs e)
        {
            i = i + 1;
            string sql = "SELECT Emri,Cmimi from picat where Emri='PicëGreke'";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Picë Greke";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }

        }

        private void bunifuImageButton83_Click(object sender, EventArgs e)
        {
            i = i + 1;
            string sql = "SELECT Emri,Cmimi from picat where Emri='PicëBardhe'";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Picë e Bardhe";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }

        }

        private void bunifuImageButton85_Click(object sender, EventArgs e)
        {
            i = i + 1;
            string sql = "SELECT Emri,Cmimi from picat where Emri='Picë4Stinet'";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Picë 4Stinet";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }

        }

        private void bunifuImageButton84_Click(object sender, EventArgs e)
        {
            i = i + 1;
            string sql = "SELECT Emri,Cmimi from picat where Emri='PicëPrimavera'";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Picë Primavera";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }

        }

        private void bunifuImageButton78_Click(object sender, EventArgs e)
        {
            i = i + 1;
            string sql = "SELECT Emri,Cmimi from picat where Emri='PicëSiciliane'";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Picë Siciliane";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }

        }

        private void bunifuImageButton42_Click(object sender, EventArgs e)
        {
            i = i + 1;
            string sql = "SELECT Emri,Cmimi from pijetstok where Emri='Juice'AND Sasia>0";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Juice";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }
            string sqlu = "Update pijetstok set Sasia=Sasia-'" + this.sasia.Text + "'WHERE Emri='Juice'";

            try
            {
                db_connection();
                MySqlCommand cu = new MySqlCommand(sqlu, connect);
                cu.ExecuteNonQuery();
            }
            catch (Exception uuu)
            {

            }
        }

        private void bunifuImageButton41_Click(object sender, EventArgs e)
        {
            i = i + 1;
            string sql = "SELECT Emri,Cmimi from pijetstok where Emri='IceTea'AND Sasia>0";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Ice Tea";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }
            string sqlu = "Update pijetstok set Sasia=Sasia-'" + this.sasia.Text + "'WHERE Emri='IceTea'";

            try
            {
                db_connection();
                MySqlCommand cu = new MySqlCommand(sqlu, connect);
                cu.ExecuteNonQuery();
            }
            catch (Exception uuu)
            {

            }
        }

        private void bunifuImageButton69_Click(object sender, EventArgs e)
        {
            i = i + 1;
            string sql = "SELECT Emri,Cmimi from alkool where Emri='RakiShpisë'";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Raki e Shpisë";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }

          
            

              
               
        }

        private void bunifuImageButton59_Click(object sender, EventArgs e)
        {
            i = i + 1;
            string sql = "SELECT Emri,Cmimi from alkool where Emri='Malibu'";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Malibu";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }

        }

        private void bunifuImageButton60_Click(object sender, EventArgs e)
        {
            i = i + 1;
            string sql = "SELECT Emri,Cmimi from alkool where Emri='Badell'";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Badell";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }
        }

        private void bunifuImageButton68_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Emri,Cmimi from alkool where Emri='Tekilla'";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Tekilla";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }
        }

        private void bunifuImageButton64_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Emri,Cmimi from alkool where Emri='VodkeKuqe'";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Vodkë e Kuqe";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }
        }

        private void bunifuImageButton63_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Emri,Cmimi from alkool where Emri='SmirnoffVodka'";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Smirnoff Vodka";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }
        }

        private void bunifuImageButton61_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Emri,Cmimi from alkool where Emri='GrejGus'";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Grey Goose";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }
        }

        private void bunifuImageButton62_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Emri,Cmimi from alkool where Emri='SmirnoffIce'";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Smirnoff Ice";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }
        }

        private void bunifuImageButton65_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Emri,Cmimi from alkool where Emri='DomPerijon'";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Dom Perijon";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }
        }

        private void bunifuImageButton66_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Emri,Cmimi from alkool where Emri='Vinë'";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Vinë";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }
        }

        private void bunifuImageButton58_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Emri,Cmimi from alkool where Emri='Martini'";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Martini";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }
        }

        private void bunifuImageButton72_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Emri,Cmimi from alkool where Emri='B52'";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "B52";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }
        }

        private void bunifuImageButton70_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Emri,Cmimi from alkool where Emri='Koktell'";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Koktell";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }
        }

        private void bunifuImageButton74_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Emri,Cmimi from alkool where Emri='JackDanielsMjaltë'";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Jack Daniels Mjaltë";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }
        }

        private void bunifuImageButton75_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Emri,Cmimi from alkool where Emri='JackDaniels'";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Jack Daniels";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }
        }

        private void bunifuImageButton73_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Emri,Cmimi from alkool where Emri='Beiles'";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Baileys";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }
        }

        private void bunifuImageButton67_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Emri,Cmimi from alkool where Emri='Shampanjë'";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Shampanjë";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }
        }

        private void bunifuImageButton57_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Emri,Cmimi from alkool where Emri='Jeger'";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Jeger";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }
        }

        private void bunifuImageButton71_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Emri,Cmimi from alkool where Emri='Sambuk'";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Sambuca";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }
        }

        private void bunifuImageButton76_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Emri,Cmimi from alkool where Emri='GjoniWoker'";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "John Walker";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }
        }

        private void bunifuImageButton87_Click_1(object sender, EventArgs e)
        {
            string sql = "SELECT Emri,Cmimi from ushqimet where Emri='HamburgerKlasik'";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Hamburger Klasik";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }

        }

        private void bunifuImageButton88_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Emri,Cmimi from ushqimet where Emri='HamburgerBardhë'";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Hamburger i Bardhë";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }

        }

        private void bunifuImageButton89_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Emri,Cmimi from ushqimet where Emri='Sandwich'";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Sandwich";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }

        }

        private void bunifuImageButton90_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Emri,Cmimi from ushqimet where Emri='Qebapa'";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Qebapa";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }

        }

        private void bunifuImageButton91_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Emri,Cmimi from ushqimet where Emri='HotDog'";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Hot Dog";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }

        }

        private void bunifuImageButton92_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Emri,Cmimi from ushqimet where Emri='Tost'";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Tost";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }

        }

        private void bunifuImageButton93_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Emri,Cmimi from ushqimet where Emri='Sugjukë'";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Sugjukë";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }

        }

        private void bunifuImageButton94_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Emri,Cmimi from ushqimet where Emri='BurekMish'";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Burek me Mish";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }

        }

        private void bunifuImageButton96_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Emri,Cmimi from ushqimet where Emri='BurekDjathë'";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Burek me Djathë";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }

        }

        private void bunifuImageButton95_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Emri,Cmimi from ushqimet where Emri='Pulë'";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Pulë";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }

        }

        private void bunifuImageButton98_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Emri,Cmimi from ushqimet where Emri='SallatëShope'";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Sallatë Shope";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }

        }

        private void bunifuImageButton97_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Emri,Cmimi from ushqimet where Emri='Djathë'";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Djathë";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }

        }

        private void bunifuImageButton99_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Emri,Cmimi from embelsira where Emri='Trileqe'";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Trileqe";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }
        }

        private void bunifuImageButton100_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Emri,Cmimi from embelsira where Emri='Akullore'";

            string emri;
            double cmimi;
            ListViewItem lv = new ListViewItem();
            emri = "Akullore";
            double llog;
            string sm;
            try
            {

                db_connection();
                MySqlCommand es = new MySqlCommand(sql, connect);
                MySqlDataReader rd = es.ExecuteReader();

                while (rd.Read())
                {
                    cmimi = Convert.ToDouble(rd["Cmimi"]);
                    llog = Convert.ToDouble(sasia.Text) * cmimi;

                    lv.SubItems.Add(emri);
                    lv.SubItems.Add(sasia.Text);
                    lv.SubItems.Add(cmimi.ToString());
                    lv.SubItems.Add(llog.ToString());

                    lista.Items.Add(lv);
                }


            }

            catch (Exception iu)
            {

            }
        }
    }
}

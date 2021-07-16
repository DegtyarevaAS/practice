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

namespace Practice
{
    public partial class FormAutho : Form
    {
        public FormAutho()
        {
            InitializeComponent();
        }

        public void btnCancel_Click(object sender, EventArgs e)
        {
            //this.Close();
            this.Hide();
            FormStart fm4 = new FormStart();
            fm4.Show();
        }

        private void btnAutho_Click(object sender, EventArgs e)
        {
            //try
            var conn = DbHelper.GetConn();
            string query = "SELECT idUsers FROM `users` WHERE login = @lg AND password = @pass";

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.Add("@lg", MySqlDbType.VarChar).Value = txtLogin.Text;
                cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = GenHesh.CalculateMD5Hash(txtPassword.Text);

                cmd.ExecuteNonQuery();
                int id = 0;
                id = Convert.ToInt32(cmd.ExecuteScalar());
                if (id == 0)
                {
                    MessageBox.Show("Данные введены неверно");
                    this.Close();
                    return;
                }
                this.Hide();
                //  Form1 form1 = new Form1(id);
                // form1.Show();
                // form1.FormClosed += this.FormAutho_FormClosed;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Нет соединения с БД\n\r" + ex.ToString());

            }
            finally
            {
                conn.Close();
            }

        }
        private void FormAutho_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        public void formClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void FormAutho_Load(object sender, EventArgs e)
        {

        }
    }
}





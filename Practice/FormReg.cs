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
    public partial class FormReg : Form
    {
        public FormReg()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var conn = DbHelper.GetConn();

            string query = "INSERT INTO `users`" +
              "(`lastName`,`firstName`,`middleName`,`login`,`password`,`date`, `topic`, `gr`) " +
              "VALUES(@ln, @fn, @mn, @log, @pas, @date, @topic, @gr)";
         
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.Add("@ln", MySqlDbType.VarChar).Value = txtName1.Text;
                cmd.Parameters.Add("@fn", MySqlDbType.VarChar).Value = txtName2.Text;
                cmd.Parameters.Add("@mn", MySqlDbType.VarChar).Value = txtName3.Text;
                cmd.Parameters.Add("@log", MySqlDbType.VarChar).Value = txtLogin.Text;
                cmd.Parameters.Add("@pas", MySqlDbType.VarChar).Value = GenHesh.CalculateMD5Hash(txtPassword.Text);
                cmd.Parameters.Add("@date", MySqlDbType.VarChar).Value = " 2000.10.12";
                cmd.Parameters.Add("@topic", MySqlDbType.VarChar).Value = "''";
                cmd.Parameters.Add("@gr", MySqlDbType.VarChar).Value = "''";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Пользователь зарегестрирован");
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
    }
}

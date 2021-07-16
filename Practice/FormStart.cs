using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice
{
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormReg formReg = new FormReg();
            formReg.Show();
            formReg.FormClosed += this.formClosed;
        }
		
        private void formClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAutho formAutho= new FormAutho();
            formAutho.Show();
            formAutho.FormClosed += this.formClosed;
            
        }

       
        private void FormStart_Shown(object sender, EventArgs e)
        {
            Task.Delay(0).ContinueWith(CheckConnection);
        }

        private void CheckConnection(Task obj)
        {
            var conn = DbHelper.GetConn();
            try

            {
                conn.Open();
                this.status1.Text = "Соединение установлено";
            }
            catch (Exception ex)
            {
                this.status1.Text = "Нет соединения";
                MessageBox.Show("Нет соединения c БД\n\r" + ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

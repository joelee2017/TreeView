using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using 李崇維_HW.Properties;
using System.Security.Cryptography;

namespace 李崇維_HW
{
    public partial class LogOn : Form
    {
        public LogOn()
        {
            InitializeComponent();
        }
        //新增會員，含MD5CryptoServiceProvider雜湊
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connString = Settings.Default.NorthwindConnectionString;
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = connString;
                    conn.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        string UserName = this.UsernameTextBox.Text;
                        string Password = this.PasswordTextBox.Text;

                        
                        MD5CryptoServiceProvider md5Hasher = new MD5CryptoServiceProvider();
                        byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(Password));
                        StringBuilder sBuilder = new StringBuilder();
                        for (int i = 0; i < data.Length; i++)
                        {
                            sBuilder.Append(data[i].ToString("x2"));                        }

                        command.CommandText =
                            "Insert into Member (UserName, Password) values ('" + UserName + "','" + sBuilder + "')";



                        command.Connection = conn;
                        command.ExecuteNonQuery();
                        MessageBox.Show("財神上門，歡迎老闆!!");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            UsernameTextBox.Text = "";
            PasswordTextBox.Text = "";
        }
        //會員登入
        private void OK_Click(object sender, EventArgs e)
        {
            try
            {
                string connString = Settings.Default.NorthwindConnectionString;
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = connString;
                    conn.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        string UserName = this.UsernameTextBox.Text;
                        string Password = this.PasswordTextBox.Text;

                        command.CommandText =
                            "select * from Member where UserName='"+UserName+"' and Password='"+Password+"'";
                        command.Connection = conn;

                        //MessageBox.Show(command.CommandText);
                        SqlDataReader dataReader = command.ExecuteReader();

                        if(dataReader.HasRows)
                        {
                            MessageBox.Show("Ok的!!");
                            Main f = new Main();
                            //f.TopLevel = false;
                            f.Show();
                        }
                        else
                        {
                            MessageBox.Show("該吃銀杏囉!!");
                        }
                       
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

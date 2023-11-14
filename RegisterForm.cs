using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMIApp
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection("Data Source=HAFIDH\\SQLEXPRESS01;Initial Catalog=BMIApp;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[Register]\r\n           " +
                "([Name]\r\n           ,[Username]\r\n," +
                "[Password])\r\n" +
                "VALUES\r\n " +
                "('"+txtNameRegister.Text+"',>\r\n ," +
                "<'"+txtUsernameRegis+"',>\r\n," +
                "<'"+txtPasswordRegis+"',>)");
            connect.Open();
            cmd.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Register Succesfully");
        }
    }
}

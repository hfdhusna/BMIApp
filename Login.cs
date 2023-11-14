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
namespace BMIApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source=HAFIDH\\SQLEXPRESS01;Initial Catalog=BMIApp;Integrated Security=True");

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username, password;

            username = txtUsernameLogin.Text;
            password = txtPassLogin.Text;

            try
            {
                String querry = "SELECT * FROM Login WHERE username = '" + txtUsernameLogin.Text + "' AND password = '" + txtPassLogin.Text + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(querry, connect);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if(dtable.Rows.Count > 0)
                {
                    username = txtUsernameLogin.Text;
                    password = txtPassLogin.Text;

                    //showing the dashboard
                    DataInputForm form2 =  new DataInputForm();
                    form2.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsernameLogin.Clear();
                    txtPassLogin.Clear();

                    txtUsernameLogin.Focus();
                }
            }
            catch 
            {
                MessageBox.Show("Error");
            }
            finally
            {
                connect.Close();    
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm Registerform = new RegisterForm();
            Hide();
            Registerform.ShowDialog();
        }
    }
}

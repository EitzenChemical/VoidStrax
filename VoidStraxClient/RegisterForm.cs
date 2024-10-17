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

namespace VoidStrax
{
    public partial class RegisterForm : Form
    {
        private SqlConnection _connection;

        public RegisterForm()
        {
            InitializeComponent();
            _connection = new SqlConnection("Server=localhost;Database=InsuranceDB;Integrated Security=True;");
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            string query = "INSERT INTO Clients (FullName, Email, PasswordHash) VALUES (@FullName, @Email, @Password)";
            using (SqlCommand command = new SqlCommand(query, _connection))
            {
                command.Parameters.AddWithValue("@FullName", fullName);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);

                _connection.Open();
                command.ExecuteNonQuery();
                _connection.Close();

                MessageBox.Show("Регистрация успешна. Теперь вы можете войти.");
                this.Close();
            }
        }
    }
}

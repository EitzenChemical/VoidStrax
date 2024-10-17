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

namespace VoidStraxEmployee
{
    public partial class EmployeeLoginForm : Form
    {
        private SqlConnection _connection;

        public EmployeeLoginForm()
        {
            InitializeComponent();
            _connection = new SqlConnection("Server=localhost;Database=InsuranceDB;Integrated Security=True;");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            string query = "SELECT EmployeeID FROM Employees WHERE Email = @Email AND PasswordHash = @Password";
            using (SqlCommand command = new SqlCommand(query, _connection))
            {
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);

                _connection.Open();
                var result = command.ExecuteScalar();
                _connection.Close();

                if (result != null)
                {
                    int employeeId = (int)result;
                    EmployeeMainForm employeeForm = new EmployeeMainForm(employeeId);
                    employeeForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Неверный email или пароль.");
                }
            }
        }
    }
}

using MetroFramework.Forms;
using System.Data.SqlClient;

namespace VoidStraxAdmin
{
    public partial class AdminForm : Form
    {
        private SqlConnection _connection;

        public AdminForm()
        {
            InitializeComponent();
            _connection = new SqlConnection("Server=localhost;Database=InsuranceDB;Integrated Security=True;");
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            cmbEmployees.Items.Clear();

            string query = "SELECT EmployeeID, FullName FROM Employees";
            using (SqlCommand command = new SqlCommand(query, _connection))
            {
                _connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cmbEmployees.Items.Add(new ComboBoxItem { Text = reader["FullName"].ToString(), Value = (int)reader["EmployeeID"] });
                }
                _connection.Close();
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            string employeeName = txtEmployeeName.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            string query = "INSERT INTO Employees (FullName, Email, PasswordHash) VALUES (@Name, @Email, @Password)";
            using (SqlCommand command = new SqlCommand(query, _connection))
            {
                command.Parameters.AddWithValue("@Name", employeeName);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);

                _connection.Open();
                command.ExecuteNonQuery();
                _connection.Close();

                MessageBox.Show("Сотрудник успешно добавлен.");
                LoadEmployees();
            }
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (cmbEmployees.SelectedItem != null)
            {
                var selectedEmployee = (ComboBoxItem)cmbEmployees.SelectedItem;

                string query = "DELETE FROM Employees WHERE EmployeeID = @EmployeeID";
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@EmployeeID", selectedEmployee.Value);

                    _connection.Open();
                    command.ExecuteNonQuery();
                    _connection.Close();

                    MessageBox.Show("Сотрудник удалён.");
                    LoadEmployees();
                }
            }
            else
            {
                MessageBox.Show("Выберите сотрудника для удаления.");
            }
        }
    }

    // Вспомогательный класс для отображения сотрудников в ComboBox
    public class ComboBoxItem
    {
        public string Text { get; set; }
        public int Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}

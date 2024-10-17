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
    public partial class EmployeeMainForm : Form
    {
        private SqlConnection _connection;
        private int _employeeId;

        public EmployeeMainForm(int employeeId)
        {
            InitializeComponent();
            _employeeId = employeeId;
            _connection = new SqlConnection("Server=localhost;Database=InsuranceDB;Integrated Security=True;");
            LoadServices();
            LoadClientRequests();
        }

        private void LoadServices()
        {
            lstServices.Items.Clear();
            string query = "SELECT * FROM Services";
            using (SqlCommand command = new SqlCommand(query, _connection))
            {
                _connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    lstServices.Items.Add($"{reader["ServiceName"]}: {reader["ServiceDescription"]}");
                }
                _connection.Close();
            }
        }

        private void LoadClientRequests()
        {
            lstClientRequests.Items.Clear();
            string query = "SELECT RequestID, ClientID, ServiceName, Status FROM InsuranceRequests INNER JOIN Services ON InsuranceRequests.ServiceID = Services.ServiceID";
            using (SqlCommand command = new SqlCommand(query, _connection))
            {
                _connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    lstClientRequests.Items.Add($"Заявка #{reader["RequestID"]}: Клиент {reader["ClientID"]}, Услуга: {reader["ServiceName"]}, Статус: {reader["Status"]}");
                }
                _connection.Close();
            }
        }

        private void btnChangeStatus_Click(object sender, EventArgs e)
        {
            if (lstClientRequests.SelectedItem != null)
            {
                string selectedRequest = lstClientRequests.SelectedItem.ToString();
                int requestId = int.Parse(selectedRequest.Split('#')[1].Split(':')[0]);

                string newStatus = cmbStatus?.SelectedItem?.ToString() ?? "На рассмотрении";
                string query = "UPDATE InsuranceRequests SET Status = @Status WHERE RequestID = @RequestID";
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@Status", newStatus);
                    command.Parameters.AddWithValue("@RequestID", requestId);

                    _connection.Open();
                    command.ExecuteNonQuery();
                    _connection.Close();

                    MessageBox.Show("Статус заявки обновлен.");
                    LoadClientRequests();
                }
            }
            else
            {
                MessageBox.Show("Выберите заявку для изменения статуса.");
            }
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            string serviceName = txtServiceName.Text;
            string description = txtServiceDescription.Text;

            string query = "INSERT INTO Services (ServiceName, ServiceDescription) VALUES (@ServiceName, @Description)";
            using (SqlCommand command = new SqlCommand(query, _connection))
            {
                command.Parameters.AddWithValue("@ServiceName", serviceName);
                command.Parameters.AddWithValue("@Description", description);

                _connection.Open();
                command.ExecuteNonQuery();
                _connection.Close();

                MessageBox.Show("Новая услуга добавлена.");
                LoadServices();
            }
        }

        private void btnDeleteService_Click(object sender, EventArgs e)
        {
            if (lstServices.SelectedItem != null)
            {
                string selectedService = lstServices.SelectedItem.ToString();
                string serviceName = selectedService.Split(':')[0];

                string query = "DELETE FROM Services WHERE ServiceName = @ServiceName";
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@ServiceName", serviceName);

                    _connection.Open();
                    command.ExecuteNonQuery();
                    _connection.Close();

                    MessageBox.Show("Услуга удалена.");
                    LoadServices();
                }
            }
            else
            {
                MessageBox.Show("Выберите услугу для удаления.");
            }
        }
    }
}

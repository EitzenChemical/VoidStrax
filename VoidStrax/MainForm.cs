using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using VoidStrax;
using VoidStrax.Properties;

namespace InsuranceApp
{
    public partial class MainForm : Form
    {
        private SqlConnection _connection;
        private int _clientId;

        public MainForm(int clientId)
        {
            InitializeComponent();
            _clientId = clientId;
            _connection = new SqlConnection("Server=localhost;Database=InsuranceDB;Integrated Security=True;");
            LoadClientRequests();
            LoadServices();
        }

        private void LoadServices()
        {
            cmbServices.Items.Clear();
            string query = "SELECT * FROM Services";
            using (SqlCommand command = new SqlCommand(query, _connection))
            {
                _connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cmbServices.Items.Add(reader["ServiceName"]);
                }
                _connection.Close();
            }
        }

        private void LoadClientRequests()
        {
            lstRequests.Items.Clear();
            string query = "SELECT RequestID, ServiceName, Status FROM InsuranceRequests as a INNER JOIN Services as b ON a.ServiceID = b.ServiceID WHERE ClientID = @ClientID";
            using (SqlCommand command = new SqlCommand(query, _connection))
            {
                command.Parameters.AddWithValue("@ClientID", _clientId);
                _connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    lstRequests.Items.Add($"Заявка #{reader["RequestID"]}: Услуга: {reader["ServiceName"]}, Статус: {reader["Status"]}");
                }
                _connection.Close();
            }
        }

        private void btnSubmitRequest_Click(object sender, EventArgs e)
        {
            if (cmbServices.SelectedItem != null)
            {
                string serviceName = cmbServices.SelectedItem.ToString();
                string query = "INSERT INTO InsuranceRequests (ClientID, ServiceID, Status) " +
                               "VALUES (@ClientID, (SELECT ServiceID FROM Services WHERE ServiceName = @ServiceName), 'На рассмотрении')";
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@ClientID", _clientId);
                    command.Parameters.AddWithValue("@ServiceName", serviceName);

                    _connection.Open();
                    command.ExecuteNonQuery();
                    _connection.Close();

                    MessageBox.Show("Заявка отправлена.");
                    LoadClientRequests();
                }
            }
            else
            {
                MessageBox.Show("Выберите услугу.");
            }
        }

        private void btnCancelRequest_Click(object sender, EventArgs e)
        {
            if (lstRequests.SelectedItem != null)
            {
                string selectedRequest = lstRequests.SelectedItem.ToString();
                int requestId = int.Parse(selectedRequest.Split('#')[1].Split(':')[0]);

                string query = "DELETE FROM InsuranceRequests WHERE RequestID = @RequestID";
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@RequestID", requestId);

                    _connection.Open();
                    command.ExecuteNonQuery();
                    _connection.Close();

                    MessageBox.Show("Заявка отменена.");
                    LoadClientRequests();
                }
            }
            else
            {
                MessageBox.Show("Выберите заявку для отмены.");
            }
        }
    }
}
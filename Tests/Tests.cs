using Microsoft.VisualStudio.TestPlatform.ObjectModel.DataCollection;
using System.Data.Common;
using System.Data.SqlClient;

namespace Tests
{
    public class Tests
    {
        private SqlConnection _connection = new SqlConnection("Server=localhost;Database=InsuranceDB;Integrated Security=True;");

        [Fact]
        public void Empty_Fields_Employee_Adding_Test()
        {
            Assert.ThrowsAny<Exception>(() => {
                string query = "INSERT INTO Employees (FullName, Email, PasswordHash) VALUES (@Name, @Email, @Password)";
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@Name", "");
                    command.Parameters.AddWithValue("@Email", "");
                    command.Parameters.AddWithValue("@Password", "");

                    try
                    {
                        _connection.Open();
                        command.ExecuteNonQuery();
                        _connection.Close();
                    }
                    finally { _connection.Close(); }
                }
            });
        }

        [Fact]
        public void Empty_Pwd_Employee_Adding_Test()
        {
            Assert.ThrowsAny<Exception>(() => {
                string query = "INSERT INTO Employees (FullName, Email, PasswordHash) VALUES (@Name, @Email, @Password)";
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@Name", "qwe");
                    command.Parameters.AddWithValue("@Email", "qwe");
                    command.Parameters.AddWithValue("@Password", "");

                    try
                    {
                        _connection.Open();
                        command.ExecuteNonQuery();
                        _connection.Close();
                    }
                    finally { _connection.Close(); }
                }
            });
        }

        [Fact]
        public void Empty_Pwd_Client_Adding_Test()
        {
            Assert.ThrowsAny<Exception>(() => {
                string query = "INSERT INTO Clients (FullName, Email, PasswordHash) VALUES (@FullName, @Email, @Password)";
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@FullName", "qwe");
                    command.Parameters.AddWithValue("@Email", "qwe");
                    command.Parameters.AddWithValue("@Password", "");

                    try
                    {
                        _connection.Open();
                        command.ExecuteNonQuery();
                        _connection.Close();
                    }
                    finally { _connection.Close(); }
                }
            });
        }

        [Fact]
        public void Empty_Login_Client_Adding_Test()
        {
            Assert.ThrowsAny<Exception>(() => {
                string query = "INSERT INTO Clients (FullName, Email, PasswordHash) VALUES (@FullName, @Email, @Password)";
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@FullName", "");
                    command.Parameters.AddWithValue("@Email", "qwe");
                    command.Parameters.AddWithValue("@Password", "qwe");

                    try
                    {
                        _connection.Open();
                        command.ExecuteNonQuery();
                        _connection.Close();
                    }
                    finally { _connection.Close(); }
                }
            });
        }

        [Fact]
        public void Empty_Fields_Client_Adding_Test()
        {
            Assert.ThrowsAny<Exception>(() => {
                string query = "INSERT INTO Clients (FullName, Email, PasswordHash) VALUES (@FullName, @Email, @Password)";
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@FullName", "");
                    command.Parameters.AddWithValue("@Email", "");
                    command.Parameters.AddWithValue("@Password", "");

                    try
                    {
                        _connection.Open();
                        command.ExecuteNonQuery();
                        _connection.Close();
                    }
                    finally { _connection.Close(); }
                }
            });
        }

        [Fact]
        public void Duplicate_Client_Adding_Test()
        {
            Assert.ThrowsAny<Exception>(() => {
                string query = "INSERT INTO Clients (FullName, Email, PasswordHash) VALUES (test, test, test)";
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    try
                    {
                        _connection.Open();
                        command.ExecuteNonQuery();
                        _connection.Close();
                    }
                    finally { _connection.Close(); }
                }
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    try
                    {
                        _connection.Open();
                        command.ExecuteNonQuery();
                        _connection.Close();
                    }
                    finally { _connection.Close(); }
                }
            });
        }

        [Fact]
        public void Duplicate_Employee_Adding_Test()
        {
            Assert.ThrowsAny<Exception>(() => {
                string query = "INSERT INTO Employees (FullName, Email, PasswordHash) VALUES (test, test, test)";
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    try
                    {
                        _connection.Open();
                        command.ExecuteNonQuery();
                        _connection.Close();
                    }
                    finally { _connection.Close(); }
                }
            });
        }

        [Fact]
        public void Null_Id_Status_Setting_Test()
        {
            Assert.ThrowsAny<Exception>(() => {
                string query = "UPDATE InsuranceRequests SET Status = @Status WHERE RequestID = @RequestID";
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@Status", "test");
                    command.Parameters.AddWithValue("@RequestID", null);

                    try
                    {
                        _connection.Open();
                        command.ExecuteNonQuery();
                        _connection.Close();
                    }
                    finally { _connection.Close(); }
                }
            });
        }

        [Fact]
        public void Null_Status_Setting_Test()
        {
            Assert.ThrowsAny<Exception>(() => {
                string query = "UPDATE InsuranceRequests SET Status = @Status WHERE RequestID = @RequestID";
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@Status", null);
                    command.Parameters.AddWithValue("@RequestID", "1");

                    try
                    {
                        _connection.Open();
                        command.ExecuteNonQuery();
                        _connection.Close();
                    }
                    finally { _connection.Close(); }
                }
            });
        }

        [Fact]
        public void Null_Fields_Status_Setting_Test()
        {
            Assert.ThrowsAny<Exception>(() => {
                string query = "UPDATE InsuranceRequests SET Status = @Status WHERE RequestID = @RequestID";
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@Status", null);
                    command.Parameters.AddWithValue("@RequestID", null);

                    try
                    {
                        _connection.Open();
                        command.ExecuteNonQuery();
                        _connection.Close();
                    }
                    finally { _connection.Close(); }
                }
            });
        }
    }
}
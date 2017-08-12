using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FinalCrypt.DB
{
    class DBOperations
    {
        public static string Domain = "gaming.tstc.edu";
        public static string DBName = "dgateleyCSFInal";
        public static string Username = "dgateley";
        public static string Password = "1616190";
        public static string ConnectionString = "server=gaming.tstc.edu;database=" + DBName + ";user id = " + Username + "; password=" + Password + ";";

        static SqlConnection connection;

        /// <summary>
        /// Create the SQL Connection using default parameters
        /// </summary>
        public static void CreateConnection()
        {
            connection = new SqlConnection(ConnectionString);

            // Test connection
            try
            {
                connection.Open();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Attempts to log into the server
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool AttemptLogin(string username, string password)
        {
            bool ret = false;
            SqlDataReader dataReader;
            string query = "SELECT Username, Pass FROM Users WHERE Username = @username AND Pass = @password;";

            try
            {
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.AddWithValue("@username", username);
                sqlCommand.Parameters.AddWithValue("@password", password);

                connection.Open();
                dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    ret = true;
                    DBUserInformation.Username = username;
                }
                else
                {
                    ret = false;
                }
                dataReader.Close();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.ToString());
            }
            finally
            {
                connection.Close();
            }

            return ret;
        }

        /// <summary>
        /// Attempts to register the user, fails if the account exists.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool AttemptRegister(string username, string password)
        {
            bool exists = AttemptLogin(username, password);
            string query = "INSERT INTO Users VALUES (@password, @username);";
            bool ret = false;

            if (exists)
            {
                System.Windows.Forms.MessageBox.Show("Username taken.");
                return ret;
            }
            else
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand(query, connection);
                    sqlCommand.Parameters.AddWithValue("@username", username);
                    sqlCommand.Parameters.AddWithValue("@password", password);

                    connection.Open();

                    sqlCommand.ExecuteNonQuery();
                    ret = true;
                }
                catch (Exception e)
                {
                    System.Windows.Forms.MessageBox.Show(e.ToString());
                }
                finally
                {
                    connection.Close();
                }
            }

            return ret;
        }
    } 
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using FinalCrypt.Crypto;

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
        /// <returns>Returns true on success</returns>
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

                    GetUserInformation(username);
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

        /// <summary>
        /// Populates user information
        /// </summary>
        public static void GetUserInformation(string username)
        {
            string query = "Select * FROM Users WHERE Username = @username";
            DataTable dt = new DataTable();

            try
            {
                connection.Close();
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.AddWithValue("@username", username);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                connection.Open();

                sqlDataAdapter.Fill(dt);

                foreach (DataRow item in dt.Rows)
                {
                    DBUserInformation.Username = username;
                    DBUserInformation.UserID = item.Field<int>("ID");
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Problem retrieving info for user: " + DBUserInformation.Username);
                System.Windows.Forms.MessageBox.Show(e.ToString());
            }
            finally
            {
                connection.Close();
            }
        }


        /// <summary>
        /// Changes the current user's username
        /// </summary>
        /// <param name="username">The new username</param>
        public static void ChangeUsername(string username)
        {
            string query = "UPDATE Users SET Username = @username WHERE ID = @userID;";

            try
            {
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.AddWithValue("@username", username);
                sqlCommand.Parameters.AddWithValue("@userID", DBUserInformation.UserID);

                connection.Open();

                sqlCommand.ExecuteNonQuery();

                DBUserInformation.Username = username;
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
        /// Changes the current user's password
        /// </summary>
        /// <param name="username">The new username</param>
        public static void ChangePassword(string password)
        {
            string query = "UPDATE Users SET Pass = @password WHERE ID = @userID;";

            try
            {
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.AddWithValue("@password", password);
                sqlCommand.Parameters.AddWithValue("@userID", DBUserInformation.UserID);

                connection.Open();

                sqlCommand.ExecuteNonQuery();
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
        /// Populates the list of files
        /// </summary>
        public static void GetMyFiles()
        {
            string query = "SELECT * FROM Files WHERE UserID = (SELECT ID FROM Users WHERE Username = @username);";
            DataTable dt = new DataTable();

            try
            {
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.AddWithValue("@username", DBUserInformation.Username);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                connection.Open();

                sqlDataAdapter.Fill(dt);

                // Purge old files in list and reload new ones
                FileInformation.myFiles.Clear();

                foreach (DataRow item in dt.Rows)
                {
                    FileInformation file = new FileInformation();
                    file.Path = item.Field<string>("FilePath");
                    file.Name = System.IO.Path.GetFileName(file.Path);
                    file.Encyrption = item.Field<string>("EncryptionType");
                    file.IsEncrypted = Convert.ToBoolean(item.Field<int>("IsEncrypted"));
                    file.OnThisMachine = System.IO.File.Exists(file.Path);
                    file.DBID = item.Field<int>("ID");


                    FileInformation.myFiles.Add(file);
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Problem retrieving files for user: " + DBUserInformation.Username);
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Returns a list of all files in the database for statistic purposes
        /// </summary>
        /// <returns></returns>
        public static List<FileInformation> GetAllFiles()
        {
            string query = "SELECT * FROM Files;";
            DataTable dt = new DataTable();

            try
            {
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                connection.Open();

                sqlDataAdapter.Fill(dt);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.ToString());
            }
            finally
            {
                connection.Close();
            }

            List<FileInformation> ret = new List<FileInformation>();

            foreach (DataRow item in dt.Rows)
            {
                FileInformation file = new FileInformation();
                file.Path = item.Field<string>("FilePath");
                file.Encyrption = item.Field<string>("EncryptionType");
                file.IsEncrypted = Convert.ToBoolean(item.Field<int>("IsEncrypted"));

                ret.Add(file);
            }

            return ret;
        }


        /// <summary>
        /// Check if a file exists in the database for the current user
        /// </summary>
        /// <param name="fileInformation"></param>
        /// <returns></returns>
        public static bool FileExists(FileInformation fileInformation)
        {
            bool ret = false;
            SqlDataReader dataReader;
            string query = "SELECT * FROM Files WHERE FilePath = @filePath AND UserID = (SELECT ID FROM Users WHERE Username = @username);";

            try
            {
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.AddWithValue("@filePath", fileInformation.Path);
                sqlCommand.Parameters.AddWithValue("@username", DBUserInformation.Username);

                connection.Open();
                dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                    ret = true;
                else
                    ret = false;
                
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
        /// Adds a file to the database
        /// </summary>
        /// <param name="fileInformation"></param>
        /// <returns></returns>
        public static void AddFile(FileInformation fileInformation)
        {
            bool exists = FileExists(fileInformation);

            if (exists)
            {
                // Update the file
                string query = "UPDATE Files SET FilePath = @filePath, IsEncrypted = @isEncrypted, EncryptionType = @type WHERE UserID = (SELECT ID FROM Users WHERE Username = @username);";

                try
                {
                    SqlCommand sqlCommand = new SqlCommand(query, connection);
                    sqlCommand.Parameters.AddWithValue("@filePath", fileInformation.Path);
                    sqlCommand.Parameters.AddWithValue("@isEncrypted", Convert.ToInt32(fileInformation.IsEncrypted));
                    sqlCommand.Parameters.AddWithValue("@type", fileInformation.Encyrption);
                    sqlCommand.Parameters.AddWithValue("@username", DBUserInformation.Username);

                    connection.Open();

                    sqlCommand.ExecuteNonQuery();
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
            else
            {
                string query = "INSERT INTO Files VALUES (@filePath, @isEncrypted, @type, @userID);";

                try
                {
                    SqlCommand sqlCommand = new SqlCommand(query, connection);
                    sqlCommand.Parameters.AddWithValue("@filePath", fileInformation.Path);
                    sqlCommand.Parameters.AddWithValue("@isEncrypted", Convert.ToInt32(fileInformation.IsEncrypted));
                    sqlCommand.Parameters.AddWithValue("@type", fileInformation.Encyrption);
                    sqlCommand.Parameters.AddWithValue("@userID", DBUserInformation.UserID);

                    connection.Open();

                    sqlCommand.ExecuteNonQuery();

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
        }


        /// <summary>
        /// Delete a file from the database
        /// </summary>
        /// <param name="fileInformation"></param>
        public static void DeleteFile(FileInformation fileInformation)
        {
            if (FileExists(fileInformation))
            {
                string query = "DELETE FROM Files WHERE ID = @fileID";

                try
                {
                    SqlCommand sqlCommand = new SqlCommand(query, connection);
                    sqlCommand.Parameters.AddWithValue("@fileID", fileInformation.DBID);

                    connection.Open();

                    sqlCommand.ExecuteNonQuery();
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
        }
    } 
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using MetroFramework;

namespace DAQNavi_WF_v1_0_0
{

    public class LoginManager
    {

        public string dataSource { get; set; }
        public string port { get; set; }
        public string username { get; set; }
        public string dbPassword { get; set; }
        public string dbName { get; set; }

        public UserDTO loggedUser { get; set; }

        public LoginManager(string dataSource, string port, string username, string password, string dbName)
        {
            this.dataSource = dataSource;
            this.username = username;
            this.port = port;
            this.dbPassword = password;
            this.dbName = dbName;
        }
        public Boolean checkLogin(string login, string password)
        {
            try
            {
                //string dbName = "sh194684_kwpomiary";
                // localhost 3306 root root
                string myConnection = "datasource=" + dataSource + ";port=" + port + ";username=" + username + ";password=" + dbPassword;
                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlCommand SelectCommand = new MySqlCommand("select * from " + dbName + ".users where login='" + login + "' and password='" + password + "' ;", myConn);

                MySqlDataReader myReader;
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();
                int count = 0;
                while (myReader.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    loggedUser = new UserDTO();
                    loggedUser.idusers = myReader.GetString("idusers");
                    loggedUser.email = myReader.GetString("email");
                    loggedUser.imie = myReader.GetString("imie");
                    loggedUser.nazwisko = myReader.GetString("nazwisko");
                    loggedUser.admin = myReader.GetInt16("admin");
                    //loggedUser.dataZalozenia = myReader.GetString("dataZalozenia");
                    loggedUser.login = myReader.GetString("login");
                    loggedUser.password = myReader.GetString("password");
                    myConn.Close();
                    return true;
                }
                else
                {
                    myConn.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static Boolean testConnection(Form mainWindow, string dataSource, string port, string username, string dbPassword, string dbName)
        {
            string myConnection = "datasource=" + dataSource + ";port=" + port + ";username=" + username + ";password=" + dbPassword;
            bool isConn = false;
            bool success = true;
            MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection(myConnection);
                conn.Open();
                isConn = true;
            }
            catch (ArgumentException a_ex)
            {
                MetroMessageBox.Show(mainWindow, "Wpisałeś niepoprawne dane, albo serwer nie został odnaleziony!", "Niepowodzenie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                success = false;
            }
            catch (MySqlException ex)
            {
                MetroMessageBox.Show(mainWindow, "Wpisałeś niepoprawne dane, albo serwer nie został odnaleziony!", "Niepowodzenie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isConn = false;
                success = false;
                switch (ex.Number)
                {
                    //http://dev.mysql.com/doc/refman/5.0/en/error-messages-server.html
                    case 1042: // Unable to connect to any of the specified MySQL hosts (Check Server,Port)
                        break;
                    case 0: // Access denied (Check DB name,username,password)
                        break;
                    default:
                        break;
                }
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            if (!success)
            {
                return false;
            }

            MetroMessageBox.Show(mainWindow, "Udało się nawiązać połączenie z serwerem!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return isConn;
        }
    }
}

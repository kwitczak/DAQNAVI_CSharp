using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace DAQNavi_WF_v1_0_0
{

    public class LoginPanel
    {

        public string dataSource { get; set; }
        public string port { get; set; }
        public string username { get; set; }
        public string dbPassword { get; set; }

        public UserDTO loggedUser { get; set; }

        public LoginPanel(string dataSource, string port, string username, string password)
        {
            this.dataSource = dataSource;
            this.username = username;
            this.port = port;
            this.dbPassword = password;
        }
        public Boolean checkLogin(string login, string password)
        {
            try
            {
                // localhost 3306 root root
                string myConnection = "datasource=" + dataSource + ";port=" + port + ";username=" + username + ";password=" + dbPassword;
                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlCommand SelectCommand = new MySqlCommand("select * from usb4702_logindb.users where login='" + login + "' and password='" + password + "' ;", myConn);

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
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}

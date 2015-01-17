using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace DAQNavi_WF_v1_0_0
{
    class LoginPanel
    {
        public User loggedUser { get; set; }
        public Boolean checkLogin(string login, string password)
        {
            try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=root";
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
                    loggedUser = new User();
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

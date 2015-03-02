using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAQNavi_WF_v1_0_0
{
    public class Measurment
    {
        private double[] dataToSave;

        public static void saveDataToDataBase(LoginPanel Login, string dateStart, string dateEnd, double[] data, MetroFramework.Controls.MetroProgressBar progressBar){
            // localhost 3306 root root
            string myConnection = "datasource=" + Login.dataSource + ";port=" + Login.port + ";username=" + Login.username + ";password=" + Login.dbPassword;
            progressBar.Visible = true;
            progressBar.Value = 0;
            progressBar.Maximum = data.Length;
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand command = myConn.CreateCommand();
            myConn.Open();

            command.CommandText = "INSERT INTO usb4702_logindb.measurments (idusers,timestart,timeend) VALUES ('" + Login.loggedUser.idusers.ToString() + "','" + dateStart + "','" + dateEnd + "')";
            command.ExecuteNonQuery();
            long lastId = command.LastInsertedId;
            for (int i = 0; i < data.Length; i++)
            {
                progressBar.Value++;
                progressBar.Refresh();
                command.CommandText = "INSERT INTO usb4702_logindb.data (idmeasurments,value) VALUES (" + lastId.ToString() + ",'" + data[i].ToString() + "')";
                command.ExecuteNonQuery();
            }
            myConn.Close();
                
        }

    }
}

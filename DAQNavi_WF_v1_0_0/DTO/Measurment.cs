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

        public static void saveDataToDataBase(string dateStart, string dateEnd, double[] data){
            // localhost 3306 root root
            string myConnection = "datasource=" + "localhost" + ";port=" + "3306" + ";username=" + "root" + ";password=" + "root";
                
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand command = myConn.CreateCommand();
            command.CommandText = "INSERT INTO usb4702_logindb.measurments (idusers,timestart,timeend) VALUES ('1','start','end')";
            myConn.Open();
            command.ExecuteNonQuery();
            for (int i = 0; i < data.Length; i++)
            {
                command.CommandText = "INSERT INTO usb4702_logindb.data (idmeasurments,value) VALUES ('1','" + data[i].ToString() + "')";
                command.ExecuteNonQuery();
            }
            myConn.Close();
                
        }

    }
}

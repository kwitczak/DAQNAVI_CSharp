using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAQNavi_WF_v1_0_0
{
    public class MeasurmentDAO
    {
        private double[] dataToSave;

        public static void saveDataToDataBase(LoginPanel Login, string dateStart, string dateEnd, double[] data, string duration, string samples, string numberofchannels, string startchannel, MetroFramework.Controls.MetroProgressBar progressBar){
            // localhost 3306 root root
            string myConnection = "datasource=" + Login.dataSource + ";port=" + Login.port + ";username=" + Login.username + ";password=" + Login.dbPassword;
            progressBar.Visible = true;
            progressBar.Value = 0;
            progressBar.Maximum = data.Length;
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand command = myConn.CreateCommand();
            myConn.Open();

            var dateAndTime = DateTime.Now;
            var date = dateAndTime.Date;
            CultureInfo cul = CultureInfo.CurrentCulture;
            int weekNum = cul.Calendar.GetWeekOfYear(
                date,
                CalendarWeekRule.FirstDay,
                DayOfWeek.Monday);

            command.CommandText = "INSERT INTO usb4702_logindb.measurments (idusers,timestart,timeend,date,task,week,duration,samples,numberofchannels,startchannel) VALUES ('" + Login.loggedUser.idusers.ToString() + "','" + dateStart + "','" + dateEnd + "','" + date.ToString() + "','" + "task" + "','" + weekNum + "','" + duration + "','" + samples + "','" + numberofchannels + "','" + startchannel +"')";
            command.ExecuteNonQuery();
            long lastId = command.LastInsertedId;
            for (int i = 0; i < data.Length; i++)
            {
                progressBar.Value++;
                progressBar.Refresh();
                command.CommandText = "INSERT INTO usb4702_logindb.data (idmeasurments,value,channel) VALUES ('" + lastId.ToString() + "','" + data[i].ToString() + "','" + "0" + "')";
                command.ExecuteNonQuery();
            }
            myConn.Close();
                
        }

    }
}

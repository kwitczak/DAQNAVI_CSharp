using DAQNavi_WF_v1_0_0.DTO;
using MetroFramework;
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
        private LoginManager login;

        public MeasurmentDAO(LoginManager login)
        {
            this.login = login;
        }


        public void saveDataToDataBase(string dateStart, string dateEnd, double[] data, string duration, string samples, string numberofchannels, string startchannel, MetroFramework.Controls.MetroProgressBar progressBar){
            // localhost 3306 root root
            string myConnection = "datasource=" + login.dataSource + ";port=" + login.port + ";username=" + login.username + ";password=" + login.dbPassword;
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

            command.CommandText = "INSERT INTO usb4702_logindb.measurments (idusers,timestart,timeend,date,task,week,duration,samples,numberofchannels,startchannel) VALUES ('" + login.loggedUser.idusers.ToString() + "','" + dateStart + "','" + dateEnd + "','" + date.ToString() + "','" + "task" + "','" + weekNum + "','" + duration + "','" + samples + "','" + numberofchannels + "','" + startchannel +"')";
            command.ExecuteNonQuery();


            long lastId = command.LastInsertedId;
            int currentChannelNumer = 0;
            string[] arr = new string[10000];
            int counter = 0;
            for (int i = 0; i < data.Length; i++)
            {
                currentChannelNumer = (i % int.Parse(numberofchannels));
                progressBar.Value++;
                progressBar.Refresh();
                arr[counter] = "INSERT INTO usb4702_logindb.data (idmeasurments,value,channel) VALUES ('" + lastId.ToString() + "','" + data[i].ToString() + "','" + currentChannelNumer.ToString() + "')";
                counter++;
                if (i % 10000 == 0 || i == data.Length - 1)
                {
                    command.CommandText = string.Join(";", arr);
                    command.ExecuteNonQuery();
                    arr = new string[10000];
                    counter = 0;
                }

            }

            myConn.Close();
                
        }

        public double[] getDataFromDatabase(int idmeasurments)
        {
            // localhost 3306 root root
            string myConnection = "datasource=" + login.dataSource + ";port=" + login.port + ";username=" + login.username + ";password=" + login.dbPassword;
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand command = new MySqlCommand("select * from usb4702_logindb.data WHERE idmeasurments='" + idmeasurments + "' ;", myConn);
            myConn.Open();

            MySqlDataReader myReader;
            myReader = command.ExecuteReader();
            List<double> myData = new List<double>();
            while (myReader.Read())
            {
                myData.Add(double.Parse(myReader.GetString("value")));
            }

            myConn.Close();
            return myData.ToArray();
        }

        public void clearMeasurments()
        {
            string myConnection = "datasource=" + login.dataSource + ";port=" + login.port + ";username=" + login.username + ";password=" + login.dbPassword;
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand command = myConn.CreateCommand();
            myConn.Open();

            command.CommandText = "TRUNCATE TABLE usb4702_logindb.data";
            command.ExecuteNonQuery();
            command.CommandText = "TRUNCATE TABLE usb4702_logindb.measurments";
            command.ExecuteNonQuery();
            myConn.Close();
        }

        /* Metoda która wyświetla listę pomiarów wykonanych przez danego użytkownika
        w oknie MyMeasurments */
        public void loadMyMeasurments(String iduser, MainWindow mainWindow)
        {
            string myConnection = "datasource=" + login.dataSource + ";port=" + login.port + ";username=" + login.username + ";password=" + login.dbPassword;
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand SelectCommand = new MySqlCommand("select * from usb4702_logindb.measurments where idusers='" + iduser + "' ;", myConn);

            MySqlDataReader myReader;
            myConn.Open();
            myReader = SelectCommand.ExecuteReader();
            int count = 0;
            while (myReader.Read())
            {
                MeasurmentDTO measurment = new MeasurmentDTO();
                measurment.idmeasurments = myReader.GetString("idmeasurments");
                measurment.idusers = myReader.GetString("idusers");
                measurment.task = myReader.GetString("task");
                measurment.timeend = myReader.GetString("timeend");
                measurment.timestart = myReader.GetString("timestart");
                measurment.week = myReader.GetString("week");
                measurment.samples = myReader.GetString("samples");
                measurment.duration = myReader.GetString("duration");
                measurment.numberofchannels = myReader.GetString("numberofchannels");
                measurment.startchannel = myReader.GetString("startchannel");
                MainWindow.myLoadedMeasurments.Add(measurment);

                mainWindow.createNewMeasurment();
                MainWindow.MM_list_titles[MainWindow.MM_numberOfMeasurments - 1].Text = "Measurment #" + MainWindow.MM_numberOfMeasurments;
                MainWindow.MM_list_titles[MainWindow.MM_numberOfMeasurments - 1].Text += "  -  " + measurment.timestart;
                MainWindow.MM_list_titles[MainWindow.MM_numberOfMeasurments - 1].Text += "                                           duration:  " + measurment.duration;
                MainWindow.MM_list_titles[MainWindow.MM_numberOfMeasurments - 1].Style = MetroColorStyle.Blue;
                MainWindow.MM_list_samplesValue[MainWindow.MM_numberOfMeasurments - 1].Text = measurment.samples;
                MainWindow.MM_list_numberOfChannelsValue[MainWindow.MM_numberOfMeasurments - 1].Text = measurment.numberofchannels;
                MainWindow.MM_list_channelStartValue[MainWindow.MM_numberOfMeasurments - 1].Text = measurment.startchannel;

                //getMeasurmentData(measurment);

            }
        }

        /* Download data from DB */
        public List<double> getMeasurmentData(MeasurmentDTO measurment)
        {
            string myConnection = "datasource=" + login.dataSource + ";port=" + login.port + ";username=" + login.username + ";password=" + login.dbPassword;
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand SelectCommand = new MySqlCommand("select * from usb4702_logindb.data where idmeasurments='" + measurment.idmeasurments + "' ;", myConn);

            MySqlDataReader myReader;
            myConn.Open();
            myReader = SelectCommand.ExecuteReader();
            int counter = 0;
            List<double> result = new List<double>();
            while (myReader.Read())
            {
                result.Add(double.Parse(myReader.GetString("value")));
                counter++;
            }
            return result;
        }

    }
}

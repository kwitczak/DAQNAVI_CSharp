using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MetroFramework;

namespace DAQNavi_WF_v1_0_0.Utils
{
    public partial class CreateNewUserForm : MetroForm
    {
        private MainWindow mainWindow;
        MetroFramework.Controls.MetroCheckBox[] checkBoxesList = new MetroFramework.Controls.MetroCheckBox[6];

        public CreateNewUserForm(MainWindow mainWindow)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.MaximizeBox = false;
            this.mainWindow = mainWindow;
            MetroFramework.MetroThemeStyle parentStyle = MainWindow.choosenStyle;
            MainWindow.Language language = MainWindow.choosenLanguage;
            this.Theme = parentStyle;
            Label_CreateNewUser_Email.Theme = parentStyle;
            Label_CreateNewUser_Login.Theme = parentStyle;
            Label_CreateNewUser_Name.Theme = parentStyle;
            Label_CreateNewUser_Password.Theme = parentStyle;
            Label_CreateNewUser_Password2.Theme = parentStyle;
            Label_CreateNewUser_Surname.Theme = parentStyle;
            Button_CreateNewUser_Save.Theme = parentStyle;
            TextBox_CreateNewUser_Email.Theme = parentStyle;
            TextBox_CreateNewUser_Login.Theme = parentStyle;
            TextBox_CreateNewUser_Name.Theme = parentStyle;
            TextBox_CreateNewUser_Password.Theme = parentStyle;
            TextBox_CreateNewUser_Password2.Theme = parentStyle;
            TextBox_CreateNewUser_Surname.Theme = parentStyle;
            CheckBox_CreateNewUser_Email.Theme = parentStyle;
            CheckBox_CreateNewUser_Login.Theme = parentStyle;
            CheckBox_CreateNewUser_Name.Theme = parentStyle;
            CheckBox_CreateNewUser_Password.Theme = parentStyle;
            CheckBox_CreateNewUser_Password2.Theme = parentStyle;
            CheckBox_CreateNewUser_Surname.Theme = parentStyle;


            if (language == MainWindow.Language.ENG)
            {
                Label_CreateNewUser_Email.Text = "Email";
                Label_CreateNewUser_Login.Text = "Index";
                Label_CreateNewUser_Name.Text = "Name";
                Label_CreateNewUser_Password.Text = "Password";
                Label_CreateNewUser_Password2.Text = "Repeat password";
                Label_CreateNewUser_Surname.Text = "Surname";
                Button_CreateNewUser_Save.Text = "Save";
                this.Text = "Registrate";

            }
            else
            {
                Label_CreateNewUser_Email.Text = "Email";
                Label_CreateNewUser_Login.Text = "Indeks";
                Label_CreateNewUser_Name.Text = "Imię";
                Label_CreateNewUser_Password.Text = "Hasło";
                Label_CreateNewUser_Password2.Text = "Powtórz hasło";
                Label_CreateNewUser_Surname.Text = "Nazwisko";
                Button_CreateNewUser_Save.Text = "Zapisz";
                this.Text = "Rejestracja";
            }
        }

        /// <summary>
        /// Sprawdź czy nie jest używany taki email
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_CreateNewUser_Email_Leave(object sender, EventArgs e)
        {
            Spinner_CreateNewUser.Visible = true;
            if (checkNullText(sender))
            {
                if (EmailIsValid(TextBox_CreateNewUser_Email.Text))
                {
                    checkEmail();
                }
                else
                {
                    CheckBox_CreateNewUser_Email.Visible = true;
                    CheckBox_CreateNewUser_Email.Checked = true;
                    CheckBox_CreateNewUser_Email.Style = MetroFramework.MetroColorStyle.Red;
                    CheckBox_CreateNewUser_Email.Text = "Invalid email!";
                    //TextBox_CreateNewUser_Email.Select();
                }
                
            }
            else
            {
                checkBoxNullWarn(CheckBox_CreateNewUser_Email);
            }
            Spinner_CreateNewUser.Visible = false;
            
        }

        private void checkEmail()
        {
            string myConnection = "datasource=" + mainWindow.getDatabaseAddress.Text + ";port=" + mainWindow.getDatabasePort.Text + ";username=" + mainWindow.getDatabaseUser.Text + ";password=" + mainWindow.getDatabasePassword.Text;
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand SelectCommand = new MySqlCommand("select * from usb4702_logindb.users where email='" + TextBox_CreateNewUser_Email.Text + "' ;", myConn);

            MySqlDataReader myReader;
            myConn.Open();
            myReader = SelectCommand.ExecuteReader();
            int count = 0;
            while (myReader.Read())
            {
                count = count + 1;
            }
            if (count == 0)
            {
                CheckBox_CreateNewUser_Email.Visible = true;
                CheckBox_CreateNewUser_Email.Checked = true;
                CheckBox_CreateNewUser_Email.Style = MetroFramework.MetroColorStyle.Default;
                CheckBox_CreateNewUser_Email.Text = "Correct";
            }
            else
            {
                CheckBox_CreateNewUser_Email.Visible = true;
                CheckBox_CreateNewUser_Email.Checked = true;
                CheckBox_CreateNewUser_Email.Style = MetroFramework.MetroColorStyle.Red;
                CheckBox_CreateNewUser_Email.Text = "Already used";
            }
        }

        private void checkLogin()
        {
            string myConnection = "datasource=" + mainWindow.getDatabaseAddress.Text + ";port=" + mainWindow.getDatabasePort.Text + ";username=" + mainWindow.getDatabaseUser.Text + ";password=" + mainWindow.getDatabasePassword.Text;
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand SelectCommand = new MySqlCommand("select * from usb4702_logindb.users where login='" + TextBox_CreateNewUser_Login.Text + "' ;", myConn);

            MySqlDataReader myReader;
            myConn.Open();
            myReader = SelectCommand.ExecuteReader();
            int count = 0;
            while (myReader.Read())
            {
                count = count + 1;
            }
            if (count == 0)
            {
                CheckBox_CreateNewUser_Login.Visible = true;
                CheckBox_CreateNewUser_Login.Checked = true;
                CheckBox_CreateNewUser_Login.Style = MetroFramework.MetroColorStyle.Default;
                CheckBox_CreateNewUser_Login.Text = "Correct";
            }
            else
            {
                CheckBox_CreateNewUser_Login.Visible = true;
                CheckBox_CreateNewUser_Login.Checked = true;
                CheckBox_CreateNewUser_Login.Style = MetroFramework.MetroColorStyle.Red;
                CheckBox_CreateNewUser_Login.Text = "Already used";
                //TextBox_CreateNewUser_Login.Select();
            }
        }

        private void TextBox_CreateNewUser_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                TextBox_CreateNewUser_Surname.Select();
            }

            e.Handled = char.IsDigit(e.KeyChar);
        }

        private void TextBox_CreateNewUser_Surname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                TextBox_CreateNewUser_Email.Select();
            }

            e.Handled = char.IsDigit(e.KeyChar);
        }

        private void TextBox_CreateNewUser_Email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                TextBox_CreateNewUser_Login.Select();
            }
        }

        private void TextBox_CreateNewUser_Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                TextBox_CreateNewUser_Password.Select();
            }
        }

        private void TextBox_CreateNewUser_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                TextBox_CreateNewUser_Password2.Select();
            }
        }

        private bool checkNullText(object sender)
        {
            if (((MetroFramework.Controls.MetroTextBox)sender).Text.Equals(""))
            {
                //((MetroFramework.Controls.MetroTextBox)sender).Select();
                return false;

            }
            else
            {
                return true;
            }
        }

        private void checkBoxCorrect(object checkBox2){
            MetroFramework.Controls.MetroCheckBox checkBox = (MetroFramework.Controls.MetroCheckBox) checkBox2;
            checkBox.Visible = true;
            checkBox.Checked = true;
            checkBox.Style = MetroFramework.MetroColorStyle.Default;
            checkBox.Text = "Correct";
        }

        private void checkBoxNullWarn(object checkBox2)
        {
            MetroFramework.Controls.MetroCheckBox checkBox = (MetroFramework.Controls.MetroCheckBox)checkBox2;
            checkBox.Visible = true;
            checkBox.Checked = true;
            checkBox.Style = MetroFramework.MetroColorStyle.Red;
            checkBox.Text = "Cannot be empty!";
        }

        private void checkBoxAlreadyChoosen(object checkBox2)
        {
            MetroFramework.Controls.MetroCheckBox checkBox = (MetroFramework.Controls.MetroCheckBox)checkBox2;
            checkBox.Visible = true;
            checkBox.Checked = true;
            checkBox.Style = MetroFramework.MetroColorStyle.Red;
            checkBox.Text = "Already choosen";
        }

        private void TextBox_CreateNewUser_Name_Leave(object sender, EventArgs e)
        {
            Spinner_CreateNewUser.Visible = true;
            if (checkNullText(sender))
            {
                checkBoxCorrect(CheckBox_CreateNewUser_Name);
            }
            else
            {
                checkBoxNullWarn(CheckBox_CreateNewUser_Name);
            }
            Spinner_CreateNewUser.Visible = false;
        }

        private void TextBox_CreateNewUser_Surname_Leave(object sender, EventArgs e)
        {
            Spinner_CreateNewUser.Visible = true;
            if (checkNullText(sender))
            {
                checkBoxCorrect(CheckBox_CreateNewUser_Surname);
            }
            else
            {
                checkBoxNullWarn(CheckBox_CreateNewUser_Surname);
            }
            Spinner_CreateNewUser.Visible = false;
        }

        static Regex ValidEmailRegex = CreateValidEmailRegex();

        /// <summary>
        /// Taken from http://haacked.com/archive/2007/08/21/i-knew-how-to-validate-an-email-address-until-i.aspx
        /// </summary>
        /// <returns></returns>
        private static Regex CreateValidEmailRegex()
        {
            string validEmailPattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(validEmailPattern, RegexOptions.IgnoreCase);
        }

        internal static bool EmailIsValid(string emailAddress)
        {
            bool isValid = ValidEmailRegex.IsMatch(emailAddress);

            return isValid;
        }

        private void TextBox_CreateNewUser_Login_Leave(object sender, EventArgs e)
        {
            Spinner_CreateNewUser.Visible = true;
            if (checkNullText(sender))
            {
                checkLogin();
            }
            else
            {
                checkBoxNullWarn(CheckBox_CreateNewUser_Login);
            }
            Spinner_CreateNewUser.Visible = false;
        }

        private void TextBox_CreateNewUser_Password_Leave(object sender, EventArgs e)
        {
            Spinner_CreateNewUser.Visible = true;
            if (checkNullText(sender))
            {
                checkBoxCorrect(CheckBox_CreateNewUser_Password);
            }
            else
            {
                checkBoxNullWarn(CheckBox_CreateNewUser_Password);
            }
            Spinner_CreateNewUser.Visible = false;
        }

        private void TextBox_CreateNewUser_Password2_Leave(object sender, EventArgs e)
        {
            Spinner_CreateNewUser.Visible = true;
            if (checkNullText(sender))
            {
                if (TextBox_CreateNewUser_Password.Text.Equals(TextBox_CreateNewUser_Password2.Text))
                {
                    checkBoxCorrect(CheckBox_CreateNewUser_Password2);
                }
                else
                {
                    CheckBox_CreateNewUser_Password2.Visible = true;
                    CheckBox_CreateNewUser_Password2.Checked = true;
                    CheckBox_CreateNewUser_Password2.Style = MetroFramework.MetroColorStyle.Red;
                    CheckBox_CreateNewUser_Password2.Text = "Passwords don't match!";
                }
                
            }
            else
            {
                checkBoxNullWarn(CheckBox_CreateNewUser_Password2);
            }
            Spinner_CreateNewUser.Visible = false;
        }

        private void TextBox_CreateNewUser_Password2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Button_CreateNewUser_Save.Select();
            }
        }

        /// <summary>
        /// Save to DB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_CreateNewUser_Save_Click(object sender, EventArgs e)
        {

            if (!testCorrectness())
            {
                MetroMessageBox.Show(this, "Wpisz poprawne dane!.", "Rejestracja", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MainWindow.checkTextValid(TextBox_CreateNewUser_Login.Text) || 
                MainWindow.checkTextValid(TextBox_CreateNewUser_Name.Text) || 
                MainWindow.checkTextValid(TextBox_CreateNewUser_Password.Text) ||
                MainWindow.checkTextValid(TextBox_CreateNewUser_Surname.Text))
            {
                MetroMessageBox.Show(this, "Twoje dane zawierają niepoprawne znaki!.", "Rejestracja", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            try
            {
                string myConnection = "datasource=" + mainWindow.getDatabaseAddress.Text + ";port=" + mainWindow.getDatabasePort.Text + ";username=" + mainWindow.getDatabaseUser.Text + ";password=" + mainWindow.getDatabasePassword.Text;
                Spinner_CreateNewUser.Visible = true;
                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlCommand command = myConn.CreateCommand();
                myConn.Open();
                command.CommandText = "INSERT INTO usb4702_logindb.users (email,imie,nazwisko,admin,login,password) VALUES ('" + TextBox_CreateNewUser_Email.Text + "','" + TextBox_CreateNewUser_Name.Text + "','" + TextBox_CreateNewUser_Surname.Text + "','" + 0 + "','" + TextBox_CreateNewUser_Login.Text + "','" + TextBox_CreateNewUser_Password.Text + "')";
                command.ExecuteNonQuery();
                myConn.Close();
                Spinner_CreateNewUser.Visible = false;
                MetroMessageBox.Show(this, "Tworzenie konta zakończone sukcesem.", "Rejestracja", MessageBoxButtons.OK, MessageBoxIcon.Question);
                this.Hide();
            }
            catch
            {
                MetroMessageBox.Show(this, "Tworzenie konta nie powiodło się!.", "Rejestracja", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
            }
        }

        public bool testCorrectness()
        {
            Boolean result = true;
            checkBoxesList[0] = CheckBox_CreateNewUser_Name;
            checkBoxesList[1] = CheckBox_CreateNewUser_Surname;
            checkBoxesList[2] = CheckBox_CreateNewUser_Email;
            checkBoxesList[3] = CheckBox_CreateNewUser_Login;
            checkBoxesList[4] = CheckBox_CreateNewUser_Password;
            checkBoxesList[5] = CheckBox_CreateNewUser_Password2;
            foreach (MetroFramework.Controls.MetroCheckBox item in checkBoxesList)
            {
                if (!item.Text.Equals("Correct"))
                {
                    MessageBox.Show("Test");
                    result = false;
                }
            }

            return result;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Spinner_CreateNewUser.Refresh();
            Spinner_CreateNewUser.Value++;
        }

        private void CreateNewUserForm_Load(object sender, EventArgs e)
        {

        }
    }
}

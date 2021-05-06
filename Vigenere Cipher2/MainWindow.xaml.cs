using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Vigenere_Cipher2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

        }

        private void SentMessage_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (SentMessage.Text == "Enter your message consisting of numbers.")
                SentMessage.Text = ""; //Clears the message text box when it's clicked
        }

        private void UserKey_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (UserKey.Text == "Enter a key of 10 different digits")
                UserKey.Text = ""; //Clears the key text box when it's clicked
        }

        private void SentMessage_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(SentMessage.Text != "Enter your message consisting of numbers.")
            {
                SentMessage.Text = encryption_console_prog.Program.CleanText(SentMessage.Text);  //removes non-numeric values
                SentMessage.Select(SentMessage.Text.Length, 0); //Moves the curser to the end of the string
            }

            if (UserKey.Text.Length == 10 && UserKey.Text != "Enter a key of 10 different digits" && SentMessage.Text != "Enter your message consisting of numbers.")
                Result.Text = encryption_console_prog.Program.encryptMSG(UserKey.Text,SentMessage.Text);
        }

        private void UserKey_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (UserKey.Text != "Enter a key of 10 different digits")
            {
                UserKey.Text = encryption_console_prog.Program.CleanText(UserKey.Text); //removes non-numeric values
                UserKey.Text = encryption_console_prog.Program.CleanDuplicate(UserKey.Text); //removes duplicate characters
                UserKey.Select(UserKey.Text.Length, 0); //Moves the curser to the end of the string
            }
            if (UserKey.Text.Length == 10 && UserKey.Text != "Enter a key of 10 different digits" && SentMessage.Text != "Enter your message consisting of numbers.")
                Result.Text = encryption_console_prog.Program.encryptMSG(UserKey.Text, SentMessage.Text);

        }
    }
}

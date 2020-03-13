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

namespace LabsWithWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //private void Change_Click(object sender, RoutedEventArgs e)
        //{
        //    string text = textBox.Text;
        //    var words = text.Split(' ');
        //    int lastWordLength = words.Last().Length;
        //    var query = from word in words
        //                where word.Length == lastWordLength
        //                select word;
        //    var list = query.ToList();
        //    string res = "";
        //    list.ForEach(w => res += w + " ");
        //    MessageBox.Show(res);
        //}

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            PasswordWindow passwordWindow = new PasswordWindow();

            if (passwordWindow.ShowDialog() == true)
            {
                if (passwordWindow.Password == "1234")
                    MessageBox.Show("Авторизация пройдена");
                else
                    MessageBox.Show("Неверный пароль");
            }
            else
            {
                MessageBox.Show("Авторизация не пройдена");
            }
        }

        //<Grid.Background>
        //    <ImageBrush ImageSource = "C:/MailRu.jpg" ></ ImageBrush >
        //</ Grid.Background >
    }
}

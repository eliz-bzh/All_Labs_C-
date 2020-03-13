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
using System.Windows.Shapes;

namespace LabsWithWPF
{
    /// <summary>
    /// Логика взаимодействия для lab23.xaml
    /// </summary>
    public partial class lab23 : Window
    {
        public lab23()
        {
            InitializeComponent();
        }
        private void Change_Click(object sender, RoutedEventArgs e)
        {
            string text = textBox.Text;
            var words = text.Split(' ');
            int lastWordLength = words.Last().Length;
            var query = from word in words
                        where word.Length == lastWordLength
                        select word;
            var list = query.ToList();
            string res = "";
            list.ForEach(w => res += w + " ");
            MessageBox.Show(res);
        }

    }
}

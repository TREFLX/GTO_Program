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
using GTO_Program.BD;

namespace GTO_Program
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Model1 _context;
        public int access;
        public MainWindow()
        {
            InitializeComponent();
            _context = new Model1();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var user = _context.Auth.FirstOrDefault(p => p.Login.Equals(login.Text) && p.Password.Equals(pass.Password));
            if (user != null)
            {
                if (user.Role == "Препадователь")
                {
                    MessageBox.Show(user.Role + " успешно вошел в систему");
                    Serch_Students ST = new Serch_Students(user.Role); ST.Show();
                    this.Close();
                }
                else if (user.Role == "Студент")
                {
                    MessageBox.Show(user.Role + " успешно вошел в систему");
                    Serch_Students ST = new Serch_Students(user.Role); ST.Show();
                    this.Close();
                }
                else if (user.Role == "Администратор")
                {
                    MessageBox.Show(user.Role + " успешно вошел в систему");
                    Serch_Students ST = new Serch_Students(user.Role); ST.Show();
                    this.Close();
                }
            }
            else { MessageBox.Show("Неверный логин или пароль!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning); }

           
            
        }
    }
}

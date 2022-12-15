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
using GTO_Program.BD;

namespace GTO_Program
{
    /// <summary>
    /// Логика взаимодействия для Serch_Students.xaml
    /// </summary>
    public partial class Serch_Students : Window
    {
        private readonly Model1 _context;
        public Serch_Students(string Role)
        {
            InitializeComponent();
            _context = new Model1();
            LoadStudents();
            if (Role == "Студент")
            {
                IZM.Visibility = Visibility.Hidden;
            }
        }
        public List<StydentsData> StydentsDatas { get; set; }
        private void LoadStudents()
        {
            StydentsDatas = _context.StydentsData.ToList();
            StydentsDG.ItemsSource = StydentsDatas.OrderBy(p => p.id);
        }

        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            var filtered = StydentsDatas.Where(p => p.FIO.ToLower().StartsWith(searchtxt.Text.ToLower()));
            if (searchtxt.Text != null)
            {
                StydentsDG.ItemsSource = filtered;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (StydentsDG.SelectedItem != null)
            {
                var conEditWindow = new DataStudents(_context, StydentsDG.SelectedItem as StydentsData);

                if (conEditWindow.ShowDialog() == true)
                {
                    StydentsDG.ItemsSource = _context.StydentsData.ToList();
                    MessageBox.Show("Показатели студента успешно изменены!", "Оповещение", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else
            {
                MessageBox.Show("Сначала выберите студента!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow MW = new MainWindow(); MW.Show();
            this.Close();
        }

        private void KursCB_LostFocus(object sender, RoutedEventArgs e)
        {
        }

        private void GrupCB_LostFocus(object sender, RoutedEventArgs e)
        {
        }

        private void Button_Click_Search(object sender, RoutedEventArgs e)
        {
            if (KursCB.SelectedItem != null || GrupCB.SelectedItem != null)
            {
                StydentsDG.ItemsSource = StydentsDatas.Where(p => p.YearGroup.Contains(KursCB.Text)).Where(p => p.NumberGroup.Contains(GrupCB.Text));
            }


       
        }

        private void RefreshBook(object sender, RoutedEventArgs e)
        {
            KursCB.SelectedItem = null;
            GrupCB.SelectedItem = null;
            LoadStudents();
        }
    }
}

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
    /// Логика взаимодействия для DataStudents.xaml
    /// </summary>
    public partial class DataStudents : Window
    {
        private readonly Model1 _context;
        private bool _isStudentEdit = false;
        private StydentsData _Students;

        public DataStudents(Model1 context)
        {
            InitializeComponent();
            _context = context;
        }

        public DataStudents(Model1 context, StydentsData stydentsData) : this(context)
        {
           
            _isStudentEdit = true;
            _Students = stydentsData;
            FIOS.Text = stydentsData.FIO;
            podtig.Text = stydentsData.Подтягивания;
            brus.Text = stydentsData.Брусья;
            run30.Text = stydentsData.Бег30М;
            run60.Text = stydentsData.Бег60М;
            run100.Text = stydentsData.Бег100М;
            run2000.Text = stydentsData.Бег2000М;
            otzim.Text = stydentsData.Отжимания;
            jump.Text = stydentsData.Прыжок_с_места;
            jumping.Text = stydentsData.Прыжок_С_Разбега;
            abs.Text = stydentsData.Пресс;
            girya.Text = stydentsData.Гиря;
            naklon.Text = stydentsData.Наклоны_на_гибкость;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            _Students.FIO = FIOS.Text;
            _Students.Подтягивания = podtig.Text;
            _Students.Брусья = brus.Text;
            _Students.Бег30М = run30.Text;
            _Students.Бег60М = run60.Text;
            _Students.Бег100М = run100.Text;
            _Students.Бег2000М = run2000.Text;
            _Students.Отжимания = otzim.Text;
            _Students.Прыжок_с_места = jump.Text;
            _Students.Прыжок_С_Разбега = jumping.Text;
            _Students.Пресс = abs.Text;
            _Students.Гиря = girya.Text;
            _Students.Наклоны_на_гибкость = naklon.Text;
            if (_isStudentEdit)
            {
                StydentsData contactInDb = _context.StydentsData.Find(_Students.id);

                if (contactInDb != null)
                {
                    _context.Entry(contactInDb).CurrentValues.SetValues(_Students);

                    _context.SaveChanges();
                    DialogResult = true;
                }
            }
            else
            {
                if (_Students != null)
                {
                    _context.StydentsData.Add(_Students);

                    _context.SaveChanges();
                    DialogResult = true;
                }
            }
        }
    }
}

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

namespace ПР8
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
        private void MaleInfo_Click(object sender, RoutedEventArgs e) //информация о мужчине
        {
            if (string.IsNullOrEmpty(maleName.Text) || string.IsNullOrEmpty(maleSurname.Text) || string.IsNullOrEmpty(malePatronymic.Text))
            {
                MessageBox.Show("Введите информацию о служащем с почасовой оплатой!");
            }
            else
            {
                result.Clear();
                EmployeeWithASalary male = new EmployeeWithASalary(maleName.Text, maleSurname.Text, malePatronymic.Text);
                result.Text = male.ShowMaleInfo();
            }
        }

        private void FemaleInfo_Click(object sender, RoutedEventArgs e) //информация о женщине
        {
            if (string.IsNullOrEmpty(femaleName.Text) || string.IsNullOrEmpty(femaleSurname.Text) || string.IsNullOrEmpty(femalePatronymic.Text))
            {
                MessageBox.Show("Введите информацию о служащем с окладом!");
            }
            else
            {
                result.Clear();
                EmployeeWithHourlyPay female = new EmployeeWithHourlyPay(femaleName.Text, femaleSurname.Text, femalePatronymic.Text);
                result.Text = female.ShowInfo();
            }
        }
        private void Reaction_Click(object sender, RoutedEventArgs e) //рекция
        {
            result.Clear();
            EmployeeWithASalary male = new EmployeeWithASalary(maleName.Text, maleSurname.Text, malePatronymic.Text);
            result.Text = male.GetReaction();
        }
        private void CompareSurname_Click(object sender, RoutedEventArgs e) //сравнение фамилий
        {
            if (maleSurname.Text == string.Empty || femaleSurname.Text == string.Empty)
            {
                MessageBox.Show("Введите фамилии!");
            }
            else
            {
                result.Clear();
                EmployeeWithASalary EmployeeWithASalary = new EmployeeWithASalary(maleName.Text, maleSurname.Text, malePatronymic.Text);
                EmployeeWithASalary EmployeeWithHourlyPay = new EmployeeWithASalary(femaleName.Text, femaleSurname.Text, femalePatronymic.Text);

                if (EmployeeWithHourlyPay.CompareTo(EmployeeWithASalary) == 1)
                {
                    result.Text = "Фамилия служащего с окладом больше, чем у служащего с почасовой оплатой";
                }

                if (EmployeeWithHourlyPay.CompareTo(EmployeeWithASalary) == -1)
                {
                    result.Text = "Фамилия служащего с почасовой оплатой больше, чем у служащего с окладом";
                }

                if (EmployeeWithHourlyPay.CompareTo(EmployeeWithASalary) == 0)
                {
                    result.Text = "Фамилии одинаковые";
                }
            }
        }

        private void Information_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Работу выполнил студент группы Ржексвкий Александр. ИСП-34", "О программе", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

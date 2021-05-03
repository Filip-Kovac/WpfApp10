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
using System.ComponentModel;

namespace WpfApp10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Person.InitPersons();
            Person p = new Person();
            DataContext = p;
        }


        private void Persons_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Person pi = (Person)((sender as ListView).SelectedItem);
            DataContext = pi;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Persons.SelectedIndex = 0;
        }

        private void Persons_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Person pi = (Person)((sender as ListView).SelectedItem);
            PersonEdit pe = new PersonEdit(pi);
            pe.ShowDialog();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            PersonEdit pe = new PersonEdit();
            pe.ShowDialog();
        }
    }

}

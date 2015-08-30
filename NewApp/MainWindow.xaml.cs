using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace NewApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            //this.Background = new SolidColorBrush(Colors.RoyalBlue);
            dgemp.ItemsSource = new EmployeeList();
        }
    }

    public class Employee
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public int Salary { get; set; }
    }

    public class EmployeeList : ObservableCollection<Employee>
    {
        public EmployeeList()
        {
            Add(new Employee() { EmpNo=1,EmpName="A",Salary=10000});
            Add(new Employee() { EmpNo = 2, EmpName = "B", Salary = 11000 });
            Add(new Employee() { EmpNo = 3, EmpName = "C", Salary = 12000 });
            Add(new Employee() { EmpNo = 4, EmpName = "D", Salary = 13000 });
            Add(new Employee() { EmpNo = 5, EmpName = "E", Salary = 14000 });
        }
    }
}

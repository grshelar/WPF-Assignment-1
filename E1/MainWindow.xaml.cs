using LiveCharts.Wpf.Charts.Base;
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
using System.Windows.Threading;

namespace E1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            table john=new table();
            john.id = 1;
            john.Name = "Herman Beck";
            john.Duedate = "May 15, 2015";
            john.Progress = "70%";
            tables.Items.Add(john);

            table Herman = new table();
            Herman.id = 2;
            Herman.Name = "Messsy Adam";
            Herman.Duedate = "Jul 01, 2016";
            Herman.Progress = "60%";
            tables.Items.Add(Herman);


            table Messsy = new table();
            Messsy.id = 3;
            Messsy.Name = "John Richards";
            Messsy.Duedate = "May 15, 2017";
            Messsy.Progress = "50%";
            tables.Items.Add(Messsy);


            table Peter = new table();
            Peter.id = 4;
            Peter.Name = "Peter Meggik";
            Peter.Duedate = "Sep 15, 2018";
            Peter.Progress = "40%";
            tables.Items.Add(Peter);


            table Edward = new table();
            Edward.id = 5;
            Edward.Name = "Edward";
            Edward.Duedate = "Aug 03, 2015";
            Edward.Progress = "30%";
            tables.Items.Add(Edward);


            table Ronald = new table();
            Ronald.id = 6;
            Ronald.Name = "Ronald";
            Ronald.Duedate = "Jun 05, 2015";
            Ronald.Progress = "50%";
            tables.Items.Add(Ronald);

        }

        public class table
        {
            public int id { get; set; }
            public string Name { get; set; }
            public string Duedate { get; set; }
            public string Progress { get; set; }
        
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        
    }  
}

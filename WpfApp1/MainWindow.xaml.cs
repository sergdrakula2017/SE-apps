using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.VisualBasic;


namespace WpfApp1
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
       
        private void grid_Loaded(object sender, RoutedEventArgs e)
        {
            List<MyTable> result = new List<MyTable>(6);
            result.Add(new MyTable(1, 1234, 1235, "yes", "Optimix", 1971));
            result.Add(new MyTable(2, 5454, 5455, "yes", "Alebado", 1971));
            result.Add(new MyTable(3, 3268, 32369, "yes", "Drakula", 1971));
            result.Add(new MyTable(4, 8763, 8764, "yes", "MoryakSPb", 1971));
            grid.ItemsSource = result;
        }

        //Получаем данные из таблицы
        private void grid_MouseUp(object sender, MouseButtonEventArgs e)
        {
            
            MyTable path = grid.SelectedItem as MyTable;
            int parse = grid.SelectedIndex;
            DataRowView rowView = grid.SelectedValue as DataRowView;
            
            if (parse==0)
            {
                string str = "Convert.ToString(parse)";
                tb.Text = str;
            }
            else
            {
                string str ="  ";
                tb.Text = str;
            }
        }
       
        private void add_Click(object sender, RoutedEventArgs e)
        {
           
        }

        
    }
    class MyTable
    {
        public MyTable(int name, int current_version, int final_version, string Upload_prototypes, string author,
            int modified_date)
        {
            this.name = name;
            this.current_version = current_version;
            this.final_version = final_version;
            this.Upload_prototypes = Upload_prototypes;
            this.author = author;
            this.modified_date = modified_date;
        }

        public int name { get; set; }
        public int current_version { get; set; }
        public int final_version { get; set; }
        public string Upload_prototypes { get; set; }
        public string author { get; set; }
        public int modified_date { get; set; }

    }
}

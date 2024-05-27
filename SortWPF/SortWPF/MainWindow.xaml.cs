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

namespace SortWPF
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

        static List<int> Sorting(List<int> nnums1, List<int> nnums2)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < nnums1.Count; i++)
            {

                if (!list.Contains(nnums1[i]))
                { list.Add(nnums1[i]); }
            }
            for (int i = 0; i < nnums2.Count; i++)
            {
                if (!list.Contains(nnums2[i]))
                { list.Add(nnums2[i]); }

            }
            list.Sort();


            return list;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string input = nums1.Text;
            string input2 = nums2.Text;

            List<int> numbersList = new List<int>();
            List<int> numbers2List = new List<int>();

            string[] numbers = input.Split(',');
            string[] numbers2 = input2.Split(',');

            foreach (string number in numbers)
            {
                if (int.TryParse(number, out int num))
                {
                    numbersList.Add(num);
                }
            }
            foreach (string number in numbers2)
            {
                if (int.TryParse(number, out int num))
                {
                    numbers2List.Add(num);
                }
            }
            list.ItemsSource = Sorting(numbersList, numbers2List);
        }
    }
}
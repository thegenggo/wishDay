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

namespace HelloWorldGUI
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                float income = float.Parse(txtIncome.Text);
                float expenses = float.Parse(txtExpenses.Text);
                float netIncome = income - expenses;
                if (netIncome > 0)
                {
                    float require = float.Parse(txtRequire.Text);
                    string result = Math.Floor(require / netIncome).ToString();
                    txtResult.Text = result;
                }
                else
                {
                    txtResult.Text = "";
                }
            } 
            catch
            {
                
            }
        }
    }
}

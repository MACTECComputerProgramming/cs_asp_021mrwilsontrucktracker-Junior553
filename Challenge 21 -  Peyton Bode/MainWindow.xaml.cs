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

namespace Challenge_21____Peyton_Bode
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

        private void answerTicket_Click(object sender, RoutedEventArgs e)
        {
            string result = string.Format("Driver: {0}", answerDriver.Text);
            labelResult.Content = result;
            result = string.Format("Social Security: {0}", answerSecurity.Text);
            labelResult2.Content = result;
            result = string.Format("Phone: {0}", answerPhone.Text);
            labelResult3.Content = result;

            
        }
        // Instantiate Variables

        // Format Driver Info

        // Get Total Days

        // Get Days Off

        // Get Total Miles

        // Get Total Pay

        // Driver Ticket

    }
}

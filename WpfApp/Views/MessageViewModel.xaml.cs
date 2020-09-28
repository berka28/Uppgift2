using System;
using System.Collections.Generic;
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

namespace WpfApp.Views
{
    /// <summary>
    /// Interaction logic for MessageViewModel.xaml
    /// </summary>
    public partial class MessageViewModel : UserControl
    {
        public MessageViewModel()
        {
            InitializeComponent();
        }

        private void messageButton1_Click(object sender, RoutedEventArgs e)
        {
            
            from.Text = "CONTACT NAME";
            to.Text = "Mathias Bergquist";
            body.Text = "Meddelande";
        }

        private void messageButton2_Click(object sender, RoutedEventArgs e)
        {
            
            from.Text = "ABCd Data <ABCData@ABC.com>";
            to.Text = "Mathias Bergquist";
            body.Text = "Meddelande";
        }

        private void messageButton3_Click(object sender, RoutedEventArgs e)
        {
            
            from.Text = "ABCe Data <ABCData@ABC.com>";
            to.Text = "Mathias Bergquist";
            body.Text = "Meddelande";
        }

        private void messageButton4_Click(object sender, RoutedEventArgs e)
        {
            
            from.Text = "ABCk Data <ABCData@ABC.com>";
            to.Text = "Mathias Bergquist";
            body.Text = "Meddelande";
        }

        private void messageButton5_Click(object sender, RoutedEventArgs e)
        {
            
            from.Text = "ABCl Data <ABCData@ABC.com>";
            to.Text = "Mathias Bergquist";
            body.Text = "Meddelande";
        }

        private void messageButton6_Click(object sender, RoutedEventArgs e)
        {
            
            from.Text = "ABCn Data <ABCData@ABC.com>";
            to.Text = "Mathias Bergquist";
            body.Text = "Meddelande";
        }

        private void messagebutton7_Click(object sender, RoutedEventArgs e)
        {
            
            from.Text = "ABCi Data <ABCData@ABC.com>";
            to.Text = "Mathias Bergquist";
            body.Text = "Meddelande";
        }

        private void messageButton8_Click(object sender, RoutedEventArgs e)
        {
           
            from.Text = "ABCx Data <ABCData@ABC.com>";
            to.Text = "Mathias Bergquist";
            body.Text = "Meddelande";
        }
    }
}

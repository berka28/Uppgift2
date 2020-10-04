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
            
            from.Text = "From Contact Name";
            to.Text = "Mathias Bergquist";
            body.Text = "Hej! Hur står det till. Skriver endast lite text här nu. \nTack för mig. Ha det gott!";
        }

        private void messageButton2_Click(object sender, RoutedEventArgs e)
        {
            
            from.Text = "From Contact Name";
            to.Text = "Mathias Bergquist";
            body.Text = "Hej igen! Hur står det till. Skriver endast lite text här nu. \nTack för mig. Ha det gott!";
        }

        private void messageButton3_Click(object sender, RoutedEventArgs e)
        {
            
            from.Text = "From Contact Name";
            to.Text = "Mathias Bergquist";
            body.Text = "Hejsan! Hur står det till. Skriver endast lite text här nu. \nTack för mig. Ha det gott!";
        }

        private void messageButton4_Click(object sender, RoutedEventArgs e)
        {
            
            from.Text = "From Contact Name";
            to.Text = "Mathias Bergquist";
            body.Text = "Tjena! Hur står det till. Skriver endast lite text här nu. \nTack för mig. Ha det gott!";
        }

        private void messageButton5_Click(object sender, RoutedEventArgs e)
        {
            
            from.Text = "From Contact Name";
            to.Text = "Mathias Bergquist";
            body.Text = "Morsning! Hur står det till. Skriver endast lite text här nu. \nTack för mig. Ha det gott!";
        }

        private void messageButton6_Click(object sender, RoutedEventArgs e)
        {
            
            from.Text = "From Contact Name";
            to.Text = "Mathias Bergquist";
            body.Text = "Tjabba! Hur står det till. Skriver endast lite text här nu. \nTack för mig. Ha det gott!";
        }

        private void messagebutton7_Click(object sender, RoutedEventArgs e)
        {
            
            from.Text = "From Contact Name";
            to.Text = "To Mathias Bergquist";
            body.Text = "Halloj! Hur står det till. Skriver endast lite text här nu. \nTack för mig. Ha det gott!";
        }

        private void messageButton8_Click(object sender, RoutedEventArgs e)
        {
           
            from.Text = "Contact Name";
            to.Text = "To Mathias Bergquist";
            body.Text = "Hej! Hur står det till. Skriver endast lite text här nu. \nTack för mig. Ha det gott!";
        }
    }
}

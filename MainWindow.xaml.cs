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

namespace u2SebastianTXTMSG
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

        private void btnClick_Click(object sender, RoutedEventArgs e)
        {
            
            string TTYL = "TTYL";
            string Input = txtInput.Text;
            //MessageBox.Show(Input);
            string positionOfR = Input.Substring(Input.IndexOf("\r"));
           //MessageBox.Show(positionOfR.ToString());
            string Abreveation = Input.Substring(0, Input.IndexOf("\r"));
            MessageBox.Show(Input.ToString());
            
            //MessageBox.Show(Abreveation);
            //MessageBox.Show(Abreveation.Length.ToString());
            while (Input != TTYL)
            {
                if (Abreveation == "CU")
                {
                    lblOutput.Content = "see you";
                    
                }
                if (Abreveation == ":-)")
                {
                    lblOutput.Content = "I'm Happy";
                    MessageBox.Show("I'm Happy");
                }
                if (Abreveation == ":-(")
                {
                    lblOutput.Content = "I'm Sad";
                    MessageBox.Show("I'm Sad");
                }
                else
                {
                   // MessageBox.Show("no");
                }
            }
        }
    }
}

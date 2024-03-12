﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NarcissisticNumberCheck
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
            double dblNarcNum = 0;
            double dblCharNum = 0;

            //get input number from txtNumber
            string strInputNum = txtNumber.Text;

            //get the total number of digits to raise to that power
            int intNumDigits = strInputNum.Length;

            //split string into array to get invdividual digits
            char[] charDigits = strInputNum.ToCharArray();

            //raise each digit to the power of the total number of digits
            //of input number and add to total 
            foreach(var c in charDigits)
            {
                //dblNarcNum = Math.Pow(c, intNumDigits);
                dblCharNum = Char.GetNumericValue(c);
                dblNarcNum += Math.Pow(dblCharNum, intNumDigits);
            }

            //check if it is equal to original number
            if (dblNarcNum == Int32.Parse(strInputNum))
            {
                lblResult.Content = "This is a Narcissistic Number!";
            }
            else
            {
                lblResult.Content = "This is not a Narcissistic Number!";
            }
        }
    }
}
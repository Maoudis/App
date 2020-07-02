using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace app.UControls
{
    /// <summary>
    /// Interaction logic for INDENum.xaml
    /// </summary>
    public partial class INDENum : UserControl
    {



        public int minNum = 1;
        int currentInt = 0;
        public INDENum()
        {
            InitializeComponent();

            var currentIntString = this.DisplayNum.Text;
            currentInt = int.Parse(currentIntString);
        }

        private void IncreaseNum_Click(object sender, RoutedEventArgs e)
        {
            currentInt = currentInt + 1;
            this.DisplayNum.Text = currentInt.ToString();
        }

        private void DecreaseNum_Click(object sender, RoutedEventArgs e)
        {
            if (currentInt >= minNum)
            {
                currentInt = currentInt - 1;
                this.DisplayNum.Text = currentInt.ToString();
            }
            else
            {
                this.DisplayNum.Text = currentInt.ToString();
            }
        }
    }
}

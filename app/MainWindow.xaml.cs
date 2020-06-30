using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Drawing;
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

namespace app
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string currentDir;
        public MainWindow()
        {
            InitializeComponent();
            currentDir = GetCurrentDir();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            RaceDropdown_RaceChanged(this.RaceDropdown, null);
            ClassDropdown_ClassChanged(this.ClassDropdown, null);
            
        }

        
        private string GetCurrentDir()
        {
            string currentDir = Directory.GetCurrentDirectory();
            string ProjectFolder = Directory.GetParent(currentDir).Parent.Parent.FullName;
            return ProjectFolder;
        }
        
        private void RaceDropdown_RaceChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.RaceInfoDisplay == null)
                return;

            var combo = (ComboBox)sender;//Var Combo = (type of ComboBox)From the Sender of RaceDropdown_RaceChanged
            var value = (ComboBoxItem)combo.SelectedItem;//var value = (type of ComboBoxitem)the selected item of the comboBox
            string race = (string)value.Name;//Gets the name of the ComboBoxItem           
            string DisplatInfo = File.ReadAllText($@"{currentDir}\RaceClassInfo\Race\{race}.txt");
            this.RaceInfoDisplay.Text = (string)DisplatInfo;
        }

        private void ClassDropdown_ClassChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.ClassInfoDisplay == null)
                return;
            var combo = (ComboBox)sender;
            var value = (ComboBoxItem)combo.SelectedItem;
            string PlayerClass = (string)value.Name;
            string DisplayInfo = File.ReadAllText($@"{currentDir}\RaceClassInfo\Class\{PlayerClass}.txt");
            this.ClassInfoDisplay.Text = (string)DisplayInfo;
        }

        private void ClearNameButton_Click(object sender, RoutedEventArgs e)
        {
            this.NameTextBox.Text = "";
        }
        private void ClearAgeButton_Click(object sender, RoutedEventArgs e)
        {
            this.AgeTextBox.Text = "";
        }

 
        private void Farmer_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string name = button.Name;
            this.ProfessionInfoDisplay.Text = File.ReadAllText($@"{currentDir}\Professions\{name}.txt");
        }

        private void Doctor_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ShopKeeper_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Kight_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}


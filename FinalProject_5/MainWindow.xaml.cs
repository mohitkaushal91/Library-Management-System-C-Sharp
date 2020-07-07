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

namespace FinalProject_5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Main Window Function
        public MainWindow()
        {
            InitializeComponent(); // Don't Remove it. This function initilize components.
            Binddata(); // calls bind data function

            ImageBrush myBrush = new ImageBrush();

            myBrush.ImageSource = new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), "C:\\Users\\mmohitku\\Desktop\\C# Projects\\FinalProject_5\\FinalProject_5\\Resources\\library-bg-e.jpg"));

            this.Background = myBrush;
            /*
            ImageBrush myBrush = new ImageBrush();
            myBrush.ImageSource =
                new BitmapImage(new Uri("pack://application:,,,/library-bg.jpg", UriKind.Absolute));
            this.Background = myBrush;*/
        }

        // Bind data to gridview
        void Binddata()
        {
            namesgrid.ItemsSource = Library.librarymembers;
            booksgrid.ItemsSource = Library.media;
        }

        // Update data grid
        private void UpdateDataGrid()
        {
            // names grid update
            namesgrid.ItemsSource = null;
            namesgrid.ItemsSource = Library.librarymembers;
            // Books grid update
            booksgrid.ItemsSource = null;
            booksgrid.ItemsSource = Library.media;
        }

        //lend click function to lend any media to user
        private void Lend_Click(object sender, RoutedEventArgs e)
        {
            if((namesgrid.SelectedValue != null) && (booksgrid.SelectedValue != null))
            {
                LibraryMember lm = (LibraryMember)(namesgrid.SelectedItem);
                Media m = (Media)(booksgrid.SelectedItem);

                if(m.BorrowerName == "")
                {
                    m.BorrowerName = lm.Name;
                    m.isAvailable = false;
                    UpdateDataGrid();
                    MessageBox.Show("You have successfully Lented this Media to " + lm.Name + "!", "Success", MessageBoxButton.OK, MessageBoxImage.Information); // Display Message
                }
                else
                {
                    string name = m.BorrowerName;
                    MessageBox.Show("This Media is already Lented by " + name + "!", "Error", MessageBoxButton.OK, MessageBoxImage.Error); // Display Message
                }
            }
            else
            {
                MessageBox.Show("Invalid Selection! Please select both Media and Member from List.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning); // Display Message
            }
        }

        // Return click function to return media which is lented
        private void Return_Click(object sender, RoutedEventArgs e)
        {
            if (booksgrid.SelectedValue != null)
            {
                //LibraryMember lm = (LibraryMember)(namesgrid.SelectedItem);
                Media m = (Media)(booksgrid.SelectedItem);

                if (m.BorrowerName != "")
                {
                    m.BorrowerName = "";
                    m.isAvailable = true;
                    UpdateDataGrid();
                    MessageBox.Show("You have successfully Returned this Media.", "Success", MessageBoxButton.OK, MessageBoxImage.Information); // Display Message
                }
                else
                {
                    MessageBox.Show("This Media is not Lented. You can only return Lented Media!", "Error", MessageBoxButton.OK, MessageBoxImage.Error); // Display Message
                }
            }
            else
            {
                MessageBox.Show("Invalid Selection! Please select valid Media from List.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning); // Display Message
            }
        }
    }
}

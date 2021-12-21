using System.Windows;

namespace WpfApplication12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            
            // listView.Items.Add(new string[] = {"11", "Hideru"}); // get rid of "="
            listView.Items.Add(new string[] {"11", "Hideru"});
            listView.Items.Add(new string[] {"12", "Seiko"});
        }

        private void BtClick(object sender, RoutedEventArgs e)
        {
            var window = new Window1();
            window.Show();
        } 
    }
}
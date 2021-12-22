using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace WpfApplication12
{
    public partial class Window2 : Window
    {
        // If adding and changing some data of the list on the App, use "ObservableCollection<> Hoge
        private ObservableCollection<Person> People { get; set; }
        
        public Window2()
        {
            InitializeComponent();

            this.People = new ObservableCollection<Person>();
            listView.DataContext = this.People;
        }

        private void AddBtClick(object sender, RoutedEventArgs e)
        {
            int random = new Random().Next(100, 1000); // 100-999
            this.People.Add(new Person { ID = random, Name = $"User-{random}"});
        }
    }
}
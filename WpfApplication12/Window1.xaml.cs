using System.Collections.Generic;
using System.Windows;

namespace WpfApplication12
{
    public partial class Window1 : Window
    {
        // private List<Person> People { get; set; }
        // private List<Person> Persons { get; set; }
        List<Person> People { get; set; }
        
        public Window1()
        {
            InitializeComponent();

            this.People = new List<Person>();
            this.People.Add(new Person{ ID = 32, Name = "Miyon" });
            this.People.Add(new Person{ ID = 43, Name = "Reina" });
            listView.DataContext = this.People;
        }
        
    }
}
using OtherBindingOpdracht.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace OtherBindingOpdracht
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page, INotifyPropertyChanged
    {
        private ObservableCollection<Person> _ocPersonCollection = new ObservableCollection<Person>();
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private Person _Person = new Person();

        public Person MyPerson
        {
            get { return _Person; }
            set { _Person = value; NotifyPropertyChanged(); }
        }

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Toevoegen_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(MyPerson.Title) && !String.IsNullOrWhiteSpace(MyPerson.Auteur) && !String.IsNullOrWhiteSpace(MyPerson.Aantal.ToString()) && !String.IsNullOrWhiteSpace(MyPerson.Beschrijving))
            {
                _ocPersonCollection.Add(MyPerson);
                MyPerson = new Person();
            }
        }
        private void Verwijder_Click(object sender, RoutedEventArgs e)
        {
            _ocPersonCollection.Remove((Person)((Button)sender).DataContext);
        }
    }
}

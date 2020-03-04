using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherBindingOpdracht.Classes
{
    public sealed partial class Person
    {
        private string _title;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        private string _auteur;

        public string Auteur
        {
            get { return _auteur; }
            set { _auteur = value; }
        }
        private int _aantal;

        public int Aantal
        {
            get { return _aantal; }
            set { _aantal = value; }
        }

        private string _beschrijving;

        public string Beschrijving
        {
            get { return _beschrijving; }
            set { _beschrijving = value; }
        }

        public Person()
        {
        }

    }
}

using Contact_App.Model;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contact_App.ViewModel
{
    class ContactListVM : ViewModelBase
    {
        private string text;
        private double _value = 10;

        public List<Contact> Contacts { get; set; }

        public string Text { get => text; set => Set(ref text, value); }
        public double Value { get => _value; set => Set(ref _value, value); } 

        public ContactListVM()
        {
            Contacts = new List<Contact>();
            Contacts.Add(new Contact()
            {
                Name = "Israfil",
                Phone = "9932131",
                Favorite = true,
                Position = "Boss"
            });
            Contacts.Add(new Contact()
            {
                Name = "Aftandil",
                Phone = "91321131",
                Favorite = false,
                Position = "Employee"
            });
            Contacts.Add(new Contact()
            {
                Name = "Gulchohre",
                Phone = "123213123",
                Favorite = true,
                Position = "Contracter"
            });
        }
    }
}

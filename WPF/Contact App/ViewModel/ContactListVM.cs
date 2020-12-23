using Contact_App.Model;
using Contact_App.Services;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Contact_App.ViewModel
{
    class ContactListVM : ViewModelBase
    {
        private string text;
        private double _value = 10;
        private ObservableCollection<Contact> contacts;

        public ObservableCollection<Contact> Contacts { get => contacts; set => Set(ref contacts, value); }

        public string Text { get => text; set => Set(ref text, value); }
        public double Value { get => _value; set => Set(ref _value, value); }

        public ContactListVM(IStorage<Contact> storage)
        {
            Contacts = storage.GetAll();
        }
    }
}

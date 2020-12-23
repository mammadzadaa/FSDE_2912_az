using Contact_App.Messaging;
using Contact_App.Model;
using Contact_App.Services;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contact_App.ViewModel
{
    class AddCOntactsVM : ViewModelBase
    {
        private string fullName;
        private string phone;
        private string email;
        private string bio;
        private RelayCommand addCommand;
        private Messenger messenger;
        private IStorage<Contact> storage;

        public string FullName { get => fullName; set => Set(ref fullName, value); }
        public string Phone { get => phone; set => Set(ref phone, value); }
        public string Email { get => email; set => Set(ref email, value); }
        public string Bio { get => bio; set => Set(ref bio, value); }
        

        public AddCOntactsVM(IStorage<Contact> storage, Messenger messenger)
        {
            this.messenger = messenger;
            this.storage = storage;
        }

        public RelayCommand AddCommand => addCommand ?? (addCommand = new RelayCommand(() =>
             {

                 messenger.Send(new VMChange() { ViewModel = App.Container.GetInstance<ContactListVM>() });
                 storage.Add(new Contact()
                 {
                     Bio = Bio,
                     FullName = FullName,
                     Email = Email,
                     Phone = Phone
                 });
             }));
    }
}

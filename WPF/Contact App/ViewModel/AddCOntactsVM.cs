using Contact_App.Messaging;
using Contact_App.Model;
using Contact_App.Services;
using Contact_App.Validation;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Contact_App.ViewModel
{
    class AddCOntactsVM : ViewModelBase, IDataErrorInfo
    {
        private string fullName;
        private string phone;
        private string email;
        private string bio;
        private RelayCommand addCommand;
        private Messenger messenger;
        private IStorage<Contact> storage;
        private string photo;
        private RelayCommand cancelCommand;

        public string FullName { get => fullName; set => Set(ref fullName, value); }
        public string Photo { get => photo; set => Set(ref photo, value); }
        public string Phone { get => phone; set => Set(ref phone, value); }
        public string Email { get => email; set => Set(ref email, value); }
        public string Bio { get => bio; set => Set(ref bio, value); }


        public AddCOntactsVM(IStorage<Contact> storage, Messenger messenger)
        {
            this.messenger = messenger;
            this.storage = storage;
        }

        public RelayCommand CancelCommand => cancelCommand ?? (cancelCommand = new RelayCommand(() =>
             {
                 messenger.Send(new VMChange() { ViewModel = App.Container.GetInstance<ContactListVM>() });

             }));

        public RelayCommand AddCommand => addCommand ?? (addCommand = new RelayCommand(() =>
             {

                 messenger.Send(new VMChange() { ViewModel = App.Container.GetInstance<ContactListVM>() });
                 storage.Add(new Contact()
                 {
                     Bio = Bio,
                     FullName = FullName,
                     Email = Email,
                     Phone = Phone,
                     Photo = Photo
                 });
             }));

        public string Error => throw new NotImplementedException();

        public string this[string columnName]
        {
            get
            {
                var validator = new AddContactValidator();
                var result = validator.Validate(this);

                if (!result.IsValid)
                {
                    var error = result.Errors.FirstOrDefault(x => x.PropertyName.Contains(columnName));
                    if (error != null)
                        return error.ErrorMessage;
                }
                return string.Empty;
            }
        }
    }
}

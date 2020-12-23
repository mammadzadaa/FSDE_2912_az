using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Contact_App.Services
{
    interface IStorage<T>
    {
        void Add(T value);
        ObservableCollection<T> GetAll();
    }
}

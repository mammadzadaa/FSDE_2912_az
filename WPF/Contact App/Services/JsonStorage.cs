using Contact_App.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;

namespace Contact_App.Services
{
    class JsonStorage : IStorage<Contact>
    {
        public ObservableCollection<Contact> contacts { get; set; }
        private string path = "contacts.json";
        public JsonStorage()
        {
            contacts = new ObservableCollection<Contact>();
        }

        public void Add(Contact value)
        {
            if (value != null)
            {
                contacts.Add(value);
            }
            WriteFile();
        }

        public ObservableCollection<Contact> GetAll()
        {
            ReadFile();
            return contacts;
        }

        private void WriteFile()
        {
            File.WriteAllText(path, JsonConvert.SerializeObject(contacts));
        }
        private void ReadFile()
        {
            contacts = JsonConvert.DeserializeObject<ObservableCollection<Contact>>(File.ReadAllText(path));
        }
    }
}

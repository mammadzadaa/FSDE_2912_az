using System;
using System.Security.Permissions;

namespace Bridge
{
    [Serializable]
    public class Contact
    {
        public string Name { get; set; }
        public string Number { get; set; }
    }
}

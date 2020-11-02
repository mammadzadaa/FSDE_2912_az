namespace Bridge
{
    public class ContactList : Storage<Contact>
    {
        public ContactList(ISaveLoad<Contact> saveLoad) : base(saveLoad) { }
    }
}

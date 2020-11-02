namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            var toDoList = new ToDoList(new XmlSaveLoad<ToDo>());
            toDoList.Add(new ToDo() { Task = "Wash your hands", IsDone = true });
            toDoList.Add(new ToDo() { Task = "Wash your teeth", IsDone = false });
            toDoList.Add(new ToDo() { Task = "Wash your dishes", IsDone = false });
            toDoList.Save("todo.xml");

            var contactList = new ContactList(new JsonSaveLoad<Contact>());
            contactList.Add(new Contact() { Name = "Aftandil", Number = "+99455555555" });
            contactList.Add(new Contact() { Name = "Israfil", Number = "+99455325545" });
            contactList.Add(new Contact() { Name = "Qudret", Number = "+99454340000" });
            contactList.Save("contacts.json");

        }
    }
}

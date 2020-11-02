namespace Bridge
{
        public class ToDoList : Storage<ToDo>
        {
            public ToDoList(ISaveLoad<ToDo> saveLoad) : base(saveLoad) { }
        }
    
}

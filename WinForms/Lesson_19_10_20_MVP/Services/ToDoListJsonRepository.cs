using Lesson_19_10_20_MVP.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_19_10_20_MVP.Services
{
    public class ToDoListJsonRepository : IToDoListRepository
    {
        private string fileName = "data.json";
        public void AddTask(ToDo task)
        {
            var list = Read();
            list.Add(task);
            Write(list);
        }

        public IEnumerable<ToDo> GetAllTasks()
        {
            return Read();
        }

        public void RemoveTask(string id)
        {
            var list = Read();
            list.RemoveAll(x => x.Id == id);
            Write(list);
        }

        private List<ToDo> Read()
        {
            if (File.Exists(fileName))
            {
               return JsonConvert.DeserializeObject<List<ToDo>>(File.ReadAllText(fileName));
            }
            return new List<ToDo>();
        }

        private void Write(List<ToDo> list)
        {
            File.WriteAllText(fileName,JsonConvert.SerializeObject(list));
        }

    }
}

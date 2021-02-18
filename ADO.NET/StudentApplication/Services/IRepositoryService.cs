using StudentApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApplication.Services
{
    interface IRepositoryService
    {
        IEnumerable<Student> GetAllStudents();
        int AddStudent(Student student);
        void UpdateStudent(Student student);
        void DeleteStudent(int id);
        Student FindStudent(int id);
    }
}

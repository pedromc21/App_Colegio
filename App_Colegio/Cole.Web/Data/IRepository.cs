using Cole.Web.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cole.Web.Data
{
    public interface IRepository
    {
        void AddStudent(Student student);
        Student GetStudent(int id);
        IEnumerable<Student> GetStudents();
        void RemoveStudent(Student student);
        Task<bool> SaveAllAsync();
        bool StudentExists(string matricula);
        void UpdateStudent(Student student);
    }
}
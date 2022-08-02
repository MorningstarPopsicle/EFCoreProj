using EFCore;

namespace Repo
{
    public class RepositoryClass
    {
        private readonly ApplicationContext _context =  new ApplicationContext();

        public void CreateStudent (Student student)
        {
           _context.Students.Add(student);
           _context.SaveChanges();
        }

        public Student GetById (int id , string email)
        {
            
          var student = _context.Students.FirstOrDefault(a => a.Id == id || a.Email == email);
          return student;
          
        }
        public IList<Student> GetAll ()
        {
            return _context.Students.ToList();
        }
        public IList<Student> GetBymail (string email)
        {
            return _context.Students.Where(a => a.Email == email).ToList();
        } 

        public void Delete(int id)
        {
            var student = _context.Students.Find(id);
            _context.Students.Remove(student);
            _context.SaveChanges();
        }
        public void Update (Student student)
        {
      
            var studentInfo = _context.Students.Find(student.Id);
            if(studentInfo == null)
            {
                return;
            }
            studentInfo.FirstName = student.FirstName ?? studentInfo.FirstName;
            
            _context.Students.Update(studentInfo);
            _context.SaveChanges();
            
        }
    
    }
}

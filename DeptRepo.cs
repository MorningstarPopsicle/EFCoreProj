using EFCore;

namespace Repo
{
     public class DeptRepositoryClass
    {
        private readonly ApplicationContext _context =  new ApplicationContext();

        public Department CreateDept (Department department)
        {
           _context.Departments.Add(department);
           _context.SaveChanges();
           return department;
        }

        public Department GetById (int id )
        {
            
          var department = _context.Departments.FirstOrDefault(a => a.Id == id);
          return department;
          
        }
        public IList<Department> GetAll ()
        {
            return _context.Departments.ToList();
        }
     

        public void Delete(int id)
        {
            var department = _context.Departments.Find(id);
            _context.Departments.Remove(department);
            _context.SaveChanges();
        }
        public void Update (Department department)
        {
      
            var deptInfo = _context.Departments.Find(department.Id);
            if(deptInfo == null)
            {
                return;
            }
            deptInfo.Name = department.Name ?? deptInfo.Name;
            _context.Departments.Update(deptInfo);
            _context.SaveChanges();
            
        }
    }
}
using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Repo;

namespace EFCore
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            var dept = new DeptRepositoryClass();
                var std = new RepositoryClass();
                Console.WriteLine(std.GetById(1,"bola@gmail.com").FirstName);
                // var deptInfo = dept.GetAll();
                // foreach(var item in deptInfo)
                // {
                //     Console.WriteLine(item.Name);
                // }
            //dept.CreateDept(new Department(1,"Law" , "asdfghjk"));
        
            std.Update(new Student{
                FirstName = "shade",
                LastName = "Kola",
                Email = "bola@gmail.com",
                DepartmentId = 1,
                Id = 1

            });
        }
    }
   
  
    
    
}
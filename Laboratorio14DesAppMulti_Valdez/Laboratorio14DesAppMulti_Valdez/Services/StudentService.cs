using System;
using System.Collections.Generic;
using System.Text;
using Laboratorio14DesAppMulti_Valdez.DataContext;
using Laboratorio14DesAppMulti_Valdez.Models;
using System.Linq;


namespace Laboratorio14DesAppMulti_Valdez.Services
{
    public class StudentService
    {
        private readonly AppDbContext _context;

        public StudentService() => _context = App.GetContext();

        public bool Create(Student item)
        {
            try
            {
                _context.Students.Add(item);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool CreateRange(List<Student> items)
        {
            try
            {
                _context.Students.AddRange(items);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public List<Student> Get()
        {
            return _context.Students.ToList();
        }


        public List<Student> GetByText(string text)
        {
            return _context.Students.Where(x => x.Name.Contains(text) || x.DNI.Contains(text)).ToList();
        }

        public Student GetById(int id)
        {
            return _context.Students.Where(x => x.StudentId == id).FirstOrDefault();
        }
    }
}

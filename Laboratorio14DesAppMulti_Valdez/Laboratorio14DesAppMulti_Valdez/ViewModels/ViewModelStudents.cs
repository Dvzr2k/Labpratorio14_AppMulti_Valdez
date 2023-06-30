using System;
using System.Collections.Generic;
using System.Text;
using Laboratorio14DesAppMulti_Valdez.Models;
using Laboratorio14DesAppMulti_Valdez.Services;
using System.Windows.Input;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace Laboratorio14DesAppMulti_Valdez.ViewModels
{
    public class ViewModelStudents: BaseViewModel
    {
        private string name;
        public String Name
        {
            get { return name; }
            set { SetValue(ref this.name, value); }
        }

        private string dni;
        public string DNI
        {
            get { return dni; }
            set { SetValue(ref this.dni, value); }
        }

        private int studentId;

        public int StudentId
        {
            get { return studentId; }
            set { SetValue(ref this.studentId, value); }
        }

        private decimal price;
        public decimal Price
        {
            get { return price; }
            set { SetValue(ref this.price, value); }
        }

        private DateTime fechaNacimiento;
        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { SetValue(ref this.fechaNacimiento, value); }

        }
        private List<Student> students;
        public List<Student> Students
        {
            get { return this.students; }
            set { SetValue(ref this.students, value); }
        }

        private Student student;
        public Student Student
        {
            get { return this.student; }
            set { SetValue(ref this.student, value); }
        }
        public ICommand SearchCommand { get; set; }
        public ICommand InsertCommand { get; set; }

        public ICommand SelectOneCommand { get; set; }


        public ViewModelStudents()
        {
            StudentService service = new StudentService();
            Students = service.Get();

            SearchCommand = new Command(() =>
            {
                StudentService service = new StudentService();
                Students = service.Get();
            });

            InsertCommand = new Command(() =>
            {
                StudentService service = new StudentService();
                if (StudentId != 0)
                {
                    Console.WriteLine(StudentId);

                    Name = "";
                    DNI = "";
                    StudentId = 0;
                }
                else
                {
                    int newStudentId = service.Get().Count + 1;
                    service.Create(new Student { Name = Name, DNI = DNI, StudentId = newStudentId });
                    Name = "";
                    DNI = "";
                }
                Students = service.Get();
            });

            SelectOneCommand = new Command<int>(execute: (int parameter) =>
            {
                StudentService service = new StudentService();
                int ide = parameter;
                Student = service.GetById(ide);
                Name = Student.Name;
                DNI = Student.DNI;
                StudentId = Student.StudentId;

                Console.WriteLine(StudentId);
            });


        }
    }
}

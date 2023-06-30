using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Laboratorio14DesAppMulti_Valdez.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string DNI{ get; set; }
        public decimal Precio { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}

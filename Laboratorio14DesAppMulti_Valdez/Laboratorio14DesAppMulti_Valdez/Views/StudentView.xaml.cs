using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laboratorio14DesAppMulti_Valdez.Models;
using Laboratorio14DesAppMulti_Valdez.ViewModels;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Laboratorio14DesAppMulti_Valdez.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StudentView : ContentPage
    {
        public StudentView()
        {
            InitializeComponent();
            this.BindingContext = new ViewModelStudents();
        }
    }
}
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Laboratorio14DesAppMulti_Valdez.DataContext;
using Laboratorio14DesAppMulti_Valdez.Interfaces;

namespace Laboratorio14DesAppMulti_Valdez
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            GetContext().Database.EnsureCreated();
            MainPage = new MainPage();
        }
        public static AppDbContext GetContext()
        {
            string DbPath = DependencyService.Get<IConfigDataBase>().GetFullPath("efCore.db");

            return new AppDbContext(DbPath);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

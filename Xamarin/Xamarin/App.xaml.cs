using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Xamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new Home();
            MainPage = new ResultPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
        static LocationItemDatabase database;

        public static LocationItemDatabase Database
        {
            get
            {
                if (database == null)
                {
                    String ss = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                    String s = Path.Combine(ss, "LocationSQLite.db4");
                    database = new LocationItemDatabase(s);
                }
                return database;
            }
        }
    }
}

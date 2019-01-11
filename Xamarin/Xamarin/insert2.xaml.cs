using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class insert2 : ContentPage
    {
        //public int[] M;
        //public string[] K;
        //public Button kk;
        //public char abc;
        public insert2()
        {
            InitializeComponent();
            a();
            /*OnAppearing();
            T1.Clicked += T1Clicked;
            T2.Clicked += T2Clicked;
            T3.Clicked += T3Clicked;
            T4.Clicked += T4Clicked;
            T5.Clicked += T5Clicked;
            T6.Clicked += T6Clicked;
            T7.Clicked += T7Clicked;
            T8.Clicked += T8Clicked;
            T9.Clicked += T9Clicked;
            */
            //kk.Clicked += kkCli;
        }

        //private void kkCli(object sender, EventArgs e)
        //{
           
        //}

        public async void a()
        //protected override async void OnAppearing()
        {
            base.OnAppearing();
            var result = await App.Database1.GetItemsAsync();

            int size = result.Count;

            var lay2 = new StackLayout() { Spacing = 10 };

            //int[] m = new int[size];
            //string[] k = new string[size];
            //int x = 0;
            //var lay3 = new StackLayout();
            //lay3.Children.Add(new Button() { Text = "location.Iname" });
            //lay2.Children.Add(lay3);
            foreach (var location in result)
            {

                var lay3 = new StackLayout();
                //this.kk = new Button() { Text = location.Iname };
                lay3.Children.Add(new Button() {  Text = location.Iname });
                //lay3.Children.Add(new Label() { Text =  location.Iname });

                //location.Tmoney = m[x];
                //location.Iname = k[x];
                //m[x] = location.Tmoney;
                //k[x] = location.Iname;
                //this.M[0] = location.Tmoney;
                //this.K[0] = location.Iname;
                //x++;


                //T1.Text = location.Iname;
                //T2.Text = K[1];
                //T3.Text = K[2];

                lay2.Children.Add(lay3);
                //layout.Children.Add(lay3);
            }

            layout.Children.Add(lay2);
        }

       /* private void T1Clicked(object sender, EventArgs e)
        {
           
        }

        private void T2Clicked(object sender, EventArgs e)
        {
           
        }

        private void T3Clicked(object sender, EventArgs e)
        {
            
        }

        private void T4Clicked(object sender, EventArgs e)
        {
            
        }

        private void T5Clicked(object sender, EventArgs e)
        {
          
        }

        private void T6Clicked(object sender, EventArgs e)
        {
            
        }

        private void T7Clicked(object sender, EventArgs e)
        {
           
        }

        private void T8Clicked(object sender, EventArgs e)
        {
           
        }

        private void T9Clicked(object sender, EventArgs e)
        {
            
        }
        */
    }
}
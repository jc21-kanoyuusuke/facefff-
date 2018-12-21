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
        public int[] M;
        public string[] K;

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            var result = await App.Database1.GetItemsAsync();

            int size = result.Count;

            int[] m = new int[size];
            string[] k = new string[size];
            int x = 0;
            foreach (var location in result)
            {
                var lay = new StackLayout();
                location.Tmoney = m[x];
                location.Iname = k[x];
                this.M[x] = m[x];
                this.K[x] = k[x];
                x++;
            }
        }

        public insert2()
        {
            InitializeComponent();
            T1.Clicked += T1Clicked;
            T2.Clicked += T2Clicked;
            T3.Clicked += T3Clicked;
            T4.Clicked += T4Clicked;
            T5.Clicked += T5Clicked;
            T6.Clicked += T6Clicked;
            T7.Clicked += T7Clicked;
            T8.Clicked += T8Clicked;
            T9.Clicked += T9Clicked;

            //if ()
            //{
                //T1.Text = K[0];
            //}
        }

        private void T1Clicked(object sender, EventArgs e)
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
    }
}
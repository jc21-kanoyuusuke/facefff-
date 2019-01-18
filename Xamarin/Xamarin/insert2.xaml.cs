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
        
        public String dd;
        public String[] In;
        public int[] Tm;
        public int x = 0;
        //public static List<DateTime> dTime = new List<DateTime>();
        
        public insert2()//List<DateTime> dTime)
        {
            InitializeComponent();
            //ddd.Text = dTime[0].ToString("日付：yyyy年MM月dd日");
            //dd = dTime[0].ToString("yyyy/MM/dd");
            a();
           
        }

        public async void a()
        //protected override async void OnAppearing()
        {
            base.OnAppearing();
            var result = await App.Database1.GetItemsAsync();

            int size = result.Count;
            var lay2 = new StackLayout() { Spacing = 10 };
           // Button lay5 = new Button();


            foreach (var location in result)
            {
                
                string LT = location.Tmoney.ToString();
                var lay3 = new StackLayout();
               
                //Button lay3 = new Button() { Text = LT + " (" + location.Iname + ")" };

                //Button button1 = new Button();
                lay3.Children.Add(new Button() { Text = LT + " (" + location.Iname + ")" });

               //In[x] = location.Iname;
               //Tm[x] = location.Tmoney;
               //x++;
                //x = location.ID;
                lay2.Children.Add(lay3);
                //lay5 = lay3;
            }

            layout.Children.Add(lay2);
            //lay5.Clicked += lay5Clicked;
        }

       /* private void lay5Clicked(object sender, EventArgs e)
        {
            
            DateTime dt1 = DateTime.Parse(dd);
            LocationItem item = new LocationItem()
            {
                Name = In[x],
                Spay = Tm[x],
                Day = dt1
            };
            Save(item);
        }

        public async void Save(LocationItem item1)
        {
            await App.Database.SaveItemAsync(item1);
            await DisplayAlert("DATA", "登録しました","OK");
        }
        */
        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace StockAnalysis
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            var companys = new List<Company>()
            {
                new Company
                {
                    ID=1,name="company 1"
                },
                 new Company
                {
                    ID=2,name="company 2"
                },
                  new Company
                {
                    ID=3,name="company 3"
                },
                   new Company
                {
                    ID=4,name="company 4"
                },
            };

            companysListView.ItemsSource = companys;
        }

        private async void Company_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var company = e.Item as Company;

            await DisplayAlert("Company tapped", "Company" + company.name, "ok");
        }

    }
}

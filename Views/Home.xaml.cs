using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Tarea2._1.Models;

namespace Tarea2._1.Views
{
    public partial class Home : ContentPage
    {
        public ObservableCollection<Country> Countries { get; set; }

        public Home()
        {
            InitializeComponent();
            Countries = new ObservableCollection<Country>();
            LoadDataAsyn();
        }

        public async void LoadDataAsyn()
        {
            await LoadDataAsync();
        }

        private async Task LoadDataAsync()
        {
            var countries = await Controller.ControllerCountry.GetCounties();

            if (countries != null)
            {
                foreach (var country in countries)
                {
                    countries.Add(country);
                }
            }
            else
            {
                // Manejar la situación donde no se pudieron obtener los datos de la API
            }

            ListCountries.ItemsSource = countries;
        }
    }
}

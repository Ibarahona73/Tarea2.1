using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Tarea2._1.Models;

namespace Tarea2._1.Views
{
    public partial class Home : ContentPage
    {
        private Controller.ControllerCountry controllerCountry = new Controller.ControllerCountry();

        private ObservableCollection<Country> Country { get; set; }

        public Home()
        {
            InitializeComponent();
            Country = new ObservableCollection<Country>();
            LoadAsyncs();
        }

        public async void LoadAsyncs()
        {
            await LoadDataAsync();
        }

        private async Task LoadDataAsync()
        {
            try
            {
                var countries = await Controller.ControllerCountry.GetCounties();

                if (countries != null)
                {
                    foreach (var country in countries)
                    {
                        Country.Add(country);
                    }

                    ListCountries.ItemsSource = countries;
                }
                else
                {
                    await DisplayAlert("Error", "No se pudieron cargar los países.", "OK");
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"Se produjo un error al cargar los países: {ex.Message}", "OK");
            }
        }
    }
}
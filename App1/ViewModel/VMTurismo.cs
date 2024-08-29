using App1.Model.Turismo;
using App1.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace App1.ViewModel
{
    public class VMTurismo : INotifyPropertyChanged
    {
        private readonly TurismoService _turismoService;
        private List<MTurismoFormGoogle> _turismoData;

        public VMTurismo()
        {
            _turismoService = new TurismoService();
            LoadDataAsync();
        }
        public List<MTurismoFormGoogle> TurismoData
        {
            get => _turismoData;
            set
            {
                _turismoData = value;
                OnPropertyChanged();
            }
        }
        private async void LoadDataAsync()
        {
            try
            {
                string apiUrl = "https://docs.google.com/spreadsheets/d/1_uX3ie6XfA9gYEUNQ-LJiJsd7mhWDevC115WcrHfWhQ/pub?gid=230971620&single=true&output=csv"; // Reemplaza con la URL de tu API
                TurismoData = await _turismoService.GetDataFromApi(apiUrl);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cargar los datos: {ex.Message}");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

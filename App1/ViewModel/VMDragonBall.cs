using App1.Model.RIAS;
using App1.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace App1.ViewModel
{
    public class VMDragonBall:INotifyPropertyChanged
    {
        private readonly ApiServicio _apiServicio;
        private ObservableCollection<MDragonBall> _Personas;
        public VMDragonBall()
        {
            _apiServicio = new ApiServicio();
            Personas = new ObservableCollection<MDragonBall>();
            LoadItemsAsync();
        }

        public ObservableCollection<MDragonBall> Personas
        {
            get => _Personas;
            set
            {
                _Personas = value;
                OnPropertyChanged();
            }
        }

        public async Task LoadItemsAsync()
        {
            var items = await _apiServicio.GetGuerrerosZAsync();
            Personas = new ObservableCollection<MDragonBall>(items);
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using LabEXAM.Model;
using LabEXAM.APIs;

namespace LabEXAM.ViewModel
{
    class ProductListPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        
        public ObservableCollection<Product> Products { get; set; }
        
        APIservice api;

        public ProductListPageViewModel()
        {
            Products = new ObservableCollection<Product>();
            api = new APIservice();
            LoadData();

            
        }

        async void LoadData()
        {

            var prod = await api.GetProducts();

            foreach(var p in prod)
            {
                Products.Add(p);
            }
        }
    }
}

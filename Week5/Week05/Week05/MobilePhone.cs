using Microsoft.UI.Xaml.Media.Imaging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week05
{
    public class MobilePhone : INotifyPropertyChanged
    {
        private string _name;
        private string _image;
        private string _manufacturer;
        private double _price;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
            }
        }
        public String Image
        {
            get => _image;
            set
            {
                _image = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Image)));
            }
        }
        public string Manufacturer
        {
            get => _manufacturer;
            set
            {
                _manufacturer = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Manufacturer)));
            }
        }
        public double Price
        {
            get => _price;
            set
            {
                _price = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Price)));
            }
        }
    }
}

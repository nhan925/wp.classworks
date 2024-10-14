using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Week05
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ViewPage : Page
    {
        public class ViewPageViewModel
        {
            public List<MobilePhone> MobilePhones { get; set; }

            public void Init()
            {
                MobilePhones = new List<MobilePhone>()
                {
                    new MobilePhone()
                    {
                        Name = "iPhone 12",
                        Image = "Assets/phone.png",
                        Manufacturer = "Apple",
                        Price = 799.99
                    },
                    new MobilePhone()
                    {
                        Name = "Galaxy S21",
                        Image = "Assets/phone.png",
                        Manufacturer = "Samsung",
                        Price = 699.99
                    },
                    new MobilePhone()
                    {
                        Name = "Pixel 5",
                        Image = "Assets/phone.png",
                        Manufacturer = "Google",
                        Price = 699.99
                    },
                    new MobilePhone()
                    {
                        Name = "OnePlus 9",
                        Image = "Assets/phone.png",
                        Manufacturer = "OnePlus",
                        Price = 729.99
                    },
                    new MobilePhone()
                    {
                        Name = "Xperia 1 II",
                        Image = "Assets/phone.png",
                        Manufacturer = "Sony",
                        Price = 1199.99
                    },
                    new MobilePhone()
                    {
                        Name = "Mi 11",
                        Image = "Assets/phone.png",
                        Manufacturer = "Xiaomi",
                        Price = 749.99
                    },
                    new MobilePhone()
                    {
                        Name = "Mate 40 Pro",
                        Image = "Assets/phone.png",
                        Manufacturer = "Huawei",
                        Price = 1199.99
                    },
                    new MobilePhone()
                    {
                        Name = "V60 ThinQ",
                        Image = "Assets/phone.png",
                        Manufacturer = "LG",
                        Price = 799.99
                    },
                    new MobilePhone()
                    {
                        Name = "Zenfone 7",
                        Image = "Assets/phone.png",
                        Manufacturer = "Asus",
                        Price = 749.99
                    },
                    new MobilePhone()
                    {
                        Name = "Find X3 Pro",
                        Image = "Assets/phone.png",
                        Manufacturer = "Oppo",
                        Price = 1149.99
                    },
                };
            }
        }

        public ViewPageViewModel ViewModel { get; set; }

        public ViewPage()
        {
            this.InitializeComponent();
            ViewModel = new ViewPageViewModel();
            ViewModel.Init();
        }
    }
}

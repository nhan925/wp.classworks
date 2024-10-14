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

namespace Week4
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }

        private void firstBtn_Click(object sender, RoutedEventArgs e)
        {
            var window = new BlankWindow1();
            window.Activate();
            this.Close();
        }

        private void secondBtn_Click(object sender, RoutedEventArgs e)
        {
            var window = new BlankWindow2();
            window.Activate();
            this.Close();
        }

        private void thirdBtn_Click(object sender, RoutedEventArgs e)
        {
            var window = new BlankWindow3();
            window.Activate();
            this.Close();
        }

        private void fourthBtn_Click(object sender, RoutedEventArgs e)
        {
            var window = new BlankWindow4();
            window.Activate();
            this.Close();
        }
    }
}

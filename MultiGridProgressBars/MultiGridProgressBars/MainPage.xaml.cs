using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using MultiGridProgressBars.Models;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MultiGridProgressBars
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public ObservableCollection<ViewModel> MyData { get; set; } = new ObservableCollection<ViewModel>();
        public bool IsLoaded { get; set; }
        public MainPage()
        {
            this.InitializeComponent();
            this.DataContext = this;
        }

        private async Task GetData()
        {
            await Task.Delay(TimeSpan.FromSeconds(2));
            MyData.Add(new ViewModel { Name = "Item 1" });
            MyData.Add(new ViewModel { Name = "Item 2" });
            MyData.Add(new ViewModel { Name = "Item 3" });
            MyData.Add(new ViewModel { Name = "Item 4" });
            MyData.Add(new ViewModel { Name = "Item 5" });
            MyData.Add(new ViewModel { Name = "Item 6" });
            MyData.Add(new ViewModel { Name = "Item 7" });
            IsLoaded = true;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            GetData();
        }
    }
}

using DataTemplateSelectorSample.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DataTemplateSelectorSample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            List<Customer> list = new List<Customer>();
            for (int i = 0; i < 20; i++)
            {
                Customer newCustomer = new Customer();
                if (i ==12)
                {
                    newCustomer.Id = "VipCustomer";
                }
                else
                {
                    newCustomer.Id = "CustomerId" + i;
                }
                newCustomer.Name = "Customer" + i;
                list.Add(newCustomer);
            }
            myListView.ItemsSource = list;
            base.OnNavigatedTo(e);
        }
    }
}

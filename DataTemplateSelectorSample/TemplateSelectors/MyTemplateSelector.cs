using DataTemplateSelectorSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace DataTemplateSelectorSample.TemplateSelectors
{
    public class MyTemplateSelector: DataTemplateSelector
    {
        public DataTemplate VIPTemplate { get; set; }//DataTemplate for special user
        public DataTemplate CustomerTemplate { get; set; }//DataTemplate for normal user
        protected override DataTemplate SelectTemplateCore(object item)
        {
            if (((Customer)item).Id.ToLower() == "vipcustomer")
            {
                //if current user is vip then user VIP Template.
                return VIPTemplate;
            }
            else
            {
                //otherwise return normal template.
                return CustomerTemplate;
            }
            
        }
    }
}

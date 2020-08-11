using Ecommerce.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ecommerce.View
{
   [XamlCompilation(XamlCompilationOptions.Compile)]
   public partial class TopItems : ContentPage
   {
      public TopItems()
      {
         InitializeComponent();
      }
      protected async override void OnAppearing()
      {
         base.OnAppearing();
         await ((TopItemsViewModel)BindingContext).LoadTopProducts();
      }
   }
}
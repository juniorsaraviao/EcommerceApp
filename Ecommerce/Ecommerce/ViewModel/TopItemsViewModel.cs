using Acr.UserDialogs;
using Ecommerce.Model;
using Ecommerce.Util;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Ecommerce.ViewModel
{
   public class TopItemsViewModel : BaseViewModel
   {
      public string Star  => FontAwesomeIcon.Star + Environment.NewLine;
      public string Trash => FontAwesomeIcon.Trash + Environment.NewLine;
      private ObservableCollection<Product> _productList;

      public ObservableCollection<Product> ProductList
      {
         get => _productList;
         set
         {
            _productList = value;
            OnPropertyChanged();
         }
      }

      public ICommand LeftCommand => new Command<Product>(FavoriteMethod);
      public ICommand RightCommand => new Command<Product>(DeleteMethod);

      private void DeleteMethod(Product itemSelected)
      {
         var index = ProductList.IndexOf(itemSelected);
         ProductList.RemoveAt(index);
      }

      private void FavoriteMethod(Product itemSelected)
      {         
         var index = ProductList.IndexOf(itemSelected);
         itemSelected.IsFavorite = true;
         ProductList[index]     = itemSelected;
         UserDialogs.Instance.Toast("Added to Favorite Items", TimeSpan.FromMilliseconds(1000));
      }

      public TopItemsViewModel()
      {
         ProductList = new ObservableCollection<Product>();               
      }

      public async Task LoadTopProducts()
      {
         using (UserDialogs.Instance.Loading())
         {
            await Task.Delay(2000);
            ProductList = Product.ProductsList();
         }
      }

   }
}

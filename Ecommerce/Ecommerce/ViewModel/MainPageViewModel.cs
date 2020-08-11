using Acr.UserDialogs;
using Ecommerce.Model;
using Ecommerce.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Ecommerce.ViewModel
{
   public class MainPageViewModel : BaseViewModel
   {
      private ObservableCollection<Category> _categoryList;
      private ObservableCollection<Product>  _productList;
      private int                            _height;
      public int Height 
      {
         get => _height;
         set
         {
            _height = value;
            OnPropertyChanged();
         } 
      }
      public ObservableCollection<Category> CategoryList
      {
         get => _categoryList;
         set 
         {
            _categoryList = value;
            OnPropertyChanged();
         }
      }
      public ObservableCollection<Product> ProductList
      {
         get => _productList;
         set
         {
            _productList = value;
            OnPropertyChanged();
         }
      }

      public ICommand TopItemsCommand => new Command(async () => await TopItemsMethod());

      private async Task TopItemsMethod()
      {
         await Application.Current.MainPage.Navigation.PushModalAsync( new TopItems() );
      }

      public MainPageViewModel()
      {
         ProductList = new ObservableCollection<Product>();
      }
     
      public async Task LoadInformation()
      {
         using (UserDialogs.Instance.Loading())
         {
            await Task.Delay(2000);

            CategoryList = Category.CategoryList();
            var products = Product.ProductsList().Take(6).ToList();

            var productCollection = new ObservableCollection<Product>();
            products.ForEach(x => productCollection.Add(x));

            ProductList = productCollection;
            Height      = ProductList.Count * 92;
         }
      } 
   }
}

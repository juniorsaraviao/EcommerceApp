using Ecommerce.Util;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Ecommerce.Model
{
   public class Category
   {
      public string CategoryName { get; set; }
      public string CategoryFont { get; set; }

      public static ObservableCollection<Category> CategoryList()
      {
         return new ObservableCollection<Category>()
         {
            new Category()
            {
               CategoryName = "Shirts",
               CategoryFont = FontAwesomeIcon.Shirt
            },
            new Category()
            {
               CategoryName = "Sport",
               CategoryFont = FontAwesomeIcon.Sport
            },
            new Category()
            {
               CategoryName = "Wallets",
               CategoryFont = FontAwesomeIcon.Wallet
            },
            new Category()
            {
               CategoryName = "Shoes",
               CategoryFont = FontAwesomeIcon.Shoe
            },
            new Category()
            {
               CategoryName = "Socks",
               CategoryFont = FontAwesomeIcon.Sock
            },
            new Category()
            {
               CategoryName = "Laptop",
               CategoryFont = FontAwesomeIcon.Laptop
            },
            new Category()
            {
               CategoryName = "Mobile",
               CategoryFont = FontAwesomeIcon.Mobile
            },
            new Category()
            {
               CategoryName = "Games",
               CategoryFont = FontAwesomeIcon.Game
            }           
         };
      }

   }
}

using System.Collections.ObjectModel;

namespace Ecommerce.Model
{
   public class Product
   {
      public string Name          { get; set; }
      public string Type          { get; set; }
      public string ImageUrl      { get; set; }
      public string PreviousPrice { get; set; }      
      public string CurrentPrice  { get; set; }
      public bool   IsFavorite    { get; set; }
      public bool HasPreviousPrice   => !string.IsNullOrEmpty(PreviousPrice);
      public bool HasNoPreviousPrice => !HasPreviousPrice;

      public static ObservableCollection<Product> ProductsList()
      {
         return new ObservableCollection<Product>()
         {
            new Product()
            {
               Name = "Sneakers",
               Type = "Shoes",
               CurrentPrice = "$259.99",
               PreviousPrice = "$299.99",
               ImageUrl = "https://martinvalen.com/13342/heren-low-top-sneakers-schoenen-wit.jpg"
            },
            new Product()
            {
               Name = "T-shirt",
               Type = "Clothes",
               CurrentPrice = "$120.00",
               PreviousPrice = "$160.00",
               ImageUrl = "https://www.futbolemotion.com/imagesarticulos/134622/grandes/camiseta-nike-chelsea-fc-breathe-stadium-segunda-equipacion-2019-2020-white-rush-blue-0.png"
            },
            new Product()
            {
               Name = "Cap",
               Type = "Clothes",
               CurrentPrice = "$80.99",
               ImageUrl = "https://dexter.vteximg.com.br/arquivos/ids/375971-540-540/891284010_1.jpg?v=636639675098630000"
            },
            new Product()
            {
               Name = "Sport Jacket Size M",
               Type = "Clothes",
               CurrentPrice = "$129.99",
               ImageUrl = "https://imcut.jollychic.com//uploads/jollyimg/imageService/img/goods/2019/10/10/17/15/937e2222-b34c-486d-818b-1c70097528b2.jpg"
            },
            new Product()
            {
               Name = "Polera Nike M Nsw Crew",
               Type = "Clothes",
               CurrentPrice = "$200.99",
               PreviousPrice = "250.99",
               ImageUrl = "https://home.ripley.com.pe/Attachment/WOP_5/2020266331623/2020266331623_2.jpg"
            },
            new Product()
            {
               Name = "Dauss Shoes",
               Type = "Shoes",
               CurrentPrice = "$80.00",
               PreviousPrice = "$100.00",
               ImageUrl = "https://home.ripley.com.pe/Attachment/WOP_5/2025237015564/2025237015564-1.jpg"
            },
            new Product()
            {
               Name = "Donovan Wallet",
               Type = "Wallet",
               ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/41u3oquZk5L.jpg"
            },
            new Product()
            {
               Name = "Chino Pants",
               Type = "Pants",
               ImageUrl = "https://images.boardriders.com/global/rvca-products/all/default/hi-res/ml301src_rvca,wg_bov_frt1.jpg"
            },
            new Product()
            {
               Name = "Adidas Socks",
               Type = "Socks",
               ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR-2EZzaj8-2_2GmRcCGKzn9yOqWq20Qwr-8w&usqp=CAU"
            },
            new Product()
            {
               Name = "Short Dark Blue",
               Type = "Sport",
               ImageUrl = "https://www.kentwang.com/media/catalog/product/cache/76365af441ea129bbed454bf05fc598f/1/5/15003909791_397a10f5d8_k_1.jpg"
            }
         };
      }

   }
}

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
               ImageUrl = "https://static.netshoes.com.ar/produtos/zapatillas-nike-air-max-oketo/02/001-6173-002/001-6173-002_zoom1.jpg?ims=544x"
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
               ImageUrl = "https://http2.mlstatic.com/casaca-deportivo-del-chelsea-100-original-a-pedido-D_NQ_NP_661003-MPE40971409411_032020-F.jpg"
            },
            new Product()
            {
               Name = "Polera Nike M Nsw Crew",
               Type = "Clothes",
               CurrentPrice = "$200.99",
               PreviousPrice = "250.99",
               ImageUrl = "https://runastore.pe/media/catalog/product/cache/1/image/1600x/040ec09b1e35df139433887a97daa66f/9/2/928635-010-001__1_1.jpg"
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
               ImageUrl = "https://tiendasel.vteximg.com.br/arquivos/ids/2029801-1000-1000/billetera-donovan-100--cuero-negro-std.jpg?v=637272779142270000"
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
               ImageUrl = "https://assets.adidas.com/images/w_600,f_auto,q_auto/093e37f991c247d6a765a9d300acca3e_9366/Medias_Tobilleras_(3_Pares)_Plomo_DZ9400_DZ9400_03_standard.jpg"
            },
            new Product()
            {
               Name = "Short Dark Blue",
               Type = "Sport",
               ImageUrl = "https://www.joma-sport.com/files/0001/jomabeta987543098359809538245098/web.system/assets/products/20161128183701.100568.301.jpg"
            }
         };
      }

   }
}

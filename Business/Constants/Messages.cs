using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        //bu klas sabit ve değişmeyecek sadece 1 instance ı olacak ondan dolayı static
        //Car
        public static string CarPriceError = "Girdiğiniz kiralama bedeli geçersiz.";
        public static string CarAdded = "Araba başarıyla eklendi.";
        public static string CarDeleted = "Araba başarıyla silindi.";
        public static string CarUpdated = "Araba başarıyla güncellendi.";
        public static string CarsListed = "Arabalar başarıyla listelendi.";

        //Brand
        public static string BrandNameError = "Girdiğiniz marka ismi geçersiz.";
        public static string BrandAdded = "Marka başarıyla eklendi.";
        public static string BrandDeleted = "Marka başarıyla silindi.";
        public static string BrandUpdated = "Marka başarıyla güncellendi.";
        public static string BrandsListed = "Markalar başarıyla listelendi.";

        //Color
        public static string ColorAdded = "Renk başarıyla eklendi.";
        public static string ColorDeleted = "Renk başarıyla silindi.";
        public static string ColorUpdated = "Renk başarıyla güncellendi.";
        public static string ColorsListed = "Renkler başarıyla listelendi.";

        //Rental
        public static string RentDateError = "Araba kiralanmaya uygun değil.";
        public static string RentAdded = "Araba başarıyla kiralandı.";
        public static string RentDeleted = "Kiralama başarıyla silindi.";
        public static string RentUpdated = "Kiralama başarıyla güncellendi.";
        public static string RentsListed = "Kiralamalar başarıyla listelendi.";

        //User
        public static string UserAdded = "Kullanıcı başarıyla eklendi.";
        public static string UserDeleted = "Kullanıcı başarıyla silindi.";
        public static string UserUpdated = "Kullanıcı başarıyla güncellendi.";
        public static string UsersListed = "Kullanıcılar başarıyla listelendi.";

        //Customer
        public static string CustomerAdded = "Müşteri başarıyla eklendi.";
        public static string CustomerDeleted = "Müşteri başarıyla silindi.";
        public static string CustomerUpdated = "Müşteri başarıyla güncellendi.";
        public static string CustomersListed = "Müşteriler başarıyla listelendi.";


    }
}

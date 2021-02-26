using System.Runtime.Serialization;

namespace Business.Constants
{
    public class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string CarPriceInValid = "Araba fiyatı 0'dan büyük olmalıdır";
        public static string CarDeleted = "Araba silindi";
        public static string CarUpdated = "Araba güncellendi";
        public static string CarCanNotUpdated = "Araba güncellenemedi";
        public static string CarsListed = "Araba listelendi";
        

        public static string BrandAdded = "Marka eklendi";
        public static string BrandNameInValid = "Marka ismi geçersiz";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandCanNotDeleted = "Marka Silinirken Hata alındı";
        public static string BrandUpdated = "Marka güncellendi";
        public static string BrandCanNotUpdated = "Marka güncellenemedi";
        public static string BrandsListed = "Markalar listelendi";

        public static string ColorAdded = "Renk eklendi";
        public static string ColorCanNotAdded = "Renk eklenemedi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorUpdated = "Renk güncellendi";
        public static string ColorCanNotUpdated = "Renk Güncellenemedi";
        public static string ColorsListed = "Renkler listelendi";
        public static string GetColorByColorId = "Renk numaralarıyla birlikte isimleri listelendi";

        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerNameInValid = "Müşteri ismi Geçersiz";//customermanager 34 
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerUpdated = "Müşteri güncellendi";
        public static string CustomerCanNotUpdated = "Müşteri güncellenemedi";
        public static string CustomersListed = "Müşteriler listelendi";

        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserCanNotDeleted="Kullanıcı silinirken hata oluştu";
        public static string UserUpdated = "Kullanıcı güncellendi";
        public static string UsersListed = "Kullanıcılar listelendi";
        public static string UserEmailFormatIsWrong = "Yanlış Email Formatı";
        public static string GetUserByUserId = "Kullanıcı numaralarıyla birlikte kullanıcılar listelendi";

        public static string RentalAdded = "Araç kiralama eklendi";
        public static string RentalDeleted = "Araç kiralama silindi";
        public static string RentalUpdated = "Araç kiralama güncellendi";
        public static string RentalsListed = "Araç kiralamaları listelendi";
        public static string RentalReturnDateNull = "Araç henüz teslim edilmedi";
        public static string GetRentalByRentalId = "Araç kiralamalar numaralarıyla listelendi";

        public static string CarListedWDto = "Arabalar detaylarıyla listelendi";
        public static string CarListedWBrandId = "Seçilen markanın arabaları listelendi";
        public static string CarListedWColorId = "Seçilen renk arabalar listelendi";

        public static string Maintenance = "Sistem bakımda";
        public static string GetAll = "listelendi";

    }
}
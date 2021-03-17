using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün sisteme eklendi.";
        public static string ProductDeleted = "Ürün sistemden silindi.";
        public static string ProductUpdated = "Ürün güncellendi";
        public static string BrandNameError = "işlem başarısız.Girilen marka değeri min 2 karakter olmalı.";
        public static string ProductInvalidName = "Ürün ismi geçersiz.";
        public static string DailyPriceError = "İşlem başarısız.Araç günlük fiyatı 0'dan büyük bir değer almalı.";
        public static string AllProductsListed = "Tüm ürünler listelendi.";
        public static string ListByBrandId = "Marka id'sine göre liste oluşturuldu.";
        public static string ListByColorId = "Araç renk id'sine göre liste oluşturuldu.";
        public static string ListByDailyPrice = "Günlük araç fiyatına göre liste oluşturuldu.";
        public static string GetId = "Araç id'si getirildi.";
        public static string ListByModel = "Model yılına göre liste oluşturuldu.";
        public static string ListOfProductDetails = "Araç detayları listelendi.";

        public static string ColorUpdated = "Renk güncellendi";
        public static string AllColorsListed = "Tüm renkler listelendi.";
        public static string ColorDeleted = "Renk sistemden silindi";
        public static string ColorAdded = "Renk sisteme eklendi.";
        public static string GetColorById = "Id'e göre renk getirildi.";

        public static string BrandAdded = "Marka sisteme eklendi.";
        public static string BrandDeleted = "Marka sistemden silindi.";
        public static string AllBrandsListed = "Tüm markalar listelendi.";
        public static string BrandUpdated = "Marka güncellendi.";
        public static string GetBrandById = "Id'e göre marka getirildi.";

        public static string UserAdded = "Kullanıcı eklendi.";
        public static string UserDeleted = "Kullanıcı silindi.";
        public static string AllUsersListed = "Tüm kullanıcılar listelendi.";
        public static string GetUserById = "Id'e göre kullanıcı getirildi.";
        public static string UserUpdated = "Kullanıcı güncellendi";

        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerDeleted = "Müşteri silindi.";
        public static string AllCustomersListed = "Tüm müşteriler listelendi.";
        public static string GetCustomerById = "Id'e göre müşteri getirildi.";
        public static string CustomerUpdated = "Müşteri güncellendi.";

        public static string RentalError = "Kiralama işlemi gerçekleştirilemedi.Arabanın kiralanabilmesi için teslim edilmesi gerekir.";
        public static string RentalAdded = "Kiralama başarılı";
        public static string RentalDetailDeleted = "Kiralama işlemi silindi";
        public static string AllRentalsListed = "Tüm kiralamalar listendi.";
        public static string GetRentalDetailById = "Id'e göre kiralama detayları getirildi.";
        public static string ListOfRentalDetails = "Kiralama detayları listelendi.";
        public static string RentalDetailUpdated = "Kiralama bilgileri güncellendi.";
        public static string RentalUpdatedReturnDateError= "Araç zaten teslim alınmış.";
        public static string RentalUpdatedReturnDate= "Araç teslim alındı.";

        public static string MaintenanceTime = "Site bakımda!";


        public static string ImageNotFound = "İlgili resim bulunamadı";
        public static string ImagesLimitExceded = "Araç başı fotoğraf sayısı max 5 olabilir";
        public static string GetImagesById = "Id'e göre fotoğraflar gönderildi";
        public static string AllImagesListed = "Tüm fotoğraflar listelendi";
        public static string UserNotFound = "Kullanıcı bulunamadı!";
        public static string PasswordError="Şifre hatalı!";
        public static string SuccessfulLogin = "Giriş başarılı";
        public static string UserAlreadyExist = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla sisteme kaydoldu";
        public static string AccessTokenCreated = "Access Token oluşturuldu";
    }
}

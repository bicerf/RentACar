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
        internal static string AllProductsListed = "Tüm ürünler listelendi.";
        internal static string ListByBrandId = "Marka id'sine göre liste oluşturuldu.";
        internal static string ListByColorId = "Araç renk id'sine göre liste oluşturuldu.";
        internal static string ListByDailyPrice = "Günlük araç fiyatına göre liste oluşturuldu.";
        internal static string GetId = "Araç id'si getirildi.";
        internal static string ListByModel = "Model yılına göre liste oluşturuldu.";
        internal static string ListOfProductDetails = "Araç detayları listelendi.";
        internal static string ColorUpdated = "Renk güncellendi";
        internal static string AllColorsListed = "Tüm renkler listelendi.";
        internal static string ColorDeleted = "Renk sistemden silindi";
        internal static string ColorAdded = "Renk sisteme eklendi.";
        internal static string GetColorById = "Id'e göre renk getirildi.";
        internal static string BrandAdded = "Marka sisteme eklendi.";
        internal static string BrandDeleted = "Marka sistemden silindi.";
        internal static string AllBrandsListed = "Tüm markalar listelendi.";
        internal static string BrandUpdated = "Marka güncellendi.";        
        internal static string GetBrandById = "Id'e göre marka getirildi.";
    }
}

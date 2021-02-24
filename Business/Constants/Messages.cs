using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        //newlememek için static verilir
        //constants sabitler
        public static string ProductAddedMessage = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string ProductListMessage = "Ürünler listelendi";
        public static string MaintenenceTime = "Bakım zamanı";
        public static string ProductCountCategoryError = "bir kategoryde en fazla 10 ürün bulunabilir";
        public static string ProductNameAlreadyExists = "Aynı üründen başka olamaz";
        internal static string CategorLimitExceded="kategory limiti aşıldı";
    }
}

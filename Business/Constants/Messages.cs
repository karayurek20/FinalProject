using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
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
        public static string CategorLimitExceded="kategory limiti aşıldı";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";

        public static string AuthorizationDenied = "Yetkiniz yok";
        

        
    }
}

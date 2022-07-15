using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        
        public static string CarAdded = "Ürün eklendi";
        public static string CarDescription = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Bakım Zamanı";
        public static string ProductListed = "Ürünler Listelendi";
        public static string CarDeleted = " ";
        public static string CarListed = " ";
        public static string CarUpdated = " ";
        public static string ReturnCar = " ";
        public static string ItemAdded = "Resim Eklendi";
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string ProductAdded = "Ürün eklendi";
        public static string UserRegistered = "Kullanıcı kayydı yapıldı";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola hatası";
        public static string SuccessfulLogin = "Giriş başarılı";
        public static string UserAlreadyExists = "Kullanıcı Sistemde Kayıtlıdır";
        public static string AccessTokenCreated = "Token oluşturuldu";
    }
}

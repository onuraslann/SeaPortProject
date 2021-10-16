using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
   public static class Messages
    {

        public static string CategoryAdded = "Category  eklendi";
        public static string CategoryList = "Category Listelendi";
        public static string ColorAdded = "Renk Eklendi";
        public static string ContainerAdded = "Container eklendi";
        public static string ContainerDeleted = "Container silindi";
        public static string CustomerList = "Müşteriler Listelendi";
        public static string EmployeAdded = "Çalışanlar Eklendi";
        public static string CheckIfShipCount = "Bir geminin en fazla 5 adet resmi bulunur";
        public static string ImageAdded = "Resim eklendi";
        public static string PortList = "Port Listelendi";
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductList = "Ürünler Listenlendi";
        public static string ShipAdded = "Gemi eklendi";
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Hatalı Parola";
        public static string SuccessLogin = "Giriş Başarılı";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string UsersAdded = "Kullanıcı eklendi";
        public static string AccessTokenAdded = "AccessToken Oluşturuldu";
        public static string CategoryUpdate = "Category Güncellendi";
        public static string EmployeeUpdate = "Employe Güncellendi";
    }
}

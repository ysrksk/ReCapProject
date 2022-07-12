using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        public static string CarAdded = "Ürün eklendi";
        public static string CarDescription = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Bakım Zamanı";
        public static string ProductListed = "Ürünler Listelendi";
        internal static string CarDeleted;
        internal static string CarListed;
        internal static string ReturnCar;

        public static string CarUpdated { get; internal set; }
    }
}

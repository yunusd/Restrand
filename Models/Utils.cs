using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restrand
{
    static class Utils
    {   /** 
            @string ServerName[server adı] Local bilgisayarın adını tutar
            @string DatabaseName[veritabanı adı]* "RESTRAND_DB_NAME" adında bir değişken varsa değerini alır
            @string DatabaseUsername[veritabanı kullanıcı adı]* "RESTRAND_DB_USERNAME" adında bir değişken varsa değerini alır
            @string DatabasePassword[veritabanı kullanıcı şifresi]* "RESTRAND_DB_PASSWORD" adında bir değişken varsa değerini alır
            
            Geliştirici environment variable içinde yukarıda ki gerekli (*) değişkenleri ve karşılıklarını tutmalıdır.
            Environment variable oluşturma örnek(CMD): setx RESTRAND_DB_NAME "db_adi_örnek"
            
         */
        public static string ServerName { get; } = Environment.GetEnvironmentVariable("USERDOMAIN");
        public static string DatabaseName { get; } = Environment.GetEnvironmentVariable("RESTRAND_DB_NAME");
        public static string DatabaseUsername { get; } = Environment.GetEnvironmentVariable("RESTRAND_DB_USERNAME");
        public static string DatabasePassword { get; } = Environment.GetEnvironmentVariable("RESTRAND_DB_PASSWORD");

        public static string ConnectionString(string serverName = null, string databaseName = null,
                                            string databaseUsername = null, string databasePassword = null)
        {
            // Eğer parametre verilmez ise varsayılan verileri atar aksi takdirde verilen değeri atar.
            string dbServerName = string.IsNullOrEmpty(serverName) ? ServerName : serverName;
            string dbName = string.IsNullOrEmpty(databaseName) ? DatabaseName : databaseName;
            string dbUsername = string.IsNullOrEmpty(databaseUsername) ? DatabaseUsername : databaseUsername;
            string dbPassword = string.IsNullOrEmpty(databasePassword) ? DatabasePassword : databasePassword;
            string connectionString =
                $"Data Source={dbServerName}; Initial Catalog={dbName};" +
                $"User id={dbUsername}; Password={dbPassword};";
            return connectionString;
        }

        public static string SelectMasaBilgileri { get; } = "SELECT * FROM MasaBilgileri";
        public static string SelectWhereMasaBilgileri { get; } = "SELECT * FROM MasaBilgileri WHERE MasaKonumu = @masaKonumu";
        public static string InsertMasaBilgileri { get; } = "INSERT INTO MasaBilgileri ([MasaNumarasi], [MasaKonumu], [SandalyeSayisi]) VALUES(@masaNumarasi, @masaKonumu, @sandalyeSayisi)";
        public static string SelectMasaKonumu { get; } = "SELECT * FROM MasaKonumu";
        public static string SelectMasaKonumuSayi { get; } = "SELECT COUNT(*) FROM MasaKonumu";
        public static string InsertMasaKonumu { get; } = "INSERT INTO MasaKonumu ([MasaKonumuAd]) VALUES(@masaKonumuAd)";

        public static string DeleteMasaKonumu { get; } = "DELETE FROM MasaKonumu WHERE MasaKonumuAd = @masaKonumuAd";

        public static string SelectRezervasyon { get; } = "SELECT * FROM Rezervasyon";
        public static string SelectRandevuBilgi { get; } = "SELECT * FROM Musteriler m JOIN Rezervasyon r ON m.MusterilerID=r.MusteriID ";

        public static string SelectUrunler { get; } = "SELECT ProductID [Id], CategoryName[Kategori], ProductName [Ürün Adı], Price[Fiyat] FROM Products JOIN Categories ON Products.CategoryID = Categories.CategoryID";
        public static string InsertUrunler { get; } = "INSERT INTO Products(ProductName, Price, CategoryID) VALUES(@productName, @price, @categoryID)";
        public static string SelectKategoriByName { get; } = "SELECT CategoryID FROM Categories WHERE CategoryName = @categoryName";
        public static string DeleteUrunler { get; } = "DELETE FROM Products WHERE ProductID = @productID";
        public static string DuzenleUrunler { get; } = "UPDATE Products SET ProductName = @productName, Price = @price WHERE ProductID = @productId";
        public static string SelectKategori { get; } = "SELECT * FROM Categories";
        public static string InsertKategori { get; } = "INSERT INTO Categories(CategoryName) VALUES(@categoryName)";

        public static string SelectIfStateTrueRezervasyon(int masaNo)
        {
            return "SELECT TOP 1 * FROM Rezervasyon WHERE MasaID = " + masaNo;
        }

    }
}

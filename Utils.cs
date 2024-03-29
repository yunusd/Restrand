﻿using System;
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
        public static string InsertMasaBilgileri { get; } = "INSERT INTO MasaBilgileri ([MasaNumarasi], [MasaKonumu], [SandalyeSayisi]) VALUES(@masaNumarasi, @masaKonumu, @sandalyeSayisi)";
        public static string SelectMasaKonumu { get; } = "SELECT * FROM MasaKonumu";
        public static string InsertMasaKonumu { get; } = "INSERT INTO MasaKonumu ([MasaKonumuAd]) VALUES(@masaKonumuAd)";

        public static string DeleteMasaKonumu { get; } = "DELETE FROM MasaKonumu WHERE MasaKonumuAd = @masaKonumuAd";

    }
}

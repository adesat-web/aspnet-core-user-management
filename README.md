# 📋 ASP.NET Core MVC Kullanıcı Yönetim Sistemi

ASP.NET Core (.NET 8) ve Entity Framework Core (EF Core) kullanılarak geliştirilmiş, SQL Server veritabanı tabanlı temel bir CRUD (Ekleme, Listeleme, Silme) web uygulamasıdır.

## 🚀 Proje Özellikleri

*   **Kullanıcı Listeleme:** Veritabanındaki kayıtlı kişileri şık bir HTML tablo yapısında listeleme.
*   **Yeni Kayıt Ekleme:** Model doğrulama (Data Annotations) desteğiyle güvenli kullanıcı ekleme formu.
*   **Kayıt Silme:** Seçilen ID'ye göre veritabanından anlık veri silme işlemi.
*   **Code-First Yaklaşımı:** Entity Framework Core ile veritabanı yönetim altyapısı.

## 🛠️ Kullanılan Teknolojiler

*   **Framework:** ASP.NET Core MVC (.NET 8)
*   **ORM:** Entity Framework Core (SQL Server Provider)
*   **Arayüz:** Bootstrap 5, HTML5, Razor View Engine
*   **Veritabanı:** Microsoft SQL Server

## ⚙️ Kurulum ve Çalıştırma

1. Projeyi bilgisayarınıza klonlayın veya indirin.
2. `appsettings.json` dosyasındaki bağlantı cümlesini (`ConnectionStrings`) kendi SQL Server sunucu adınıza göre güncelleyin:
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=SUNUCU_ADINIZ;Database=KisiBilgi;Trusted_Connection=True;TrustServerCertificate=True;"
   }

#Game Collection Management App

Merhaba,
Bu proje, oyun koleksiyonunuzu düzenlemek ve yönetmek için geliştirilmiş bir Game Collection Management uygulamasıdır. PostgreSQL veritabanı ile entegre çalışan bu uygulama, oyunlar, kullanıcılar ve incelemeler gibi bilgileri verimli bir şekilde yönetmenize olanak tanır.
📚 Proje Hakkında

Game Collection Management App, aşağıdaki konuları öğrenmek ve uygulamak için tasarlanmıştır:

    C# ile konsol tabanlı bir uygulama geliştirme.
    PostgreSQL ile veritabanı işlemlerini gerçekleştirme.
    CRUD işlemlerini (Create, Read, Update, Delete) hayata geçirme.
    LINQ kullanarak veritabanı sorgularını optimize etme.
    Veritabanı tabloları arasında ilişkiler kurma (Foreign Key kullanımı).
    Kullanıcı dostu bir CLI (Command-Line Interface) oluşturma.

🔧 Teknolojiler

Bu projede kullanılan temel teknolojiler şunlardır:

    C# (.NET 6)
    PostgreSQL
    Npgsql (PostgreSQL için .NET veri sağlayıcısı)
    Entity Framework Core

📂 Veritabanı Yapısı

Projede kullanılan veritabanı aşağıdaki tabloları içerir:
1. Games

    `GameId (int)` - Oyun benzersiz kimliği
    `Title (string)` - Oyun adı
    `Genre (string)` - Türü
    `ReleaseDate (DateTime)` - Çıkış tarihi

2. Users

    `UserId (int)` - Kullanıcı benzersiz kimliği
    `Username (string)` - Kullanıcı adı
    `Email (string)` - E-posta adresi

3. Reviews

    `ReviewId (int)` - İnceleme benzersiz kimliği
    `UserId (int)` - İnceleme yapan kullanıcı
    `GameId (int)` - İnceleme yapılan oyun
    `Rating (int)` - İnceleme puanı (1-10 arası)
    `Comment (string)` - Yorum

🚀 Kurulum ve Çalıştırma

Aşağıdaki adımları takip ederek projeyi kurabilir ve çalıştırabilirsiniz:
1. Proje Deposu

Projeyi GitHub üzerinden indirin:
Game Collection Management App - GitHub

`git clone https://github.com/YasarDogann/GameCollectionManagementApp.git`

2. Gerekli Araçlar

    Visual Studio 2022 veya üzeri
    PostgreSQL (Kurulu değilse buradan indirip yükleyebilirsiniz.)
    pgAdmin (PostgreSQL yönetim aracı)

3. Veritabanı Ayarları

    PostgreSQL üzerinde bir veritabanı oluşturun.
    appsettings.json dosyasını açarak bağlantı bilgilerinizi güncelleyin:
`
"ConnectionStrings": {
    "GameCollectionManagement": "Server=localhost;Database=GameCollectionDB;User Id=postgres;Password=yourpassword;"
}
`
Veritabanı tablolarını oluşturmak için Entity Framework Core Migrations komutlarını çalıştırın:

   ` dotnet ef migrations add InitialCreate`
   ` dotnet ef database update`

4. Uygulamayı Çalıştırma

    Visual Studio'da projeyi açın ve F5 tuşuna basarak uygulamayı çalıştırın.

📝 Özellikler

    Oyun Ekleme ve Listeleme: Koleksiyonunuza yeni oyunlar ekleyebilir ve mevcut oyunları görüntüleyebilirsiniz.
    Kullanıcı Yönetimi: Yeni kullanıcılar ekleyebilir ve kullanıcı bilgilerini düzenleyebilirsiniz.
    Oyun İncelemeleri: Oyunlar için inceleme ekleyebilir ve diğer kullanıcıların yorumlarını okuyabilirsiniz.
    Arama ve Filtreleme: Tür veya çıkış tarihine göre oyunları filtreleyebilirsiniz.

🌟 Geliştirilmesi Planlanan Özellikler

    API Desteği: Uygulama, ileride RESTful API desteği ile genişletilecektir.
    Modern Arayüz: CLI yerine bir web veya masaüstü arayüzü eklenebilir.
    Gelişmiş Filtreleme: Kullanıcıların daha detaylı arama yapabilmesi için filtreleme sistemi geliştirilecektir.

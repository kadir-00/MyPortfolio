# MyPortfolio

MyPortfolio, yeteneklerinizi, deneyimlerinizi ve projelerinizi sergileyebileceğiniz, aynı zamanda dinamik bir yönetim paneli içeren, **ASP.NET Core 6.0** ile geliştirilmiş kapsamlı bir kişisel portföy web uygulamasıdır.

## 🌟 Öne Çıkan Özellikler

Projenin geliştirilme sürecinde modern yazılım prensipleri ve verimlilik odaklı teknikler ön planda tutulmuştur:

*   **🧩 Partial Components (Parçalı Bileşen Yapısı)**: 
    Sayfa içerisindeki modüller (Header, Footer, Navbar vb.) birbirinden bağımsız `ViewComponent` ve `PartialView` yapıları kullanılarak parçalanmıştır. Bu sayede kod tekrarı önlenmiş, yönetilebilirlik artırılmış ve daha temiz bir yapı elde edilmiştir.

*   **🏗️ Code First Yaklaşımı**:
    Veritabanı mimarisi, tamamen C# sınıfları (Entity'ler) üzerinden kurgulanmıştır. Entity Framework Core'un **Code First** yaklaşımı sayesinde veritabanı bağımlılığı en aza indirilmiş ve migration yapısı ile güncellemeler kolaylaşmıştır.

*   **🎨 Modern ve Kullanıcı Odaklı Tasarım**:
    UI tarafında kullanıcı deneyimini (UX) artıran, pastel tonların hakim olduğu şık bir tasarım; Admin panelinde ise responsive ve profesyonel bir dashboard teması kullanılmıştır.

## � Ekran Görüntüleri

Projenin arayüzü ve yönetim panelinden bazı görüntüler:

### 🖥️ Kullanıcı Arayüzü (UI)
> *Not: Buraya projenizin ana sayfasından bir ekran görüntüsü ekleyebilirsiniz.*
>
> ![Ana Sayfa Arayüzü](https://via.placeholder.com/800x450?text=Ana+Sayfa+Goruntusu)

### ⚙️ Yönetim Paneli (Admin Dashboard)
> *Not: Buraya admin panelinizden bir ekran görüntüsü ekleyebilirsiniz.*
>
> ![Admin Paneli](https://via.placeholder.com/800x450?text=Admin+Paneli+Goruntusu)

## ✨ Diğer Özellikler

### 🌍 Arayüz (Public UI)
*   **Ana Sayfa**: Genel tanıtım.
*   **Hakkımda**: Kişisel bilgiler.
*   **Yetenekler**: Progress bar ile görselleştirilmiş yetenekler.
*   **Projeler**: Tamamlanan işler.
*   **İletişim**: Mesaj formu.

### 🛠 Yönetim Paneli (Admin Dashboard)
*   **İstatistikler**: Grafiksel veri analizleri.
*   **İçerik Yönetimi**: Tüm bölümler (Hakkımda, Deneyim vb.) için CRUD işlemleri.
*   **Mesaj Kutusu**: Gelen mesajları görüntüleme.
*   **Bildirimler**: İşlem durumları.

## 🧰 Teknolojiler

*   **Platform**: .NET 6.0 & ASP.NET Core MVC
*   **Veritabanı**: MSSQL & Entity Framework Core
*   **Frontend**: HTML5, CSS3, JavaScript, Bootstrap
*   **Kütüphaneler**: FluentValidation, Toastr/SweetAlert

## 🔐 Kullanım

1.  **Admin Girişi**: Yönetim paneline erişmek için `/Login` rotasını kullanın.
2.  **Veri Yönetimi**: Admin paneline giriş yaptıktan sonra sol menüden içeriklerinizi düzenleyebilirsiniz.

## 📄 Lisans

Bu proje [MIT Lisansı](LICENSE) altında lisanslanmıştır.

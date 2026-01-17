# 🏋️ Spor Salonu Yönetim Sistemi (Gym Management System)
Bu proje, spor salonu işletmeleri için geliştirilmiş kapsamlı bir masaüstü otomasyon sistemidir. **Yönetici (Admin)** ve **Üye (Member)** olmak üzere iki farklı yetki seviyesi sunarak, hem salon yönetimini dijitalleştirir hem de üyelerin gelişim takiplerini kolaylaştırır.
---
## 📋 İçindekiler
- [Özellikler](#-özellikler)
- [Teknolojiler](#-teknolojiler)
- [Kurulum](#-kurulum)
- [Veritabanı Yapısı](#-veritabanı-yapısı)
---
## 🚀 Özellikler
Sistem, kullanıcı türüne göre özelleştirilmiş arayüzler sunar:

### 👤 Üye Paneli (Member Panel)
* **🔐 Güvenli Giriş:** Kullanıcı adı ve şifre ile kişisel panele erişim.
* **📅 Antrenman Takibi:** Eğitmenler tarafından atanan antrenman programlarını görüntüleme.
* **📢 Duyurular:** Yönetimden gelen duyuru ve etkinlik bildirimlerini anlık görme.
* **💳 Ödeme Paneli:** Üyelik durumu sorgulama ve aidat ödeme işlemleri (Simülasyon).

### 🛡️ Admin Paneli (Admin Panel)
* **📢 Duyuru Yayınlama:** Tüm üyelere veya belirli gruplara bildirim gönderme.
* **💰 Finansal Yönetim:** Üye ödemelerini alma, borç takibi ve kasa yönetimi.
* **👥 Üye İşlemleri:** Yeni üye kaydı, üye silme ve bilgi güncelleme.
* **📊 Raporlama:** Genel durum hakkında özet bilgiler.

---

## 🛠 Teknolojiler

Proje geliştirilirken Clean Code prensiplerine dikkat edilmiştir.

* **Programlama Dili:** C#
* **Framework:** .NET Framework / .NET Core (Windows Forms)
* **Veritabanı:** Microsoft SQL Server (MSSQL)
* **IDE:** Visual Studio 2022
* **Versiyon Kontrol:** Git & GitHub

---
## ⚙️ Kurulum

Projeyi kendi bilgisayarınızda çalıştırmak için şu adımları izleyin:

1.  **Projeyi Klonlayın:**
    ```bash
    git clone [https://github.com/muratgncl/SporSalonuUyelikSistemi.git]
    ```
2.  **Veritabanını Oluşturun:**
    * `Database` klasörü içerisindeki `script.sql` dosyasını SQL Server Management Studio (SSMS) ile açın ve çalıştırın (Execute).
3.  **Bağlantı Ayarı:**
    * Projedeki `App.config` veya `ConnectionStrings` dosyasını açın.
    * `Data Source` kısmını kendi yerel sunucunuza göre güncelleyin.
4.  **Çalıştırın:**
    * Visual Studio üzerinden `Start` tuşuna basarak uygulamayı başlatın.

---

## 💾 Veritabanı Yapısı

Proje ilişkisel veritabanı (Relational Database) yapısına sahiptir. Temel tablolar:
* `Users` (Kullanıcılar ve Rolleri)
* `Payments` (Ödeme Geçmişi)
* `Workouts` (Antrenman Programları)
* `Announcements` (Duyurular)

---
**Murat Gencel** *Yazılım Mühendisliği Öğrencisi @ Beykent Üniversitesi*
---
*Bu proje MIT Lisansı ile lisanslanmıştır.*

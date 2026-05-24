# Personal Site & Tech Blog
ASP.NET Core 8 MVC ile geliştirilmiş kişisel portfolyo ve teknik blog sitesi.

## Teknolojiler
- ASP.NET Core 8 MVC
- Entity Framework Core
- PostgreSQL (Npgsql)
- N-Tier Architecture (Entity, DAL, BL, UI)
- TinyMCE (Blog editörü)

## Özellikler
- Kişisel CV/Hakkımda sayfası (timeline)
- Teknik blog (kategorili, filtrelenebilir)
- Projeler sayfası
- Admin panel (CRUD)
- Dark/Light tema

## Kurulum
1. Repoyu klonla
2. `appsettings.example.json` dosyasını `appsettings.json` olarak kopyala
3. PostgreSQL bağlantı bilgilerini gir
4. Package Manager Console'da `Update-Database` çalıştır
5. Projeyi başlat

## Mimari
PersonalSite.sln
├── EntityLayer        → Modeller
├── DataAccessLayer    → EF Core + PostgreSQL
├── BusinessLayer      → Servisler
└── PersonalSite.UI    → ASP.NET Core MVC


## Geliştirici
Muhammet Servet Bayrak — Sistem Yöneticisi & Teknik Destek Uzmanı
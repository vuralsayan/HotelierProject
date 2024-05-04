
<h1 align="center">
  <br>
  Hotelier Project
  <br>
</h1>

<h4 align="center">Asp.Net Core Api kullanılarak geliştirilen Otel Rezervasyon Projesi</h4>

<p align="center">
  <a href="#hakkında">Hakkında</a> •
  <a href="#nasıl-kullanılır">Nasıl Kullanılır</a> •
  <a href="#download">Görseller</a> •
</p>


## Hakkında
.Net Core Api, .Net Core Identity, .Net Core 6.0, Entity Framework Core, Api Consume, Rapid Api, JWT, Fluent Validation, N Tier Architecture, Repository Design Patern, DTO, Auto Mapper, Swagger, Postman, Login, Register, Mail işlemleri

Projenin temel amacı, kullanıcıların web sitesi arayüzü üzerinden otel odaları hakkında bilgi alabilmelerini sağlamak ve rezervasyon yapmalarına imkan tanımaktır. Ayrıca, kullanıcılar admin kısmına öneri, talep, şikayet gibi konularda mesaj gönderebilirler. Admin tarafında ise kullanıcıların rezervasyonları düzenlenip onaylanabilir. Admin kullanıcısı ayrıca site içerisinde çeşitli CRUD işlemleri gerçekleştirerek sistemi yönetebilir.

## Nasıl Kullanılır

```bash
# Projeyi klonlayın
$ git clone https://github.com/vuralsayan/HotelierProject.git

# DbContext sınıfınında bulunan connection string'i düzenleyin
$ .\HotelierProject\ApiConsume\HotelProject.DataAccessLayer\Concrete\Context.cs

# Migration oluşturup veritabanını lokalinizde çalıştırın
$ add-migration & update database

# Önce api projesini sonra UI projesini çalıştırıp kullanabilirsiniz
```

---

> [vuralsayan.com](https://www.vuralsayan.com) &nbsp;&middot;&nbsp;
> GitHub [@vuralsayan](https://github.com/vuralsayan) &nbsp;&middot;&nbsp;
> LinkedIn [@Vural Sayan](https://www.linkedin.com/in/vural-sayan-79326a171/)


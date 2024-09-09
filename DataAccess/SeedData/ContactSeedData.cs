using Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.SeedData
{
    public class ContactSeedData : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.HasData(
                new Contact
                {
                    Id = 1,
                    FirstName = "Yasin",
                    LastName = "Bol",
                    PhoneNumber = "+905326944521",

                },
                new Contact
                {
                    Id = 2,
                    FirstName = "Hasan",
                    LastName = "Sarı",
                    PhoneNumber = "+905627588456"
                },
                new Contact
                {
                    Id = 4,
                    FirstName = "Mehmet",
                    LastName = "Ak",
                    PhoneNumber = "+905627588457"
                },
                new Contact
                {
                    Id = 5,
                    FirstName = "Fatma",
                    LastName = "Gül",
                    PhoneNumber = "+905326944523"
                },
                new Contact
                {
                    Id = 6,
                    FirstName = "Ali",
                    LastName = "Yeşil",
                    PhoneNumber = "+905627588458"
                },
                new Contact
                {
                    Id = 7,
                    FirstName = "Emine",
                    LastName = "Mavi",
                    PhoneNumber = "+905326944524"
                },
                new Contact
                {
                    Id = 8,
                    FirstName = "Veli",
                    LastName = "Kırmızı",
                    PhoneNumber = "+905627588459"
                },
                new Contact
                {
                    Id = 9,
                    FirstName = "Ahmet",
                    LastName = "Turuncu",
                    PhoneNumber = "+905326944525"
                },
                new Contact
                {
                    Id = 10,
                    FirstName = "Zeynep",
                    LastName = "Pembe",
                    PhoneNumber = "+905627588460"
                },
                new Contact
                {
                    Id = 11,
                    FirstName = "Mustafa",
                    LastName = "Mor",
                    PhoneNumber = "+905326944526"
                },
                new Contact
                {
                    Id = 12,
                    FirstName = "Rabia",
                    LastName = "Kahverengi",
                    PhoneNumber = "+905627588461"
                },
                new Contact
                {
                    Id = 13,
                    FirstName = "İsmail",
                    LastName = "Beyaz",
                    PhoneNumber = "+905326944527"
                },
                new Contact
                {
                    Id = 14,
                    FirstName = "Ayhan",
                    LastName = "Gri",
                    PhoneNumber = "+905627588462"
                },
                new Contact
                {
                    Id = 15,
                    FirstName = "Serpil",
                    LastName = "Sarı",
                    PhoneNumber = "+905326944528"
                },
                new Contact
                {
                    Id = 16,
                    FirstName = "Gülten",
                    LastName = "Turkuaz",
                    PhoneNumber = "+905627588463"
                },
                new Contact
                {
                    Id = 17,
                    FirstName = "Hakan",
                    LastName = "Kum",
                    PhoneNumber = "+905326944529"
                },
                new Contact
                {
                    Id = 18,
                    FirstName = "Merve",
                    LastName = "Gökyüzü",
                    PhoneNumber = "+905627588464"
                },
                new Contact
                {
                    Id = 19,
                    FirstName = "Can",
                    LastName = "Deniz",
                    PhoneNumber = "+905326944530"
                },
                new Contact
                {
                    Id = 20,
                    FirstName = "Ceren",
                    LastName = "Yeşim",
                    PhoneNumber = "+905627588465"
                },
                new Contact
                {
                    Id = 21,
                    FirstName = "Bora",
                    LastName = "Tuna",
                    PhoneNumber = "+905326944531"
                },
                new Contact
                {
                    Id = 22,
                    FirstName = "Duygu",
                    LastName = "Güneş",
                    PhoneNumber = "+905627588466"
                },
                new Contact
                {
                    Id = 23,
                    FirstName = "Barış",
                    LastName = "Ay",
                    PhoneNumber = "+905326944532"
                },
                new Contact
                {
                    Id = 24,
                    FirstName = "Selin",
                    LastName = "Yıldız",
                    PhoneNumber = "+905627588467"
                },
                new Contact
                {
                    Id = 25,
                    FirstName = "Onur",
                    LastName = "Kuzey",
                    PhoneNumber = "+905326944533"
                },
                new Contact
                {
                    Id = 26,
                    FirstName = "Nazan",
                    LastName = "Güney",
                    PhoneNumber = "+905627588468"
                },
                new Contact
                {
                    Id = 27,
                    FirstName = "Kerem",
                    LastName = "Doğu",
                    PhoneNumber = "+905326944534"
                },
                new Contact
                {
                    Id = 28,
                    FirstName = "Deniz",
                    LastName = "Batı",
                    PhoneNumber = "+905627588469"
                },
                new Contact
                {
                    Id = 29,
                    FirstName = "Ceyda",
                    LastName = "Gül",
                    PhoneNumber = "+905326944535"
                },
                new Contact
                {
                    Id = 30,
                    FirstName = "Fırat",
                    LastName = "Savaş",
                    PhoneNumber = "+905627588470"
                },
                new Contact
                {
                    Id = 31,
                    FirstName = "Aylin",
                    LastName = "Derya",
                    PhoneNumber = "+905326944536"
                },
                new Contact
                {
                    Id = 32,
                    FirstName = "Arda",
                    LastName = "Deniz",
                    PhoneNumber = "+905627588471"
                },
                new Contact
                {
                    Id = 33,
                    FirstName = "Sinem",
                    LastName = "Ege",
                    PhoneNumber = "+905326944537"
                },
                new Contact
                {
                    Id = 34,
                    FirstName = "Oğuz",
                    LastName = "Koray",
                    PhoneNumber = "+905627588472"
                },
                new Contact
                {
                    Id = 35,
                    FirstName = "Seda",
                    LastName = "Nil",
                    PhoneNumber = "+905326944538"
                },
                new Contact
                {
                    Id = 36,
                    FirstName = "Hüseyin",
                    LastName = "Rüzgar",
                    PhoneNumber = "+905627588473"
                },
                new Contact
                {
                    Id = 37,
                    FirstName = "Nilgün",
                    LastName = "Duman",
                    PhoneNumber = "+905326944539"
                },
                new Contact
                {
                    Id = 38,
                    FirstName = "Metin",
                    LastName = "Işık",
                    PhoneNumber = "+905627588474"
                },
                new Contact
                {
                    Id = 39,
                    FirstName = "Pelin",
                    LastName = "Ateş",
                    PhoneNumber = "+905326944540"
                },
                new Contact
                {
                    Id = 40,
                    FirstName = "Erhan",
                    LastName = "Toprak",
                    PhoneNumber = "+905627588475"
                },
                new Contact
                {
                    Id = 41,
                    FirstName = "Yasemin",
                    LastName = "Dağ",
                    PhoneNumber = "+905326944541"
                },
                new Contact
                {
                    Id = 42,
                    FirstName = "Gökhan",
                    LastName = "Çimen",
                    PhoneNumber = "+905627588476"
                },
                new Contact
                {
                    Id = 43,
                    FirstName = "Şebnem",
                    LastName = "Bahar",
                    PhoneNumber = "+905326944542"
                },
                new Contact
                {
                    Id = 44,
                    FirstName = "Eren",
                    LastName = "Orman",
                    PhoneNumber = "+905627588477"
                },
                new Contact
                {
                    Id = 45,
                    FirstName = "Nihan",
                    LastName = "Küçük",
                    PhoneNumber = "+905326944543"
                },
                new Contact
                {
                    Id = 46,
                    FirstName = "Kemal",
                    LastName = "Büyük",
                    PhoneNumber = "+905627588478"
                },
                new Contact
                {
                    Id = 47,
                    FirstName = "Burcu",
                    LastName = "Kaya",
                    PhoneNumber = "+905326944544"
                },
                new Contact
                {
                    Id = 48,
                    FirstName = "Cem",
                    LastName = "Göl",
                    PhoneNumber = "+905627588479"
                },
                new Contact
                {
                    Id = 49,
                    FirstName = "Murat",
                    LastName = "Arslan",
                    PhoneNumber = "+905326944545"
                },
                new Contact
                {
                    Id = 50,
                    FirstName = "Sibel",
                    LastName = "Kartal",
                    PhoneNumber = "+905627588480"
                }
                );
        }
    }
}

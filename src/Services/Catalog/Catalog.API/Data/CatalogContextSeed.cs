﻿using Catalog.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace Catalog.API.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
           new Product
           {
               Id = 1,
               Name = "IPhone X",
               Summary = "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
               Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
               ImageFile = "product-1.png",
               Price = 950.00M,
               Category = "Smart Phone"
           },
            new Product()
            {
                Id = 2,
                Name = "Samsung 10",
                Summary = "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
                Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                ImageFile = "product-2.png",
                Price = 840.00M,
                Category = "Smart Phone"
            },
               new Product()
               {
                   Id = 3,
                   Name = "Huawei Plus",
                   Summary = "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
                   Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                   ImageFile = "product-3.png",
                   Price = 650.00M,
                   Category = "White Appliances"
               },
               new Product()
               {
                   Id = 4,
                   Name = "Xiaomi Mi 9",
                   Summary = "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
                   Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                   ImageFile = "product-4.png",
                   Price = 470.00M,
                   Category = "White Appliances"
               },
               new Product()
               {
                   Id = 5,
                   Name = "HTC U11+ Plus",
                   Summary = "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
                   Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                   ImageFile = "product-5.png",
                   Price = 380.00M,
                   Category = "Smart Phone"
               },
               new Product()
               {
                   Id = 6,
                   Name = "LG G7 ThinQ",
                   Summary = "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
                   Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                   ImageFile = "product-6.png",
                   Price = 240.00M,
                   Category = "Home Kitchen"
               }
           );
        }
    }
}

﻿using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBooks.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            BookDBContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<BookDBContext>();
            //if there are any migrations pending it goes and does them
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Books.Any())
            {   //creating the context for the database
                context.Books.AddRange(
                    new Book
                    {

                        Title = "Les Miserables",
                        Author = "Victor Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Classification_Category = "Fiction, Classic",
                        Price = 9.95


                    },
                    new Book
                    {

                        Title = "Team of Rivals",
                        Author = "Doris Kearns Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = "978-0743270755",
                        Classification_Category = "Non-Fiction, Biography",
                        Price = 14.58
                    },
                    new Book
                    {

                        Title = "The Snowball",
                        Author = "Alice Schroeder",
                        Publisher = "Bantam",
                        ISBN = "978-0553384611",
                        Classification_Category = "Non-Fiction, Biography",
                        Price = 21.54


                    },
                    new Book
                    {

                        Title = "America Ulysses",
                        Author = "Ronald C. White",
                        Publisher = "Random House",
                        ISBN = "978-0812981254 ",
                        Classification_Category = "Non-Fiction, Biography",
                        Price = 11.61


                    },
                    new Book
                    {

                        Title = "Unbroken",
                        Author = "Laura Hillenbrand",
                        Publisher = "Random House ",
                        ISBN = "978-0812974492",
                        Classification_Category = "Non-Fiction, Historical",
                        Price = 13.33


                    },
                    new Book
                    {

                        Title = "The Great Train Robbery",
                        Author = "Michael Crichton",
                        Publisher = "Vintage",
                        ISBN = "978-0804171281",
                        Classification_Category = "Fiction, Historical Fiction",
                        Price = 15.95

                    },
                   new Book
                   {

                       Title = "Deep Work",
                       Author = "Cal Newport",
                       Publisher = "Grand Central Publishing",
                       ISBN = "978-1455586691",
                       Classification_Category = "Non-Fiction, Self-Help",
                       Price = 14.99
                   },
                   new Book
                   {
                       Title = "It's Your Ship",
                       Author = "Michael Abrashoff",
                       Publisher = "Grand Central Publishing",
                       ISBN = "978-1455523023",
                       Classification_Category = "Non-Fiction, Self-Help",
                       Price = 21.66
                   },
                    new Book
                    {
                        Title = "The Virgin Way",
                        Author = "Richard Branson",
                        Publisher = "Portfolio",
                        ISBN = "978-1591847984",
                        Classification_Category = "Non-Fiction, Business",
                        Price = 29.16
                    },
                    new Book
                    {
                        Title = "Sycamore Row",
                        Author = "Josh Grisham",
                        Publisher = "Bantam",
                        ISBN = "978-0553393613",
                        Classification_Category = "Fiction, Thrillers",
                        Price = 15.03
                    }
            );
                context.SaveChanges();
            }
        }
    }
}
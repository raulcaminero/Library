using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebApp.Controllers;
using WebApp.Models;

namespace Library.Tests
{
    [TestFixture]
    public class BooksTests
    {
        [Test]
        public async Task PagesTestEmptyCase() {
            //Arrange
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer("Server=localhost;Database=LibraryDB;Trusted_Connection=True;");
            var _context = new ApplicationDbContext(optionsBuilder.Options);
            var BooksController = new BooksController(_context);

            //Act
            var result = await BooksController.Pages(0, 0);

            // Assert
            Assert.IsInstanceOf<EmptyResult>(result);
        }

        [Test]
        public async Task PagesTestFirstPage()
        {
            //Arrange
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer("Server=localhost;Database=LibraryDB;Trusted_Connection=True;");
            var _context = new ApplicationDbContext(optionsBuilder.Options);
            var BooksController = new BooksController(_context);

            //Act
            var result = await BooksController.Pages(1, 1);

            // Assert
            Assert.IsInstanceOf<ViewResult>(result);
        }

        [Test]
        public async Task NextPage()
        {
            //Arrange
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer("Server=localhost;Database=LibraryDB;Trusted_Connection=True;");
            var _context = new ApplicationDbContext(optionsBuilder.Options);
            var BooksController = new BooksController(_context);

            //Act
            var result = await BooksController.Pages(1, 1);

            // Assert
            Assert.IsInstanceOf<ViewResult>(result);
        }

        [Test]
        public async Task PreviousPage()
        {
            //Arrange
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer("Server=localhost;Database=LibraryDB;Trusted_Connection=True;");
            var _context = new ApplicationDbContext(optionsBuilder.Options);
            var BooksController = new BooksController(_context);

            //Act
            var result = await BooksController.Pages(1, 1);

            // Assert
            Assert.IsInstanceOf<ViewResult>(result);
        }

        [Test]
        public async Task GetBooks()
        {
            //Arrange
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer("Server=localhost;Database=LibraryDB;Trusted_Connection=True;");
            var _context = new ApplicationDbContext(optionsBuilder.Options);
            var BooksController = new BooksController(_context);

            //Act
            var result = await BooksController.Pages(1, 1);

            // Assert
            Assert.IsInstanceOf<ViewResult>(result);
        }

        [Test]
        public async Task BookDetails()
        {
            //Arrange
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer("Server=localhost;Database=LibraryDB;Trusted_Connection=True;");
            var _context = new ApplicationDbContext(optionsBuilder.Options);
            var BooksController = new BooksController(_context);

            //Act
            var result = await BooksController.Pages(1, 1);

            // Assert
            Assert.IsInstanceOf<ViewResult>(result);
        }
    }
}

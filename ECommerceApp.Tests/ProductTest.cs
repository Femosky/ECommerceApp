﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.Tests
{
    [TestFixture]
    public class ProductTest
    {
        public Product _product { get; set; } = null;

        [SetUp]
        public void Setup()
        {
            // Default values
            _product = new Product(144, "Product 1", 100.34, 30);
        }

        // TESTS FOR ATTRIBUTES

        // Test for ProductID
        [Test]
        public void Test_ProductID_ValidInitialValue()
        {
            // Assign
            var value = _product.ProductID;

            // Act
            _product.ProductID = value;

            // Assert
            Assert.That(_product.ProductID, Is.EqualTo(144));
        }

        [Test]
        public void Test_ProductID_MinValue()
        {
            // Assign
            var value = 1;

            // Act
            _product.ProductID = value;

            // Assert
            Assert.That(_product.ProductID, Is.EqualTo(1));
        }

        [Test]
        public void Test_ProductID_MaxValue()
        {
            // Assign
            var value = 1000;

            // Act
            _product.ProductID = value;

            // Assert
            Assert.That(_product.ProductID, Is.EqualTo(1000));
        }

        // Test for ProductName
        [Test]
        public void Test_ProductName_ValidInitialValue()
        {
            // Assign
            var value = _product.ProductName;

            // Act
            _product.ProductName = value;

            // Assert
            Assert.That(_product.ProductName, Is.EqualTo("Product 1"));
        }

        [Test]
        public void Test_ProductName_SpecialCharacters()
        {
            // Assign
            var value = "Product ##";

            // Act
            _product.ProductName = value;

            // Assert
            Assert.That(_product.ProductName, Is.EqualTo("Product ##"));
        }

        [Test]
        public void Test_ProductName_EmptyString()
        {
            // Assign
            var value = "";

            // Act
            _product.ProductName = value;

            // Assert
            Assert.That(_product.ProductName, Is.EqualTo(""));
        }
    }
}
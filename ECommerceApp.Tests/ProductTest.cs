using System;
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

        // Test for Price
        [Test]
        public void Test_Price_ValidInitialValue()
        {
            // Assign
            var value = _product.Price;

            // Act
            _product.Price = value;

            // Assert
            Assert.That(_product.Price, Is.EqualTo(100.34));
        }

        [Test]
        public void Test_Price_MinValue()
        {
            // Assign
            var value = 1.00;

            // Act
            _product.Price = value;

            // Assert
            Assert.That(_product.Price, Is.EqualTo(1.00));
        }

        [Test]
        public void Test_Price_MaxValue()
        {
            // Assign
            var value = 5000.00;

            // Act
            _product.Price = value;

            // Assert
            Assert.That(_product.Price, Is.EqualTo(5000.00));
        }

        // Test for Stock
        [Test]
        public void Test_Stock_ValidInitialValue()
        {
            // Assign
            var value = _product.Stock;

            // Act
            _product.Stock = value;

            // Assert
            Assert.That(_product.Stock, Is.EqualTo(30));
        }

        [Test]
        public void Test_Stock_MinValue()
        {
            // Assign
            var value = 1;

            // Act
            _product.Stock = value;

            // Assert
            Assert.That(_product.Stock, Is.EqualTo(1));
        }

        [Test]
        public void Test_Stock_MaxValue()
        {
            // Assign
            var value = 1000;

            // Act
            _product.Stock = value;

            // Assert
            Assert.That(_product.Stock, Is.EqualTo(1000));
        }

        // TESTS FOR METHODS

        // Test for IncreaseStock method
        [Test]
        public void Test_IncreaseStock_ValidValue()
        {
            // Assign
            var value = 5;

            // Act
            _product.IncreaseStock(value);

            // Assert
            Assert.That(_product.Stock, Is.EqualTo(35)); // Initial Stock value = 30
        }

        [Test]
        public void Test_IncreaseStock_NegativeValue()
        {
            // Assign
            var value = -5;

            // Act
            _product.IncreaseStock(value);

            // Assert
            Assert.That(_product.Stock, Is.EqualTo(30)); // Initial Stock value = 30 (Value should not change - cannot got below 0)
        }

        [Test]
        public void Test_IncreaseStock_LimitValue()
        {
            // Assign
            var value = 970;

            // Act
            _product.IncreaseStock(value);

            // Assert
            Assert.That(_product.Stock, Is.EqualTo(1000)); // Initial Stock value = 30
        }

        // Test for DecreaseStock method
        [Test]
        public void Test_DecreaseStock_NormalValue()
        {
            // Assign
            var value = 5;

            // Act
            _product.DecreaseStock(value);

            // Assert
            Assert.That(_product.Stock, Is.EqualTo(25)); // Initial Stock value = 30
        }

        [Test]
        public void Test_DecreaseStock_LimitValue()
        {
            // Assign
            var value = 30;

            // Act
            _product.DecreaseStock(value);

            // Assert
            Assert.That(_product.Stock, Is.EqualTo(0)); // Initial Stock value = 30
        }

        [Test]
        public void Test_DecreaseStock_InvalidValue()
        {
            // Assign
            var value = 40;

            // Act
            _product.DecreaseStock(value);

            // Assert
            Assert.That(_product.Stock, Is.EqualTo(30)); // Initial Stock value = 30 (Value should not change - cannot got below 0)
        }
    }
}

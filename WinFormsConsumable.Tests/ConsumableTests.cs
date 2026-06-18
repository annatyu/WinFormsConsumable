using NUnit.Framework;
using System;
using WinFormsConsumable; // Пространство имен вашего основного проекта

namespace WinFormsConsumable.Tests
{
    [TestFixture]
    public class ConsumableTests
    {
        private ConsumableValidator _validator;

        [SetUp]
        public void Setup()
        {
            _validator = new ConsumableValidator();
        }

        [Test]
        public void CheckConsumableData_BaseFlow_ReturnsTrue()
        {
            // Arrange
            string name = "Линзы для глаз";
            string cycle = "1";
            string period = "мес.";

            // Act
            bool result = _validator.CheckConsumableData(name, cycle, period);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void CheckConsumableData_EmptyName_ThrowsArgumentException()
        {
            // Arrange
            string name = "";
            string cycle = "3";
            string period = "нед.";

            // Act & Assert
            // Сначала проверяем тип исключения и сохраняем его в переменную ex
            var ex = Assert.Throws<ArgumentException>(() =>
                _validator.CheckConsumableData(name, cycle, period));

            // Затем отдельно проверяем, что внутри исключения содержится правильный текст
            Assert.That(ex.Message, Does.Contain("Название расходника не может быть пустым"));
        }

        [Test]
        public void CheckConsumableData_InvalidCycleNotANumber_ThrowsFormatException()
        {
            // Arrange
            string name = "Губка для посуды";
            string cycle = "две";
            string period = "нед.";

            // Act & Assert
            var ex = Assert.Throws<FormatException>(() =>
                _validator.CheckConsumableData(name, cycle, period));

            Assert.That(ex.Message, Does.Contain("Значение цикла должно быть числом"));
        }
    }
}
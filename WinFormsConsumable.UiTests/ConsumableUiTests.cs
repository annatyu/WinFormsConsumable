using NUnit.Framework;
using FlaUI.Core;
using FlaUI.Core.AutomationElements;
using FlaUI.UIA3;
using System.IO;

namespace WinFormsConsumable.UiTests
{
    [TestFixture]
    public class ConsumableUiTests
    {
        private FlaUI.Core.Application _app;
        private Window _window;
        private UIA3Automation _automation;

        [SetUp]
        public void TestSetup()
        {
            // Укажите точный путь к вашему скомпилированному .exe файлу приложения
            string appPath = @"D:\Study_2025_2026\TP\Practica\WinFormsConsumable\WinFormsConsumable\bin\Debug\net10.0-windows\WinFormsConsumable.exe";

            // Запускаем приложение
            _app = FlaUI.Core.Application.Launch(appPath);
            _automation = new UIA3Automation();

            // Получаем главное окно программы
            _window = _app.GetMainWindow(_automation);
        }

        [TearDown]
        public void TestTeardown()
        {
            // Закрываем автоматизацию и приложение после теста
            _automation.Dispose();
            _app.Close();
        }

        [Test]
        public void System_AddConsumable_SuccessfullyDisplaysInList()
        {
            // 1. Находим элементы на форме по их AutomationId (или по типу)
            var txtName = _window.FindFirstDescendant(cf => cf.ByAutomationId("txtNameField")).AsTextBox();
            var txtCycle = _window.FindFirstDescendant(cf => cf.ByAutomationId("txtCycleValueField")).AsTextBox();
            var cbPeriod = _window.FindFirstDescendant(cf => cf.ByAutomationId("cbPeriodTypeField")).AsComboBox();
            var btnSave = _window.FindFirstDescendant(cf => cf.ByAutomationId("btnSaveConsumable")).AsButton();
            var listBox = _window.FindFirstDescendant(cf => cf.ByAutomationId("listBoxItems")).AsListBox();

            // 2. Имитируем ввод данных реальным пользователем
            txtName.Text = "Зубная щетка";
            txtCycle.Text = "3";
            //cbPeriod.Select("мес."); // Выбираем первый элемент в выпадающем списке (например, "мес.")
            // Принудительно вписываем текст в ComboBox, имитируя выбор пользователя
            cbPeriod.EditableText = "мес.";
            // 3. Робот нажимает на кнопку "Добавить"
            btnSave.Click();
            System.Threading.Thread.Sleep(300);
            // 4. Проверяем результат (системное ожидание)
            // Ищем, появился ли в ListBox добавленный элемент
            Assert.That(listBox.Items, Has.Length.GreaterThan(0), "Список расходников пуст!");
            Assert.That(listBox.Items[0].Text, Does.Contain("Зубная щетка"), "Расходник не добавился в интерфейс.");
        }
    }
}
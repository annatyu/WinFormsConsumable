using NUnit.Framework;
using FlaUI.Core;
using FlaUI.Core.AutomationElements;
using FlaUI.UIA3;
using System.IO;
using System;

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
            _automation?.Dispose();
            _app?.Close();
        }

        // ТЕСТ 1: Успешное добавление расходника (Вариант "мес.")
        [Test]
        public void System_AddConsumable_SuccessfullyDisplaysInList()
        {
            var txtName = _window.FindFirstDescendant(cf => cf.ByAutomationId("txtNameField")).AsTextBox();
            var txtCycle = _window.FindFirstDescendant(cf => cf.ByAutomationId("txtCycleValueField")).AsTextBox();
            var cbPeriod = _window.FindFirstDescendant(cf => cf.ByAutomationId("cbPeriodTypeField")).AsComboBox();
            var btnSave = _window.FindFirstDescendant(cf => cf.ByAutomationId("btnSaveConsumable")).AsButton();
            var listBox = _window.FindFirstDescendant(cf => cf.ByAutomationId("listBoxItems")).AsListBox();

            txtName.Text = "Зубная щетка";
            txtCycle.Text = "3";
            cbPeriod.EditableText = "мес.";

            btnSave.Click();
            System.Threading.Thread.Sleep(300);

            Assert.That(listBox.Items, Has.Length.GreaterThan(0), "Список расходников пуст!");
            Assert.That(listBox.Items[0].Text, Does.Contain("Зубная щетка"), "Расходник не добавился в интерфейс.");
        }

        // ТЕСТ 2: Альтернативный сценарий добавления (Вариант "нед.")
        [Test]
        public void System_AddConsumable_WithWeeksPeriod_SuccessfullyDisplaysInList()
        {
            var txtName = _window.FindFirstDescendant(cf => cf.ByAutomationId("txtNameField")).AsTextBox();
            var txtCycle = _window.FindFirstDescendant(cf => cf.ByAutomationId("txtCycleValueField")).AsTextBox();
            var cbPeriod = _window.FindFirstDescendant(cf => cf.ByAutomationId("cbPeriodTypeField")).AsComboBox();
            var btnSave = _window.FindFirstDescendant(cf => cf.ByAutomationId("btnSaveConsumable")).AsButton();
            var listBox = _window.FindFirstDescendant(cf => cf.ByAutomationId("listBoxItems")).AsListBox();

            txtName.Text = "Фильтр для воды";
            txtCycle.Text = "2";
            cbPeriod.EditableText = "нед."; // Проверяем другую ветку логики и данных

            btnSave.Click();
            System.Threading.Thread.Sleep(300);

            Assert.That(listBox.Items, Has.Length.GreaterThan(0), "Список расходников пуст!");
            Assert.That(listBox.Items[0].Text, Does.Contain("Фильтр для воды"), "Второй расходник не отобразился.");
        }

        // ТЕСТ 3: Негативный сценарий. Проверка вызова окна ошибки при пустом периоде
        [Test]
        public void System_AddConsumable_EmptyPeriod_ShowsValidationErrorWindow()
        {
            var txtName = _window.FindFirstDescendant(cf => cf.ByAutomationId("txtNameField")).AsTextBox();
            var txtCycle = _window.FindFirstDescendant(cf => cf.ByAutomationId("txtCycleValueField")).AsTextBox();
            var cbPeriod = _window.FindFirstDescendant(cf => cf.ByAutomationId("cbPeriodTypeField")).AsComboBox();
            var btnSave = _window.FindFirstDescendant(cf => cf.ByAutomationId("btnSaveConsumable")).AsButton();

            txtName.Text = "Линзы контактные";
            txtCycle.Text = "1";
            cbPeriod.EditableText = ""; // Намеренно оставляем тип периода пустым!

            btnSave.Click();
            System.Threading.Thread.Sleep(500); // Даем время на появление модального окна

            // Ищем модальное окно ошибки (MessageBox), которое перекрывает главное окно
            var modalWindows = _window.ModalWindows;

            // Проверяем, что окно предупреждения физически появилось
            Assert.That(modalWindows, Has.Length.GreaterThan(0), "Диалоговое окно валидации не появилось!");
            // Извлекаем первое открывшееся диалоговое окно
            var messageBox = modalWindows[0];
            // Автоматически закрываем окно MessageBox (нажимаем кнопку ОК), чтобы тест не завис
            var btnOk = modalWindows[0].FindFirstDescendant(cf => cf.ByText("OK")).AsButton();
            btnOk?.Click();
        }
    }
}
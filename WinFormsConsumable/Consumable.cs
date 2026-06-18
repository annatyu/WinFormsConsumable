using System;

namespace WinFormsConsumable
{
    public class ConsumableValidator
    {
        private readonly IConsumableRepository _repository;

        // Конструктор принимает зависимость (опционально для старых тестов)
        public ConsumableValidator(IConsumableRepository repository = null)
        {
            _repository = repository;
        }
        public bool CheckConsumableData(string name, string cycleValue, string periodType)
        {
            // 1. Проверка на пустоту имени
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Название расходника не может быть пустым");
            }
            // 2. Проверка дубликата имени в БД(Использование зависимости)
            if (_repository != null && _repository.IsNameExists(name))
            {
                throw new InvalidOperationException("Расходник с таким названием уже существует");
            }

            // 3. Проверка, что цикл является числом
            if (!int.TryParse(cycleValue, out int parsedCycle))
            {
                throw new FormatException("Значение цикла должно быть числом");
            }

            // 4. Проверка на положительное значение числового цикла
            if (parsedCycle <= 0)
            {
                throw new ArgumentOutOfRangeException("cycleValue", "Цикл замены должен быть больше нуля");
            }

            // 5. Проверка периода
            if (string.IsNullOrWhiteSpace(periodType))
            {
                throw new ArgumentException("Не выбран тип периода");
            }

            return true;
        }
    }
}
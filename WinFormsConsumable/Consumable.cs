using System;

namespace WinFormsConsumable
{
    public class ConsumableValidator
    {
        public bool CheckConsumableData(string name, string cycleValue, string periodType)
        {
            // 1. Проверка на пустоту имени
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Название расходника не может быть пустым");
            }

            // 2. Проверка, что цикл является числом
            if (!int.TryParse(cycleValue, out int parsedCycle))
            {
                throw new FormatException("Значение цикла должно быть числом");
            }

            // 3. Проверка на положительное значение числового цикла
            if (parsedCycle <= 0)
            {
                throw new ArgumentOutOfRangeException("cycleValue", "Цикл замены должен быть больше нуля");
            }

            // 4. Проверка периода
            if (string.IsNullOrWhiteSpace(periodType))
            {
                throw new ArgumentException("Не выбран тип периода");
            }

            return true;
        }
    }
}
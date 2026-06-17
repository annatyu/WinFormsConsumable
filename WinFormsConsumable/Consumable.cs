using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsConsumable
{
    public class Consumable
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public int CycleDays { get; set; }
        public DateTime LastReplaceDate { get; set; }
        public DateTime NextDueDate { get; set; }
        public int ReminderDaysBefore { get; set; } = 7;

        public void UpdateLastReplacedDate(DateTime newDate)
        {
            if (newDate == default)
                throw new ArgumentException("Дата замены не может быть пустой");

            LastReplaceDate = newDate;
            CalculateNextDueDate();
        }

        public void CalculateNextDueDate()
        {
            if (CycleDays <= 0)
                throw new InvalidOperationException("Цикл замены должен быть положительным числом");

            NextDueDate = LastReplaceDate.AddDays(CycleDays);
        }

        public bool IsDueSoon()
        {
            return DateTime.Today.AddDays(ReminderDaysBefore) >= NextDueDate;
        }
    }
}


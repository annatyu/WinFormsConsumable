using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsConsumable
{
    public interface IConsumableRepository
    {
        // Метод возвращает true, если расходник с таким именем уже есть в БД
        bool IsNameExists(string name);
    }
}

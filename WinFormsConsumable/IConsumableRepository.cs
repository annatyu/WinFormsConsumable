using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsConsumable
{
    internal interface IConsumableRepository
    {
        // Метод возвращает true, если расходник с таким именем уже есть в БД
        bool IsNameExists(string name);
    }
}

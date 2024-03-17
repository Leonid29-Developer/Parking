using System;

namespace Test135.Exceptions.Information
{
    /// <summary> Класс-сообщение «Загрузка данных завершилась успешно» </summary>
    public class LoadData : Exception
    {
        public LoadData() : base($"Загрузка данных завершилась успешно")
            => Data.Add("Say", "Результат");
    }
}
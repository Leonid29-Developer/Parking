using System;

namespace Test135.Exceptions.Information
{
    /// <summary> Класс-сообщение «Сохранение данных завершилось успешно» </summary>
    public class SaveData : Exception
    {
        public SaveData() : base($"Сохранение данных завершилось успешно")
            => Data.Add("Say", "Результат");
    }
}
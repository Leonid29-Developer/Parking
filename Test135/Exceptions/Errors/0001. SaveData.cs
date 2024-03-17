using System;

namespace Test135.Exceptions.Errors
{
    /// <summary> Error #0001 <br/> 
    /// Класс-исключение «Загрузка данных завершилась с ошибкой» </summary>
    public class SaveData : Exception
    {
        public SaveData() : base($"Сохранение данных завершилось с ошибкой")
            => Data.Add("Kod", "Ошибка #0001");
    }
}
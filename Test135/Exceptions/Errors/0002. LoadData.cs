using System;

namespace Test135.Exceptions.Errors
{
    /// <summary> Error #0002 <br/> 
    /// Класс-исключение «Загрузка данных завершилась с ошибкой» </summary>
    public class LoadData : Exception
    {
        public LoadData() : base($"Загрузка данных завершилась с ошибкой")
            => Data.Add("Kod", "Ошибка #0002");
    }
}
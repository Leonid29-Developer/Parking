using System;

namespace Test135.Exceptions.Errors
{
    /// <summary> Error #0003 <br/> 
    /// Класс-исключение «Не удалось создать транспорт» </summary>
    public class FailedCreateTransport : Exception
    {
        public FailedCreateTransport() : base($"Не удалось создать транспорт")
            => Data.Add("Kod", "Ошибка #0003");
    }
}
using System;

namespace Test135.Exceptions.Errors
{
    /// <summary> Error #0005 <br/> 
    /// Класс-исключение «Транспорт не найден на заданном парковочном месте» </summary>
    /// <param name="Index">Номер парковочного места</param>
    public class NoParkingPlaceFound : Exception
    {
        public NoParkingPlaceFound(int Index) : base($"Транспорт не найден на парковочном месте [{Index}]")
        => Data.Add("Kod", "Ошибка #0005");
    }
}
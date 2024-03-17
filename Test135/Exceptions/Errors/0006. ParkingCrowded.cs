using System;

namespace Test135.Exceptions.Errors
{
    /// <summary> Error #0006 
    /// <br/> Класс-исключение «На парковке нет свободных мест» </summary>
    public class ParkingCrowded : Exception
    {
        public ParkingCrowded() : base($"На парковке нет свободных мест")
            => Data.Add("Kod", "Ошибка #0006");
    }
}
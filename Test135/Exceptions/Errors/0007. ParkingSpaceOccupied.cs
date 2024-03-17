using System;

namespace Test135.Exceptions.Errors
{
    /// <summary> Error #0007 <br/> Класс-исключение «Парковочное место занято» </summary>
    /// <param name="Index">Номер парковочного места</param>
    public class ParkingSpaceOccupied : Exception
    {
        public ParkingSpaceOccupied(int Index) : base($"Парковочное место [{Index}] занято")
            => Data.Add("Kod", "Ошибка #0007");
    }
}
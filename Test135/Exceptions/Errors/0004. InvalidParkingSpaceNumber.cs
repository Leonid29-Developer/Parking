using System;

namespace Test135.Exceptions.Errors
{
    /// <summary> Error #0004 
    /// <br/> Класс-исключение «Введен недопустимый номер парковочного места» </summary>
    /// <param name="Index">Номер парковочного места</param>
    public class InvalidParkingSpaceNumber : Exception
    {
        public InvalidParkingSpaceNumber(int Index) : base($"Введен недопустимый номер [{Index}] парковочного места")
            => Data.Add("Kod", "Ошибка #0004");
    }
}
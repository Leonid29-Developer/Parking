using System;

namespace Test135.Exceptions.Errors
{
    /// <summary> Error #0008 <br/> Класс-исключение «Недопустимый номер парковочного уровня» </summary>
    /// <param name="Index">Номер парковочного уровня</param>
    public class UnacceptableParkingLevelNumber : Exception
    {
        public UnacceptableParkingLevelNumber(int Index) : base($"Недопустимый номер [{Index}] парковочного уровня")
            => Data.Add("Kod", "Ошибка #0008");
    }
}
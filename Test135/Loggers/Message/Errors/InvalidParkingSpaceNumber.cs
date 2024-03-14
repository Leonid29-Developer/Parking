using System.Windows.Forms;

namespace Test135.Loggers.Message.Errors
{
    public class InvalidParkingSpaceNumber
    {
        /// <summary> Error #44776 <br/> Класс-исключение «Введен недопустимый номер парковочного места» </summary>
        /// <param name="Index">Номер парковочного места</param>
        public InvalidParkingSpaceNumber(int Index) => MessageBox.Show
            ($"Введен недопустимый номер [{Index}] парковочного места", "Ошибка #44776", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
using System.Windows.Forms;

namespace Test135.Loggers.Message.Errors
{
    public class UnacceptableParkingLevelNumber
    {
        /// <summary> Error #45852 <br/> Класс-исключение «Недопустимый номер парковочного уровня» </summary>
        /// <param name="Index">Номер парковочного уровня</param>
        public UnacceptableParkingLevelNumber(int Index) => MessageBox.Show
            ($"Недопустимый номер [{Index}] парковочного уровня", "Ошибка #45852", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
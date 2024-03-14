using System.Windows.Forms;

namespace Test135.Loggers.Message.Errors
{
    public class NoParkingPlaceFound
    {
        /// <summary> Error #21392 <br/> Класс-исключение «Транспорт не найден на заданном парковочном месте» </summary>
        /// <param name="Index">Номер парковочного места</param>
        public NoParkingPlaceFound(int Index) => MessageBox.Show
            ($"Транспорт не найден на парковочном месте [{Index}]", "Ошибка #21392", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
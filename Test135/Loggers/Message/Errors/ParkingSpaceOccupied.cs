using System.Windows.Forms;

namespace Test135.Loggers.Message.Errors
{
    public class ParkingSpaceOccupied
    {
        /// <summary> Error #83433 <br/> Класс-исключение «Парковочное место занято» </summary>
        /// <param name="Index">Номер парковочного места</param>
        public ParkingSpaceOccupied(int Index) => MessageBox.Show
            ($"Парковочное место [{Index}] занято", "Ошибка #83433", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
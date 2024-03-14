using System.Windows.Forms;

namespace Test135.Loggers.Message.Errors
{
    public class ParkingCrowded
    {
        /// <summary> Error #50475 <br/> Класс-исключение «На парковке нет свободных мест» </summary>
        public ParkingCrowded() => MessageBox.Show
            ("На парковке нет свободных мест", "Ошибка #50475", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
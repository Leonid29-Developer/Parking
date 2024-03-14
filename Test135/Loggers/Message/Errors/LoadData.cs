using System.Windows.Forms;

namespace Test135.Loggers.Message.Errors
{
    public class LoadData
    {
        /// <summary> Error #87242 <br/> Класс-исключение «Загрузка данных завершилась с ошибкой» </summary>
        public LoadData() => MessageBox.Show
            ("Загрузка данных завершилась с ошибкой", "Ошибка #87242", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
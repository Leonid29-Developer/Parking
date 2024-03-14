using System.Windows.Forms;

namespace Test135.Loggers.Message.Information
{
    public class LoadData
    {
        /// <summary> Класс-сообщение «Загрузка данных завершилась успешно» </summary>
        public LoadData() => MessageBox.Show
            ("Загрузка данных завершилась успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
using System.Windows.Forms;

namespace Test135.Loggers.Message.Information
{
    public class SaveData
    {
        /// <summary> Класс-сообщение «Сохранение данных завершилось успешно» </summary>
        public SaveData() => MessageBox.Show
            ("Сохранение данных завершилось успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
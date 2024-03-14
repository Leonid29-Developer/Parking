using System.Windows.Forms;

namespace Test135.Loggers.Message.Errors
{
    public class SaveData
    {
        /// <summary> Error #87238 <br/> Класс-исключение «Загрузка данных завершилась с ошибкой» </summary>
        public SaveData() => MessageBox.Show
            ("Сохранение данных завершилось с ошибкой", "Ошибка #87238", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
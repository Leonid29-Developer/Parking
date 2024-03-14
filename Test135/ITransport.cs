using System.Drawing;

namespace Test135
{
    public interface ITransport
    {
        /// <summary> Получение типа транспорта </summary>
        Transports GetTypeTransport();

        /// <summary> Получение направления транспорта </summary>
        Directions GetDirection();

        /// <summary> Получение позиции автомобиля </summary>
        Point GetPosition();

        /// <summary> Получение размера автомобиля </summary>
        Size GetSize();

        /// <summary> Установка позиции автомобиля </summary>
        /// <param name="XY">Координаты</param>
        /// <param name="Width_Height">Размер картинки</param>
        void SetPosition(Point XY, Size Width_Height);

        /// <summary> Изменение направления пермещения </summary>
        /// <param name="Direction">Направление</param>
        void MoveTransport(Directions NewDirection);

        /// <summary> Изменение цвета транспорта </summary>
        /// <param name="NewColor">Назначаемый цвет</param>
        /// <param name="TypeColor">Тип назначаемого цвета</param>
        void SetColor(Color NewColor, TypesСolors TypeColor);

        /// <summary> Получение параметра Bitmap транспорта </summary>
        Bitmap FlagBM { get; }

        /// <summary> Метод отрисовки траспорта </summary>
        /// <param name="Grap_Transport">Элемент управления - Интерфейс</param>
        void Draw(Graphics Grap_Transport);
    }
}
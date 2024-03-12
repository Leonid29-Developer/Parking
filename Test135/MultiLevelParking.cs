using System.Collections.Generic;
using System.Drawing;

namespace Test135
{
    public class MultiLevelParking
    {
        /// <summary> Список с уровнями парковки </summary>
        List<Parking<ITransport>> parkingStages;

        /// <summary> Конструктор </summary>
        /// <param name="countStages">Количество уровенй парковки</param>
        public MultiLevelParking(int countStages, Size PictureSize)
        {
            parkingStages = new List<Parking<ITransport>>();
            for (int i = 0; i < countStages; ++i)
                parkingStages.Add(new Parking<ITransport>(new Size(PictureSize.Width, PictureSize.Height)));
        }

        /// <summary> Индексатор </summary>
        public Parking<ITransport> this[int ind]
        {
            get
            {
                if (ind > -1 && ind < parkingStages.Count)
                    return parkingStages[ind];
                return null;
            }
        }
    }
}
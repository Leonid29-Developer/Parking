namespace Test135
{
    /// <summary> Дополнительные элементы транспорта </summary>
    public class AdditionalElements
    {
        public AdditionalElements(bool Num1, bool Num2, bool Num3, bool Num4)
        { Slot_1 = Num1; Slot_2 = Num2; Slot_3 = Num3; Slot_4 = Num4; }

        // Слоты для дополнительных элементов
        public bool Slot_1 { private set; get; }
        public bool Slot_2 { private set; get; }
        public bool Slot_3 { private set; get; }
        public bool Slot_4 { private set; get; }
    }
}
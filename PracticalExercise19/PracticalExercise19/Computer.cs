namespace PracticalExercise19
{
    internal class Computer
    {
        public string Model { get; set; }

        public string CPU { get; set; }

        public float CpuClockRate { get; set; }

        public uint RAM { get; set; }

        public uint HDD { get; set; }

        public uint VRAM { get; set; }

        public uint Price { get; set; }

        public uint InStockCount { get; set; }

        public override string ToString()
        {
            return $"Модель: {Model}\n" +
                $"Тип процессора: {CPU}\n" +
                $"Частота процессора: {CpuClockRate} ГГц\n" +
                $"Объем ОЗУ: {RAM} ГБ\n" +
                $"Объем диска: {HDD} ГБ\n" +
                $"Объем видеопамяти: {VRAM} ГБ\n" +
                $"Стоимость: {Price}\n" +
                $"Кол-во в наличии: {InStockCount}";
        }
    }
}

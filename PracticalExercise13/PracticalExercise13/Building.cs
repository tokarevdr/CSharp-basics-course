namespace PracticalExercise13
{
    internal class Building
    {
        private string adress;
        uint length;
        uint width;
        uint height;

        public Building(string adress, uint length, uint width, uint height)
        {
            this.adress = adress;
            this.length = length;
            this.width = width;
            this.height = height;
        }

        public string Print()
        {
            return $"Здание\nадрес: {adress}\nдлина: {length} м\nширина: {width} м\nвысота: {height} м";
        }
    }
}

namespace PracticalExercise13
{
    internal class MultiBuilding : Building
    {
        private uint floorCount;

        public MultiBuilding(string adress, uint length, uint width, uint height, uint floorCount)
            : base(adress, length, width, height)
        {
            this.floorCount = floorCount;
        }

        new public string Print()
        {
            return base.Print() + $"\nкол-во этажей: {floorCount}";
        }
    }
}

namespace PracticalExercise15
{
    internal class GeomProgression : ISeries
    {
        private int start;
        private int step;
        private int currentValue;

        public int GetNext()
        {
            return currentValue *= step;
        }

        public void Reset()
        {
            currentValue = start;
        }

        public void SetStart(int x)
        {
            start = x;
            currentValue = start;
        }

        public void SetStep(int x)
        {
            step = x;
        }
    }
}

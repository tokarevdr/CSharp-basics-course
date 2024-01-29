namespace PracticalExercise16
{
    public class Product
    {
        private double price;

        public uint Id { get; set; }
        public string Name { get; set; }
        public double Price 
        {
            get
            {
                return price;
            }

            set
            {
                if (value < 0)
                {
                    throw new System.ArgumentException("Значение цены не должно быть меньше нуля.");
                }

                price = value;
            }
        }

        public override string ToString()
        {
            return $"{Id} {Name} {Price}";
        }
    }
}

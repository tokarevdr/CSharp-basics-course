using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalExercise17
{
    internal class BankAccount<T>
    {
        public T Id { get; set; }
        public double Balance { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Счет: {Id}\nБаланс: {Balance}\nФИО: {Name}";
        }
    }
}

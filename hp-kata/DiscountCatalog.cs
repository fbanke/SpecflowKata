using System.Collections.Generic;

namespace HarryPotter
{
    internal class DiscountCatalog
    {
        private Dictionary<int, double> catalogue = new Dictionary<int, double>
        {
            {1, 0},
            {2, 0.05},
            {3, 0.1},
            {4, 0.15},
            {5, 0.20}
        };

        public double GetDiscount(int count)
        {
            return 1 - catalogue[count];
        }
    }
}
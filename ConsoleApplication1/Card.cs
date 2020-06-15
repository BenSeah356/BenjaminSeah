using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Card
    {
        public int Id { get; set; }
        public int WalletId { get; set; }
        public string CardType { get; set; }
        public float Balance { get; set; }
        public float Interest { get; set; }

        public float calculateCardInterest(float Balance, string CardType)
        {
            Interest = 0;
            if (CardType == "Visa")
            {
                Interest = 0.1f * Balance;
            }
            else if (CardType == "MC")
            {
                Interest = .05f * Balance;
            }
            else if (CardType == "Discover")
            {
                Interest = .01f * Balance;
            }
            else
            {
                Interest = 0f;
            }
            return Interest;
        }
    }
}

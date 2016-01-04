using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunescapeFlippingTracker
{
    class Item
    {

        private String Name;
        private int buyPrice = 0;
        private int sellPrice = 0;


        public Item(String ItemName)
        {
            this.Name = ItemName;
        }

        public int getBuyPrice()
        {
            return buyPrice;
        }

        public void setBuyPrice(int BuyPrice)
        {
            buyPrice = BuyPrice;
        }

        public int getSellPrice()
        {
            return sellPrice;
        }

        public void setSellPrice(int SellPrice)
        {
            sellPrice = SellPrice;
        }

    }
}

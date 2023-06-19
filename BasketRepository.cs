using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SGT2_Basket_006_0619
{
    public class BasketRepository
    {
        private List<BasketItem> _items = new List<BasketItem>();

        public decimal TotalBasketAmount { get; set; }


        public void Add(BasketItem item)
        {
            _items.Add(item);
            TotalBasketAmount += item.Price;
        }

        public void Remove(BasketItem item)
        {
            _items.Remove(item);
            TotalBasketAmount -= item.Price;
        }

        //Why not a list? 
        public IEnumerable<BasketItem> BasketItems => _items.AsReadOnly();


    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace WindowsFormsApplication1
{
    class Shop
    {
        public BindingList<ItemStorage> goods;
        public BindingList<Item> sold_goods;
        public BindingList<ItemStorage> deleted_goods;

        public Shop()                                                                        //Конструктор по умолчанию, инициализация переменных , хранящих списки товаров
        {
            goods = new BindingList<ItemStorage>();
            sold_goods = new BindingList<Item>();
            deleted_goods = new BindingList<ItemStorage>();
        }

        public bool FindByFilter(IEnumerable<Item> list, Predicate<Item> p)
        {
            Item item = list.FirstOrDefault(x => p(x) == true);
            if (item != null)
                return true;
            return false;
        }

        public double Sum(IEnumerable<Item> list, Predicate<Item> p, Func<Item, double> f)
        {
            double sum = list.Where(x => p(x) == true).Sum(x => f(x));
            return sum;
        }
    }
}

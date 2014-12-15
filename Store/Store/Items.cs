using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data.Entity;

namespace WindowsFormsApplication1
{ 
    public class Item
    {
        public int ItemId { get; set; }
        //Задание атрибутов полей и самих полей
        [DisplayName("Артикул")]
        public int id { get; set; }
        [DisplayName("Наименование")]
        public string name { get; set; }
        [DisplayName("Количество")]
        public int count { get; set; }
        [DisplayName("Цена")]
        public double price { get; set; }
        //[DisplayName("Место")]
        //public string place { get; set; }
        //fgdfgdfgdfg
        //dfgdfgdfgdfg

        public Item()                                                                                   //Объявляем пустой конструктор Item
        {

        }

        public Item(int tid, string tname, int tcount, double tprice)                    //Объявляем конструктор Item
        {
            id = tid;
            name = tname;
            count = tcount;
            price = tprice;
        }

        public Item(string line)
        {
            char[] separators = { ';' };                                                               //Создаем символьный массив разделителей              
            string[] str = line.Split(separators);                                                     //Разделяем строчку line по заданным разделителям в массиве Separators и сохраняем результат разбиения в массив str
            id = int.Parse(str[0]);
            name = str[1];
            count = int.Parse(str[2]);
            price = double.Parse(str[3]);
        }

        public virtual string GetItemInfo()                                                                   //Представление объектов в строковом формате
        {
            string info = string.Format("{0};{1};{2};{3}", id, name, count, price);        //Для всего объекта создаётся его строковое представление в нужном формате
            return info;
        }
        public virtual string GetItemFullInfo()                                                               //Представление объектов в строковом формате
        {
            string Info = string.Format("Артикул: {0};\nНаименование: {1};\nКоличество: {2};\nЦена: {3}", id, name, count, price);        //Для всего объекта создаётся его строковое представление в нужном формате
            return Info;
        }

    }

    public class ItemStorage : Item
    {
        public int ItemStorageId { get; set; }

        public ItemStorage() { }

        [DisplayName("Место")]
        public string place { get; set; }

        public bool IsDeleted { get; set; }

        public ItemStorage(int tid, string tname, int tcount, double tprice, string tplace, bool is_del):base(tid, tname, tcount, tprice)
        {
            place = tplace;
            IsDeleted = is_del;
        }

        public ItemStorage(string line, bool is_del):base(line)
        {
            place = line.Substring(line.LastIndexOf(';') + 1, line.Length - line.LastIndexOf(';') - 1);
            IsDeleted = is_del;
        }

        public override string GetItemInfo()
        {
            return String.Format( "{0};{1}", base.GetItemInfo(), place);
        }

        public override string GetItemFullInfo()
        {
            return String.Format("{0};\nМесто: {1}\n", base.GetItemFullInfo(), place);
        }
    }

    public class ItemFull : ItemStorage                                           //Объявляем класс с полями и их атрибутами
    {
        public int ItemFullId { get; set; }

        public ItemFull() { }

        //Задание атрибутов полей и самих полей
        [DisplayName("Тип")]
        public string type { get; set; }

        public ItemFull(Item item, string t)
           : base(item.id, item.name, item.count, item.price, (item is ItemStorage) ? (item as ItemStorage).place : "Продано", (item is ItemStorage) ? (item as ItemStorage).IsDeleted : false)                       //Объявляем конструктор ItemFull
        {
            type = t;
        }

    }

    public class MyContex : DbContext
    {
        public DbSet<ItemStorage> gad { get; set; }
        public DbSet<Item> sold { get; set; }
    }

}

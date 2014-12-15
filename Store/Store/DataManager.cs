using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.IO;

namespace WindowsFormsApplication1
{
    class DataManager
    {
        public MyContex context = new MyContex();
        
        //Создаём публичные строки, хранящие путь к файлам
        public  string file_path = @"Goods.txt";
        public  string file_path1 = @"Deleted.txt";
        public  string file_path2 = @"Sold.txt";

        public void InitDb(Shop shop)
        {
            /*context.Database.ExecuteSqlCommand("delete from Items");
            context.SaveChanges();

            foreach (ItemStorage item in shop.goods)
            {
                context.gad.Add(item);
            }

            foreach (ItemStorage item in shop.deleted_goods)
            {
                context.gad.Add(item);
            }

            foreach (Item item in shop.sold_goods)
            {
                context.sold.Add(item);
            }

            context.SaveChanges();*/
        }

        public void ReadFromFile(ref BindingList<ItemStorage> objects, string path)                               //Объявляем приватный метод, считывающий информацию из файла, возвращающий массив 
        {
            BindingList<Item> temp = new BindingList<Item>();
            ReadFromFile(ref temp, path);
            foreach (Item x in temp)
                objects.Add(x as ItemStorage);
        }

        public void ReadFromFile(ref BindingList<Item> objects, string path)                               //Объявляем приватный метод, считывающий информацию из файла, возвращающий массив 
        {
            if (path.Contains("Goods"))
            {
                List<ItemStorage> temp = context.gad.Where(x => x.IsDeleted == false).ToList<ItemStorage>();
                for (int i = 0; i < temp.Count; i++)
                    objects.Add(temp[i]);
                return;
            }
            if (path.Contains("Deleted"))
            {
                List<ItemStorage> temp = context.gad.Where(x => x.IsDeleted == true).ToList<ItemStorage>();
                for (int i = 0; i < temp.Count; i++)
                    objects.Add(temp[i]);
                return;
            }
            if (path.Contains("Sold"))
            {
                List<Item> temp = context.sold.ToList<Item>();
                for (int i = 0; i < temp.Count; i++)
                    objects.Add(temp[i]);
                return;
            }

            /*objects.Clear();                                                                                //Очищаем массив 
            string line;
            StreamReader file = new StreamReader(path, Encoding.GetEncoding("Windows-1251"));               //Объявляем класс, считывающий символы из потока с учётом кодировки 
            while ((line = file.ReadLine()) != null)
            {
                if (line == String.Empty)
                    continue;
                Item s = new Item();

                if (path.Contains("Goods"))// || path.Contains("Deleted"))
                    s = new ItemStorage(line, false);                                                                    //Создаём экземпляр класса(товар) Item по выделенной строке
                else if(path.Contains("Deleted"))
                    s = new ItemStorage(line, true); 
                else
                    s = new Item(line);
                objects.Add(s);                                                                             //Добавляем в динамический массив
            }
            file.Close();*/                                                                                   //Закрываем поток
     }

        public void WriteToFile(string path, List<Item> objects, bool flag_append)                        //Объявялем публичный метод, записывающий информацию в файл
        {

           /* if (path.Contains("Goods") || path.Contains("Deleted"))
            {
                if (flag_append == true)   
                    objects.ForEach(x => context.gad.Add(x as ItemStorage));
            }
            if (path.Contains("Sold"))
            {
                if (flag_append == true)
                    objects.ForEach(x => context.sold.Add(x));
            }
            context.SaveChanges();*/

            /*StreamWriter sw = new StreamWriter(path, flag_append, Encoding.GetEncoding("Windows-1251"));   //Объявляем класс, записывающий символы в поток с учётом кодировки
            for (int i = 0; i < objects.Count; i++)
            {
                sw.WriteLine(objects[i].GetItemInfo());
            }
            sw.Close();*/                                                                                    //Закрываем поток
        }

    }
}

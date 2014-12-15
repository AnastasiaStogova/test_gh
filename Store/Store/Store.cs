using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace StoreOfGoods
{
    public partial class Store : Form
    {
        static DataManager data_mgr = new DataManager();                                  //Создаем объект класса DataManager
        static Shop shop = new Shop();                                                    //Создаем объект класса Shop
        static Func<Item, double> f_volume = x => x.price * x.count;

        public Store()
        {
            InitializeComponent();
            //BindingSource является "посредником" между таблицей на Form и массивом с данными. Осн.цель-автоматическая синхронизация данных между таблицей и массивом
            BindingSource source = new BindingSource(shop.goods, null);                      //Создаем объект BindingSource и связываем его с массивом goods
            dataGridView1.DataSource = source;                                               //Связываем объект BindingSource с таблицей
            data_mgr.ReadFromFile(ref shop.goods, data_mgr.file_path);

            BindingSource source1 = new BindingSource(shop.sold_goods, null);
            dataGridView2.DataSource = source1;
            data_mgr.ReadFromFile(ref shop.sold_goods, data_mgr.file_path2);

            BindingSource source2 = new BindingSource(shop.deleted_goods, null);
            dataGridView3.DataSource = source2;
            data_mgr.ReadFromFile(ref shop.deleted_goods, data_mgr.file_path1);

            //data_mgr.InitDb(shop);

            /*MyContex context = new MyContex();
            Iforeach (ItemStorage item in shop.goods)
            {
                context.gad.Add(item);
            }
            int xxx = context.SaveChanges();*/

            //List<ItemStorage> test = context.gad.Where(x=>x.price <= 20).ToList<ItemStorage>();
            //int a = 10;
            //a++;

            /**/
        }

        private void Store_Load(object sender, System.EventArgs e)
        {

        }

        public bool ArtikulCheck(string s)
        {
            int id = 0;
            bool is_correct_parse = Int32.TryParse(s, out id);
            if (id <= 0 || id.ToString().Length != 4 || is_correct_parse == false)    //Если "артикул" меньше или равен 0,совпадает с уже существующим или 
            {                                                                                    //его длина меньше 4, то выводим на экран сообщение о некорректном вводе
                MessageBox.Show("Ошибка! Некорректный ввод артикула!");
                return false;
            }
            return true;
        }

        private void AddInfo_Click(object sender, EventArgs e)                                 //Объявляем приватный метод, добавляющий информацию о товаре
        {
            string s1 = IDTextBox1.Text;
            string s2 = NameTextBox2.Text;
            string s3 = NumbTextBox3.Text;
            string s4 = PriceTextBox4.Text;
            string s5 = PlaceTextBox5.Text;

            int id = 0;
            bool is_correct_parse = Int32.TryParse(s1, out id);
            if (ArtikulCheck(s1) || shop.FindByFilter(shop.goods, x => x.id == id) == true)    //Если "артикул" меньше или равен 0,совпадает с уже существующим или 
            {                                                                                    //его длина меньше 4, то выводим на экран сообщение о некорректном вводе
                MessageBox.Show("Ошибка! Некорректный ввод артикула!"); 
                return;
            } 

            string name = NameTextBox2.Text;
            if (name.Length==0)                                                              //Если длина наименования равна 0, то выводим на экран сообщение
            {                                                                                //о некорректном вводе
                MessageBox.Show("Ошибка! Некорректный ввод наименования!");
                return;
            }
            int count = 0;
            bool Count = Int32.TryParse(s3, out count);
            if (count <= 0 || Count == false)                                                //Если "количество" меньше или равно 0, то выводим на экран сообщение
            {                                                                                //о некорректном вводе
                MessageBox.Show("Ошибка! Неккоректный ввод количества!");
                return;
            }
            double price = 0;
            bool Price = Double.TryParse(s4, out price);    
            if (price <= 0 || Price==false)                                                  //Если "цена" меньше или равна 0, то выводим на экран сообщение  
            {                                                                                //о некорректном вводе
                MessageBox.Show("Ошибка! Неккоректный ввод цены!");
                return;
            }
            string place = PlaceTextBox5.Text;
            if (place.Length == 0 || shop.FindByFilter(shop.goods, x => (x as ItemStorage).place == place) == true)                           //Если длина "места" равна 0 или уже существует,то выводим на экран
            {                                                                                //сообщение о некорректном вводе
                MessageBox.Show("Ошибка! Неккоректный ввод места!");
                return;
            }
            

            shop.goods.Add(new ItemStorage(id, name, count, price, place, false));                         //Создаём объект (товар) класса Item
            //data_mgr.WriteToFile(data_mgr.file_path, shop.goods.ToList<Item>(), false);                                  //Обновляем текстовый файл "Goods"
            
        }
       
        private void DeleteInfo_Click(object sender, EventArgs e)                           //Объявляем приватный метод, удаляющий информацию о товаре(бракованном)
        {
            string s1 = IDTextBox1.Text;

            int id = 0;
            bool is_correct_parse = Int32.TryParse(s1, out id);
            if (ArtikulCheck(s1) == false)        
                return;
            
            //Создаём списки объектов (динамические массивы)
            List<ItemStorage> temp_goods = new List<ItemStorage>();
            List<ItemStorage> del_goods = new List<ItemStorage>();
            for (int i = 0; i < shop.goods.Count; i++)
            {
                if (id != shop.goods[i].id)                                                 //Если введённый артикул не совпадает с уже существующим, то
                {                                                                           //добавляем товар в массив temp_goods
                    temp_goods.Add(shop.goods[i]);
                }
                else                                                                        //Иначе, добавляем в массив del_goods
                {
                    del_goods.Add(shop.goods[i]);
                }

            }
            shop.goods.Clear();                                                                    
            for (int i = 0; i < temp_goods.Count; i++)                                      //Делаем массив состоящий из эл-тов temp_goods
            {
                shop.goods.Add(temp_goods[i]);
            }
            data_mgr.WriteToFile(data_mgr.file_path, shop.goods.ToList<Item>(), false);                                 //Записываем информацию в файл "Goods" (обновление всего файла)
            data_mgr.WriteToFile(data_mgr.file_path2, del_goods.ToList<Item>(), true);                                    //Записываем информацию в файл "DeletedGoods" (обновление всего файла)
            data_mgr.ReadFromFile(ref shop.deleted_goods, data_mgr.file_path2);                      //Считываем информацию из файла "DeletedGoods"
        }

        private void SearchInfo_Click(object sender, EventArgs e)                           //Объявляем приватный метод, который ищет информацию от товаре
        {
            List<string> find_results = new List<string>();                                 //Создаем лист строк (динамический массив)
            dataGridView1.ClearSelection();
            string s1 = IDTextBox1.Text;                                                    //Проверяем "артикул" и "кол-во" на корректность введенных данных
            
            int id = 0;
            bool is_correct_parse = Int32.TryParse(s1, out id);
            if (ArtikulCheck(s1) == false)
                return;

            bool flag_correct = false;
            for (int i = 0; i < shop.goods.Count; i++)
            {
                if (id == shop.goods[i].id)                                                  //Если введённый артикул совпадает с уже существующим, то 
                {                                                                            //строка с информацией о товаре выделяется в таблице
                    dataGridView1.Rows[i].Selected = true;
                    flag_correct = true;
                    find_results.Add(shop.goods[i].GetItemFullInfo());
                }

            }
            if (flag_correct == false)                                                        //Если не совпадает, то на экран выводится сообщение о том, что товар не найден
            {
                MessageBox.Show("Не найдено!");
            }
            else
            {
                SearchForm f = new SearchForm(find_results);                                 //Выводим на экран "форму" с данными о выбранном товаре
                f.Show();
            }
        }

        private void SumButton_Click(object sender, EventArgs e)                             //Объявляем приватный метод, считающий сумму конкретного товара
        {
            string s1 = IDTextBox1.Text;
            int id = 0;
            bool is_correct_parse = Int32.TryParse(s1, out id);
            if (ArtikulCheck(s1) == false)
                return;

            double sum = shop.Sum(shop.goods, x => x.id == id, f_volume);
            if (sum == -1)                                                                    //Если сумма равна "-1", то выводим на экран сообщение о том, что товар не найден
                MessageBox.Show("Не найдено!");
            else                                                                              //Иначе, выводим на экран посчитанную сумму
                MessageBox.Show(sum.ToString());
        }

        private void SoldGoods_Click(object sender, EventArgs e)                              //Объявляем приватный метод, списывающий товар
        {
            string s1 = IDTextBox1.Text;
            int id = 0;
            bool is_correct_parse = Int32.TryParse(s1, out id);
            if (ArtikulCheck(s1) == false)
                return;

            string s3 = NumbTextBox3.Text;
            int count = 0;
            bool Count = Int32.TryParse(s3, out count);
            if (count <= 0 || Count == false)                                           
            {                                                                                       
                MessageBox.Show("Ошибка! Неккоректный ввод количества!");
                return;
            }
            
            //Создаём списки объектов (динамические массивы)
            List<Item> s_goods = new List<Item>();
            List<Item> not_null_goods = new List<Item>();
            for (int i = 0; i < shop.goods.Count; i++)
            {
                if (id == shop.goods[i].id && count != 0)                                    //Если введённый артикул совпадает с уже существующим и количество не равно 0
                {
                    if (count > shop.goods[i].count)                                         //Если введённое количество товара больше, чем существует на складе, то
                        MessageBox.Show("Не найдено!");                                      //выводим на экран сообщение о том, что товар не найден
                    else                                                                     //Иначе, из имеющего количества вычитаем введённое и добавляем объект класса 
                    {                                                                        //Item в массив s_goods
                        shop.goods[i].count -= count;
                        s_goods.Add(new Item(shop.goods[i].id, shop.goods[i].name, count, shop.goods[i].price));
                        count = 0;
                    }
                }
                if (shop.goods[i].count != 0)                                                 //Если количество не равно 0, то 
                {
                    not_null_goods.Add(shop.goods[i]);                                        //добавляем в массив not_null_goods
                }
            }

            data_mgr.WriteToFile(data_mgr.file_path, not_null_goods, false);                                        //Записываем информацию из not_null_goods в файл "Goods"(обновление всего файла)
            data_mgr.WriteToFile(data_mgr.file_path1, s_goods, true);                                           //Записываем информацию из s_goods в файл "SoldGoods"(обновление всего файла)

            data_mgr.ReadFromFile(ref shop.goods, data_mgr.file_path);                                       //Считываем информацию из файла "Goods"
            data_mgr.ReadFromFile(ref shop.sold_goods, data_mgr.file_path1);                              //Считываем информацию из файла "SoldGoods"

        }

        private void SumStore_Click(object sender, EventArgs e)                               //Объявляем приватный метод, считающий сумму всего склада
        {
            List<Item> all_goods = new List<Item>();
            all_goods.AddRange(shop.goods);
            all_goods.AddRange(shop.sold_goods);
            all_goods.AddRange(shop.deleted_goods);

            double sum1 = shop.Sum(all_goods, x => true, f_volume);
            if (sum1 == 0)                                                                    //Если сумма равна 0, то на экран выводим сообщени о том, что склад пуст
            {
                MessageBox.Show("Склад пуст!");
                return;
            }
            MessageBox.Show(sum1.ToString());                                                 //Иначе, выводим сумму всего склада на экран
        }

        private void SearchSoldGoods_Click(object sender, EventArgs e)                        //Объявляем приватный метод, который ищет информацию о списанном товаре
        {
            List<string> find_results = new List<string>();                                   //Создаем лист строк (динамический массив)
            dataGridView2.ClearSelection();
            string s6 = IdTextBox6.Text;
            int id = 0;
            bool is_correct_parse = Int32.TryParse(s6, out id);
            if (ArtikulCheck(s6) == false)
                return;

            bool flag_correct = false;
            for (int i = 0; i < shop.sold_goods.Count; i++)
            {
                if (id == shop.sold_goods[i].id)                                               //Если введённый артикул совпадает с уже существующим, то      
                {                                                                              //строка с информацией о товаре выделяется в таблице
                    dataGridView2.Rows[i].Selected = true;
                    flag_correct = true;
                    find_results.Add(shop.sold_goods[i].GetItemFullInfo());
                }

            }
            if (flag_correct == false)                                                         //Если не совпадает, то на экран выводится сообщение о том, что товар не найден                      
            {
                MessageBox.Show("Не найдено!");
            }
            else
            {
                SearchForm f = new SearchForm(find_results);                                  //На экран выводится "форма" с данными о выбранном товаре
                f.Show();
            }
        }

        private void SumButton1_Click(object sender, EventArgs e)                              //Объявляем приватный метод, считающий сумму конкретного списанного товара
        {
            string s6 = IdTextBox6.Text;
            int id = 0;
            bool is_correct_parse = Int32.TryParse(s6, out id);
            if (ArtikulCheck(s6) == false)
                return;

            double sum = shop.Sum(shop.sold_goods, x => x.id == id, f_volume);
            MessageBox.Show(sum.ToString());
        }

        private void SumSoldGoods_Click(object sender, EventArgs e)                            //Объявляем приватный метод, считающий сумму всех списанных товаров
        {
            double sum1 = shop.Sum(shop.sold_goods, x => true, f_volume);
            MessageBox.Show(sum1.ToString());
        }

        private void SearchDelInfo_Click(object sender, EventArgs e)                           //Объявляем приватный метод, который ищет информацию об удалённом(бракованном)товаре
        {
            List<string> find_results = new List<string>();                                   //Создаем лист строк (динамический массив)
            dataGridView3.ClearSelection();
            string s7 = IdTextBox7.Text;
            int id = 0;
            bool is_correct_parse = Int32.TryParse(s7, out id);
            if (ArtikulCheck(s7) == false)
                return;

            bool flag_correct = false;
            for (int i = 0; i < shop.deleted_goods.Count; i++)
            {
                if (id == shop.deleted_goods[i].id)                                             //Если введённый артикул совпадает с уже существующим, то 
                {
                    dataGridView3.Rows[i].Selected = true;                                      //строка с информацией о товаре выделяется в таблице
                    flag_correct = true;
                    find_results.Add(shop.deleted_goods[i].GetItemFullInfo());
                }

            }
            if (flag_correct == false)                                                          //Если не совпадает, то на экран выводится сообщение о том, что товар не найден
            {
                MessageBox.Show("Не найдено!");
            }
            else
            {
                SearchForm f = new SearchForm(find_results);                                    //Выводим на экран "форму" с данными о выбранном товаре
                f.Show();
            }
        }

        private void SumButton2_Click(object sender, EventArgs e)                               //Объявляем приватный метод, считающий сумму конкретного удалённого(бракованного) товара
        {
            string s7 = IdTextBox7.Text;
            int id = 0;
            bool is_correct_parse = Int32.TryParse(s7, out id);
            if (ArtikulCheck(s7) == false)
                return;

            double sum = shop.Sum(shop.deleted_goods, x => x.id == id, f_volume);
            MessageBox.Show(sum.ToString());
        }

        private void SumDelGoods_Click(object sender, EventArgs e)                             //Объявляем приватный метод, считающий сумму всех удалённых(бракованных) товаров
        {
            double sum1 = shop.Sum(shop.deleted_goods, x => true, f_volume);
            MessageBox.Show(sum1.ToString());
        }

        private void CloseStore_Click(object sender, EventArgs e)                              //Приватным метод, который позволяет выйти из программы
        {
            Close();
        }

        public void ShowAllGoods_Click(object sender, EventArgs e)                            //Публичный метод, который показывает информацию обо всех видах товара
        {
            List<ItemFull> items = new List<ItemFull>();                                      //Объявляем список объектов items
            for (int i = 0; i < shop.goods.Count; i++)
            {
                items.Add(new ItemFull(shop.goods[i], "Товар на складе"));                   //Копируем(добавляем) объекты из массива goods в массив items
            }
            for (int i = 0; i < shop.sold_goods.Count; i++)
            {
                items.Add(new ItemFull(shop.sold_goods[i], "Списанный товар"));              //Копируем(добавляем) объекты из массива sold_goods в массив items
            }
            for (int i = 0; i < shop.deleted_goods.Count; i++)
            {
                items.Add(new ItemFull(shop.deleted_goods[i], "Бракованный товар"));         //Копируем(добавляем) объекты из массива deleted_goods в массив items
            }

            AllItemsForm f = new AllItemsForm();                                            //Выводим на экран "форму" с инфорацией обо всех видах товара       
            f.items = items;
            f.Init();
            f.Show();
        }

        private void Store_FormClosing(object sender, FormClosingEventArgs e)                //Объявляем метод,сохраняющий изменения в "форме" в текстовый файл
        {
            string file_path1 = @"DeletedGoods.txt";
            string file_path2 = @"SoldGoods.txt";
            data_mgr.WriteToFile(data_mgr.file_path, shop.goods.ToList<Item>(), false);                                    //Сохраняем изменения в массив goods
            data_mgr.WriteToFile(data_mgr.file_path1, shop.deleted_goods.ToList<Item>(), false);              //Сохраняем изменения в массив deleted_goods
            data_mgr.WriteToFile(data_mgr.file_path2, shop.sold_goods.ToList(), false);                 //Сохраняем изменения в массив sold_goods
        }

        
    }
}     
        
    



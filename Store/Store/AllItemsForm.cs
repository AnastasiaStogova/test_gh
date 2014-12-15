using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StoreOfGoods;

namespace WindowsFormsApplication1
{

    public partial class AllItemsForm : Form
    {
        public List<ItemFull> items;                             //Объявляем список объектов items

        public AllItemsForm()                                    //Конструктор 
        {
            InitializeComponent();
        }

        public void Init()                                       //Объявляем метод, связывающий BindingList c BindingSource
        {
            BindingList<ItemFull> blist = new BindingList<ItemFull>(items);  //Объявляем BindingList (динамический массив)
            BindingSource source = new BindingSource(items, null);           //Создаем объект BindingSource и связываем его с массивом items
            dataGridView1.DataSource = source;                               //Связываем объект BindingSource с таблицей
        } 

    }

    
}

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
 
    public partial class SearchForm : Form
    {
        public SearchForm()                                         //Конструктор 
        {
            InitializeComponent();
        }

        public SearchForm(List<string> lines)                       //Конструктор,принимающий на вход список строк
        {
            InitializeComponent();
            richTextBox1.Lines = lines.ToArray();
        }
    }
}

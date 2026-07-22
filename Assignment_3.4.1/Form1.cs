using Assignment_3._4._1.Models;
using System.ComponentModel;

namespace Assignment_3._4._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            BindingList<Coffee> coffee = new BindingList<Coffee>();
            coffee.Add(new Coffee() { IsIced = true, BeanName = "Arabica", RoastType = "Medium Roast", TbspCreamer = 2, TbspSugar = 2, EspressoShots = 0, Style = "Latte", MilkType = "Whole", ColdFoam = false});
            coffee.Add(new Coffee() { IsIced = false, BeanName = "Columbian", RoastType = "Dark Roast", TbspCreamer = 0, TbspSugar = 0, EspressoShots = 4, Style = "Macchiato", MilkType = null, ColdFoam = true});
            coffee.Add(new Coffee() { IsIced = true, BeanName = "Arabica", RoastType = "Light Roast", TbspCreamer = 3, TbspSugar = 2, EspressoShots = 0, Style = "Mocha", MilkType = "Almond", ColdFoam = true });

            dataGridView1.DataSource = coffee;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

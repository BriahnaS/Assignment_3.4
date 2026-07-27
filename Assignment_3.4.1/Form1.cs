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
            coffee.Add(new Coffee() { IsIced = true, BeanName = BeanName.Arabica, RoastType = RoastType.Medium, AddedTbspCreamer = 2, AddedTbspSugar = 2, EspressoShots = 0, Style = "Latte", MilkType = MilkType.Whole, ColdFoam = false});
            coffee.Add(new Coffee() { IsIced = false, BeanName = BeanName.Columbian, RoastType = RoastType.Dark, AddedTbspCreamer = 0, AddedTbspSugar = 0, EspressoShots = 4, Style = "Macchiato", MilkType = MilkType.Almond, ColdFoam = true});
            coffee.Add(new Coffee() { IsIced = true, BeanName = BeanName.Arabica, RoastType = RoastType.Light, AddedTbspCreamer = 3, AddedTbspSugar = 2, EspressoShots = 0, Style = "Mocha", MilkType = MilkType.Oat, ColdFoam = true });

            dataGridView1.DataSource = coffee;

            // Bean Name drop down column code
            var beanColumn = new DataGridViewComboBoxColumn();
            beanColumn.DataPropertyName = "BeanName";
            beanColumn.DataSource = Enum.GetValues(typeof(BeanName)); ;
            beanColumn.HeaderText = "Bean Name";

            int indexBean = dataGridView1.Columns["BeanName"].Index;
            dataGridView1.Columns.Remove("BeanName");
            dataGridView1.Columns.Insert(indexBean, beanColumn);
            

            // Roast Type drop down column code
            var roastColumn = new DataGridViewComboBoxColumn();
            roastColumn.DataPropertyName = "RoastType";
            roastColumn.DataSource = Enum.GetValues(typeof(RoastType));
            roastColumn.HeaderText = "Roast Type";

            int indexRoast = dataGridView1.Columns["RoastType"].Index;
            dataGridView1.Columns.Remove("RoastType");
            dataGridView1.Columns.Insert(indexRoast, roastColumn);

            // Milk Type drop down column
            var milkColumn = new DataGridViewComboBoxColumn();
            milkColumn.DataPropertyName = "MilkType";
            milkColumn.DataSource = Enum.GetValues(typeof(MilkType));
            milkColumn.HeaderText= "Milk Type";

            int indexMilk = dataGridView1.Columns["MilkType"].Index;
            dataGridView1.Columns.Remove("MilkType");
            dataGridView1.Columns.Insert(indexMilk, milkColumn);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

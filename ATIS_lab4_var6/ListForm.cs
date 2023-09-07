using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATIS_lab4_var6
{
    public partial class ListForm : System.Windows.Forms.Form
    {
        public ListForm()
        {
            InitializeComponent();
            for(int i = 0; i < FactoryAnimals.animals.Count(); i++)
            {
                string[] animalSroke = { listManager.Items.Count.ToString(), FactoryAnimals.animals[i].condition.ToString(), FactoryAnimals.animals[i].type.ToString(), FactoryAnimals.animals[i].aviary.ToString(), FactoryAnimals.animals[i].diet.ToString(), FactoryAnimals.animals[i].therapy.ToString() };
                var list = new ListViewItem(animalSroke);
                listManager.Items.Add(list);
                //if(FactoryAnimals.animals[i].condition.ToString() == "умерло")
            }
            
        }

        private void buttonManagerForm_Click(object sender, EventArgs e)
        {
            listManager.Items.Clear();
            for (int i = 0; i < FactoryAnimals.animals.Count(); i++)
            {
                string[] animalSroke = { listManager.Items.Count.ToString(), FactoryAnimals.animals[i].condition.ToString(), FactoryAnimals.animals[i].type.ToString(), FactoryAnimals.animals[i].aviary.ToString(), FactoryAnimals.animals[i].diet.ToString(), FactoryAnimals.animals[i].therapy.ToString() };
                var list = new ListViewItem(animalSroke);
                listManager.Items.Add(list);
            }
        }
    }
}

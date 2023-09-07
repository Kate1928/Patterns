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
    public partial class ListAviaryForm : Form
    {
        public ListAviaryForm()
        {
            InitializeComponent();
            for (int i = 0; i < Aviary.aviarys.Count(); i++)
            {
                string[] aviarySroke = { listAviary.Items.Count.ToString(), Aviary.aviarys[i].type.ToString(), Aviary.aviarys[i].statusClean.ToString(), Aviary.aviarys[i].statusDes.ToString(), "15", Aviary.aviarys[i].Temperature.ToString(), Aviary.aviarys[i].statusTemperature.ToString() };
                var list = new ListViewItem(aviarySroke);
                listAviary.Items.Add(list);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listAviary.Items.Clear();
            for (int i = 0; i < Aviary.aviarys.Count(); i++)
            {
                string[] aviarySroke = { listAviary.Items.Count.ToString(), Aviary.aviarys[i].type.ToString(), Aviary.aviarys[i].statusClean.ToString(), Aviary.aviarys[i].statusDes.ToString(), "15", Aviary.aviarys[i].Temperature.ToString(), Aviary.aviarys[i].statusTemperature.ToString() };
                var list = new ListViewItem(aviarySroke);
                listAviary.Items.Add(list);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listAviary.Items.Clear();
            for (int i = 0; i < Aviary.aviarys.Count(); i++)
            {
                string[] aviarySroke = { listAviary.Items.Count.ToString(), Aviary.aviarys[i].type.ToString(), "нет", "нет", "15", Aviary.aviarys[i].Temperature.ToString(), Aviary.aviarys[i].statusTemperature.ToString() };
                var list = new ListViewItem(aviarySroke);
                listAviary.Items.Add(list);
            }
        }
    }
}

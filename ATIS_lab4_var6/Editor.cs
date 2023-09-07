using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIS_lab4_var6
{
    internal class Editor
    {
        public void addAnimal(FactoryAnimals.IDAnimals id, string condition1, string type1, string aviary1, string diet1, string therapy1) 
        {
            FactoryAnimals.createAnimal(id, condition1, type1, aviary1, diet1, therapy1);
        }

        public void removeAnimal(int i)
        {
            FactoryAnimals.animals.RemoveAt(i);
        }

       

        public void desinfection(int i)
        {
            Aviary.aviarys[i].statusDes = "да";
        }

        public void cleaning(int i)
        {
            Aviary.aviarys[i].statusClean = "да";
        }

        public void feeding(int i)
        {
            FactoryAnimals.animals[i].diet = "да";
        }

        public void treatment(string therapy, int i)
        {
            FactoryAnimals.animals[i].therapy = therapy;
        }

        public void cooling(int i)
        {
            int temp = Int32.Parse(Aviary.aviarys[i].Temperature) - 5;
            Aviary.aviarys[i].statusTemperature = "охлаждение";
            Aviary.aviarys[i].Temperature = temp.ToString();
        }

        public void heating(int i)
        {
            int temp = int.Parse(Aviary.aviarys[i].Temperature) + 5;
            Aviary.aviarys[i].statusTemperature = "обогрев";
            Aviary.aviarys[i].Temperature = temp.ToString();
        }

        public void changeState(int i, string state)
        {
            FactoryAnimals.animals[i].condition = state;
        }

        public void move(int i, string aviary)
        {
            FactoryAnimals.animals[i].aviary = aviary;
        }
    }
}

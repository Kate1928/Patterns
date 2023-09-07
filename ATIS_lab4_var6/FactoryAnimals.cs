using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ATIS_lab4_var6
{
    internal class FactoryAnimals
    {
        public static List <Animals> animals = new List<Animals>();
        //public static List<string[]> animalsString = new List<string[]>();
        //public static string[] animalSroke;
        public enum IDAnimals { Mammals_Id, Birds_Id, Reptilies_Id };
        //стартовый "набор" животных
        public static void listAnimals()
        {
            string condition1 = "здорово";
            string type1 = "млекопитающее";
            string aviary1 = "1";//?????????????????
            string diet1 = "нет";
            string therapy1 = "отсутсвует";
            Animals animal = new Mammals(Guid.NewGuid(), condition1, type1, aviary1, diet1, therapy1);
            animals.Add(animal);
            condition1 = "больное";
            type1 = "птица";
            aviary1 = "2";//?????????????????
            diet1 = "нет";
            therapy1 = "увеличение питания";
            animal = new Birds(Guid.NewGuid(), condition1, type1, aviary1, diet1, therapy1);
            animals.Add(animal);
            condition1 = "умерло";
            type1 = "пресмыкающееся";
            aviary1 = "3";//?????????????????
            diet1 = "нет";
            therapy1 = "отсутсвует";
            animal = new Reptilies(Guid.NewGuid(), condition1, type1, aviary1, diet1, therapy1);
            animals.Add(animal);
        }


        public static Animals createAnimal(IDAnimals id, string condition1, string type1, string aviary1, string diet1, string therapy1)
        {
            switch (id)
            {
                case IDAnimals.Mammals_Id:
                    {
                        Animals animal = new Mammals(Guid.NewGuid(), condition1, type1, aviary1, diet1, therapy1);
                        animals.Add(animal);
                        return animal;
                    }
                case IDAnimals.Birds_Id:
                    {
                        Animals animal = new Birds(Guid.NewGuid(), condition1, type1, aviary1, diet1, therapy1);
                        animals.Add(animal);
                        return animal;
                    }
                case IDAnimals.Reptilies_Id:
                    {
                        Animals animal = new Reptilies(Guid.NewGuid(), condition1, type1, aviary1, diet1, therapy1);
                        animals.Add(animal);
                        //Console.WriteLine(animals);
                        return animal;
                    }
                default:
                    return null;

            }
        }

    }
}

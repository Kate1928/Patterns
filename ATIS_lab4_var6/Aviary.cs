using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIS_lab4_var6
{
    internal class Aviary
    {
        public string type;
        public string statusDes;
        public string statusClean;
        public string Temperature;
        public string statusTemperature;
        public static List<Aviary> aviarys = new List<Aviary>();
        public Aviary(string type1, string statusDes1, string statusClean1, string Temperature1, string statusTemperature1)
        {
            type = type1;
            statusDes = statusDes1;
            statusClean = statusClean1;
            Temperature = Temperature1;
            statusTemperature = statusTemperature1;
        }
        public static void listAviary()
        {
            //0
            string type1 = "открытый";
            string statusDes1 = "нет";
            string statusClean1 = "нет";
            string Temperature1 = "15";
            Aviary aviary = new OpenAviary(type1, statusDes1, statusClean1, Temperature1);
            aviarys.Add(aviary);
            //1
            type1 = "закрытый";
            statusDes1 = "нет";
            statusClean1 = "нет";
            Temperature1 = "20";
            string statusTemperature1 = "обогрев";
            aviary = new CloseAviary(type1, statusDes1, statusClean1, Temperature1, statusTemperature1);
            aviarys.Add(aviary);
            //2
            type1 = "закрытый";
            statusDes1 = "нет";
            statusClean1 = "нет";
            Temperature1 = "10";
            statusTemperature1 = "охлаждение";
            aviary = new CloseAviary(type1, statusDes1, statusClean1, Temperature1, statusTemperature1);
            aviarys.Add(aviary);
            //3
            type1 = "закрытый";
            statusDes1 = "нет";
            statusClean1 = "нет";
            Temperature1 = "15";
            statusTemperature1 = "никакой";
            aviary = new CloseAviary(type1, statusDes1, statusClean1, Temperature1, statusTemperature1);
            aviarys.Add(aviary);
            //4
            //Создание объекта для генерации чисел
            Random rnd = new Random();
            type1 = "открытый";
            statusDes1 = "нет";
            statusClean1 = "нет";
            Temperature1 = rnd.Next(0, 30).ToString();
            aviary = new OpenAviary(type1, statusDes1, statusClean1, Temperature1);
            aviarys.Add(aviary);
            //5
            type1 = "открытый";
            statusDes1 = "нет";
            statusClean1 = "нет";
            Temperature1 = rnd.Next(0, 30).ToString();
            aviary = new OpenAviary(type1, statusDes1, statusClean1, Temperature1);
            aviarys.Add(aviary);
            //6
            type1 = "открытый";
            statusDes1 = "нет";
            statusClean1 = "нет";
            Temperature1 = rnd.Next(0, 30).ToString();
            aviary = new OpenAviary(type1, statusDes1, statusClean1, Temperature1);
            aviarys.Add(aviary);
            //7
            type1 = "открытый";
            statusDes1 = "нет";
            statusClean1 = "нет";
            Temperature1 = rnd.Next(0, 30).ToString();
            aviary = new OpenAviary(type1, statusDes1, statusClean1, Temperature1);
            aviarys.Add(aviary);

        }
    }
}

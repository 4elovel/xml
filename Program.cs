using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Text;
using System.Threading.Tasks;

namespace xml
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlTextWriter Wr = null;
            Wr = new XmlTextWriter("auto.xml", System.Text.Encoding.UTF8);
            Wr.Formatting = Formatting.Indented;
            Wr.WriteStartDocument();
            Wr.WriteStartElement("Запити");

            Wr.WriteStartElement("Запит1");

            Wr.WriteStartElement("Авто1");
            Wr.WriteAttributeString("Вигляд", "500px-2016_Toyota_Prius.jpg");
            Wr.WriteElementString("Виробник", "Тойота");
            Wr.WriteElementString("Модель", "Пріус");
            Wr.WriteElementString("Рік", "2016");
            Wr.WriteElementString("Колір", "Червоний");
            Wr.WriteElementString("Витрати", "3,1л/100км");
            Wr.WriteEndElement();

            Wr.WriteStartElement("Авто2");
            Wr.WriteAttributeString("Вигляд", "500px-2016_Daewoo_Lanos.jpg");
            Wr.WriteElementString("Виробник", "Ланос");
            Wr.WriteElementString("Модель", "Део");
            Wr.WriteElementString("Рік", "2014");
            Wr.WriteElementString("Колір", "Сірий");
            Wr.WriteElementString("Витрати", "4,2л/100км");
            Wr.WriteEndElement();

            Wr.WriteStartElement("Авто3");
            Wr.WriteAttributeString("Вигляд", "");
            Wr.WriteElementString("Виробник", "Тесла");
            Wr.WriteElementString("Модель", "model S");
            Wr.WriteElementString("Рік", "2019");
            Wr.WriteElementString("Колір", "Чорний");
            Wr.WriteElementString("Витрати", "6л/100км");
            Wr.WriteEndElement();

            Wr.WriteEndElement();


            Wr.WriteStartElement("Запит2");

            Wr.WriteStartElement("Авто1");
            Wr.WriteAttributeString("Вигляд", "");
            Wr.WriteElementString("Виробник", "Тесла");
            Wr.WriteElementString("Модель", "model X");
            Wr.WriteElementString("Рік", "2019");
            Wr.WriteElementString("Колір", "білий");
            Wr.WriteElementString("Витрати", "7,1л/100км");
            Wr.WriteEndElement();

            Wr.WriteStartElement("Авто2");
            Wr.WriteAttributeString("Вигляд", "");
            Wr.WriteElementString("Виробник", "Тесла");
            Wr.WriteElementString("Модель", "model S");
            Wr.WriteElementString("Рік", "2011");
            Wr.WriteElementString("Колір", "чорний");
            Wr.WriteElementString("Витрати", "5,1л/100км");
            Wr.WriteEndElement();

            Wr.WriteStartElement("Авто3");
            Wr.WriteAttributeString("Вигляд", "");
            Wr.WriteElementString("Виробник", "Тесла");
            Wr.WriteElementString("Модель", "model X");
            Wr.WriteElementString("Рік", "2017");
            Wr.WriteElementString("Колір", "Чорний");
            Wr.WriteElementString("Витрати", "5л/100км");
            Wr.WriteEndElement();

            Wr.WriteEndElement();



            Wr.WriteEndElement();
            Wr.Close();
            Console.WriteLine("XML файл згенеровано");
            Console.ReadKey();
        }
    }
}

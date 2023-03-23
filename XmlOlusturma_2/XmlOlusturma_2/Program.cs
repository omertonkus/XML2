using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XmlOlusturma_2
{
    class Program
    {
        static void Main(string[] args)
        {

            // LİST İLE XML DOSYA OLUŞTURMA

            //List<Ogrenci> Ogrencilerim = new List<Ogrenci>();
            //for (int i = 0; i < 100; i++)
            //{
            //    Ogrenci Temp = new Ogrenci();
            //    Temp.ID = Guid.NewGuid();
            //    Temp.Isim = FakeData.NameData.GetFirstName();
            //    Temp.Soyisim = FakeData.NameData.GetSurname();
            //    Temp.Numara = FakeData.NumberData.GetNumber(100, 500);
            //    Ogrencilerim.Add(Temp);
            //}

            //XDocument Doc = new XDocument(new XDeclaration("1.1", "UTF-8", "yes"), new XElement("Ogrencilerim", Ogrencilerim.Select(I => new XElement("Ogrenci", new XElement("ID", I.ID), new XElement("Isim", I.Isim), new XElement("Soyisim", I.Soyisim), new XElement("Numara", I.Numara)))));
            //Doc.Save(@"D:\Ogrencilerim.xml");



            //XML DOSYA OKUMA

            List<Ogrenci> OkunanData = new List<Ogrenci>(); //Boş kolleksiyon oluştu
            XDocument DocOku = XDocument.Load(@"D:\Ogrencilerim.xml");
            List<XElement> OkunanElement = DocOku.Descendants("Ogrenci").ToList(); //ogrenci bloguna göre ayırdım
            foreach(XElement item in OkunanElement)
            {
                Ogrenci Temp = new Ogrenci();
                Temp.ID = Guid.Parse(item.Element("ID").Value);
                Temp.Isim = item.Element("Isim").Value;
                Temp.Soyisim = item.Element("Soyisim").Value;
                Temp.Numara = int.Parse(item.Element("Numara").Value);
                OkunanData.Add(Temp);

            }

            Console.ReadLine();
        }
    }
}

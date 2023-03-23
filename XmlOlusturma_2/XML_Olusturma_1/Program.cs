using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XML_Olusturma_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*

             <?xml version="1.0" standalone="yes"?>
 <VeriTabanim>
 + Yorum eklendi. 
   <Personellerim ID="102">
     <Isim>Daniel</Isim>
     <Soyisim>Perkins</Soyisim>
   </Personellerim>
 </VeriTabanim>

             */

            XDocument XDoc = new XDocument(
                new XDeclaration("1.0", "UTF-8", "yes"), 
                new XElement("VeriTabanim", 
                new XComment("Personellerim Bilgilerini Taşır"),
                new XElement("Personellerim",new XAttribute("ID","102"), 
                new XElement("Isim", "Cengiz"), 
                new XElement("Soyisim", "Atilla"), 
                new XElement("EmailAdres", "cengiz.atilla@hotmail.com")
                )
                )
                );
            XDoc.Save(@"c:\XML\Ornek2.xml");
        }
    }
}

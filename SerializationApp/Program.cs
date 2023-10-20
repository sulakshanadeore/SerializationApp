using ShoppingLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerializationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BinarySerializationDemo();

            //BinaryDeserializationDemo();

            //XmlSerializationDemo();
            XmlSerializer serializer = new XmlSerializer(typeof(Customer));
            FileStream fs = new FileStream("D:\\NewDrive\\MphasisSept\\custdata.xml", FileMode.Open, FileAccess.Read);
            Customer readObj=(Customer)serializer.Deserialize(fs);
            Console.WriteLine(readObj.custid);
            Console.WriteLine(  readObj.custname);
            Console.WriteLine(  readObj.LoginID);
            fs.Flush();
            fs.Close();

            fs.Dispose();





            Console.ReadLine();



        }

        private static void XmlSerializationDemo()
        {
            Customer c = new Customer();
            c.custid = 1;
            c.custname = "Ana";
            c.LoginID = "ana1";

            XmlSerializer serializer = new XmlSerializer(typeof(Customer));
            FileStream fs = new FileStream("D:\\NewDrive\\MphasisSept\\custdata.xml", FileMode.Create, FileAccess.Write);
            serializer.Serialize(fs, c);
            fs.Flush();
            fs.Close();

            fs.Dispose();
            Console.WriteLine("File created successfully..");
        }

        private static void BinaryDeserializationDemo()
        {
            FileStream fs = new FileStream("D:\\NewDrive\\MphasisSept\\cust101.bin", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            Orders obj = (Orders)bf.Deserialize(fs);
            Console.WriteLine(obj.Custid);
            Console.WriteLine(obj.ProductName);
            Console.WriteLine(obj.Price);
            Console.WriteLine("Qty=" + obj.Quantity);
            Console.WriteLine("OrderDate=" + obj.OrderDate);
            Console.WriteLine("Debit card no= " + obj.DebitCardNo);
            fs.Close();
            fs.Dispose();
        }

        private static void BinarySerializationDemo()
        {
            Orders o = new Orders();
            o.OrderDate = DateTime.Now;
            o.Quantity = 10;
            o.ProductName = "HardDisk";
            o.Custid = 101;
            o.Price = 2000;
            o.DebitCardNo = 1234456789012223;

            FileStream fs = new FileStream("D:\\NewDrive\\MphasisSept\\cust101.bin", FileMode.Create, FileAccess.Write);
            //Binary format---write the data to the file in binary format use binary formatter(system.runtime.serialization.formatters.binary)
            BinaryFormatter bf = new BinaryFormatter();
            //serialize()--writes---writes the object to the file
            bf.Serialize(fs, o);
            fs.Flush();
            fs.Close();//file gets saved
            fs.Dispose();//filestream object is destroyed

            Console.WriteLine("Order placed successfully....");
        }
    }
}

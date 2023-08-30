//using SerializationAndDeSeriDemo.Model;
using SerializationAndDeSeriDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationAndDeSeriDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Car car1 = new Car { CarNo = 101, CarName = "WagonR" };
            string filePath = @"C:\Users\albin.kurian\Desktop\DotNet\section14\SerializationAndDeSeriDemo\myFile.txt";

            //DataSerializer.BinarySerializer(car1, filePath);
            //Console.WriteLine("Car obj serialed");

            Car recreatedCar = DataSerializer.BinaryDeserilizer(filePath);
            Console.WriteLine("Car Created in prev run was: \n" +
               "Id: " + recreatedCar.CarNo + "\n" +
               "Name : " + recreatedCar.CarName);
        }
    }
}

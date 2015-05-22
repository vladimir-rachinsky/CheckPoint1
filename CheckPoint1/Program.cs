using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint1
{
    public class AutoItem
    {
        public string Name {get; set;} // Название автомобиля
        public int Cost { get; set; } // Цена автомобиля
        public short Speed { get; set; } // Скорость автомобиля
        public byte FuelConsuption { get; set; } // Расход топлива
    }
    public enum CarType // Тип автомобилей
    {
        Sedan,
        Miniwan,
        Limusin,

    }
    public enum EngineType // Тип двигателя
    {
        Benzine,
        Diesiel,
        Gas
    }

    public interface IAuto 
    {
        string Name { get; }
        int Cost { get; }
        short Speed { get; }
        byte FuelConsumption { get; }
        CarType CarType { get; }
        EngineType EngineType { get; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    








}

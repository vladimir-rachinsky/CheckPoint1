using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint1
{
    public class AutoItem
    {
        public int Cost { get; set; } // Цена автомобиля
        public short Speed { get; set; } // Скоорость автомобиля
        public byte FuelConsuption { get; set; } // Расход топлива
        public CarType CarType { get; set; } //Тип автомобиля
        public EngineType EngineType { get; set; } // Тип двигателя
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
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

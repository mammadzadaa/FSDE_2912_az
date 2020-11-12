using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks.Sources;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<MapObject> mapObjects = new List<MapObject>();
            mapObjects.Add(new Hotel() { Name = "Absheron", Latitude = 40.12, Longitude = 41.34, Stars = 5});
            mapObjects.Add(new Restaurant() { Name = "Sheki", Latitude = 43.25, Longitude = 45.34, Cuisine = Cuisine.Traditional });
            mapObjects.Add(new BusStop() { Name = "28 May", Latitude = 41.22, Longitude = 43.78, BusNumbers = {1, 2, 14 } });
            MapObjectExporter exporter = new MapObjectExporter();

            foreach (var obj in mapObjects)
            {
                obj.Export(exporter);

                //if (obj is Hotel)
                //{
                //    exporter.ExportHotel(obj as Hotel);
                //}
                //if (obj is Restaurant)
                //{
                //    exporter.ExportRestaurant(obj as Restaurant);
                //}
                //if (obj is BusStop)
                //{
                //    exporter.ExportBusStop(obj as BusStop);
                //}
            }
        }
    }

    interface IExpot
    {
        void Export(MapObjectExporter exporter);
    }

    abstract class MapObject : IExpot
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Name { get; set; }

        public abstract void Export(MapObjectExporter exporter);

        public override string ToString()
        {
            return $"Name: {Name}\nCoordinates: {Latitude}, {Longitude}\n";
        }
    }

    class Hotel : MapObject
    {
        public int Stars { get; set; }

        public override void Export(MapObjectExporter exporter)
        {
            exporter.ExportHotel(this);
        }

        public override string ToString()
        {
            return "Hotel\n" + base.ToString() + $"Stars: {Stars}\n";
        }
    }
    enum Cuisine
    {
        Traditional, SeaFood, FastFood
    }
    class Restaurant : MapObject
    {
        public override void Export(MapObjectExporter exporter)
        {
            exporter.ExportRestaurant(this);
        }
        public Cuisine Cuisine { get; set; }
        public override string ToString()
        {
            return "Restaurant\n" + base.ToString() + $"Cuisine: {Cuisine}\n";
        }
    }
    class BusStop : MapObject
    {
        public override void Export(MapObjectExporter exporter)
        {
            exporter.ExportBusStop(this);
        }
        public List<int> BusNumbers { get; set; } = new List<int>();

        public override string ToString()
        {
            var str = "";
            foreach (var busNumber in BusNumbers)
            {
                str += $"{busNumber} ";
            }
            return "Bus Stop\n" + base.ToString() + $"Bus Numbers: {str}";
        }
    }

    class MapObjectExporter
    {
        public void ExportHotel(Hotel hotel)
        {
            if (!Directory.Exists("hotels"))
            {
                Directory.CreateDirectory("hotels");
            }
            File.WriteAllText($"hotels\\{hotel.Name}.txt", hotel.ToString());
        }
        public void ExportRestaurant(Restaurant restaurant)
        {
            if (!Directory.Exists("restaurants"))
            {
                Directory.CreateDirectory("restaurants");
            }
            File.WriteAllText($"restaurants\\{restaurant.Name}.txt", restaurant.ToString());
        }

        public void ExportBusStop(BusStop busstop)
        {
            if (!Directory.Exists("busstops"))
            {
                Directory.CreateDirectory("busstops");
            }
            File.WriteAllText($"busstops\\{busstop.Name}.txt", busstop.ToString());
        }
    }
}

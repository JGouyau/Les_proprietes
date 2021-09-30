using System;
using System.Collections.Generic;
using System.Linq;

//Critères de validation
//Les accesseurs ne sont plus des méthodes, mais des propriétés
//Le comportement est exactement le même
//Le code du point d'entrée Main est modifié en accord avec l'utilisation des propriétés
//Votre programme se compile et se lance sans erreur


namespace Encapsulation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            House house = new House();
            Room room = new Room();
            Door houseDoor = new Door();
            Door roomDoor = new Door();
            
            house.AddDoor(houseDoor);
            room.AddDoor(roomDoor);
            house.AddRoom(room);

        }
    }

    public class House
    {
         public House()
        {
            Rooms = new List<Room>();
            Doors = new List<Door>();
        }

        public List<Door> Doors {get; }

        public List<Room> Rooms { get; }

        public void AddDoor(Door door)
        {
            Doors.Add(door);
        }
        public void AddRoom(Room room)
        {
            Rooms.Add(room);
        }
    }

    public class Room
    {
        public Room()
        {
            Doors = new List<Door>();
        }
        public List<Door> Doors {  get;  }
        public void AddDoor(Door door)
        {
            Doors.Add(door);
        }
}

    public class Door
    {
         public Door()
         {
            IsOpen = false;
         }

        public bool IsOpen { get ; set; }

        public void Open()
        {
            if (IsOpen)
            {
                Console.WriteLine("Door already opened. Ain't done anything.");
            }
            else
            {
                IsOpen = true;
            }
        }

        public void Close()
        {
            if (!IsOpen)
            {
                Console.WriteLine("Door already closed. Ain't done anything.");
            }
            else
            {
                IsOpen = false;
            }
        }
    }
}


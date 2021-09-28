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
            
            house.door = houseDoor;
            room.door = roomDoor;
            house.room = room;

            //house.AddDoor(houseDoor);
            //room.AddDoor(roomDoor);
            //house.AddRoom(room);
        }
    }

    public class House
    {
        private List<Room> _rooms;
        private List<Door> _doors;


         public House()
        {
            _rooms = new List<Room>();
            _doors = new List<Door>();
        }

        public Door door
        { 
            set { _doors.Add(value); }
        }

        public Room room
        {
            set { _rooms.Add(value); }
        }


        //public void AddDoor(Door door)
        //{
        //    _doors.Add(door);
        //}

        //public void AddRoom(Room room)
        //{
        //    _rooms.Add(room);
        //}
    }

    public class Room
    {
        private List<Door> _doors;

        public Room()
        {
            _doors = new List<Door>();
        }

        public Door door
        {
            set { _doors.Add(value); }
        }
        //public void AddDoor(Door door)
        //{
        //    _doors.Add(door);
        //}
    }

    public class Door
    {
        private bool _isOpen;

        public Door()
        {
            _isOpen = false;
        }

        public bool IsOpen
        {
            get { return _isOpen; }
            set { _isOpen = value; }
        }


        public void Open()
        {
            if (_isOpen)
            {
                Console.WriteLine("Door already opened. Ain't done anything.");
            }
            else
            {
                _isOpen = true;
            }
        }

        public void Close()
        {
            if (!_isOpen)
            {
                Console.WriteLine("Door already closed. Ain't done anything.");
            }
            else
            {
                _isOpen = false;
            }
        }
    }
}


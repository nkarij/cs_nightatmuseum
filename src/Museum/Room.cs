using System;
using System.Collections.Generic;

namespace Museum
{
    public class Room : Menu
    {
        public Room(int id, string name)
        {
            this.id = id;
            this.name = name;
            jointRooms = new List<Room>();
            artOnDisplay = new List<ArtPiece>();
        }

        public List<Room> jointRooms;
        public List<ArtPiece> artOnDisplay;

        public string name { get; set; }
        public int id { get; set; }

        protected virtual void PrintJointRooms(Room room){}

        protected virtual void PrintArtOnDisplay(Room room){}
        // override findRoom
        protected Room findRoom(int index){
            var room = rooms.Find(x => x.id == index);
            return room;
        }

        private string [] roomArray = {"White", "Black", "Purple", "Blue", "Red", "Green", "Corridor", "Hall"};
        public override List<Room> initializeRooms(List<Room> RoomList){
            foreach (var name in roomArray)
            {
                var room = new Room(RoomIndex+=1, $"{name} Room");
                RoomList.Add(room);
            }
            return RoomList;
        }

        public override List<Room> initJointRooms(List<Room> RoomList){ 
            var Hall = RoomList[7];
            var Corridor = RoomList[6];
            var GreenRoom = RoomList[5];
            var RedRoom = RoomList[4];
            var BlueRoom = RoomList[3];
            var PurpleRoom = RoomList[2];
            var BlackRoom = RoomList[1];
            var WhiteRoom = RoomList[0];
            Hall.jointRooms.Add(Corridor);
            Corridor.jointRooms.Add(GreenRoom);
            Corridor.jointRooms.Add(Hall);
            GreenRoom.jointRooms.Add(BlackRoom);
            GreenRoom.jointRooms.Add(RedRoom);
            GreenRoom.jointRooms.Add(Corridor);
            RedRoom.jointRooms.Add(GreenRoom);
            RedRoom.jointRooms.Add(PurpleRoom);
            PurpleRoom.jointRooms.Add(RedRoom);
            PurpleRoom.jointRooms.Add(BlueRoom);
            BlueRoom.jointRooms.Add(PurpleRoom);
            BlueRoom.jointRooms.Add(BlackRoom);
            BlueRoom.jointRooms.Add(WhiteRoom);
            BlueRoom.jointRooms.Add(GreenRoom);
            BlackRoom.jointRooms.Add(BlueRoom);
            WhiteRoom.jointRooms.Add(BlueRoom);
            return RoomList;
        }

        
        public override List<Room> initArtOnDisplay(List<Room> RoomList){
            var WhiteRoom = RoomList[0];
            WhiteRoom.artOnDisplay.Add(ArtList[0]);
            var PurpleRoom = RoomList[2];
            PurpleRoom.artOnDisplay.Add(ArtList[1]);
            PurpleRoom.artOnDisplay.Add(ArtList[2]);
            PurpleRoom.artOnDisplay.Add(ArtList[3]);
            PurpleRoom.artOnDisplay.Add(ArtList[4]);
            var BlueRoom = RoomList[3];
            BlueRoom.artOnDisplay.Add(ArtList[5]);
            var RedRoom = RoomList[4];
            RedRoom.artOnDisplay.Add(ArtList[6]);
            RedRoom.artOnDisplay.Add(ArtList[7]);
            RedRoom.artOnDisplay.Add(ArtList[8]);
            var GreenRoom = RoomList[5];
            GreenRoom.artOnDisplay.Add(ArtList[9]);
            GreenRoom.artOnDisplay.Add(ArtList[10]);
            // er det her korrekt?
            return RoomList;
        }

  


    }
}
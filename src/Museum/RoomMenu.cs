using System;
using System.Collections.Generic;

namespace Museum
{
    public class RoomMenu : Room
    {
        public RoomMenu(int id, string name) : base(id, name)
        {
            this.id = id;
            this.name = name;
        }

        protected override void startRoomMenu(int roomnum){
            var room = this.findRoom(roomnum);
            Console.WriteLine($"Welcome to the {room}. What would you like to do?");
            Console.WriteLine("[1] Se kunstværker");
            Console.WriteLine("[2] Gå til det næste rum?");
            Console.WriteLine("[3] Quit the program?");
            var option = this.getOption();
            // Console.WriteLine(option);
            this.executeRoomMenu(option, room);
        }

        public void executeRoomMenu(int option, Room room){
            switch (option)
            {
                case 1: 
                    this.PrintArtOnDisplay(room);
                    break;
                case 2:
                    this.PrintJointRooms(room);
                    var subOption = this.getOption();
                    this.startRoomMenu(subOption);
                    break;
                case 3:
                    return;
                default: 
                    Console.WriteLine("Try again");
                break;
            }
        }

        protected override void PrintJointRooms(Room room){
            foreach (var item in room.jointRooms)
            {
                Console.WriteLine($"{item.name}");
            }
        }

        protected override void PrintArtOnDisplay(Room room){
            foreach (var item in room.artOnDisplay)
            {
                Console.WriteLine($"Title: {item.title} Author: {item.author}");
            }
        }
    }
}




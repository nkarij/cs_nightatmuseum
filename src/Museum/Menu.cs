using System;
using System.Collections.Generic;

namespace Museum
{
    public class Menu : Building
    {
    
        public int RoomIndex;
        public List<Room> RoomList;
        protected List<ArtPiece> ArtList;

        protected RoomMenu subMenu; 
        public Menu()
        {
            RoomIndex = 0;
            subMenu = new RoomMenu(1, "roomMenu");
            RoomList = rooms;
            ArtList = artPieces;
            this.initializeRooms(RoomList);
            this.initializeArtPieces(ArtList);
            this.initJointRooms(RoomList);
            this.initArtOnDisplay(RoomList);
        }

        public virtual List<ArtPiece> initializeArtPieces(List<ArtPiece> ArtList){return ArtList;}
        public virtual List<Room> initializeRooms(List<Room> RoomList){return RoomList;}
        public virtual List<Room> initArtOnDisplay(List<Room> RoomList){return RoomList;}
        public virtual List<Room> initJointRooms(List<Room> RoomList){ return RoomList;}

        public void startMenu(){
            Console.WriteLine("Welcome to the Museum, you are in the Hall. What would you like to do?");
            Console.WriteLine("[1] See a list of art in the museum?");
            Console.WriteLine("[2] See a list of the rooms");
            Console.WriteLine("[3] Gå to the next room?");
            Console.WriteLine("[4] Quit the program?");
            var option = this.getOption();
            this.executeStartMenu(option);
        }

        public void executeStartMenu(int option){
            switch (option)
            {
                case 1: 
                    this.PrintPieces();
                    break;
                case 2:
                    this.PrintRooms();
                    break;
                case 3:
                    subMenu.startRoomMenu(7);
                    break;
                case 4:
                    return;
                default:
                    break;
            }
        }

        protected int getOption(){
            // Console.WriteLine("")
            var stringInput = Console.ReadLine();
            var num = Convert.ToInt32(stringInput);
            return num;
        }

        protected virtual void startRoomMenu(int option){}
    }
}
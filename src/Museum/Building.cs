using System;
using System.Collections.Generic;

namespace Museum
{
    public class Building
    {
        public Building ()
        {
            rooms = new List<Room>();
            artPieces = new List<ArtPiece>();
        }

        protected List<Room> rooms;
        protected List<ArtPiece> artPieces;

        protected virtual void PrintRooms(){
            foreach (var room in rooms)
            {
                Console.WriteLine($"Room: {room.name}");
            }
        }

        protected virtual void PrintPieces(){
            foreach (var artPiece in artPieces)
            {
                Console.WriteLine($"Title: {artPiece.title}, Author: {artPiece.author} ");
            }
        } 

    }
}
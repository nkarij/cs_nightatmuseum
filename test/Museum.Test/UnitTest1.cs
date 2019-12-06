using System;
using Xunit;

namespace Museum.Test
{
    public class UnitTest1 : Menu
    {
        // [Fact]
        public void ListOfArt()
        {   Menu testLength = new Menu();
            testLength.initializeArtPieces(ArtList);
            int length = ArtList.Count;

            Assert.Equal(11, length);
        }
        // [Fact]
        public void ListOfRooms()
        {   Menu testLengthRoom = new Menu();
            testLengthRoom.initializeRooms(RoomList);
            int length =RoomList.Count;

            Assert.Equal(8, length);
        }

        [Fact]
        public void LastTest()
        {   Menu testRoomList = new Menu();
            testRoomList.initJointRooms(RoomList);
            Assert.Equal("Whiteroom", RoomList[0].name);
        }


    }
}

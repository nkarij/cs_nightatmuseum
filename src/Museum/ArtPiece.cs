using System;
using System.Collections.Generic;

namespace Museum
{
    public class ArtPiece : Menu
    {
        public ArtPiece(int id, string title, string author, string descript)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.descript = descript; 
        }

        //private ArtPiece artPiece;
        public int id { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public string descript { get; set; }

        public int [] artIds = {0,1,2,3,4,5,6,7,8,9,10};

        public override List<ArtPiece> initializeArtPieces(List<ArtPiece> ArtList){
            foreach (var num in artIds)
            {
                var art = new ArtPiece(num, $"Artpiece{num}", $"Author{num}", $"description{num}");
                ArtList.Add(art);
            }
            return ArtList;
        }

    }
}
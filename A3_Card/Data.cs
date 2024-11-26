using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3_Card
{
    public static class Data
    {
        public static List<Artist> GetArtists()
        {
            List<Artist> artists = new List<Artist>();

            Artist artist = new Artist
            {
                Id = 1,
                Name = "KARINA",
                Age = 24,
                DebutAlbum = "Black Mamba",
                Img= "https://static.wikia.nocookie.net/superstar-smtown/images/4/4a/Karina_%28DCT%29.png/revision/latest?cb=20220105093630",
                GroupId = 1
            };
            artists.Add(artist);
            artist = new Artist
            {
                Id = 2,
                Name = "GISELLE",
                Age = 24,
                DebutAlbum = "Black Mamba",
                Img = "https://static.wikia.nocookie.net/superstar-smtown/images/c/c4/Giselle_%28DCT%29.png/revision/latest?cb=20220105093632",
                GroupId = 1
            };
            artists.Add(artist);
            artist = new Artist
            {
                Id = 3,
                Name = "WINTER",
                Age = 23,
                DebutAlbum = "Black Mamba",
                Img = "https://static.wikia.nocookie.net/superstar-smtown/images/8/8d/Winter_%28DCT%29.png/revision/latest?cb=20220105093632",
                GroupId = 1
            };
            artists.Add(artist);
            artist = new Artist
            {
                Id = 4,
                Name = "NINGNING",
                Age = 22,
                DebutAlbum = "Black Mamba",
                Img = "https://static.wikia.nocookie.net/superstar-smtown/images/2/2e/NingNing_%28DCT%29.png/revision/latest?cb=20220105093632",
                GroupId = 1
            };
            artists.Add(artist);
            artist = new Artist
            {
                Id = 5,
                Name = "IRENE",
                Age = 33,
                DebutAlbum = "Happiness",
                Img = "https://static.wikia.nocookie.net/superstar-smtown/images/a/a4/Irene_%28Rainbow_Halo%29.png/revision/latest?cb=20220802071026",
                GroupId = 2
            };
            artists.Add(artist);
            artist = new Artist
            {
                Id = 6,
                Name = "SEULGI",
                Age = 30,
                DebutAlbum = "Happiness",
                Img = "https://static.wikia.nocookie.net/superstar-smtown/images/4/43/Seulgi_%28Rainbow_Halo%29.png/revision/latest?cb=20220802071027",
                GroupId = 2
            };
            artists.Add(artist);
            artist = new Artist
            {
                Id = 7,
                Name = "WENDY",
                Age = 30,
                DebutAlbum = "Happiness",
                Img = "https://static.wikia.nocookie.net/superstar-smtown/images/b/b0/Wendy_%28Rainbow_Halo%29.png/revision/latest?cb=20220802071028",
                GroupId = 2
            };
            artists.Add(artist);
            artist = new Artist
            {
                Id = 8,
                Name = "JOY",
                Age = 28,
                DebutAlbum = "Happiness",
                Img = "https://static.wikia.nocookie.net/superstar-smtown/images/0/03/Joy_%28Rainbow_Halo%29.png/revision/latest?cb=20220802071027",
                GroupId = 2
            };
            artists.Add(artist);
            artist = new Artist
            {
                Id = 9,
                Name = "YERI",
                Age = 25,
                DebutAlbum = "Happiness",
                Img = "https://static.wikia.nocookie.net/superstar-smtown/images/5/57/Yeri_%28Rainbow_Halo%29.png/revision/latest?cb=20220802071029",
                GroupId = 2
            };
            artists.Add(artist);
            artist = new Artist
            {
                Id = 10,
                Name = "DOYOUNG",
                Age = 28,
                DebutAlbum = "The 7th Sense",
                Img = "https://static.wikia.nocookie.net/superstar-smtown/images/b/be/Doyoung_%28Base_Note%29.png/revision/latest?cb=20240805235932",
                GroupId = 3
            };
            artists.Add(artist);
            artist = new Artist
            {
                Id = 11,
                Name = "JAEHYUN",
                Age = 27,
                DebutAlbum = "The 7th Sense",
                Img = "https://static.wikia.nocookie.net/superstar-smtown/images/2/22/Jaehyun_%28Base_Note%29.png/revision/latest?cb=20240806000006",
                GroupId = 3
            };
            artists.Add(artist);
            artist = new Artist
            {
                Id = 12,
                Name = "JUNGWOO",
                Age = 26,
                DebutAlbum = "NCT 2018",
                Img = "https://static.wikia.nocookie.net/superstar-smtown/images/8/81/Jungwoo_%28Base_Note%29.png/revision/latest?cb=20240806000032",
                GroupId = 3
            };
            artists.Add(artist);
            return artists;
        }

        public static List<Group> GetGroups()
        {
            List<Group> groups = new List<Group>();

            Group group = new Group
            {
                Id = 1,
                GroupName = "Aespa",
                ColorCode = "#714f9d"
            };
            groups.Add(group);
            group = new Group
            {
                Id = 2,
                GroupName = "Red Velvet",
                ColorCode = "#FDA487"
            };
            groups.Add(group);
            group = new Group
            {
                Id = 3,
                GroupName = "NCT DOJEAJUNG",
                ColorCode = "#A8DD04"
            };
            groups.Add(group);


            return groups;
        }
    }
}

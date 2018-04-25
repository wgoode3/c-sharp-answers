using System;
using System.Collections.Generic;
using System.Linq;
using JsonData;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Collections to work with
            List<Artist> Artists = JsonToFile<Artist>.ReadJson();
            List<Group> Groups = JsonToFile<Group>.ReadJson();

            //========================================================
            //Solve all of the prompts below using various LINQ queries
            //========================================================

            //There is only one artist in this collection from Mount Vernon, what is their name and age?

            var one_artist =    from match in Artists
                                where match.Hometown == "Mount Vernon"
                                select new {match.ArtistName, match.Age};
            Console.WriteLine(one_artist.ToArray()[0]);
            
            //Who is the youngest artist in our collection of artists?

            // var youngest =  from match in Artists
            //                 where match.Age < 24
            //                 select new {match};
            // Console.WriteLine(youngest.ToArray()[0].match.ArtistName);

            Artist youngest = Artists.OrderBy( artist => artist.Age ).First();
            Console.WriteLine(youngest.ArtistName);

            //Display all artists with 'William' somewhere in their real name

            IEnumerable<Artist> williams = Artists.Where( x => x.RealName.Contains("William"));
            Console.WriteLine("The artists with the name William are:");
            for(int i=0; i<williams.Count(); i++){
                Console.WriteLine($"{i+1}. {williams.ToArray()[i].RealName}");
            }
             
            //Display the 3 oldest artist from Atlanta

            IEnumerable<Artist> atlantans = Artists.Where( x => x.Hometown == "Atlanta").OrderByDescending( x => x.Age);

            int end = (atlantans.Count() > 3) ? end = 3 : end = atlantans.Count();

            Console.WriteLine("The oldest Atlantans are:");
            for(int i=0; i<end; i++){
                Console.WriteLine($"{i+1}. {atlantans.ToArray()[i].RealName} ({atlantans.ToArray()[i].Age})");
            }

            //(Optional) Display the Group Name of all groups that have members that are not from New York City

            //Seems like busy work to me...

            //(Optional) Display the artist names of all members of the group 'Wu-Tang Clan'

            Group wuTangClan = Groups.Where( 
                x => x.GroupName == "Wu-Tang Clan"
            ).GroupJoin(
                Artists, 
                x => x.Id, 
                y => y.GroupId, 
                (x, z) => {
                    x.Members = z.ToList(); 
                    return x;
                }
            ).First();

            Console.WriteLine("The artists in the Wu-Tang-Clan");
            foreach(Artist artist in wuTangClan.Members){
                Console.WriteLine($"{artist.ArtistName}");
            }

        }
    }
}

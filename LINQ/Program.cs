using System.Security.Cryptography.X509Certificates;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var franchises = new List<string>() { "Mario", "Zelda", "Donkey Kong", "Metal Gear Solid", "Assassin's Creed", "Battlefield", "Call of Duty", "Halo", "Castlevania", "The Witcher", "Baldur's Gate", "Dragon Age", "Mass Effect", "Fortnite", "Final Fantasy", "Dragon Quest", "Persona", "Fallout", "Fire Emblem", "Skyrim", "God of War", "Horizon Zero Dawn", "Bravely Default", "Shin Megami Tensei", "Xenoblade Chronicles", "Tales"};
        
            var orderedByLength = franchises.OrderBy(x => x.Length).ToList();

            foreach (var franchise in orderedByLength) 
            { 
                Console.WriteLine(franchise);
            }
        }
    }
}

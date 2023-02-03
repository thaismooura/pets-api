namespace Pets.Api.Models
{
    public class Dog
    {
        public string Id { get; set; }
        public string Breed { get; set; }

        public string Name { get; set; }

        public string Allergies { get; set; }

        public int Age { get; set; }
        public double Height { get; set; }
    }
}
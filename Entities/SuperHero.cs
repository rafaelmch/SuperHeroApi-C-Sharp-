// Rafael Hassegawa - 16/02/2024

namespace SuperHeroAPI_DotNet8.Entity
{
    public class SuperHero
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string FirstName {  get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Place {  get; set; } = string.Empty;
    }
}

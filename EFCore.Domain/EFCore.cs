namespace EFCore.Domain
{
    public class EFCore
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Word> Words { get; set; } = new List<Word>();

    }
}
namespace entity
{
    public class Produs
    {
        public Produs(uint id, string? nume, string? codIntern, string? producator)
        {
            Id = id;
            Nume = nume;
            CodIntern = codIntern;
            Producator = producator;
        }
        public uint Id { get; set; }
        public string? Nume { get; set; }
        public string? CodIntern { get; set; }
        public string? Producator { get; set; }
    }
}
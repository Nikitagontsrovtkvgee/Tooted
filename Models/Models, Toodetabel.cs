using System;

namespace AutodjaOmanikud.Models
{
    public class Toodetabel
    {
        public int Id { get; set; }
        public string Toodenimetus { get; set; }
        public int Kogus { get; set; }
        public decimal Hind { get; set; }
        public string Pilt { get; set; }
        public DateTime Lisatud { get; set; }

        public int KategooriaId { get; set; }
        public Kategooriatabel Kategooria { get; set; }
    }
}

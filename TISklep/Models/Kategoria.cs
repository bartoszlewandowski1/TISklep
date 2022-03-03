using System.Collections.Generic;

namespace TISklep.Models
{
    public class Kategoria
    {
        public int Id { get; set; }

        public string Nazwa { get; set; }

        public string Opis { get; set; }

        public ICollection<Film> Filmy { get; set; }
    }
}

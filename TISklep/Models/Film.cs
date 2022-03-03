using System;
using System.ComponentModel.DataAnnotations;

namespace TISklep.Models
{
    public class Film
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nie podano Tytułu")]
        public string Tytul { get; set; }

        public string Rezyser { get; set; }
        [StringLength(1000)]
        public string Opis { get; set; }

        public decimal Cena { get; set; }
        //znak zapytania po typie = nieobowiązkowa
        public DateTime? DataProdukcji { get; set; }
        //klucz obcy
        public int KategoriaId { get; set; }

        public Kategoria Kategoria { get; set; }

    }
}

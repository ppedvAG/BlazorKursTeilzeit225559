using System.ComponentModel.DataAnnotations;

namespace BlazorKursTeilzeit225559.Pages.Modul5
{
    public class Person
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="da muss was rein")]
        [StringLength(10, ErrorMessage ="DB Schema max 10")]
        public string Name { get; set; }
        [Required(ErrorMessage = "da muss was rein")]
        [Range (150, 190,ErrorMessage ="zwischen 150 und 180")]
        public int Gross { get; set; }
        [Required(ErrorMessage = "da muss was rein")]
        public DateTime GebDat { get; set; }


    }
}

using System.ComponentModel.DataAnnotations;

namespace LeBataillon.Database.Models
{
    public class Player
    {
        public Player()
        {


        }

        public Player(int Id, string NickName, string Email, string PhoneNumber, string FirstName, string LastName, PlayerLevel level)
        {
            this.Id = Id;
            this.NickName = NickName;
            this.Email = Email;
            this.PhoneNumber = PhoneNumber;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Level = Level;

        }

        public void EditFrom(Player p)
        {
            this.Id = p.Id;
            this.NickName = p.NickName;
            this.Email = p.Email;
            this.PhoneNumber = p.PhoneNumber;
            this.FirstName = p.FirstName;
            this.LastName = p.LastName;
            this.Level = p.Level;

        }
        [Key]
        public int Id { get; set; }

        [Display(Name = "NickName du joueur ")]
        public string NickName { get; set; }
        [Display(Name = "Email du joueur ")]
        [Required(ErrorMessage = "Email requis")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Téléphone du joueur ")]
        [Phone(ErrorMessage = "Il faut que le téléphone soit de la forme ###-###-####")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [Display(Name = "Prenom du joueur ")]
        [Required(ErrorMessage = "Prenom requis")]

        public string FirstName { get; set; }

        [Display(Name = "Nom du joueur ")]
        [Required(ErrorMessage = "Nom requis")]
        public string LastName { get; set; }
        [Display(Name = "level du joueur ")]
        public PlayerLevel Level { get; set; }

    }
}
using System.ComponentModel.DataAnnotations;

namespace LeBataillon.Database.Models
{
    public class Team
    {

        public Team()
        {


        }

        public Team(int Id, string TeamName, int CaptainId)
        {
            this.Id = Id;
            this.TeamName = TeamName;
            this.CaptainId = CaptainId;

        }

        public void EditFrom(Team t)
        {
            this.Id = t.Id;
            this.TeamName = t.TeamName;
            this.CaptainId = t.CaptainId;

        }

        [Key]
        public int Id { get; set; }

        [Display(Name = "Nom de l'équipe")]
        [Required(ErrorMessage = "Nom de l'équipe requis")]
        public string TeamName { get; set; }

        [Display(Name = "Capitain de l'équipe")]
        [Required(ErrorMessage = "Capitain de l'équipe requis")]
        public int CaptainId { get; set; }
        [Display(Name = "Capitain de l'équipe")]

        public virtual Player Captain { get; set; }

    }
}
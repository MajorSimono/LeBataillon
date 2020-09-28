using System;
using System.ComponentModel.DataAnnotations;

namespace LeBataillon.Database.Models
{
    public class Game
    {
        public Game()
        {


        }

        public Game(int Id, DateTime GameDateTime, int TeamDefendant, int TeamAttacker)
        {
            this.Id = Id;
            this.GameDateTime = GameDateTime;
            this.TeamDefendantId = TeamDefendant;
            this.TeamAttackerId = TeamAttacker;

        }

        public void EditFrom(Game g)
        {
            this.Id = g.Id;
            this.GameDateTime = g.GameDateTime;
            this.TeamDefendantId = g.TeamDefendantId;
            this.TeamAttackerId = g.TeamAttackerId;

        }
        [Key]
        public int Id { get; set; }
        [Display(Name = "Date de la partie")]
        [Required(ErrorMessage = "Date de la partie requis")]
        [DataType(DataType.Date)]
        public DateTime GameDateTime { get; set; }
        [Display(Name = "Équipe défendante de la partie")]
        public int TeamDefendantId { get; set; }
        [Display(Name = "Équipe attaquante de la partie")]
        public int TeamAttackerId { get; set; }

    }
}
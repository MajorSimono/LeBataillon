namespace LeBataillon.Database.Models
{
    public class Team
    {

        public Team()
        {


        }

        public Team(int Id, string TeamName, int Captain)
        {
            this.Id = Id;
            this.TeamName = TeamName;
            this.CaptainId = Captain;

        }

        public void EditFrom(Team t)
        {
            this.Id = t.Id;
            this.TeamName = t.TeamName;
            this.CaptainId = t.CaptainId;

        }
        public int Id { get; set; }
        public string TeamName { get; set; }
        public int CaptainId { get; set; }

        public virtual Player Captain { get; set; }

    }
}
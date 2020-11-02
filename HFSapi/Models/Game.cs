namespace HFSapi.Models
{
  public class Game
  {
    public int GameId { get; set; }
    public int Season { get; set; }
    public int Week { get; set; }
    public int PlayerId { get; set; }
    public string Team { get; set; }
    public int PassYards { get; set; }
    public int RecYards { get; set; }
    public int RushYards { get; set; }
    public int Interceptions { get; set; }
    public int Fumbles { get; set; }
    public int Receptions { get; set; }
    public int PassTDs { get; set; }
    public int RushTDs { get; set; }
    public int RecTDs { get; set; }
  }
}
using System.Collections.Generic;

namespace Patisserie.Models
{
  public class Treat
  {
    public Treat()
    {
      this.JoinEntities = new HashSet<FlavourTreat>();
    }

    public int TreatId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<FlavourTreat> JoinEntities { get;}
  }
}
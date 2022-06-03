using System.Collections.Generic;

namespace Patisserie.Models
{
  public class Flavour
  {
    public Flavour()
    {
      this.JoinEntities = new HashSet<FlavourTreat>();
    }

    public int FlavourId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<FlavourTreat> JoinEntities { get; set; }
  }
}
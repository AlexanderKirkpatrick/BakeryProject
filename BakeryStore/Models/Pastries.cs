using System;

namespace BakeryStore.Models
{
  public class Pastries
  {
    public int PastryCount {get; set; }
    public Pastries (int pastryCount)
    {
      PastryCount = pastryCount;
    }

    public int Cost ()
    {
      int cost = 0;
      int pastryCount = PastryCount;

      if (pastryCount >= 3)
      {
        int pastryTriples = pastryCount / 3;
        cost += 5 * pastryTriples;
        pastryCount -= (pastryTriples * 3);
      }

      cost += (2 * pastryCount);

      return cost;
    }
  }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laptop.Models
{
   public interface InterfaceLappy
    {
        //Fetch Single Details
        Lappy GetLappy(int Id);
        //Fetch All Details
        IEnumerable<Lappy> GetAllDetails();
        Lappy Add(Lappy lappy);
        Lappy Delete(int Id);
        Lappy Update(Lappy lappyChange);
    }
}

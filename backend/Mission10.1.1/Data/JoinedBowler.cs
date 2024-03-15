using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Mission10._1._1.Data
{
    public class JoinedBowler
    {
            

        
            public int BowlerID { get; set; }
            public string BowlerLastName { get; set; }
            public string BowlerFirstName { get; set; }
            public string? BowlerMiddleInit { get; set; }
            public string BowlerAddress { get; set; }
            public string BowlerCity { get; set; }
            public string BowlerState { get; set; }
            public string BowlerZip { get; set; }
            public string BowlerPhoneNumber { get; set; }
            public int TeamID { get; set; }
            public string TeamName { get; set; }


        }

    }



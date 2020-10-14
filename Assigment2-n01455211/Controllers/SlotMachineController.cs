using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assigment2_n01455211.Controllers
{
    public class SlotMachineController : ApiController
    {
        /// <summary>
        /// Canadian Computing Competition: 2000 Stage 1, Junior #3, Senior #1
        ///Martha takes a jar of quarters to the casino with the intention of becoming rich.
        ///She plays three machines in turn.Unknown to her, the machines are entirely predictable.
        ///Each play costs one quarter.The first machine pays 30 quarters every 35th time it is played; the second machine pays 60 quarters every 100th time it is played; the third pays 9 quarters every 10th time it is played.
        /// </summary>
        /// <param name="quarters" - integer representing the quarters user input></param>
        /// <param name="machine1" - integer representing the number of times machine1 has been played></param>
        /// <param name="machine2" - integer representing the number of times machine2 has been played></param>
        /// <param name="machine3" - integer representing the number of times machine3 has been played></param>
        /// <returns>
        /// Your program should output the number of times Martha plays until she goes broke.
        /// </returns>
        /// <example>
        /// GET ../api/J3/SlotMachine/48/3/10/4   ---> Martha plays 66 times before going broke.
        /// GET ../api/J3/SlotMachine/48/3/10/4   ---> Martha plays 66 times before going broke.
        /// </example>
        /// 
        [HttpGet]
        [Route("api/J3/SlotMachine/{quarters}/{machine1}/{machine2}/{machine3}")]
        public string SlotMachine(int quarters, int machine1, int machine2, int machine3)
        {

            int counter = 0; //Number of times it can be played until quarters goes 0

            //While loop based on the quarters to play the game
            while (quarters >= 1)
            {
                quarters = quarters - 1;
                counter = counter + 1;
                machine1 = machine1 + 1;
                if (machine1 == 35) 
                {
                    quarters = quarters + 30;
                    machine1 = 0;
                }
                 if (quarters == 0) break;

                quarters = quarters - 1;
                counter = counter + 1;
                machine2 = machine2 + 1;

                if (machine2 == 100)
                {
                    quarters = quarters + 60;
                    machine2 = 0;
                }
                if (quarters == 0) break;


                quarters = quarters - 1;
                counter = counter + 1;
                machine3 = machine3 + 1;

                if (machine3 == 10)
                {
                    quarters = quarters + 9;
                    machine3 = 0;
                }
                if (quarters == 0) break;
               
            }
            
            return "Martha plays " + counter.ToString() + " times before going broke.";

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Web.Http;

namespace Assigment2_n01455211.Controllers
{
    public class DiceGameController : ApiController
    {
        /// <summary>
        /// Diana is playing a game with two dice.
        /// ● One dice has m sides labelled 1, 2, 3 ..., m
        /// ● The other dice has n sides labelled 1, 2, 3, …, n
        /// Write a program which determines how many ways she can roll the value of 10.
        /// </summary>
        /// <param name="m"- positive integer representing the number of sides on the first die  ></param>
        /// <param name="n" - positive integer representing the number of sides on the second die></param>
        /// <param name="x"- positive integer representing the value on first die m  ></param>
        /// <param name="y" - positive integer representing the value on the second die n></param>
        /// <returns>
        /// Total ways to get the sum of 10 depending on the sides of dice input by user
        /// </returns>
        /// <example>
        /// GET ../api/J2/DiceGame/6/8   ---> There are 5 total ways to get the sum 10.
        /// GET ../api/J2/DiceGame/12/4  ---> There are 4 ways to get the sum 10.
        /// GET ../api/J2/DiceGame/3/3   ---> There are 0 ways to get the sum 10.
        /// </example>

        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]

       public string DiceGame(int m, int n)
        {
            int sum = 0; //Sum of the values when 2 dices are thrown
            int count = 0; //Number of ways the 2 dices can give sum 10

            for (int x = 1; x <= m; x++)
            {
                for (int y = 1; y <= n; y++)
                {
                        sum = x + y;
                        //Using Ternary operators for the given condition
                        count += ((sum == 10) ? 1 : 0);                        
                }
            }
                
            return "There are " + count.ToString() + " total ways to get the sum 10.";
        }
    }
}

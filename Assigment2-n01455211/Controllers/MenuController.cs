using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Principal;
using System.Web.Http;
using System.Xml.Schema;

namespace Assigment2_n01455211.Controllers
{
    public class MenuController : ApiController
    {
        /// <summary>
        /// Adapted J1 - The New CCC(Canadian Calorie Counting)
        /// At Chip’s Fast Food emporium there's a very simple menu. Each food item is selected by entering a digit choice.
        /// Write a program that will compute the total Calories of the meal
        /// </summary>
        /// <param name="burger" - Integer representing the index burger choice  ></param>
        /// <param name="drink" - Integer representing the index drink choice></param>
        /// <param name="side" - Integer representing the index side choice></param>
        /// <param name="dessert" - Integer representing the index dessert choice></param>
        /// <returns>
        /// Total Calorie count for ordered menu items
        /// </returns>
        /// <example>
        /// GET ../api/J1/Menu/4/4/4/4  ---> Your total calorie count is 0
        /// GET ../api/J1/Menu/1/2/3/4  ---> Your total calorie count is 691
        /// </example>

        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]      
        
        public string Menu(int burger, int drink, int side, int dessert)
        {
            //variable to hold calories depending on user input for each category of the menu
            int burgercalories = 0;
            int drinkcalories = 0;
            int sidecalories = 0;
            int dessertcalories = 0;

            //Using if condition to identify calorie value for ordered item from burger category
            if (burger == 1) burgercalories = 461;            
            else if (burger == 2) burgercalories = 431;            
            else if (burger == 3) burgercalories = 420;            
            else if (burger == 4) burgercalories = 0;
            
            
            if (drink == 1) drinkcalories = 130;
            else if (drink == 2) drinkcalories = 160;
            else if (drink == 3) drinkcalories = 118;
            else if (drink == 4) drinkcalories = 0;

            
            if (side == 1) sidecalories = 100;
            else if (side == 2) sidecalories = 57;
            else if (side == 3) sidecalories = 70;
            else if (side == 4) sidecalories = 0;

            
            if (dessert == 1) dessertcalories = 167;
            else if (dessert == 2) dessertcalories = 266;
            else if (dessert == 3) dessertcalories = 75;
            else if (dessert == 4) dessertcalories = 0;

            int totalcalorie = burgercalories + drinkcalories + sidecalories + dessertcalories;

            if (burger > 4  || drink > 4 || side > 4 || dessert > 4 || burger < 0 || drink < 0 || side < 0 || dessert < 0)
                return "Incorrect Digit Choice. Please enter correct code from Menu";
            else                
                return "Your total calorie count is " + totalcalorie.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave_Klikkerspill
{
    public class ClickerGame
    {
        int points = 0;
        int pointsPerClick = 1;
        int pointsPerClickIncrease = 1;


        public void BuyUpgrade()
        {

        }

        public void ClickForPoints()
        {
            points += pointsPerClick;
        }

        public void BuySuperUpgrade()
        {

        }

        public void ExitGame()
        {

        }
    }
}

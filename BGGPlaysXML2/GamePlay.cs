using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGGPlaysXML2
{
    public class GamePlay
    {
        private string GameTitle, objectID;
        private DateTime PlayDate;
        private int Quantity;

        public GamePlay(string name, string id, DateTime date)
        {
            GameTitle = name;
            objectID = id;
            PlayDate = date;
            Quantity = 1;
        }

        public string getDay()
        {
            return PlayDate.DayOfWeek.ToString();
        }

        public string getTitle()
        {
            return GameTitle;
        }

        public string getID()
        {
            return objectID;
        }
        public bool Equals(GamePlay X)
        {
            if (X.getID().Equals(objectID))
                return true;
            else
                return false;
        }

        public void IncrementQuantity()
        {
            Quantity++;
        }

        public int getQuantity()
        {
            return Quantity;
        }
    }
}

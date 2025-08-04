using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexICE
{
    public class Fish
    {
        int lenght, fishWeight;
        string Season, fishSpecies;

        public Fish(int lenght, int fishWeight, string Season, string fishSpecies)
        {
            this.lenght = lenght;
            this.fishWeight = fishWeight;
            this.Season = Season;
            this.fishSpecies = fishSpecies;
        }

        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return this.lenght;
                else if (index == 1)
                    return this.fishWeight;
                else if (index == 2)
                    return this.Season;
                else if (index == 3)
                    return this.fishSpecies;
                return null;
            }
            set
            {
                if (index == 0)
                    this.lenght = (int)value;
                else if (index == 1)
                    this.fishWeight = (int)value;
                else if (index == 2)
                    this.Season = (string)value;
                else if (index == 3)
                    this.fishSpecies = (string)value;
            }
        }

        public object this[string attrName]
        {
            get
            {
                if (attrName == "lenghth")
                    return this.lenght;
                else if (attrName == "fishWheight")
                    return this.fishWeight;
                else if (attrName == "season")
                    return this.Season;
                else if (attrName == "fishSpecies")
                    return this.fishSpecies;
                return null;
            }
            set
            {
                if (attrName.ToLower().Equals("lenghth"))
                    this.lenght = (int)value;
                else if (attrName.ToLower().Equals("fishWheight"))
                    this.fishWeight = (int)value;
                else if (attrName.ToLower().Equals("season"))
                    this.Season = (string)value;
                else if (attrName.ToLower().Equals("fishSpecies"))
                    this.fishSpecies = (string)value;
            }
        }
    } 
}

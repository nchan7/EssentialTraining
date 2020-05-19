using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialTraining
{
    public class FlowControl
    {
        public string IsYourNameNotBruce(string yourName)
        {
            if(yourName.ToLower() != "bruce")
            {
                return "Can we call you Bruce for the sake of simplicity?";
            } else
            {
                return "G'day Bruce";
            }
        }
        public string GradeLetter(int score)
        {
            if (score > 90)
            {
                return "A";
            }
            else if (score > 79 && score < 90)
            {
                return "B";
            } else if (score >= 70 && score <= 80)
            {
                return "C";
            } else
            {
                return "F";
            }
        }
        public string PrimaryOrSecondaryCompound(string color)
        {
            if(color.ToLower() == "red" || color.ToLower() == "blue" || color.ToLower() == "yellow")
            {
                return "Primary";
            } else
            {
                return "Secondary";
            }
        }
        public string SecondaryOrPrimary(string color)
        {
            var result = "";
            switch(color.ToLower())
            {
                case "red":
                    result = "Primary";
                    // could have more statements
                    break;

                case "blue":
                    result = "Primary";
                    break;

                case "yellow":
                    result = "Primary";
                    break;

                default:
                    result = "Secondary";
                    break;
            }
            return result;
        }
        public string PrimaryOrSecondary(string color)
        {
            var result = "";
            if (color.ToLower() == "red")
            {
                result = "Primary";
            }
            else if (color.ToLower() == "blue")
            {
                result = "Primary";
            }
            else if (color.ToLower() == "yellow")
            {
                result = "Primary";
            } else
            {
                result = "Secondary";
            }
            return result;
        }
        public bool IsYourFavoriteColorYellow(string color)
        {
            return (color.ToLower() == "yellow");
        }
        public bool IsYourFavoriteColorGreen(string color)
        {
            return (color.ToLower() == "Green") ? true : false;
        }
        public bool IsYourFavoriteColorRed(string color)
        {
            if (color.ToLower() == "red") return true;
            return false;
        }
        public bool IsYourFavoriteColorBlue(string color)
        {
            if( color.ToLower() == "blue")
            {
                return true; 
            } else
            {
                return false;
            }
        }
    }
}

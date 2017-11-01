using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Minder.Models
{
    public class ProfileSearchViewModel
    {
        public InteresseEnum GenderPreference { get; set; }
        public string AgeRange { get; set; }
        public int MinAge
        {
            get
            {
                return Convert.ToInt32(AgeRange.Split(',')[0]);
            }
        }

        public int MaxAge
        {
            get
            {
                return Convert.ToInt32(AgeRange.Split(',')[1]);
            }
        }
        public int HeightMin { get; set; }
        public int HeightMax { get; set; }
        public List<EducationEnum> EducationPreferences { get; set; }
        public string City { get; set; }
        public int? Range { get; set; } // '?' enables null value
    }
}
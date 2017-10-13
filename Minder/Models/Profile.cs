using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Minder.Models
{
    public class Profile
    {
        public int ID { get; set; }
        public string Ethniciteit = "Marokkaans";
        public ApplicationUser User{ get; set; }
        public string Nickname { get; set; }
        public DateTime GeboorteDatum { get; set; }
        public string Woonplaats { get; set; }
        public string Profielfoto { get; set; }
        public int Lengte { get; set; }
        public EducationEnum Educatie { get; set; }
        public InteresseEnum Interesse { get; set; }
        public List<Picture> FotoAlbum { get; set; }

       
    }

    public enum GeslachtEnum
        {
            Man,
            Vrouw,
            Overig
        }
        public enum EducationEnum
        {
            Middelbare_school,
            MBO,
            HBO,
            Universiteit
        }
        public enum InteresseEnum
        {
            Man,
            Vrouw,
            Beide,
            Overig,
            Alle
        }
}
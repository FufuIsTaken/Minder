using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Minder.Models
{
    public class Profile
    {
        public int ID { get; set; }
        public string Ethniciteit = "Marokkaans";
        public ApplicationUser User{ get; set; }
        [Display(Name = "Weergavenaam")]
        public string Nickname { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-mm-dd}", ApplyFormatInEditMode = true)]
        public DateTime GeboorteDatum { get; set; }
        public string Woonplaats { get; set; }
        [Display(Name = "Profiel foto")]
        public virtual Profile Profielfoto { get; set; }
        public int Lengte { get; set; }
        public EducationEnum Educatie { get; set; }
        [Display(Name = "Interesse in:")]
        public InteresseEnum Interesse { get; set; }
        public List<Picture> FotoAlbum { get; set; }
        public GeslachtEnum Geslacht { get; set; }
    }

    public enum GeslachtEnum
        {
            Man,
            Vrouw,
            Overig
        }
        public enum EducationEnum
        {
        [Display(Name = "Middelbare School")]
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
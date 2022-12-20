using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Entity
{
    public class Missions : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string MissionTitle { get; set; }
        public string MissionDescription { get; set; }
        public string MissionOrganisationName { get; set; }
        public string MissionOrganisationDetail { get; set; }
        public int CountryId { get; set; }       
        public int CityId { get; set; }
      
        //[DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        public DateTime StartDate { get; set; }
        //[DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        public DateTime EndDate { get; set; }

        public int TotalSheets { get; set; }
        [Column(TypeName = "Date")]
        public DateTime RegistrationDeadLine { get; set; }
        public string MissionTheme { get; set; }
        public string MissionSkill { get; set; }
        public string MissionImages { get; set; }
        public string MissionDocuments { get; set; }
        public string MissionAvilability { get; set; }        
        [NotMapped]
        public string CountryName { get; set; }
        [NotMapped]
        public string CityName { get; set; }
    }
}

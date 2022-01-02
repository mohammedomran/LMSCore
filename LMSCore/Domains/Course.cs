using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LMSCore.Models
{
    public partial class Course
    {
        [NotMapped]
        public string MainPhotoPath
        {
            get
            {
                return "physical_path/" + MainPhoto;
            }
        }
    }
}

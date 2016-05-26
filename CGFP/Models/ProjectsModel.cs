using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CGFP.Models
{
    public class ProjectsModel

    {

        [Key]
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string DescripProject { get; set; }
        public string Image { get; set; }
        public string GitAddress { get; set; }

    }
}
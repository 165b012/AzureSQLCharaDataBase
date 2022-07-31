using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CharaDataBaseProject.Models;

namespace CharaDataBaseProject.ViewModels
{
    public class CharaViewModels
    {
        public CharaName CharaNames { get; set; }
        public Skill Skills { get; set; }
        public Status Status { get; set; }
    }
}
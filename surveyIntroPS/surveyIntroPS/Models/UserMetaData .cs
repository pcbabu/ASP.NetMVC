using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace surveyIntroPS.Models
{
    [MetadataType(typeof(UserMetaData))]
    public partial class UserLogIn
    {
    }
    class UserMetaData
    {
        [Remote("IsUserExists", "UserLogIns", ErrorMessage = "User Name already in use")]
        public string Email { get; set; }
    }
}
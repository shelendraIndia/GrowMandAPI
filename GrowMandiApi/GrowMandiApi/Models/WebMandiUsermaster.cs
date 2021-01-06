using System;
using System.Collections.Generic;

namespace GrowMandiApi.Models
{
    public partial class WebMandiUsermaster
    {
        public int TrId { get; set; }
        public string UserName { get; set; }
        public string UserMobile { get; set; }
        public string UserState { get; set; }
        public int? UserRole { get; set; }
        public string UserPwd { get; set; }
        public string UserMail { get; set; }
        public int? IsLogin { get; set; }
        public string SessionId { get; set; }
        public int? LockOut { get; set; }
        public string LockStatus { get; set; }
        public int? ChangePass { get; set; }
        public string UserStatus { get; set; }
    }
}

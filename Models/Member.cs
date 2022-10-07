﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectMVC.Models
{
    public partial class Member
    {
        public Member()
        {
            Admins = new HashSet<Admin>();
            Orders = new HashSet<Order>();
        }

        public int MemberId { get; set; }
        public string MemberAccount { get; set; }
        public string MemberPassword { get; set; }
        public string MemberName { get; set; }
        public DateTime BirthDate { get; set; }
        public string MemberPhone { get; set; }
        public string MemberEmail { get; set; }
        public int CityId { get; set; }
        public byte[] MemberImage { get; set; }
        public string Authority { get; set; }

        public virtual City City { get; set; }
        public virtual ICollection<Admin> Admins { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSCTSV.Model
{
    public class HSUser
    {
        public string TokenCode { get; set; }
        public string RespText { get; set; }
        public int RespCode { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string MoreInfo { get; set; }
    }
}

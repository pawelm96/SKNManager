﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SKNManager.Models.AccountViewModels
{
    public class InviteViewModel
    {
        [Required]
        public string Email { get; set; }
    }
}

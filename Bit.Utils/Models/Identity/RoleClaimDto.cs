﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bit.Utils.Models.Identity
{
    [ComplexType]
    public class RoleClaimDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Role name is required")]
        public string? RoleName { get; set; }

        [Required(ErrorMessage = "Claim type is required")]
        public string? ClaimType { get; set; }
    }
}
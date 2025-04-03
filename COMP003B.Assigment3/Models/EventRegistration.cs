using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assigment3.Models
{
    public class EventRegistration : Controller
    {
            [Required]
            public string FullName { get; set; }
            [MinLength(3)]

            [Required]
            public string Email { get; set; }

            [Required]
            public string EventCode { get; set; }
            [MaxLength(20)]

            [Required]
            public int Tickets { get; set; }
            [Range(1, 10)]

            public string ReferralCode { get; set; }
        }
    }


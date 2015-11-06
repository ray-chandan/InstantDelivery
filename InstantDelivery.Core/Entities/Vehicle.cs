﻿using System.ComponentModel.DataAnnotations;

namespace InstantDelivery.Core.Entities
{
    public class Vehicle : ValidationBase
    {
        [Required(ErrorMessage = "To pole jest wymagane")]
        public string RegistrationNumber { get; set; }
        public virtual VehicleModel VehicleModel { get; set; }
    }
}

﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DoxaFlameAPILib.Models;

public partial class Speaker
{
    public int SpeakerId { get; set; }

    public int ChurchId { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public string Phone { get; set; }

    public DateTime CreatedDate { get; set; }

    public int? PastorId { get; set; }

    public virtual Church Church { get; set; }

    public virtual Pastor Pastor { get; set; }

    public virtual ICollection<Sermon> Sermons { get; set; } = new List<Sermon>();
}
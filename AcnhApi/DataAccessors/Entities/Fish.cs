using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AcnhApi.Controllers.Models;
using Microsoft.EntityFrameworkCore;

namespace AcnhApi.DataAccessors.Entities;

/// <summary>
/// Interface for Fish being added to the database.
/// </summary>
public class Fish
{
    // Table columns
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string? FishId { get; set; }
    public string FishName { get; set; }
    public string FishImageUri { get; set; }
    public string FishLocation { get; set; }
    public bool FishAvailabilityMonth01 { get; set; }
    public bool FishAvailabilityMonth02 { get; set; }
    public bool FishAvailabilityMonth03 { get; set; }
    public bool FishAvailabilityMonth04 { get; set; }
    public bool FishAvailabilityMonth05 { get; set; }
    public bool FishAvailabilityMonth06 { get; set; }
    public bool FishAvailabilityMonth07 { get; set; }
    public bool FishAvailabilityMonth08 { get; set; }
    public bool FishAvailabilityMonth09 { get; set; }
    public bool FishAvailabilityMonth10 { get; set; }
    public bool FishAvailabilityMonth11 { get; set; }
    public bool FishAvailabilityMonth12 { get; set; }
    public bool FishAvailabilityHours00 { get; set; }
    public bool FishAvailabilityHours01 { get; set; }
    public bool FishAvailabilityHours02 { get; set; }
    public bool FishAvailabilityHours03 { get; set; }
    public bool FishAvailabilityHours04 { get; set; }
    public bool FishAvailabilityHours05 { get; set; }
    public bool FishAvailabilityHours06 { get; set; }
    public bool FishAvailabilityHours07 { get; set; }
    public bool FishAvailabilityHours08 { get; set; }
    public bool FishAvailabilityHours09 { get; set; }
    public bool FishAvailabilityHours10 { get; set; }
    public bool FishAvailabilityHours11 { get; set; }
    public bool FishAvailabilityHours12 { get; set; }
    public bool FishAvailabilityHours13 { get; set; }
    public bool FishAvailabilityHours14 { get; set; }
    public bool FishAvailabilityHours15 { get; set; }
    public bool FishAvailabilityHours16 { get; set; }
    public bool FishAvailabilityHours17 { get; set; }
    public bool FishAvailabilityHours18 { get; set; }
    public bool FishAvailabilityHours19 { get; set; }
    public bool FishAvailabilityHours20 { get; set; }
    public bool FishAvailabilityHours21 { get; set; }
    public bool FishAvailabilityHours22 { get; set; }
    public bool FishAvailabilityHours23 { get; set; }

    // Used to cross-reference; not actually added into the Fish table
    public ICollection<User>? User { get; set; }
}


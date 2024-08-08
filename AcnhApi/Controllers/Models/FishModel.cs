using System;
using AcnhApi.Poco.Dtos;

namespace AcnhApi.Controllers.Models;

/// <summary>
/// Interface for Fish being added by an admin via Swagger.
/// </summary>
public class AddFishModel
{
    public string FishName { get; set; }
    public string FishImageUri { get; set; }
    public string FishLocation { get; set; }
    public AvailabilityHours AvailabilityHours { get; set; }
    public AvailabilityMonths AvailabilityMonths { get; set; }
}

/// <summary>
/// Interface for Fish being updated by an admin via Swagger.
/// </summary>
public class UpdateFishModel
{
    public string FishId { get; set; }
    public string? FishName { get; set; }
    public string? FishImageUri { get; set; }
    public string? FishLocation { get; set; }
    public AvailabilityHours? AvailabilityHours { get; set; }
    public AvailabilityMonths? AvailabilityMonths { get; set; }
}
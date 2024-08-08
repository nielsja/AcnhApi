using System;
using AcnhApi.DataAccessors.Entities;

namespace AcnhApi.Poco.Dtos;

/// <summary>
/// Interface for Fish being sent to the client.
/// </summary>
public class FishDto
{
    public string FishId { get; set; }
    public string FishName { get; set; }
    public string FishImageUri { get; set; }
    public string FishLocation { get; set; }
    public AvailabilityMonths AvailabilityMonths { get; set; }
    public AvailabilityHours AvailabilityHours { get; set; }
}


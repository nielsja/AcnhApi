using System.Net;
using AcnhApi.Controllers.Models;
using AcnhApi.DataAccessors.AcnhDbContext;
using AcnhApi.DataAccessors.Entities;
using AcnhApi.Migrations;
using AcnhApi.Poco.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace AcnhApi.Controllers;

[ApiController]
[Route("[controller]")]
public class FishController : ControllerBase
{
    private readonly AcnhDbContext _acnhDbContext;

    public FishController(AcnhDbContext acnhDbContext)
    {
        _acnhDbContext = acnhDbContext;
    }


    [HttpGet("GetAllFish")]
    public async Task<List<FishDto>> GetAllFish()
    {
        List<Fish> allFishDb = await _acnhDbContext.Fishes.ToListAsync();
        List<FishDto> allFishDtos = allFishDb
            .Select(fish => new FishDto()
            {
                FishId = fish.FishId,
                FishName = fish.FishName,
                FishImageUri = fish.FishImageUri,
                FishLocation = fish.FishLocation,
                AvailabilityMonths = new AvailabilityMonths()
                {
                    Month01 = fish.FishAvailabilityMonth01,
                    Month02 = fish.FishAvailabilityMonth02,
                    Month03 = fish.FishAvailabilityMonth03,
                    Month04 = fish.FishAvailabilityMonth04,
                    Month05 = fish.FishAvailabilityMonth05,
                    Month06 = fish.FishAvailabilityMonth06,
                    Month07 = fish.FishAvailabilityMonth07,
                    Month08 = fish.FishAvailabilityMonth08,
                    Month09 = fish.FishAvailabilityMonth09,
                    Month10 = fish.FishAvailabilityMonth10,
                    Month11 = fish.FishAvailabilityMonth11,
                    Month12 = fish.FishAvailabilityMonth12,
                },
                AvailabilityHours = new AvailabilityHours()
                {
                    Hour00 = fish.FishAvailabilityHours00,
                    Hour01 = fish.FishAvailabilityHours01,
                    Hour02 = fish.FishAvailabilityHours02,
                    Hour03 = fish.FishAvailabilityHours03,
                    Hour04 = fish.FishAvailabilityHours04,
                    Hour05 = fish.FishAvailabilityHours05,
                    Hour06 = fish.FishAvailabilityHours06,
                    Hour07 = fish.FishAvailabilityHours07,
                    Hour08 = fish.FishAvailabilityHours08,
                    Hour09 = fish.FishAvailabilityHours09,
                    Hour10 = fish.FishAvailabilityHours10,
                    Hour11 = fish.FishAvailabilityHours11,
                    Hour12 = fish.FishAvailabilityHours12,
                    Hour13 = fish.FishAvailabilityHours13,
                    Hour14 = fish.FishAvailabilityHours14,
                    Hour15 = fish.FishAvailabilityHours15,
                    Hour16 = fish.FishAvailabilityHours16,
                    Hour17 = fish.FishAvailabilityHours17,
                    Hour18 = fish.FishAvailabilityHours18,
                    Hour19 = fish.FishAvailabilityHours19,
                    Hour20 = fish.FishAvailabilityHours20,
                    Hour21 = fish.FishAvailabilityHours21,
                    Hour22 = fish.FishAvailabilityHours22,
                    Hour23 = fish.FishAvailabilityHours23
                },
            })
            .ToList();
        return allFishDtos;
    }

    [HttpGet("GetFish")]
    public async Task<IActionResult> GetFish(string fishId)
    {
        Fish? existingFish = await _acnhDbContext.Fishes.FirstOrDefaultAsync((f) => f.FishId == fishId);

        if (existingFish is null)
        {
            return BadRequest();
        }

        return Ok(existingFish);
    }

    [HttpPost("AddFish")]
    [ProducesResponseType(StatusCodes.Status424FailedDependency)]
    public async Task<IActionResult> AddFish(AddFishModel apiFish)
    {
        Fish dbFish = new Fish()
        {
            FishName = apiFish.FishName,
            FishImageUri = apiFish.FishImageUri,
            FishLocation = apiFish.FishLocation,
            FishAvailabilityMonth01 = apiFish.AvailabilityMonths.Month01 ?? false,
            FishAvailabilityMonth02 = apiFish.AvailabilityMonths.Month02 ?? false,
            FishAvailabilityMonth03 = apiFish.AvailabilityMonths.Month03 ?? false,
            FishAvailabilityMonth04 = apiFish.AvailabilityMonths.Month04 ?? false,
            FishAvailabilityMonth05 = apiFish.AvailabilityMonths.Month05 ?? false,
            FishAvailabilityMonth06 = apiFish.AvailabilityMonths.Month06 ?? false,
            FishAvailabilityMonth07 = apiFish.AvailabilityMonths.Month07 ?? false,
            FishAvailabilityMonth08 = apiFish.AvailabilityMonths.Month08 ?? false,
            FishAvailabilityMonth09 = apiFish.AvailabilityMonths.Month09 ?? false,
            FishAvailabilityMonth10 = apiFish.AvailabilityMonths.Month10 ?? false,
            FishAvailabilityMonth11 = apiFish.AvailabilityMonths.Month11 ?? false,
            FishAvailabilityMonth12 = apiFish.AvailabilityMonths.Month12 ?? false,
            FishAvailabilityHours00 = apiFish.AvailabilityHours.Hour00 ?? false,
            FishAvailabilityHours01 = apiFish.AvailabilityHours.Hour01 ?? false,
            FishAvailabilityHours02 = apiFish.AvailabilityHours.Hour02 ?? false,
            FishAvailabilityHours03 = apiFish.AvailabilityHours.Hour03 ?? false,
            FishAvailabilityHours04 = apiFish.AvailabilityHours.Hour04 ?? false,
            FishAvailabilityHours05 = apiFish.AvailabilityHours.Hour05 ?? false,
            FishAvailabilityHours06 = apiFish.AvailabilityHours.Hour06 ?? false,
            FishAvailabilityHours07 = apiFish.AvailabilityHours.Hour07 ?? false,
            FishAvailabilityHours08 = apiFish.AvailabilityHours.Hour08 ?? false,
            FishAvailabilityHours09 = apiFish.AvailabilityHours.Hour09 ?? false,
            FishAvailabilityHours10 = apiFish.AvailabilityHours.Hour10 ?? false,
            FishAvailabilityHours11 = apiFish.AvailabilityHours.Hour11 ?? false,
            FishAvailabilityHours12 = apiFish.AvailabilityHours.Hour12 ?? false,
            FishAvailabilityHours13 = apiFish.AvailabilityHours.Hour13 ?? false,
            FishAvailabilityHours14 = apiFish.AvailabilityHours.Hour14 ?? false,
            FishAvailabilityHours15 = apiFish.AvailabilityHours.Hour15 ?? false,
            FishAvailabilityHours16 = apiFish.AvailabilityHours.Hour16 ?? false,
            FishAvailabilityHours17 = apiFish.AvailabilityHours.Hour17 ?? false,
            FishAvailabilityHours18 = apiFish.AvailabilityHours.Hour18 ?? false,
            FishAvailabilityHours19 = apiFish.AvailabilityHours.Hour19 ?? false,
            FishAvailabilityHours20 = apiFish.AvailabilityHours.Hour20 ?? false,
            FishAvailabilityHours21 = apiFish.AvailabilityHours.Hour21 ?? false,
            FishAvailabilityHours22 = apiFish.AvailabilityHours.Hour22 ?? false,
            FishAvailabilityHours23 = apiFish.AvailabilityHours.Hour23 ?? false,
        };

        try
        {
            EntityEntry<Fish> createdFish = await _acnhDbContext.AddAsync(dbFish);
            await _acnhDbContext.SaveChangesAsync();
            return Ok(createdFish.Entity.FishId);
        }
        catch (Exception ex)
        {
            return StatusCode(424, "Something went wrong when trying to add to the database.");
        }
    }

    [HttpPut("UpdateFish")]
    public async Task<HttpStatusCode> UpdateFish(UpdateFishModel apiFish)
    {
        Fish? existingFish = await _acnhDbContext.Fishes.FirstOrDefaultAsync((f) => f.FishId == apiFish.FishId);

        if (existingFish == null)
        {
            return HttpStatusCode.NotFound;
        }

        existingFish.FishName = apiFish.FishName ?? existingFish.FishName;
        existingFish.FishImageUri = apiFish.FishImageUri ?? existingFish.FishImageUri;
        existingFish.FishLocation = apiFish.FishLocation ?? existingFish.FishLocation;
        existingFish.FishAvailabilityMonth01 = apiFish.AvailabilityMonths?.Month01 ?? existingFish.FishAvailabilityMonth01;
        existingFish.FishAvailabilityMonth02 = apiFish.AvailabilityMonths?.Month02 ?? existingFish.FishAvailabilityMonth02;
        existingFish.FishAvailabilityMonth03 = apiFish.AvailabilityMonths?.Month03 ?? existingFish.FishAvailabilityMonth03;
        existingFish.FishAvailabilityMonth04 = apiFish.AvailabilityMonths?.Month04 ?? existingFish.FishAvailabilityMonth04;
        existingFish.FishAvailabilityMonth05 = apiFish.AvailabilityMonths?.Month05 ?? existingFish.FishAvailabilityMonth05;
        existingFish.FishAvailabilityMonth06 = apiFish.AvailabilityMonths?.Month06 ?? existingFish.FishAvailabilityMonth06;
        existingFish.FishAvailabilityMonth07 = apiFish.AvailabilityMonths?.Month07 ?? existingFish.FishAvailabilityMonth07;
        existingFish.FishAvailabilityMonth08 = apiFish.AvailabilityMonths?.Month08 ?? existingFish.FishAvailabilityMonth08;
        existingFish.FishAvailabilityMonth09 = apiFish.AvailabilityMonths?.Month09 ?? existingFish.FishAvailabilityMonth09;
        existingFish.FishAvailabilityMonth10 = apiFish.AvailabilityMonths?.Month10 ?? existingFish.FishAvailabilityMonth10;
        existingFish.FishAvailabilityMonth11 = apiFish.AvailabilityMonths?.Month11 ?? existingFish.FishAvailabilityMonth11;
        existingFish.FishAvailabilityMonth12 = apiFish.AvailabilityMonths?.Month12 ?? existingFish.FishAvailabilityMonth12;
        existingFish.FishAvailabilityHours00 = apiFish.AvailabilityHours?.Hour00 ?? existingFish.FishAvailabilityHours00;
        existingFish.FishAvailabilityHours01 = apiFish.AvailabilityHours?.Hour01 ?? existingFish.FishAvailabilityHours01;
        existingFish.FishAvailabilityHours02 = apiFish.AvailabilityHours?.Hour02 ?? existingFish.FishAvailabilityHours02;
        existingFish.FishAvailabilityHours03 = apiFish.AvailabilityHours?.Hour03 ?? existingFish.FishAvailabilityHours03;
        existingFish.FishAvailabilityHours04 = apiFish.AvailabilityHours?.Hour04 ?? existingFish.FishAvailabilityHours04;
        existingFish.FishAvailabilityHours05 = apiFish.AvailabilityHours?.Hour05 ?? existingFish.FishAvailabilityHours05;
        existingFish.FishAvailabilityHours06 = apiFish.AvailabilityHours?.Hour06 ?? existingFish.FishAvailabilityHours06;
        existingFish.FishAvailabilityHours07 = apiFish.AvailabilityHours?.Hour07 ?? existingFish.FishAvailabilityHours07;
        existingFish.FishAvailabilityHours08 = apiFish.AvailabilityHours?.Hour08 ?? existingFish.FishAvailabilityHours08;
        existingFish.FishAvailabilityHours09 = apiFish.AvailabilityHours?.Hour09 ?? existingFish.FishAvailabilityHours09;
        existingFish.FishAvailabilityHours10 = apiFish.AvailabilityHours?.Hour10 ?? existingFish.FishAvailabilityHours10;
        existingFish.FishAvailabilityHours11 = apiFish.AvailabilityHours?.Hour11 ?? existingFish.FishAvailabilityHours11;
        existingFish.FishAvailabilityHours12 = apiFish.AvailabilityHours?.Hour12 ?? existingFish.FishAvailabilityHours12;
        existingFish.FishAvailabilityHours13 = apiFish.AvailabilityHours?.Hour13 ?? existingFish.FishAvailabilityHours13;
        existingFish.FishAvailabilityHours14 = apiFish.AvailabilityHours?.Hour14 ?? existingFish.FishAvailabilityHours14;
        existingFish.FishAvailabilityHours15 = apiFish.AvailabilityHours?.Hour15 ?? existingFish.FishAvailabilityHours15;
        existingFish.FishAvailabilityHours16 = apiFish.AvailabilityHours?.Hour16 ?? existingFish.FishAvailabilityHours16;
        existingFish.FishAvailabilityHours17 = apiFish.AvailabilityHours?.Hour17 ?? existingFish.FishAvailabilityHours17;
        existingFish.FishAvailabilityHours18 = apiFish.AvailabilityHours?.Hour18 ?? existingFish.FishAvailabilityHours18;
        existingFish.FishAvailabilityHours19 = apiFish.AvailabilityHours?.Hour19 ?? existingFish.FishAvailabilityHours19;
        existingFish.FishAvailabilityHours20 = apiFish.AvailabilityHours?.Hour20 ?? existingFish.FishAvailabilityHours20;
        existingFish.FishAvailabilityHours21 = apiFish.AvailabilityHours?.Hour21 ?? existingFish.FishAvailabilityHours21;
        existingFish.FishAvailabilityHours22 = apiFish.AvailabilityHours?.Hour22 ?? existingFish.FishAvailabilityHours22;
        existingFish.FishAvailabilityHours23 = apiFish.AvailabilityHours?.Hour23 ?? existingFish.FishAvailabilityHours23;

        await _acnhDbContext.SaveChangesAsync();
        return HttpStatusCode.OK;
    }

    [HttpDelete("DeleteFish")]
    public async Task<HttpStatusCode> DeleteFish(string fishId)
    {
        Fish? existingFish = await _acnhDbContext.Fishes.FirstOrDefaultAsync((f) => f.FishId == fishId);

        if (existingFish is null)
        {
            return HttpStatusCode.BadRequest;
        }

        _acnhDbContext.Fishes.Remove(existingFish);
        await _acnhDbContext.SaveChangesAsync();

        return HttpStatusCode.NoContent;
    }
}


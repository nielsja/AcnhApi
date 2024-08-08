using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AcnhApi.DataAccessors.Entities;

public class User
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string? UserId { get; set; }
    public string UserName { get; set; }
    public string UserPassword { get; set; }
    public string UserEmail { get; set; }

    // Collected Shit
    public ICollection<Fish>? Fish { get; set; }
}


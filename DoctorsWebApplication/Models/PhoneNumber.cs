﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DoctorsWebApplication.Models;

[Table("PhoneNumber")]
public partial class PhoneNumber
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int PhoneNumberId { get; set; }

    [Required]
    [Column("PhoneNumber")]
    [StringLength(50)]
    public string PhoneNumber1 { get; set; }

    public int PersonId { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public Guid rowguid { get; set; }

    [Column(TypeName = "datetime")]
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime ModifiedDate { get; set; }

    [StringLength(256)]
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public string ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime CreateDate { get; set; }

    [StringLength(256)]
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public string CreatedBy { get; set; }

    [ForeignKey("PersonId")]
    [InverseProperty("PhoneNumbers")]
    public virtual Person Person { get; set; }
}
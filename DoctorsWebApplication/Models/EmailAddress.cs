﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DoctorsWebApplication.Models;

[Table("EmailAddress")]
public partial class EmailAddress
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int EmailAddressId { get; set; }

    [Required]
    [Column("EmailAddress")]
    [StringLength(250)]
    public string EmailAddress1 { get; set; }

    [Required]
    public int PersonId { get; set; }

    [Column(TypeName = "datetime")]
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime ModifiedDate { get; set; }

    [StringLength(256)]
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public string ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime CreatedDate { get; set; }

    [StringLength(256)]
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public string CreatedBy { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public Guid rowguid { get; set; }

    [ForeignKey("PersonId")]
    [InverseProperty("EmailAddresses")]
    public virtual Person Person { get; set; }
}
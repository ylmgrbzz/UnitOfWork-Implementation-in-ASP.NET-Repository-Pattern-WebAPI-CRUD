﻿namespace Unitofwork.Models;

public partial class TblOrgin
{
    public int Id { get; set; }

    public string OrginName { get; set; } = null!;

    public bool IsActive { get; set; }
}
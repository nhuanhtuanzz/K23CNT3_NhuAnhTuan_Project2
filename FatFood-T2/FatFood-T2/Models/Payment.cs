﻿using System;
using System.Collections.Generic;

namespace FatFood_T2.Models;

public partial class Payment
{
    public int PaymentId { get; set; }

    public int OrderId { get; set; }

    public string Method { get; set; } = null!;

    public decimal Amount { get; set; }

    public string? Status { get; set; }

    public DateTime? PaidAt { get; set; }

    public virtual Order Order { get; set; } = null!;
}

﻿namespace SmartphonePortal_Vervoort_Wagner.Shared.ViewModels;

public class ProcessorViewModel
{
    public int ProcessorId { get; set; }
    public string Gigaherz { get; set; } = string.Empty;
    public int CoreCount { get; set; }
    public string Title { get; set; } = string.Empty;
}

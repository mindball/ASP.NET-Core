﻿namespace CarDealer.Web.Services.DTO.Car
{
    using CarDealer.Web.Services.DTO.Part;
    using System.Collections.Generic;

    public class CarWithParts : FullDetailCarSericeModel
    {
        public IEnumerable<PartInfo> Parts { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace YoungMomsAssistant.Core.Models.DtoModels {
    public class BabyGrowthDto {
        public int Id { get; set; }

        public int BabyId { get; set; }

        public DateTime Date { get; set; }

        public double Growth { get; set; }
    }
}

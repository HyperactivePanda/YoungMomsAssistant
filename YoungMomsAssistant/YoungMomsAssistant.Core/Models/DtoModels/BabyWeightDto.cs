﻿using System;
using System.Collections.Generic;
using System.Text;

namespace YoungMomsAssistant.Core.Models.DtoModels {
    public class BabyWeightDto {
        public int Id { get; set; }

        public int BabyId { get; set; }

        public DateTime Date { get; set; }

        public double Weight { get; set; }
    }
}

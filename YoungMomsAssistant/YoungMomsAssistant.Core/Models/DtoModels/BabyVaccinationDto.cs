﻿using System;
using System.Collections.Generic;
using System.Text;

namespace YoungMomsAssistant.Core.Models.DtoModels {
    public class BabyVaccinationDto {
        public int Id { get; set; }

        public int BabyId { get; set; }

        public string Name { get; set; }

        public DateTime Date { get; set; }
    }
}

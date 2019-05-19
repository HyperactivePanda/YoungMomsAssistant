﻿using System;

namespace YoungMomsAssistant.Core.Models.DtoModels {
    public class BabyDto {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDay { get; set; }

        public string Sex { get; set; }

        public string BloodType { get; set; }

        public bool IsImageChanged { get; set; }

        public byte[] Image { get; set; }
    }
}

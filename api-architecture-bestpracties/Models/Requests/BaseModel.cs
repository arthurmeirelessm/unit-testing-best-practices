﻿using Newtonsoft.Json;
using System;

namespace api_architecture_bestpracties.Models
{
    public class BaseModel
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}

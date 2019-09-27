﻿using System.Collections.Generic;
using Newtonsoft.Json;
using PlateformeAlloTabib.Standards.Domain;

namespace Plateforme.AlloTabib.DomainLayer.Models.Base
{
    public class ResponseEnvelope<T> : ResultOfType<T>
    {
        [JsonProperty("data")]
        public T Data { get; set; }

        [JsonProperty("errors")]
        public List<ErrorBase> Errors { get; set; }

        [JsonProperty("statusDetail")]
        public EStatusDetail StatusDetail { get; set; }

        [JsonProperty("status")]
        public EResultStatus Status { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}

﻿using System.Collections.Generic;
using MigrationTools.Enrichers;
using Newtonsoft.Json;

namespace MigrationTools._EngineV1.Configuration
{
    public interface IProcessorConfig
    {
        /// <summary>
        /// Active the processor if it true.
        /// </summary>
        [JsonProperty(Order = -200)]
        bool Enabled { get; set; }

        [JsonIgnore]
        string Processor { get; }
        List<IProcessorEnricher> Enrichers { get; set; }

        /// <summary>
        /// Indicates, if this processor can be added to the list of current processors or not.
        /// Some processors are not compatible with each other.
        /// </summary>
        /// <param name="otherProcessors">List of already configured processors.</param>
        bool IsProcessorCompatible(IReadOnlyList<IProcessorConfig> otherProcessors);
    }
}
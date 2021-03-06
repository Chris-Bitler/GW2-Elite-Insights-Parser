﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace LuckParser.Models.HtmlModels
{
    [DataContract]
    public class PlayerDetailsDto
    {
        [DataMember(EmitDefaultValue = false)] public List<DmgDistributionDto> dmgDistributions;
        [DataMember(EmitDefaultValue = false)] public List<DmgDistributionDto> dmgDistributionsBoss;
        [DataMember(EmitDefaultValue = false)] public List<DmgDistributionDto> dmgDistributionsTaken;
        [DataMember(EmitDefaultValue = false)] public List<List<double[]>> rotation;
        [DataMember(EmitDefaultValue = false)] public List<List<BoonChartDataDto>> boonGraph;
        [DataMember(EmitDefaultValue = false)] public List<List<FoodDto>> food;
        [DataMember(EmitDefaultValue = false)] public List<PlayerDetailsDto> minions;
    }
}

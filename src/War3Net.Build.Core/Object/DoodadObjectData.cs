﻿// ------------------------------------------------------------------------------
// <copyright file="DoodadObjectData.cs" company="Drake53">
// Licensed under the MIT license.
// See the LICENSE file in the project root for more information.
// </copyright>
// ------------------------------------------------------------------------------

using System.Collections.Generic;

namespace War3Net.Build.Object
{
    public sealed partial class DoodadObjectData
    {
        public const string FileExtension = ".w3d";
        public const string CampaignFileName = "war3campaign.w3d";
        public const string CampaignSkinFileName = "war3campaignSkin.w3d";
        public const string MapFileName = "war3map.w3d";
        public const string MapSkinFileName = "war3mapSkin.w3d";

        /// <summary>
        /// Initializes a new instance of the <see cref="DoodadObjectData"/> class.
        /// </summary>
        /// <param name="formatVersion"></param>
        public DoodadObjectData(ObjectDataFormatVersion formatVersion)
        {
            FormatVersion = formatVersion;
        }

        public ObjectDataFormatVersion FormatVersion { get; set; }

        public List<VariationObjectModification> BaseDoodads { get; init; } = new();

        public List<VariationObjectModification> NewDoodads { get; init; } = new();

        public override string ToString() => $"{FileExtension} file";
    }
}
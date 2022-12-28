﻿// ------------------------------------------------------------------------------
// <copyright file="CampaignDoodadObjectData.cs" company="Drake53">
// Licensed under the MIT license.
// See the LICENSE file in the project root for more information.
// </copyright>
// ------------------------------------------------------------------------------

using System.IO;

namespace War3Net.Build.Object
{
    public sealed partial class CampaignDoodadObjectData : DoodadObjectData
    {
        internal CampaignDoodadObjectData(BinaryReader reader)
            : base(reader)
        {
        }
    }
}
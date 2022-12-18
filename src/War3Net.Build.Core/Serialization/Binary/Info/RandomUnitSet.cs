﻿// ------------------------------------------------------------------------------
// <copyright file="RandomUnitSet.cs" company="Drake53">
// Licensed under the MIT license.
// See the LICENSE file in the project root for more information.
// </copyright>
// ------------------------------------------------------------------------------

using System.IO;

namespace War3Net.Build.Info
{
    public sealed partial class RandomUnitSet
    {
        internal void ReadFrom(BinaryReader reader, MapInfoFormatVersion formatVersion)
        {
            Chance = reader.ReadInt32();
            for (nint i = 0; i < UnitIds.Length; i++)
            {
                UnitIds[i] = reader.ReadInt32();
            }
        }

        internal void WriteTo(BinaryWriter writer, MapInfoFormatVersion formatVersion)
        {
            writer.Write(Chance);
            for (nint i = 0; i < UnitIds.Length; i++)
            {
                writer.Write(UnitIds[i]);
            }
        }
    }
}
﻿// ------------------------------------------------------------------------------
// <copyright file="MapInfo.cs" company="Drake53">
// Licensed under the MIT license.
// See the LICENSE file in the project root for more information.
// </copyright>
// ------------------------------------------------------------------------------

using System;
using System.Text.Json;

using War3Net.Build.Extensions;

namespace War3Net.Build.Info
{
    public sealed partial class MapInfo
    {
        internal void ReadFrom(Utf8JsonReader reader)
        {
            throw new NotImplementedException();
        }

        internal void WriteTo(Utf8JsonWriter writer)
        {
            writer.WriteNumber(nameof(FormatVersion), (int)FormatVersion);

            if (FormatVersion >= MapInfoFormatVersion.RoC)
            {
                writer.WriteNumber(nameof(MapVersion), MapVersion);
                writer.WriteNumber(nameof(EditorVersion), (int)EditorVersion);

                if (FormatVersion >= MapInfoFormatVersion.v27)
                {
                    writer.WriteObject(nameof(GameVersion), GameVersion);
                }
            }

            writer.WriteString(nameof(MapName), MapName);
            writer.WriteString(nameof(MapAuthor), MapAuthor);
            writer.WriteString(nameof(MapDescription), MapDescription);
            writer.WriteString(nameof(RecommendedPlayers), RecommendedPlayers);

            if (FormatVersion == MapInfoFormatVersion.v8)
            {
                writer.WriteNumber(nameof(Unk1), Unk1);
                writer.WriteNumber(nameof(Unk2), Unk2);
                writer.WriteNumber(nameof(Unk3), Unk3);
                writer.WriteNumber(nameof(Unk4), Unk4);
                writer.WriteNumber(nameof(Unk5), Unk5);
                writer.WriteNumber(nameof(Unk6), Unk6);
            }

            writer.Write(nameof(CameraBounds), CameraBounds);
            if (FormatVersion >= MapInfoFormatVersion.v15)
            {
                writer.Write(nameof(CameraBoundsComplements), CameraBoundsComplements);
            }

            writer.WriteNumber(nameof(PlayableMapAreaWidth), PlayableMapAreaWidth);
            writer.WriteNumber(nameof(PlayableMapAreaHeight), PlayableMapAreaHeight);

            if (FormatVersion == MapInfoFormatVersion.v8)
            {
                writer.WriteNumber(nameof(Unk7), Unk7);
            }

            writer.WriteNumber(nameof(MapFlags), (int)MapFlags);
            writer.WriteNumber(nameof(Tileset), (byte)Tileset);

            if (FormatVersion >= MapInfoFormatVersion.v23)
            {
                writer.WriteNumber(nameof(LoadingScreenBackgroundNumber), LoadingScreenBackgroundNumber);
                writer.WriteString(nameof(LoadingScreenPath), LoadingScreenPath);
            }
            else if (FormatVersion >= MapInfoFormatVersion.RoC)
            {
                writer.WriteNumber(nameof(CampaignBackgroundNumber), CampaignBackgroundNumber);
            }
            else if (FormatVersion >= MapInfoFormatVersion.v15)
            {
                writer.WriteString(nameof(LoadingScreenPath), LoadingScreenPath);
            }

            if (FormatVersion >= MapInfoFormatVersion.v10)
            {
                writer.WriteString(nameof(LoadingScreenText), LoadingScreenText);
                writer.WriteString(nameof(LoadingScreenTitle), LoadingScreenTitle);
                if (FormatVersion >= MapInfoFormatVersion.v15)
                {
                    writer.WriteString(nameof(LoadingScreenSubtitle), LoadingScreenSubtitle);
                }

                if (FormatVersion >= MapInfoFormatVersion.v23)
                {
                    writer.WriteNumber(nameof(GameDataSet), (int)GameDataSet);
                    writer.WriteString(nameof(PrologueScreenPath), PrologueScreenPath);
                }
                else if (FormatVersion >= MapInfoFormatVersion.RoC)
                {
                    writer.WriteNumber(nameof(LoadingScreenNumber), LoadingScreenNumber);
                }
                else if (FormatVersion >= MapInfoFormatVersion.v15)
                {
                    writer.WriteString(nameof(PrologueScreenPath), PrologueScreenPath);
                }

                if (FormatVersion >= MapInfoFormatVersion.v11)
                {
                    writer.WriteString(nameof(PrologueScreenText), PrologueScreenText);
                    writer.WriteString(nameof(PrologueScreenTitle), PrologueScreenTitle);
                    if (FormatVersion >= MapInfoFormatVersion.v15)
                    {
                        writer.WriteString(nameof(PrologueScreenSubtitle), PrologueScreenSubtitle);
                    }
                }

                if (FormatVersion >= MapInfoFormatVersion.v23)
                {
                    writer.WriteNumber(nameof(FogStyle), (int)FogStyle);
                    writer.WriteNumber(nameof(FogStartZ), FogStartZ);
                    writer.WriteNumber(nameof(FogEndZ), FogEndZ);
                    writer.WriteNumber(nameof(FogDensity), FogDensity);
                    writer.Write(nameof(FogColor), FogColor);

                    if (FormatVersion >= MapInfoFormatVersion.Tft)
                    {
                        writer.WriteNumber(nameof(GlobalWeather), (int)GlobalWeather);
                    }

                    writer.WriteString(nameof(SoundEnvironment), SoundEnvironment);
                    writer.WriteNumber(nameof(LightEnvironment), (byte)LightEnvironment);

                    writer.Write(nameof(WaterTintingColor), WaterTintingColor);
                }

                if (FormatVersion >= MapInfoFormatVersion.Lua)
                {
                    writer.WriteNumber(nameof(ScriptLanguage), (int)ScriptLanguage);
                }

                if (FormatVersion >= MapInfoFormatVersion.Reforged)
                {
                    writer.WriteNumber(nameof(SupportedModes), (int)SupportedModes);
                    writer.WriteNumber(nameof(GameDataVersion), (int)GameDataVersion);
                }
            }

            writer.WriteStartArray(nameof(Players));
            foreach (var player in Players)
            {
                writer.Write(player, FormatVersion);
            }

            writer.WriteEndArray();

            writer.WriteStartArray(nameof(Forces));
            foreach (var force in Forces)
            {
                writer.Write(force, FormatVersion);
            }

            writer.WriteEndArray();

            writer.WriteStartArray(nameof(UpgradeData));
            foreach (var upgrade in UpgradeData)
            {
                writer.Write(upgrade, FormatVersion);
            }

            writer.WriteEndArray();

            writer.WriteStartArray(nameof(TechData));
            foreach (var tech in TechData)
            {
                writer.Write(tech, FormatVersion);
            }

            writer.WriteEndArray();

            if (FormatVersion >= MapInfoFormatVersion.v15)
            {
                if (RandomUnitTables is null)
                {
                    writer.WriteNull(nameof(RandomUnitTables));
                }
                else
                {
                    writer.WriteStartArray(nameof(RandomUnitTables));
                    foreach (var unitTable in RandomUnitTables)
                    {
                        writer.Write(unitTable, FormatVersion);
                    }

                    writer.WriteEndArray();
                }
            }

            if (FormatVersion >= MapInfoFormatVersion.v24)
            {
                if (RandomItemTables is null)
                {
                    writer.WriteNull(nameof(RandomItemTables));
                }
                else
                {
                    writer.WriteStartArray(nameof(RandomItemTables));
                    foreach (var itemTable in RandomItemTables)
                    {
                        writer.Write(itemTable, FormatVersion);
                    }

                    writer.WriteEndArray();
                }
            }
        }
    }
}
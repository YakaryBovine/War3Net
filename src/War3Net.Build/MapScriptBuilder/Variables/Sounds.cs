﻿// ------------------------------------------------------------------------------
// <copyright file="Sounds.cs" company="Drake53">
// Licensed under the MIT license.
// See the LICENSE file in the project root for more information.
// </copyright>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

using War3Net.CodeAnalysis.Jass.Syntax;

using SyntaxFactory = War3Net.CodeAnalysis.Jass.JassSyntaxFactory;

namespace War3Net.Build
{
    public partial class MapScriptBuilder
    {
        protected virtual IEnumerable<JassGlobalDeclarationSyntax> Sounds(Map map)
        {
            if (map is null)
            {
                throw new ArgumentNullException(nameof(map));
            }

            var mapSounds = map.Sounds;
            if (mapSounds is null)
            {
                yield break;
            }

            foreach (var sound in mapSounds.Sounds)
            {
                yield return SyntaxFactory.GlobalDeclaration(
                    SyntaxFactory.ParseTypeName(nameof(sound)),
                    sound.Name,
                    JassNullLiteralExpressionSyntax.Value);
            }
        }
    }
}
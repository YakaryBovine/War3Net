﻿// ------------------------------------------------------------------------------
// <copyright file="NativeFunctionDeclarationTranspiler.cs" company="Drake53">
// Licensed under the MIT license.
// See the LICENSE file in the project root for more information.
// </copyright>
// ------------------------------------------------------------------------------

using System;
using System.Text;

using War3Net.CodeAnalysis.Jass.Syntax;

namespace War3Net.CodeAnalysis.Transpilers
{
    public static partial class JassToLuaTranspiler
    {
        [Obsolete]
        public static void Transpile(this NativeFunctionDeclarationSyntax nativeFunctionDeclarationNode, ref StringBuilder sb)
        {
            // _ = nativeFunctionDeclarationNode ?? throw new ArgumentNullException(nameof(nativeFunctionDeclarationNode));

            throw new NotSupportedException();
        }

        public static void TranspileToLua(this NativeFunctionDeclarationSyntax nativeFunctionDeclarationNode)
        {
            // _ = nativeFunctionDeclarationNode ?? throw new ArgumentNullException(nameof(nativeFunctionDeclarationNode));

            throw new NotSupportedException();
        }
    }
}
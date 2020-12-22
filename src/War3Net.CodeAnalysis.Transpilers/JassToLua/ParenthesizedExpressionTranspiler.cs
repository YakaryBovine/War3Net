﻿// ------------------------------------------------------------------------------
// <copyright file="ParenthesizedExpressionTranspiler.cs" company="Drake53">
// Licensed under the MIT license.
// See the LICENSE file in the project root for more information.
// </copyright>
// ------------------------------------------------------------------------------

using System.Diagnostics.CodeAnalysis;

using CSharpLua.LuaAst;

using War3Net.CodeAnalysis.Jass;
using War3Net.CodeAnalysis.Jass.Syntax;

namespace War3Net.CodeAnalysis.Transpilers
{
    public partial class JassToLuaTranspiler
    {
        [return: NotNullIfNotNull("parenthesizedExpression")]
        public LuaExpressionSyntax? Transpile(ParenthesizedExpressionSyntax? parenthesizedExpression, out SyntaxTokenType expressionType)
        {
            if (parenthesizedExpression is null)
            {
                expressionType = SyntaxTokenType.NullKeyword;
                return null;
            }

            return new LuaParenthesizedExpressionSyntax(Transpile(parenthesizedExpression.ExpressionNode, out expressionType));
        }
    }
}
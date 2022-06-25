﻿// ------------------------------------------------------------------------------
// <copyright file="VJassLibraryDeclarationSyntax.cs" company="Drake53">
// Licensed under the MIT license.
// See the LICENSE file in the project root for more information.
// </copyright>
// ------------------------------------------------------------------------------

using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.IO;

using War3Net.CodeAnalysis.VJass.Extensions;

namespace War3Net.CodeAnalysis.VJass.Syntax
{
    public class VJassLibraryDeclarationSyntax : VJassTopLevelDeclarationSyntax
    {
        internal VJassLibraryDeclarationSyntax(
            VJassLibraryDeclaratorSyntax declarator,
            ImmutableArray<VJassScopedDeclarationSyntax> declarations,
            VJassSyntaxToken endLibraryToken)
        {
            Declarator = declarator;
            Declarations = declarations;
            EndLibraryToken = endLibraryToken;
        }

        public VJassLibraryDeclaratorSyntax Declarator { get; }

        public ImmutableArray<VJassScopedDeclarationSyntax> Declarations { get; }

        public VJassSyntaxToken EndLibraryToken { get; }

        public override bool IsEquivalentTo([NotNullWhen(true)] VJassSyntaxNode? other)
        {
            return other is VJassLibraryDeclarationSyntax libraryDeclaration
                && Declarator.IsEquivalentTo(libraryDeclaration.Declarator)
                && Declarations.IsEquivalentTo(libraryDeclaration.Declarations);
        }

        public override void WriteTo(TextWriter writer)
        {
            Declarator.WriteTo(writer);
            Declarations.WriteTo(writer);
            EndLibraryToken.WriteTo(writer);
        }

        public override void ProcessTo(TextWriter writer, VJassPreprocessorContext context)
        {
            Declarator.ProcessTo(writer, context);
            Declarations.ProcessTo(writer, context);
            EndLibraryToken.ProcessTo(writer, context);
        }

        public override string ToString() => $"{Declarator} [...]";

        public override VJassSyntaxToken GetFirstToken() => Declarator.GetFirstToken();

        public override VJassSyntaxToken GetLastToken() => EndLibraryToken;

        protected internal override VJassLibraryDeclarationSyntax ReplaceFirstToken(VJassSyntaxToken newToken)
        {
            return new VJassLibraryDeclarationSyntax(
                Declarator.ReplaceFirstToken(newToken),
                Declarations,
                EndLibraryToken);
        }

        protected internal override VJassLibraryDeclarationSyntax ReplaceLastToken(VJassSyntaxToken newToken)
        {
            return new VJassLibraryDeclarationSyntax(
                Declarator,
                Declarations,
                newToken);
        }
    }
}
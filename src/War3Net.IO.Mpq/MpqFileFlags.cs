﻿// ------------------------------------------------------------------------------
// <copyright file="MpqFileFlags.cs" company="Foole (fooleau@gmail.com)">
// Copyright (c) 2006 Foole (fooleau@gmail.com). All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// ------------------------------------------------------------------------------

using System;

namespace War3Net.IO.Mpq
{
    /// <summary>
    ///
    /// </summary>
    [Flags]
    public enum MpqFileFlags : uint
    {
        /// <summary>
        /// AKA Imploded
        /// </summary>
        CompressedPK = 0x00000100,

        /// <summary>
        ///
        /// </summary>
        CompressedMulti = 0x00000200,

        /// <summary>
        ///
        /// </summary>
        Compressed = 0x0000ff00,

        /// <summary>
        ///
        /// </summary>
        Encrypted = 0x00010000,

        /// <summary>
        /// AKA FixSeed
        /// </summary>
        BlockOffsetAdjustedKey = 0x00020000,

        /// <summary>
        ///
        /// </summary>
        SingleUnit = 0x01000000,

        /// <summary>
        /// Appears in WoW 1.10 or newer. Indicates the file has associated metadata.
        /// </summary>
        FileHasMetadata = 0x04000000,

        /// <summary>
        ///
        /// </summary>
        Exists = 0x80000000,

        /// <summary>
        /// Invalid flags.
        /// </summary>
        Garbage = 0x7AFC00FF,
    }
}
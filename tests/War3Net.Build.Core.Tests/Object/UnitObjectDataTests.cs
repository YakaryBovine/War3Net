﻿// ------------------------------------------------------------------------------
// <copyright file="UnitObjectDataTests.cs" company="Drake53">
// Licensed under the MIT license.
// See the LICENSE file in the project root for more information.
// </copyright>
// ------------------------------------------------------------------------------

using Microsoft.VisualStudio.TestTools.UnitTesting;

using War3Net.Build.Object;

namespace War3Net.Build.Core.Tests.Object
{
    [TestClass]
    public class UnitObjectDataTests
    {
        [DataTestMethod]
        [DynamicData(nameof(TestDataFileProvider.GetUnitObjectDataFilePaths), typeof(TestDataFileProvider), DynamicDataSourceType.Method)]
        public void TestBinarySerialization(string filePath)
        {
            SerializationTestHelper<UnitObjectData>.RunBinaryRWTest(filePath);
        }

        [DataTestMethod]
        [DynamicData(nameof(TestDataFileProvider.GetUnitObjectDataFilePaths), typeof(TestDataFileProvider), DynamicDataSourceType.Method)]
        public void TestJsonSerialization(string filePath)
        {
            SerializationTestHelper<UnitObjectData>.RunJsonRWTest(filePath, false);
        }

        [DataTestMethod]
        [DynamicData(nameof(TestDataFileProvider.GetUnitObjectDataFilePaths), typeof(TestDataFileProvider), DynamicDataSourceType.Method)]
        public void TestJsonSerializationStringEnums(string filePath)
        {
            SerializationTestHelper<UnitObjectData>.RunJsonRWTest(filePath, true);
        }
    }
}
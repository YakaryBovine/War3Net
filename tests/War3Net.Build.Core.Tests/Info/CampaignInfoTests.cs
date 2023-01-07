﻿// ------------------------------------------------------------------------------
// <copyright file="CampaignInfoTests.cs" company="Drake53">
// Licensed under the MIT license.
// See the LICENSE file in the project root for more information.
// </copyright>
// ------------------------------------------------------------------------------

using Microsoft.VisualStudio.TestTools.UnitTesting;

using War3Net.Build.Info;

namespace War3Net.Build.Core.Tests.Info
{
    [TestClass]
    public class CampaignInfoTests
    {
        [DataTestMethod]
        [DynamicData(nameof(TestDataFileProvider.GetCampaignInfoFilePaths), typeof(TestDataFileProvider), DynamicDataSourceType.Method)]
        public void TestBinarySerialization(string filePath)
        {
            SerializationTestHelper<CampaignInfo>.RunBinaryRWTest(filePath);
        }

        [DataTestMethod]
        [DynamicData(nameof(TestDataFileProvider.GetCampaignInfoFilePaths), typeof(TestDataFileProvider), DynamicDataSourceType.Method)]
        public void TestJsonSerialization(string filePath)
        {
            SerializationTestHelper<CampaignInfo>.RunJsonRWTest(filePath, false);
        }

        [DataTestMethod]
        [DynamicData(nameof(TestDataFileProvider.GetCampaignInfoFilePaths), typeof(TestDataFileProvider), DynamicDataSourceType.Method)]
        public void TestJsonSerializationStringEnums(string filePath)
        {
            SerializationTestHelper<CampaignInfo>.RunJsonRWTest(filePath, true);
        }
    }
}
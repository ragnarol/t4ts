﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using T4TS.Tests.Utils;

namespace T4TS.Tests.Fixtures.Options.Default
{
    [TestClass]
    public class DefaultInterfaceNamePrefixTest
    {
        [TestMethod]
        public void DefaultCamelCaseMemberNamesHasExpectedOutput()
        {
            // Expect
            new OutputFor(
                typeof(DefaultInterfaceNamePrefixModel),
                typeof(DefaultInterfaceNamePrefixOverrideModel)
            ).With(new Settings {
                DefaultInterfaceNamePrefix = "InterfacePrefixTest"
            }).ToEqual(ExpectedOutput);
        }

const string ExpectedOutput = @"
/****************************************************************************
  Generated by T4TS.tt - don't make any changes in this file
****************************************************************************/

declare module T4TS {
    /** Generated from T4TS.Tests.Fixtures.Options.Default.DefaultInterfaceNamePrefixModel **/
    export interface InterfacePrefixTestDefaultInterfaceNamePrefixModel {
        SomeProp: string;
    }
    /** Generated from T4TS.Tests.Fixtures.Options.Default.DefaultInterfaceNamePrefixOverrideModel **/
    export interface PrefixOverrideDefaultInterfaceNamePrefixOverrideModel {
        OverrideName: string;
    }
}
";
    }
}

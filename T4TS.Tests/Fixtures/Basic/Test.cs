﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using T4TS.Tests.Utils;

namespace T4TS.Tests.Fixtures.Basic
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void InheritanceModelHasExpectedOutput()
        {
            // Expect
            new OutputFor(
                typeof(BasicModel)
            ).ToEqual(ExpectedOutput);
        }

        const string ExpectedOutput = @"
/****************************************************************************
  Generated by T4TS.tt - don't make any changes in this file
****************************************************************************/

declare module T4TS {
    /** Generated from T4TS.Tests.Fixtures.Basic.BasicModel **/
    export interface BasicModel {
        MyProperty: number;
    }
}
";
    }
}

﻿using Verify;
using Xunit;

[GlobalSetUp]
public static class GlobalSetup
{
    public static void Setup()
    {
        #region Enable
        VerifyWinForms.Enable();
        #endregion
    }
}
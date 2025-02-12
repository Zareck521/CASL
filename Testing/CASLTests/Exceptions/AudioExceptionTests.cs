﻿// <copyright file="AudioExceptionTests.cs" company="KinsonDigital">
// Copyright (c) KinsonDigital. All rights reserved.
// </copyright>

namespace CASLTests.Exceptions;

using System;
using CASL.Exceptions;
using Xunit;

/// <summary>
/// Tests the <see cref="AudioException"/> class.
/// </summary>
public class AudioExceptionTests
{
    #region Constructor Tests
    [Fact]
    public void Ctor_WhenInvokedWithNoParam_CorrectlySetsMessage()
    {
        // Act
        var exception = new AudioException();

        // Assert
        Assert.Equal("An audio exception has occurred.", exception.Message);
    }

    [Fact]
    public void Ctor_WhenInvokedWithSingleMessageParam_CorrectlySetsMesage()
    {
        // Act
        var exception = new AudioException("test-message");

        // Assert
        Assert.Equal("test-message", exception.Message);
    }

    [Fact]
    public void Ctor_WhenInvokedWithMessageAndInnerException_ThrowsException()
    {
        // Arrange
        var innerException = new Exception("inner-exception");

        // Act
        var deviceException = new AudioException("test-exception", innerException);

        // Assert
        Assert.Equal("inner-exception", deviceException.InnerException.Message);
        Assert.Equal("test-exception", deviceException.Message);
    }
    #endregion
}

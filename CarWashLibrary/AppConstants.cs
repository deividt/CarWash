// ----------------------------------------------------------------------
// <copyright file="AppConstants.cs" company="Deividt Gemeli">
// Copyright (c) Deividt Gemeli.
// </copyright>
// ----------------------------------------------------------------------

namespace CarWashLibrary
{
    using System;

    /// <summary>
    /// Classe <see cref="AppConstants" />
    /// </summary>
    public class AppConstants
    {
        #region AWS
        /// <summary>
        /// Obtém Identity Pool Id
        /// </summary>
        public static string CognitoIdentityPoolId { get => Environment.GetEnvironmentVariable("COGNITO_IDENTITY_POOL_ID") ?? string.Empty; }
        #endregion

        #region Syncfusion
        /// <summary>
        /// Obtém SyncfusionLicense
        /// </summary>
        public static string SyncfusionLicense { get => Environment.GetEnvironmentVariable("SYNCFUSION_LICENSE") ?? string.Empty; }
        #endregion
    }
}
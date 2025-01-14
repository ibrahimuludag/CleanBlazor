﻿// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityModel;
using IdentityServer4.Models;
using System.Collections.Generic;

namespace Idp
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> IdentityResources =>
            new IdentityResource[]
            {
                new IdentityResources.OpenId(),
                new ProfileWithRoleIdentityResource(),
                new IdentityResources.Email(),
                new IdentityResources.Phone()
            };

        public static IEnumerable<ApiScope> ApiScopes =>
            new ApiScope[]
            {
                new ApiScope("rapidblazor.api", "RapidBlazor API")
            };

        public static IEnumerable<ApiResource> ApiResources =>
            new ApiResource[]
            {
                new ApiResource("rapidblazor.api.resource" , "Rapid Blazor API Resouces")
                {
                    Scopes = {"rapidblazor.api" },
                    UserClaims = { JwtClaimTypes.Role,JwtClaimTypes.GivenName, JwtClaimTypes.FamilyName, JwtClaimTypes.Email, JwtClaimTypes.PhoneNumber }
                }
            };

        public static IEnumerable<Client> Clients =>
            new Client[]
            {
                new Client
                {
                    ClientId = "rapidblazor.webui.client",
                    ClientName = "Rapid Blazor WebUI Client",
                    AllowedGrantTypes = GrantTypes.Code,
                    RequireClientSecret = false,
                    RequirePkce = true,
                    RedirectUris = { "https://localhost:5503/authentication/login-callback" },
                    PostLogoutRedirectUris = { "https://localhost:5503/authentication/logout-callback" },
                    AllowedScopes = { "openid", "profile", "email" , "rapidblazor.api" },
                    AllowedCorsOrigins = { "https://localhost:5503" },
                    RequireConsent = false,
                    Enabled = true
                }
            };
    }
}
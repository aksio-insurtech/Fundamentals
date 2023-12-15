// Copyright (c) Aksio Insurtech. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Text.Json;
using Aksio.Strings;

namespace Aksio.Serialization;

public class AcronymFriendlyJsonCamelCaseNamingPolicy:  JsonNamingPolicy
{
    public static readonly JsonNamingPolicy Instance = new AcronymFriendlyJsonCamelCaseNamingPolicy();
    /// <inheritdoc/>
    public override string ConvertName(string name) => name.ToCamelCase();
}
// Copyright (c) Aksio Insurtech. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Aksio.Conversion;

/// <summary>
/// Represents a <see cref="StringTypeConverterBase{T}"/> for <see cref="DateOnly"/>.
/// </summary>
public class TimeOnlyTypeConverter : StringTypeConverterBase<TimeOnly>
{
    /// <inheritdoc/>
    public override TimeOnly Parse(string source) => TimeOnly.Parse(source);

    /// <inheritdoc/>
    public override string ToString(TimeOnly source) => source.ToString("O");
}

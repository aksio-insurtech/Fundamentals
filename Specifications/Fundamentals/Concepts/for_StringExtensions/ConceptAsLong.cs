// Copyright (c) Aksio Insurtech. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Aksio.Concepts.for_StringExtensions;

public record ConceptAsLong(long Value) : ConceptAs<long>(Value)
{
    public static implicit operator ConceptAsLong(long value) => new(value);
}

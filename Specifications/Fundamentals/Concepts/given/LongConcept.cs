// Copyright (c) Aksio Insurtech. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Aksio.Concepts.given;

public record LongConcept(long Value) : ConceptAs<long>(Value)
{
    public static implicit operator LongConcept(long value) => new(value);
}

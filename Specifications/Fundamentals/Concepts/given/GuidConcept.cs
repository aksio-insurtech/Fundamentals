// Copyright (c) Aksio Insurtech. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Aksio.Concepts.given;

public record GuidConcept(Guid Value) : ConceptAs<Guid>(Value)
{
    public static implicit operator GuidConcept(Guid value) => new(value);
}

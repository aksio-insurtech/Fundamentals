// Copyright (c) Aksio Insurtech. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Aksio.Concepts.for_ConceptFactory;

public record DecimalConcept(decimal Value) : ConceptAs<decimal>(Value);

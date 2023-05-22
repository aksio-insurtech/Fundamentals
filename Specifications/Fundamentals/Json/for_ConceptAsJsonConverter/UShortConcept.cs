// Copyright (c) Aksio Insurtech. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Aksio.Concepts;

namespace Aksio.Json.for_ConceptAsJsonConverter;

public record UShortConcept(ushort Value) : ConceptAs<ushort>(Value);

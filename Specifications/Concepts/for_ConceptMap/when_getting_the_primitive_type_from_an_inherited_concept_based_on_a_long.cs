// Copyright (c) Aksio Insurtech. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Aksio.Concepts.given;

namespace Aksio.Concepts.for_ConceptMap;

public class when_getting_the_primitive_type_from_an_inherited_concept_based_on_a_long : Specification
{
    static Type result;

    void Because() => result = ConceptMap.GetConceptValueType(typeof(InheritingFromLongConcept));

    [Fact] void should_get_a_long() => result.ShouldEqual(typeof(long));
}

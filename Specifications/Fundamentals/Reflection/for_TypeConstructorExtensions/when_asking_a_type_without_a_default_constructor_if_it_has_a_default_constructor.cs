// Copyright (c) Aksio Insurtech. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Aksio.Reflection.for_TypeExtensions;

public class when_asking_a_type_without_a_default_constructor_if_it_has_a_default_constructor : Specification
{
    bool result;

    void Because() => result = typeof(TypeWithoutDefaultConstructor).HasDefaultConstructor();

    [Fact] void should_return_false() => result.ShouldBeFalse();
}

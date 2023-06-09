// Copyright (c) Aksio Insurtech. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Aksio.Collections.for_CollectionExtensions;

public class when_counting_an_array : Specification
{
    int count;

    void Because() => count = new[] { 1, 2, 3 }.CountElements();

    [Fact] void should_have_correct_count() => count.ShouldEqual(3);
}

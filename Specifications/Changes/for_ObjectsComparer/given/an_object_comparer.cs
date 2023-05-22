// Copyright (c) Aksio Insurtech. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Aksio.Changes.for_ObjectsComparer.given;

public class an_object_comparer : Specification
{
    protected ObjectsComparer comparer;

    void Establish() => comparer = new();
}

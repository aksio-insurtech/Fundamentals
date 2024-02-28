# [v1.6.3] - 2024-2-28 [PR: #0]()

Debugging publish errro

# [v1.6.2] - 2024-2-28 [PR: #0]()

VerisonBump to test new npm token

# [v1.6.1] - 2023-12-15 [PR: #28](https://github.com/aksio-insurtech/Fundamentals/pull/28)

## Summary

Create a ToCamelCase implementation that is more friendly towards acronyms.  This is a trade-off between determining it is an acronym and ease of use / performance.  There is no register or dictionary of acronyms, instead if the first two characters of the name are upper-case we will not change the name and will just return as is.

A JsonNamingPolicy implementation is created that uses the ToCamelCase extension method.

# [v1.6.0] - 2023-12-11 [PR: #27](https://github.com/aksio-insurtech/Fundamentals/pull/27)

### Added

- Added JSON converter for `Type`.
- Added JSON converter for `Uri`.

# [v1.5.2] - 2023-10-1 [PR: #25](https://github.com/aksio-insurtech/Fundamentals/pull/25)

### Fixed

- Fixing so that the package assembly provider ignores the project referenced assemblies. This was that caused type duplication when used in combination with the `ProjectReferencedAssemblies` in a composition using for instance the `CompositeAssemblyProvider`.


# [v1.5.1] - 2023-8-22 [PR: #24](https://github.com/aksio-insurtech/Fundamentals/pull/24)

### Fixed

- Export `Field` type in JavaScript fundamentals.
- Export `DerivedType` type in JavaScript fundamentals.


# [v1.5.0] - 2023-8-21 [PR: #23](https://github.com/aksio-insurtech/Fundamentals/pull/23)

### Fixed

- Export the `Fields` type in JS. Making it easier to access information about types.


# [v1.4.2] - 2023-8-18 [PR: #22](https://github.com/aksio-insurtech/Fundamentals/pull/22)

### Removed

- Removing unused `CausationId` and `CausedBy` - not bumping minor or major since they're not used for anything.


# [v1.4.1] - 2023-8-16 [PR: #21](https://github.com/aksio-insurtech/Fundamentals/pull/21)

### Removed

- Disregard the `SoftwareVersion` introduced in v1.4.0 - that was a mistake. This removes it again.


# [v1.4.0] - 2023-8-16 [PR: #20](https://github.com/aksio-insurtech/Fundamentals/pull/20)

### Added

- ExecutionContext now holds software version.


# [v1.3.10] - 2023-7-18 [PR: #13](https://github.com/aksio-insurtech/Fundamentals/pull/13)

### Fixed

- Ensure the `ProjectReferencedAssemblies` initialize method does not initialize more than once per process. Any subsequent calls to `Initialize()` will not do anything.


# [v1.3.9] - 2023-7-18 [PR: #12](https://github.com/aksio-insurtech/Fundamentals/pull/12)

### Fixed

- Make sure assemblies in `ProjectReferencedAssemblies` are distinct.
- Make sure we only have distinct types in the `Types`.


# [v1.3.8] - 2023-7-18 [PR: #11](https://github.com/aksio-insurtech/Fundamentals/pull/11)

### Fixed

- Improve performance by explicitly doing `.ToArray()` on expensive LINQ queries for assembly and type discovery.


# [v1.3.7] - 2023-7-18 [PR: #10](https://github.com/aksio-insurtech/Fundamentals/pull/10)

### Fixed

- Adding the entry assembly as the first "project referenced" assembly in the `ProjectReferencedAssemblies` provider. As this is the assembly used to discover other project referenced assemblies, it is only natural to include itself.


# [v1.3.6] - 2023-7-14 [PR: #9](https://github.com/aksio-insurtech/Fundamentals/pull/9)

### Fixed

- Fixed the `Globals.JsonSerializerOptions` property to use the default `DerivedTypes.Instance` when calling `Configure` the first time its used and the `JsonSerializerOptions` hasn't been configured yet. This means that if you want to have a different provider for derived types, you have to make sure you call the `.Configure()` method with your derived types before the options are used by others.


# [v1.3.5] - 2023-7-11 [PR: #8](https://github.com/aksio-insurtech/Fundamentals/pull/8)

### Fixed

- Seeing problems with opt-out of type discovery. Making it only be an opt-in.


# [v1.3.4] - 2023-7-10 [PR: #7](https://github.com/aksio-insurtech/Fundamentals/pull/7)

### Fixed

- Performance and memory usage related to reflection.
- Adding `text/html` as content type when serving SPA root files.


# [v1.3.3] - 2023-6-20 [PR: #6](https://github.com/aksio-insurtech/Fundamentals/pull/6)

### Fixed

- Support for converting `JsonElement` values to desired types.


# [v1.3.2] - 2023-6-20 [PR: #5](https://github.com/aksio-insurtech/Fundamentals/pull/5)

### Fixed

- Support for converting directly from `JsonValue` to a target type in `TypeConversion`.


# [v1.3.1] - 2023-6-15 [PR: #0]()

No release notes

# [v1.3.0] - 2023-6-14 [PR: #4](https://github.com/aksio-insurtech/Fundamentals/pull/4)

### Added

- Static global instances of `Types` and `DerivedTypes` which is recommended to be used to avoid initializing multiple of these. It is recommended to register these with your IoC.


# [v1.2.0] - 2023-6-12 [PR: #3](https://github.com/aksio-insurtech/Fundamentals/pull/3)

### Added

- Added a `CompositeAssemblyProvider` that delegates to a collection of `ICanProvideAssembliesForDiscovery`.


# [v1.1.5] - 2023-6-10 [PR: #0]()

No release notes

# [v1.1.4] - 2023-6-10 [PR: #0]()

No release notes

# [v1.1.3] - 2023-6-10 [PR: #0]()

No release notes

# [v1.1.2] - 2023-6-10 [PR: #0]()

No release notes

# [v1.1.1] - 2023-6-10 [PR: #0]()

No release notes

# [v1.1.0] - 2023-5-30 [PR: #2](https://github.com/aksio-insurtech/Fundamentals/pull/2)

### Added

- Added `IServiceCollection` extension method for adding type discovery. This configures `ITypes`, `IInstancesOf<>` and `IImplementationsOf<>`.


# [v1.0.11] - 2023-5-30 [PR: #1](https://github.com/aksio-insurtech/Fundamentals/pull/1)

### Added

- Added a `DefinedTypes` property for `ICanProvideAssembliesForDiscovery` and implemented for the different providers.



# [v1.0.10] - 2023-5-30 [PR: #0]()

No release notes

# [v1.0.9] - 2023-5-30 [PR: #0]()

No release notes

# [v1.0.8] - 2023-5-30 [PR: #0]()

No release notes

# [v1.0.6] - 2023-5-25 [PR: #0]()

No release notes

# [v1.0.5] - 2023-5-25 [PR: #0]()

No release notes

# [v1.0.4] - 2023-5-25 [PR: #0]()

No release notes

# [v1.0.3] - 2023-5-25 [PR: #0]()

No release notes

# [v1.0.2] - 2023-5-25 [PR: #0]()

No release notes

# [v1.0.1] - 2023-5-23 [PR: #0]()

Bumping versions

# [v1.0.0] - 2023-5-23 [PR: #0]()

Initial release

# [v0.0.11] - 2023-5-22 [PR: #0]()

No release notes

# [v0.0.10] - 2023-5-22 [PR: #0]()

No release notes

# [v0.0.9] - 2023-5-22 [PR: #0]()

No release notes

# [v0.0.8] - 2023-5-22 [PR: #0]()

No release notes

# [v0.0.7] - 2023-5-9 [PR: #0]()

No release notes

# [v0.0.6] - 2023-5-9 [PR: #0]()

No release notes

# [v0.0.5] - 2023-5-7 [PR: #0]()

No release notes

# [v0.0.4] - 2023-5-7 [PR: #0]()

No release notes

# [v0.0.3] - 2023-5-7 [PR: #0]()

No release notes

# [v0.0.2] - 2023-5-6 [PR: #0]()

No release notes

# [v0.0.1] - 2023-5-6 [PR: #0]()

No release notes


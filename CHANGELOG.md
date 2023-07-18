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


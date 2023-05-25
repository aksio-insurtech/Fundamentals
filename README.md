# Fundamentals

## Packages / Deployables

[![Nuget](https://img.shields.io/nuget/v/Aksio.Fundamentals?logo=nuget)](http://nuget.org/packages/aksio.fundamentals)
[![NPM](https://img.shields.io/npm/v/@aksio/fundamentals?label=@aksio/fundamentals&logo=npm)](https://www.npmjs.com/package/@aksio/fundamentals)

## Builds

[![.NET Build](https://github.com/aksio-insurtech/Fundamentals/actions/workflows/dotnet-build.yml/badge.svg)](https://github.com/aksio-insurtech/Fundamentals/actions/workflows/dotnet-build.yml)
[![JavaScript Build](https://github.com/aksio-insurtech/Fundamentals/actions/workflows/javascript-build.yml/badge.svg)](https://github.com/aksio-insurtech/Fundamentals/actions/workflows/javascript-build.yml)


## Description

The Aksio fundamentals holds generic reusable helpers, utilities and tools that aims at solving common problems and help developers be more productive.
Fundamentals offers functionality for .NET and JavaScript environments. It is not a goal to have parity, as the different environments offer different
building blocks.

You should look at it as a convenience layer on top of the existing base environment you're running in.

Read more about how to use it in our documentation.

## Contributing

If you want to jump into building this repository and possibly contributing, please refer to [contributing](./Documentation/contributing/index.md).

### Prerequisites

The following are prerequisites to work with this repository.

* [.NET 6+](https://dotnet.microsoft.com/en-us/).
* [Node 16+](https://nodejs.org/en)
* [Yarn](https://yarnpkg.com)

### Central Package Management

This repository leverages [Central Package Management](https://learn.microsoft.com/en-us/nuget/consume-packages/Central-Package-Management), which
means that all package versions are managed from a file at the root level called [Directory.Packages.props](./Directory.Packages.props).

In addition there are also [Directory.Build.props](https://learn.microsoft.com/en-us/visualstudio/msbuild/customize-by-directory?view=vs-2022#directorybuildprops-and-directorybuildtargets) files for
setting up common settings that are applied cross cuttingly.

### Root package.json

The `package.json` found at the root level defines all the workspaces. It is assumed

All developer dependencies are defined in the top level `package.json`. The reason for this is to be able to provide global scripts
for every package to use for easier maintenance.

The `package.json` found at the top level contains scripts that can then be used in a child project for this to work properly.

In a package, all you need to do is to define the scripts to use the global scripts in the `package.json´ of that project:

```json
{
    "scripts": {
        "prepublish": "yarn g:build",
        "clean": "yarn g:clean",
        "build": "yarn g:build",
        "lint": "yarn g:lint",
        "lint:ci": "yarn g:lint:ci",
        "test": "yarn g:test",
        "ci": "yarn g:ci",
        "up": "yarn g:up"
    }
}
```

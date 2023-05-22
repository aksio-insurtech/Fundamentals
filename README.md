# Fundamentals

[![.NET Build](https://github.com/aksio-insurtech/Fundamentals/actions/workflows/dotnet-build.yml/badge.svg)](https://github.com/aksio-insurtech/Fundamentals/actions/workflows/dotnet-build.yml)
[![JavaScript Build](https://github.com/aksio-insurtech/Fundamentals/actions/workflows/javascript-build.yml/badge.svg)](https://github.com/aksio-insurtech/Fundamentals/actions/workflows/javascript-build.yml)

## Central Package Management

This repository leverages [Central Package Management](https://learn.microsoft.com/en-us/nuget/consume-packages/Central-Package-Management), which
means that all package versions are managed from a file at the root level called [Directory.Packages.props](./Directory.Packages.props).

In addition there are also [Directory.Build.props](https://learn.microsoft.com/en-us/visualstudio/msbuild/customize-by-directory?view=vs-2022#directorybuildprops-and-directorybuildtargets) files for
setting up common settings that are applied cross cuttingly.
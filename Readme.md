# Zen Host
[![Actions Status](https://github.com/WajahatAliAbid/zen-host/workflows/.NET%20Core%20Build/badge.svg?branch=main)](https://github.com/WajahatAliAbid/zen-host/actions) [![Actions Status](https://github.com/WajahatAliAbid/zen-host/workflows/.NET%20Core%20Publish/badge.svg)](https://github.com/WajahatAliAbid/zen-host/actions) [![Current Version](https://img.shields.io/badge/Version-1.0.0-brightgreen?logo=nuget&labelColor=30363D)](./CHANGELOG.md#100---2021-10-07)

# Overview
Base class for projects using Startup pattern

## Installing
You can add the package to your project using dotnet core CLI
```bash
dotnet add package Zen.Host
```
or by package manager console in Visual Studio
```bash
Install-Package Zen.Host
```

## Usage
Use the following steps to configure Zen Host. Please refer to [Changelog](./CHANGELOG.md) for changes between versions.

### 1. Create Startup Class
```csharp
using Zen.Host;

public class Startup : BaseStartup
{
    public override void ConfigureServices(IServiceCollection services, IConfigurationRoot configuration)
    {
    }
}
```

### 2. Create Service Provider from Startup class
```csharp
using Zen.Host;

var services = StartupUtil.From<BaseStartup>();
```
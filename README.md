[![Build Status](https://img.shields.io/endpoint.svg?url=https%3A%2F%2Factions-badge.atrox.dev%2Fcanhorn%2FEventHorizon.Blazor.TypeScript.Interop.Generator%2Fbadge%3Fref%3Dmain&style=for-the-badge)](https://actions-badge.atrox.dev/canhorn/EventHorizon.Blazor.TypeScript.Interop.Generator/goto?ref=main)
[![codecov](https://img.shields.io/codecov/c/github/canhorn/EventHorizon.Blazor.TypeScript.Interop.Generator?style=for-the-badge)](https://codecov.io/gh/canhorn/EventHorizon.Blazor.TypeScript.Interop.Generator) 
[![EventHorizon.Blazor.TypeScript.Interop.Generator](https://img.shields.io/nuget/v/EventHorizon.Blazor.TypeScript.Interop.Generator?style=for-the-badge&label=Nuget)](https://www.nuget.org/packages/EventHorizon.Blazor.TypeScript.Interop.Generator)

[![GitHub](https://img.shields.io/github/license/canhorn/EventHorizon.Blazor.TypeScript.Interop.Generator?style=for-the-badge)](https://github.com/canhorn/EventHorizon.Blazor.TypeScript.Interop.Generator/blob/main/LICENSE)
[![GitHub tag (latest SemVer pre-release)](https://img.shields.io/github/v/tag/canhorn/EventHorizon.Blazor.TypeScript.Interop.Generator?include_prereleases&label=latest%20tag&style=for-the-badge)](https://github.com/canhorn/EventHorizon.Blazor.TypeScript.Interop.Generator/tags)

[![EventHorizon.Blazor.TypeScript.Interop.Generator](https://img.shields.io/nuget/vpre/EventHorizon.Blazor.TypeScript.Interop.Generator?style=for-the-badge&label=Generator)](https://www.nuget.org/packages/EventHorizon.Blazor.TypeScript.Interop.Generator)
[![EventHorizon.Blazor.TypeScript.Interop.Generator.Model](https://img.shields.io/nuget/vpre/EventHorizon.Blazor.TypeScript.Interop.Generator.Model?style=for-the-badge&label=Model)](https://www.nuget.org/packages/EventHorizon.Blazor.TypeScript.Interop.Generator.Model)
[![EventHorizon.Blazor.TypeScript.Interop.Generator.Writers.Project](https://img.shields.io/nuget/vpre/EventHorizon.Blazor.TypeScript.Interop.Generator.Writers.Project?style=for-the-badge&label=Project+Writer)](https://www.nuget.org/packages/EventHorizon.Blazor.TypeScript.Interop.Generator.Writers.Project)

[![EventHorizon.Blazor.TypeScript.Interop.Tool](https://img.shields.io/nuget/vpre/EventHorizon.Blazor.TypeScript.Interop.Tool?style=for-the-badge&label=Tool)](https://www.nuget.org/packages/EventHorizon.Blazor.TypeScript.Interop.Tool)

# About EventHorizon Blazor TypeScript Interop Generator

This project generates a C# Blazor Interop proxy using a TypeScript definition file. 

## Details

The generated project can be used with Blazor WASM to interface with JavaScript from C#, this gives most JavaScript libraries an easy to use interface from C#. 
It uses the JSRuntime to interop directly with the underlying JavaScript from C#, this is done with a custom interop abstraction. 

The interop project can be found in the [canhorn/EventHorizon.Blazor.Interop](https://github.com/canhorn/EventHorizon.Blazor.Interop) repository, it gives the generated code access to a common set of access patterns it then uses to interface with the JavaScript.

## Tech Used

* [.NET Core](https://dotnet.microsoft.com/)
* [TypeScript](https://www.typescriptlang.org/)

## Supported API's Generated

Below is a list of API that will be generated.

API | Details | Example | Support
--- | --- | --- | ---
Constructor | You can use the default constructor of Classes, causes new call in JavaScript. | ```new BabylonJS.Engine()``` | :heavy_check_mark:
Constructor with arguments | Same as Constructor, but can also pass in arguments. | ```new BabylonJS.Engine("canvas-window-id")``` | :heavy_check_mark:
Property | You can get or set properties supplied by the object. | ```var isDisabled = engine.disableManifestCheck``` and ```engine.disableManifestCheck = true``` | :heavy_check_mark:
Property | You can ***set*** properties supplied by created objects. | ```engine.disableManifestCheck = true``` | :heavy_check_mark:
Static Property | You can ***get*** ***Static*** properties of a Class. | ```var isDisabled = Engine.ALPHA_DISABLE``` | :heavy_check_mark:
Method | You can call a ***method*** supplied by an object. | ```var ratio = engine.getScreenAspectRatio()``` | :heavy_check_mark:
Static Method | You can call a ***Static*** ***method*** provided by a Class. | ```engine.DefaultLoadingScreenFactory(canvas)``` | :heavy_check_mark:
Callback Method | You can supply a callback action to a ***method*** supplied by an object. | ```observer.add(() => doSomething())``` | :heavy_check_mark:
Static Callback Method | You can call a ***Static*** ***method*** provided by a Class. | ```Engine.AudioEngineFactory()``` | :heavy_check_mark:
Get Instance Accessor | You can have access to the ***get*** accessor on an object. | ```var check = engine.disableManifestCheck``` | :heavy_check_mark:
Set Instance Accessor | You can use the ***set*** accessor on an objects. | ```engine.onCanvasPointerOutObservable.add(() => doSomething())``` | :heavy_check_mark:
Action Callback | You can run Async based code. | ```meshLoader.OnSuccess(new ActionCallback<Mesh>(mesh => { return Task.CompletedTask; }))``` | :heavy_check_mark:
Action Callback in Literal | You can run Async based code. | ```new HeightMapMesh({ onReady = new ActionCallback<Mesh>(mesh => { return Task.CompletedTask; }) })``` | :heavy_check_mark:

Notes on the framework, it might not have the exact API supplied by a TypeScript definition file, in that it might transform the API into something more general and friendly to C#. I used C# as my main source of inspiration for the generated code.

## Future Planned Work

- [ ] Promise Result Types -> Ability to async/await Promised response typed Methods.

## Example

Checkout /Sample for a BabylonJS working example solution. The solution includes a BabylonJS generated proxy, with a working Blazor WASM site. You can also checkout the website on this repository for deployed website using the generated BabylonJS.

# UnityPhysXPlugin - macOS (Intel x64)
Experimental Unity package to enable access to NVIDIA PhysX SDK 4 from within Unity.  

This fork is specifically set up for building on macOS. All references to CUDA have been commented out.

Tested on Unity 2020.2.0f1, built with Xcode 12.2 on macOS 10.15.

![](https://media2.giphy.com/media/ccjpXXMEhVpYaJsARV/giphy.gif?cid=790b7611be7f642ee71792bcd1e5a256991de528bc76d207&rid=giphy.gif&ct=g)

Prerequisites
---
1. CMake 3.14+ SWIG 4.0+ `brew install cmake`
1. SWIG 4.0+ `brew install swig`
1. A Windows machine/VM with Visual Studio 2017, CMake 3.14+ and SWIG 4.0+

Build Instructions
---
### Build PhysX on macOS

1. Get PhysX 4.1 from GitHub (https://github.com/NVIDIAGameWorks/PhysX)
1. In `<PhysX Dir>/physx/buildtools/presets/public/mac64.xml` make sure `PX_GENERATE_STATIC_LIBRARIES` is set to `True`.
1. Use `generate_projects.sh` to generate your Xcode project. [Additional information](https://gameworksdocs.nvidia.com/PhysX/4.1/documentation/platformreadme/mac/readme_mac.html)
    1. You may have to **remove** `-Werror` and **add** `-Wanon-enum-enum-conversion -Wno-alloca` to the compiler flags in `./physx/source/compiler/cmake/mac/CMakeLists.txt`
1. Build the PhysX project, use the ALL_BUILD scheme in Release.

### Build Native Libraries on macOS

1. Set the `PHYSX_DIR` variable in the CMakeLists.txt in `./NVIDIA.PhysX.Native` to your PhysX root folder. For example `/Users/username/PhysX`.
1. Set your working directory to `./NVIDIA.PhysX.Native` and run `cmake ./ -G Xcode` to generate your Xcode project.
1. Open the Xcode project and set the ALL_BUILD scheme to Release
1. Build the project.
1. The built `NVIDIA.PhysX.Native.dylib` file will be in `./NVIDIA.PhysX.Native/Release`

### Build C# Bindings on Windows

Note: The C# wrapper built using .NET 5.0 on macOS did not work for me. Using Windows to build the wrapper, however, did work. You may be luckier! Give it a try.
1. Copy your local repository over to your Windows partition/machine.
1. Build PhysX (for Release) for Windows following the instructions for nvidia's [plugin repository](https://github.com/NVIDIAGameWorks/UnityPhysXPlugin)
1. Using nvidia's fork as a base, replace the Header, Helpers, and Interface folder from this fork in `./NVIDIA.PhysX.Native/`.
1. Generate and Build the VS2017 solution and collect the `NVIDIA.PhysX.dll` C# library.
1. Back to your macOS machine. Put `NVIDIA.PhysX.dll` in your Unity's plugins directory.

Run
---

Start Unity and open `.\Unity\PhysX` project and try out the sample scenes.

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

Note: cmake does not support C# on macOS. However, SWIG does and this step might work on macOS if done manually.
1. Copy your local repository over to your Windows partition/machine.
1. Build PhysX (for Release) for Windows following the instructions for nvidia's [plugin repository](https://github.com/NVIDIAGameWorks/UnityPhysXPlugin)
1. Using nvidia's fork as a base, replace the Header, Helpers, and Interface folder from this fork in `./NVIDIA.PhysX.Native/`.
1. Generate and Build the VS2017 solution and collect the `NVIDIA.PhysX.dll` C# library.
    1. Alternatively, you can also copy the generated Partial.cs and Wrapper folder to your Unity project.
1. Back to your macOS machine. Put `NVIDIA.PhysX.dll` in your Unity projects's Wrapper (or Plugins) directory.

IL2CPP Support
---

**You can grab the binaries and example project from the `macos-il2cpp` branch**

I've documented the process of getting IL2CPP to work here. It was a long and arduous process because of some antiquated toolchains that were involved.
Again, you will need Windows because cmake does not support c# on macOS.

1. Get this [particular fork of SWIG](https://github.com/LostPolygon/swig/tree/monoaot) and build it.
    1. For macOS/Unix, follow these instructions: http://www.swig.org/svn.html.
    2. For Windows, use these instructions as a guideline: http://www.swig.org/Doc4.0/Windows.html#Windows_swig_exe. However, instead of using mingw-32, set up MSYS2 and use that for building. First build PCRE according to the instructions and then `./autogen.sh`, `./configure` and `make`.
1. Make sure `where swig` (`which swig` for Windows) points to your newly built swig. (Set PATH variable)

### On Windows
1. Store a copy of the previously generated .cs files in Wrapper somewhere. We will need most of it later.
1. Add the `-monoaotcompat` flag to your `CMAKE_SWIG_FLAGS` (`set(CMAKE_SWIG_FLAGS ${CMAKE_SWIG_FLAGS} -namespace NVIDIA.PhysX -nodefaultctor -monoaotcompat)`)
1. Generate and build the VS2017 solution as usual. (It might fail, but the required files should have been generated.) Store the resulting Wrapper folder seperately and copy it over to your macOS partition.

### Back to macOS
1. Here, we're only building the NVIDIA.Physx.Native.dylib library, but with the `-monoaotcompat` flag added to the `CMAKE_SWIG_FLAGS`.
1. Follow the above instructions to get the native library.
1. In your Unity project (with the previous non-IL2CPP Wrapper), replace these files with the Wrapper .cs files that we just generated.
    - NativePINVOKE.cs
    - All files that end with \*Callback.cs (such as PxErrorCallback.cs)
1. In those \*Callback.cs files, find in files to replace calls to `Dispose()` with `destroy()` to be compatible with the sample code.
1. Done! Whew!

Hints gathered along the way:
- https://github.com/swig/swig/pull/1262
- https://github.com/swig/swig/issues/1832

Run
---

Start Unity and open `.\Unity\PhysX` project and try out the sample scenes.

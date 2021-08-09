# UnityPhysXPlugin - Android (armeabi-v7a + arm64-v8a, IL2CPP support)
Experimental Unity package to enable access to NVIDIA PhysX SDK 4 from within Unity.  

This fork is specifically set up for building for Android. All references to CUDA have been commented out.

Tested on Unity 2020.2.0f1, built with NDK v23's cmake toolchain on macOS 10.15

https://user-images.githubusercontent.com/25041773/128762055-aa27b915-9534-4060-b4cf-142b52b2cd1f.mp4

Prerequisites
---
- Recent Android NDK
- $NDK environment variable set to your NDK path
- For arm64-v8a, you'll need to adapt the instructions in the macos-il2cpp branch of this repo, a special SWIG fork is required.

Building Instructions
---
1. Build [this fork](https://github.com/prnthp/PhysX) of PhysX 4.1 that has some minor fixes for building PhysX 4.1 using NDK v23's cmake toolchain.
2. Back to this repo, in the NVIDIA.PhysX.Native folder, edit the CMakeLists.txt file to reflect your PhysX SDK location and your target (armeabi-v7a or arm64-v8a).
4. Generate Makefile: `cmake . -DCMAKE_TOOLCHAIN_FILE=$NDK/build/cmake/android.toolchain.cmake -DANDROID_ABI=arm64-v8a -DANDROID_NATIVE_API_LEVEL=19`
5. `make` and collect .so binaries.
6. Follow the instructions in the main or macos-il2cpp branch to build the C# wrappers. Or just get them from here.

Run
---

Start Unity and open `.\Unity\PhysX` project and try out the sample scenes.

//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace NVIDIA.PhysX {

[global::System.FlagsAttribute()]
public enum PxConstraintFlag {
  BROKEN = 1 << 0,
  PROJECT_TO_ACTOR0 = 1 << 1,
  PROJECT_TO_ACTOR1 = 1 << 2,
  PROJECTION = (1 << 1)|(1 << 2),
  COLLISION_ENABLED = 1 << 3,
  VISUALIZATION = 1 << 4,
  DRIVE_LIMITS_ARE_FORCES = 1 << 5,
  IMPROVED_SLERP = 1 << 7,
  DISABLE_PREPROCESSING = 1 << 8,
  ENABLE_EXTENDED_LIMITS = 1 << 9,
  GPU_COMPATIBLE = 1 << 10
}

}
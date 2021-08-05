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

public partial class PxD6JointDrive : PxSpring {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal PxD6JointDrive(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NativePINVOKE.PxD6JointDrive_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PxD6JointDrive obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  public override void destroy() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NativePINVOKE.delete_PxD6JointDrive(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.destroy();
    }
  }

  public float forceLimit {
    set {
      NativePINVOKE.PxD6JointDrive_forceLimit_set(swigCPtr, value);
      if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = NativePINVOKE.PxD6JointDrive_forceLimit_get(swigCPtr);
      if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public PxD6JointDriveFlag flags {
    set {
      NativePINVOKE.PxD6JointDrive_flags_set(swigCPtr, (int)value);
      if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      PxD6JointDriveFlag ret = (PxD6JointDriveFlag)NativePINVOKE.PxD6JointDrive_flags_get(swigCPtr);
      if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public PxD6JointDrive() : this(NativePINVOKE.new_PxD6JointDrive__SWIG_0(), true) {
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public PxD6JointDrive(float driveStiffness, float driveDamping, float driveForceLimit, bool isAcceleration) : this(NativePINVOKE.new_PxD6JointDrive__SWIG_1(driveStiffness, driveDamping, driveForceLimit, isAcceleration), true) {
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public PxD6JointDrive(float driveStiffness, float driveDamping, float driveForceLimit) : this(NativePINVOKE.new_PxD6JointDrive__SWIG_2(driveStiffness, driveDamping, driveForceLimit), true) {
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool isValid() {
    bool ret = NativePINVOKE.PxD6JointDrive_isValid(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}

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

public partial class PxCapsuleGeometry : PxGeometry {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal PxCapsuleGeometry(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NativePINVOKE.PxCapsuleGeometry_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PxCapsuleGeometry obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  public override void destroy() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NativePINVOKE.delete_PxCapsuleGeometry(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.destroy();
    }
  }

  public PxCapsuleGeometry() : this(NativePINVOKE.new_PxCapsuleGeometry__SWIG_0(), true) {
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public PxCapsuleGeometry(float radius, float halfHeight) : this(NativePINVOKE.new_PxCapsuleGeometry__SWIG_1(radius, halfHeight), true) {
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool isValid() {
    bool ret = NativePINVOKE.PxCapsuleGeometry_isValid(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float radius {
    set {
      NativePINVOKE.PxCapsuleGeometry_radius_set(swigCPtr, value);
      if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = NativePINVOKE.PxCapsuleGeometry_radius_get(swigCPtr);
      if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public float halfHeight {
    set {
      NativePINVOKE.PxCapsuleGeometry_halfHeight_set(swigCPtr, value);
      if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = NativePINVOKE.PxCapsuleGeometry_halfHeight_get(swigCPtr);
      if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

}

}

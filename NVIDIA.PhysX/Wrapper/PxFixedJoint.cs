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

public partial class PxFixedJoint : PxJoint {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal PxFixedJoint(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NativePINVOKE.PxFixedJoint_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PxFixedJoint obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static new PxFixedJoint getWrapper(global::System.IntPtr cPtr, bool cMemoryOwn) {
      var wrapper = WrapperCache.find(cPtr);
      if (!(wrapper is PxFixedJoint)) {
          wrapper = new PxFixedJoint(cPtr, cMemoryOwn);
          WrapperCache.add(cPtr, wrapper);
      }
      return wrapper as PxFixedJoint;
  }

  public void setProjectionLinearTolerance(float tolerance) {
    NativePINVOKE.PxFixedJoint_setProjectionLinearTolerance(swigCPtr, tolerance);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public float getProjectionLinearTolerance() {
    float ret = NativePINVOKE.PxFixedJoint_getProjectionLinearTolerance(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setProjectionAngularTolerance(float tolerance) {
    NativePINVOKE.PxFixedJoint_setProjectionAngularTolerance(swigCPtr, tolerance);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public float getProjectionAngularTolerance() {
    float ret = NativePINVOKE.PxFixedJoint_getProjectionAngularTolerance(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}

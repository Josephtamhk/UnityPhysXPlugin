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

public partial class PxPvdSceneClient {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PxPvdSceneClient(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PxPvdSceneClient obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PxPvdSceneClient() {
    destroy();
  }

  public virtual void destroy() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          throw new global::System.MethodAccessException("C++ destructor does not have public access");
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public void setScenePvdFlag(PxPvdSceneFlag flag, bool value) {
    NativePINVOKE.PxPvdSceneClient_setScenePvdFlag(swigCPtr, (int)flag, value);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setScenePvdFlags(PxPvdSceneFlag flags) {
    NativePINVOKE.PxPvdSceneClient_setScenePvdFlags(swigCPtr, (int)flags);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public PxPvdSceneFlag getScenePvdFlags() {
    PxPvdSceneFlag ret = (PxPvdSceneFlag)NativePINVOKE.PxPvdSceneClient_getScenePvdFlags(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void updateCamera(string name,  PxVec3  origin,  PxVec3  up,  PxVec3  target) {
    NativePINVOKE.PxPvdSceneClient_updateCamera(swigCPtr, name,  origin.swigCPtr ,  up.swigCPtr ,  target.swigCPtr );
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

}

}

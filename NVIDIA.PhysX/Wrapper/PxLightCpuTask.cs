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

public partial class PxLightCpuTask : PxBaseTask {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal PxLightCpuTask(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NativePINVOKE.PxLightCpuTask_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PxLightCpuTask obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static new PxLightCpuTask getWrapper(global::System.IntPtr cPtr, bool cMemoryOwn) {
      var wrapper = WrapperCache.find(cPtr);
      if (!(wrapper is PxLightCpuTask)) {
          wrapper = new PxLightCpuTask(cPtr, cMemoryOwn);
          WrapperCache.add(cPtr, wrapper);
      }
      return wrapper as PxLightCpuTask;
  }

  public void setContinuation(PxTaskManager tm, PxBaseTask c) {
    NativePINVOKE.PxLightCpuTask_setContinuation__SWIG_0(swigCPtr, PxTaskManager.getCPtr(tm), PxBaseTask.getCPtr(c));
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setContinuation(PxBaseTask c) {
    NativePINVOKE.PxLightCpuTask_setContinuation__SWIG_1(swigCPtr, PxBaseTask.getCPtr(c));
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public PxBaseTask getContinuation() {
    global::System.IntPtr cPtr = NativePINVOKE.PxLightCpuTask_getContinuation(swigCPtr);
    PxBaseTask ret = (cPtr == global::System.IntPtr.Zero) ? null : PxBaseTask.getWrapper(cPtr, false);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void removeReference() {
    NativePINVOKE.PxLightCpuTask_removeReference(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public override int getReference() {
    int ret = NativePINVOKE.PxLightCpuTask_getReference(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void addReference() {
    NativePINVOKE.PxLightCpuTask_addReference(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void release() {
    NativePINVOKE.PxLightCpuTask_release(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

}

}

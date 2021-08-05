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

public partial class PxMidphaseDesc {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PxMidphaseDesc(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PxMidphaseDesc obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PxMidphaseDesc() {
    destroy();
  }

  public virtual void destroy() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NativePINVOKE.delete_PxMidphaseDesc(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public PxMidphaseDesc() : this(NativePINVOKE.new_PxMidphaseDesc(), true) {
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public PxMeshMidPhase getType() {
    PxMeshMidPhase ret = (PxMeshMidPhase)NativePINVOKE.PxMidphaseDesc_getType(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PxBVH33MidphaseDesc mBVH33Desc {
    set {
      NativePINVOKE.PxMidphaseDesc_mBVH33Desc_set(swigCPtr, PxBVH33MidphaseDesc.getCPtr(value));
      if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = NativePINVOKE.PxMidphaseDesc_mBVH33Desc_get(swigCPtr);
      PxBVH33MidphaseDesc ret = (cPtr == global::System.IntPtr.Zero) ? null : new PxBVH33MidphaseDesc(cPtr, false);
      if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public PxBVH34MidphaseDesc mBVH34Desc {
    set {
      NativePINVOKE.PxMidphaseDesc_mBVH34Desc_set(swigCPtr, PxBVH34MidphaseDesc.getCPtr(value));
      if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = NativePINVOKE.PxMidphaseDesc_mBVH34Desc_get(swigCPtr);
      PxBVH34MidphaseDesc ret = (cPtr == global::System.IntPtr.Zero) ? null : new PxBVH34MidphaseDesc(cPtr, false);
      if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public void setToDefault(PxMeshMidPhase type) {
    NativePINVOKE.PxMidphaseDesc_setToDefault(swigCPtr, (int)type);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool isValid() {
    bool ret = NativePINVOKE.PxMidphaseDesc_isValid(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PxMidphaseDesc __assign(PxMeshMidPhase descType) {
    PxMidphaseDesc ret = new PxMidphaseDesc(NativePINVOKE.PxMidphaseDesc___assign(swigCPtr, (int)descType), false);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}

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

public partial class PxQueryCache {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PxQueryCache(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PxQueryCache obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PxQueryCache() {
    destroy();
  }

  public virtual void destroy() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NativePINVOKE.delete_PxQueryCache(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public PxQueryCache() : this(NativePINVOKE.new_PxQueryCache__SWIG_0(), true) {
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public PxQueryCache(PxShape s, uint findex) : this(NativePINVOKE.new_PxQueryCache__SWIG_1(PxShape.getCPtr(s), findex), true) {
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public PxShape shape {
    set {
      NativePINVOKE.PxQueryCache_shape_set(swigCPtr, PxShape.getCPtr(value));
      if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = NativePINVOKE.PxQueryCache_shape_get(swigCPtr);
      PxShape ret = (cPtr == global::System.IntPtr.Zero) ? null : PxShape.getWrapper(cPtr, false);
      if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public PxRigidActor actor {
    set {
      NativePINVOKE.PxQueryCache_actor_set(swigCPtr, PxRigidActor.getCPtr(value));
      if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = NativePINVOKE.PxQueryCache_actor_get(swigCPtr);
      PxRigidActor ret = (cPtr == global::System.IntPtr.Zero) ? null : PxRigidActor.getWrapper(cPtr, false);
      if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public uint faceIndex {
    set {
      NativePINVOKE.PxQueryCache_faceIndex_set(swigCPtr, value);
      if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      uint ret = NativePINVOKE.PxQueryCache_faceIndex_get(swigCPtr);
      if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

}

}

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

public partial class PxOverlapBuffer : PxOverlapCallback {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal PxOverlapBuffer(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NativePINVOKE.PxOverlapBuffer_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PxOverlapBuffer obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  public override void destroy() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NativePINVOKE.delete_PxOverlapBuffer(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.destroy();
    }
  }

  public PxOverlapBuffer(PxOverlapHit aTouches, uint aMaxNbTouches) : this(NativePINVOKE.new_PxOverlapBuffer__SWIG_0(PxOverlapHit.getCPtr(aTouches), aMaxNbTouches), true) {
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public PxOverlapBuffer(PxOverlapHit aTouches) : this(NativePINVOKE.new_PxOverlapBuffer__SWIG_1(PxOverlapHit.getCPtr(aTouches)), true) {
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public PxOverlapBuffer() : this(NativePINVOKE.new_PxOverlapBuffer__SWIG_2(), true) {
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public uint getNbAnyHits() {
    uint ret = NativePINVOKE.PxOverlapBuffer_getNbAnyHits(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PxOverlapHit getAnyHit(uint index) {
    PxOverlapHit ret = new PxOverlapHit(NativePINVOKE.PxOverlapBuffer_getAnyHit(swigCPtr, index), false);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getNbTouches() {
    uint ret = NativePINVOKE.PxOverlapBuffer_getNbTouches(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PxOverlapHit getTouches() {
    global::System.IntPtr cPtr = NativePINVOKE.PxOverlapBuffer_getTouches(swigCPtr);
    PxOverlapHit ret = (cPtr == global::System.IntPtr.Zero) ? null : new PxOverlapHit(cPtr, false);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PxOverlapHit getTouch(uint index) {
    PxOverlapHit ret = new PxOverlapHit(NativePINVOKE.PxOverlapBuffer_getTouch(swigCPtr, index), false);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getMaxNbTouches() {
    uint ret = NativePINVOKE.PxOverlapBuffer_getMaxNbTouches(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}

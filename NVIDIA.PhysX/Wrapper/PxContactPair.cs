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

public partial struct PxContactPair {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwn;

  internal PxContactPair(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PxContactPair obj) {
    return obj.swigCPtr;
  }

  public PxShape shape0 {
    get {
      global::System.IntPtr cPtr = NativePINVOKE.PxContactPair_shape0_get(swigCPtr);
      PxShape ret = (cPtr == global::System.IntPtr.Zero) ? null : PxShape.getWrapper(cPtr, false);
      if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public PxShape shape1 {
    get {
      global::System.IntPtr cPtr = NativePINVOKE.PxContactPair_shape1_get(swigCPtr);
      PxShape ret = (cPtr == global::System.IntPtr.Zero) ? null : PxShape.getWrapper(cPtr, false);
      if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public byte contactCount {
    get {
      byte ret = NativePINVOKE.PxContactPair_contactCount_get(swigCPtr);
      if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public PxContactPairFlag flags {
    get {
      PxContactPairFlag ret = (PxContactPairFlag)NativePINVOKE.PxContactPair_flags_get(swigCPtr);
      if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public PxPairFlag events {
    get {
      PxPairFlag ret = (PxPairFlag)NativePINVOKE.PxContactPair_events_get(swigCPtr);
      if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public uint extractContacts(ref PxContactPairPoint userBuffer, uint bufferSize) {
    uint ret = NativePINVOKE.PxContactPair_extractContacts(swigCPtr, ref userBuffer, bufferSize);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}

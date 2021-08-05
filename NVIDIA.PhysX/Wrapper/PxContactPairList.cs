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

public partial struct PxContactPairList {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwn;

  internal PxContactPairList(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PxContactPairList obj) {
    return obj.swigCPtr;
  }

  public uint count {
    get {
      uint ret = NativePINVOKE.PxContactPairList_count_get(swigCPtr);
      if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public PxContactPair get(uint index) {
    PxContactPair ret = new PxContactPair(NativePINVOKE.PxContactPairList_get(swigCPtr, index), false);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}

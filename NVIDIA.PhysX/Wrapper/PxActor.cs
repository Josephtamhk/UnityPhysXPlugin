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

public partial class PxActor : PxBase {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal PxActor(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NativePINVOKE.PxActor_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PxActor obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static new PxActor getWrapper(global::System.IntPtr cPtr, bool cMemoryOwn) {
      var wrapper = WrapperCache.find(cPtr);
      if (!(wrapper is PxActor)) {
          wrapper = new PxActor(cPtr, cMemoryOwn);
          WrapperCache.add(cPtr, wrapper);
      }
      return wrapper as PxActor;
  }

  public PxScene getScene() {
    global::System.IntPtr cPtr = NativePINVOKE.PxActor_getScene(swigCPtr);
    PxScene ret = (cPtr == global::System.IntPtr.Zero) ? null : PxScene.getWrapper(cPtr, false);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public  PxBounds3  getWorldBounds(float inflation) {
        global::System.IntPtr ptr = NativePINVOKE.PxActor_getWorldBounds__SWIG_0(swigCPtr, inflation);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
        //PxBounds3 ret = global::System.Runtime.InteropServices.Marshal.PtrToStructure<PxBounds3>(ptr);
        PxBounds3 ret; unsafe { ret = *(PxBounds3*)ptr; }
        return ret;
    }

  public  PxBounds3  getWorldBounds() {
        global::System.IntPtr ptr = NativePINVOKE.PxActor_getWorldBounds__SWIG_1(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
        //PxBounds3 ret = global::System.Runtime.InteropServices.Marshal.PtrToStructure<PxBounds3>(ptr);
        PxBounds3 ret; unsafe { ret = *(PxBounds3*)ptr; }
        return ret;
    }

  public void setActorFlag(PxActorFlag flag, bool value) {
    NativePINVOKE.PxActor_setActorFlag(swigCPtr, (int)flag, value);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setActorFlags(PxActorFlag inFlags) {
    NativePINVOKE.PxActor_setActorFlags(swigCPtr, (int)inFlags);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public PxActorFlag getActorFlags() {
    PxActorFlag ret = (PxActorFlag)NativePINVOKE.PxActor_getActorFlags(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setDominanceGroup(byte dominanceGroup) {
    NativePINVOKE.PxActor_setDominanceGroup(swigCPtr, dominanceGroup);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public byte getDominanceGroup() {
    byte ret = NativePINVOKE.PxActor_getDominanceGroup(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PxAggregate getAggregate() {
    global::System.IntPtr cPtr = NativePINVOKE.PxActor_getAggregate(swigCPtr);
    PxAggregate ret = (cPtr == global::System.IntPtr.Zero) ? null : PxAggregate.getWrapper(cPtr, false);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
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

public partial class Px1DConstraint {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Px1DConstraint(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Px1DConstraint obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Px1DConstraint() {
    destroy();
  }

  public virtual void destroy() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NativePINVOKE.delete_Px1DConstraint(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public PxVec3 linear0 {
    set {
      NativePINVOKE.Px1DConstraint_linear0_set(swigCPtr,  value.swigCPtr );
      if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    } 
        get { global::System.IntPtr ptr = NativePINVOKE.Px1DConstraint_linear0_get(swigCPtr);
      if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
              //PxVec3 ret = global::System.Runtime.InteropServices.Marshal.PtrToStructure<PxVec3>(ptr);
              PxVec3 ret; unsafe { ret = *(PxVec3*)ptr; }
              return ret; }
    
  }

  public float geometricError {
    set {
      NativePINVOKE.Px1DConstraint_geometricError_set(swigCPtr, value);
      if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = NativePINVOKE.Px1DConstraint_geometricError_get(swigCPtr);
      if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public PxVec3 angular0 {
    set {
      NativePINVOKE.Px1DConstraint_angular0_set(swigCPtr,  value.swigCPtr );
      if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    } 
        get { global::System.IntPtr ptr = NativePINVOKE.Px1DConstraint_angular0_get(swigCPtr);
      if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
              //PxVec3 ret = global::System.Runtime.InteropServices.Marshal.PtrToStructure<PxVec3>(ptr);
              PxVec3 ret; unsafe { ret = *(PxVec3*)ptr; }
              return ret; }
    
  }

  public float velocityTarget {
    set {
      NativePINVOKE.Px1DConstraint_velocityTarget_set(swigCPtr, value);
      if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = NativePINVOKE.Px1DConstraint_velocityTarget_get(swigCPtr);
      if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public PxVec3 linear1 {
    set {
      NativePINVOKE.Px1DConstraint_linear1_set(swigCPtr,  value.swigCPtr );
      if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    } 
        get { global::System.IntPtr ptr = NativePINVOKE.Px1DConstraint_linear1_get(swigCPtr);
      if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
              //PxVec3 ret = global::System.Runtime.InteropServices.Marshal.PtrToStructure<PxVec3>(ptr);
              PxVec3 ret; unsafe { ret = *(PxVec3*)ptr; }
              return ret; }
    
  }

  public float minImpulse {
    set {
      NativePINVOKE.Px1DConstraint_minImpulse_set(swigCPtr, value);
      if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = NativePINVOKE.Px1DConstraint_minImpulse_get(swigCPtr);
      if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public PxVec3 angular1 {
    set {
      NativePINVOKE.Px1DConstraint_angular1_set(swigCPtr,  value.swigCPtr );
      if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    } 
        get { global::System.IntPtr ptr = NativePINVOKE.Px1DConstraint_angular1_get(swigCPtr);
      if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
              //PxVec3 ret = global::System.Runtime.InteropServices.Marshal.PtrToStructure<PxVec3>(ptr);
              PxVec3 ret; unsafe { ret = *(PxVec3*)ptr; }
              return ret; }
    
  }

  public float maxImpulse {
    set {
      NativePINVOKE.Px1DConstraint_maxImpulse_set(swigCPtr, value);
      if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = NativePINVOKE.Px1DConstraint_maxImpulse_get(swigCPtr);
      if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public float forInternalUse {
    set {
      NativePINVOKE.Px1DConstraint_forInternalUse_set(swigCPtr, value);
      if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = NativePINVOKE.Px1DConstraint_forInternalUse_get(swigCPtr);
      if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public ushort flags {
    set {
      NativePINVOKE.Px1DConstraint_flags_set(swigCPtr, value);
      if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      ushort ret = NativePINVOKE.Px1DConstraint_flags_get(swigCPtr);
      if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public ushort solveHint {
    set {
      NativePINVOKE.Px1DConstraint_solveHint_set(swigCPtr, value);
      if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      ushort ret = NativePINVOKE.Px1DConstraint_solveHint_get(swigCPtr);
      if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

}

}

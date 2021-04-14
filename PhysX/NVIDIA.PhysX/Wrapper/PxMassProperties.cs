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

[global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Sequential)]
public partial struct PxMassProperties {

  public PxMat33 inertiaTensor; public PxVec3 centerOfMass; public float mass;

  internal global::System.IntPtr swigCPtr {
    get { unsafe { fixed(PxMassProperties* p = &this) return (global::System.IntPtr)p; } }
  }

  internal PxMassProperties(global::System.IntPtr ptr, bool unused) {
      //this = global::System.Runtime.InteropServices.Marshal.PtrToStructure<PxMassProperties>(ptr);
      unsafe { this = *(PxMassProperties*)ptr; }
  }
    
  public PxMassProperties(float m,  PxMat33  inertiaT,  PxVec3  com) : this(NativePINVOKE.new_PxMassProperties__SWIG_0(m,  inertiaT.swigCPtr ,  com.swigCPtr ), true) { 
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve(); }
  public PxMassProperties(PxGeometry geometry) : this(NativePINVOKE.new_PxMassProperties__SWIG_1(PxGeometry.getCPtr(geometry)), true) { 
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve(); }
  public  PxMassProperties  __multiply(float scale) {
        global::System.IntPtr ptr = NativePINVOKE.PxMassProperties___multiply(swigCPtr, scale);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
        //PxMassProperties ret = global::System.Runtime.InteropServices.Marshal.PtrToStructure<PxMassProperties>(ptr);
        PxMassProperties ret; unsafe { ret = *(PxMassProperties*)ptr; }
        return ret;
    }

  public void translate( PxVec3  t) {
    NativePINVOKE.PxMassProperties_translate(swigCPtr,  t.swigCPtr );
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public static  PxVec3  getMassSpaceInertia( PxMat33  inertia,  ref PxQuat  massFrame) {
        global::System.IntPtr ptr = NativePINVOKE.PxMassProperties_getMassSpaceInertia( inertia.swigCPtr ,  massFrame.swigCPtr );
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
        //PxVec3 ret = global::System.Runtime.InteropServices.Marshal.PtrToStructure<PxVec3>(ptr);
        PxVec3 ret; unsafe { ret = *(PxVec3*)ptr; }
        return ret;
    }

  public static  PxMat33  translateInertia( PxMat33  inertia, float mass,  PxVec3  t) {
        global::System.IntPtr ptr = NativePINVOKE.PxMassProperties_translateInertia( inertia.swigCPtr , mass,  t.swigCPtr );
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
        //PxMat33 ret = global::System.Runtime.InteropServices.Marshal.PtrToStructure<PxMat33>(ptr);
        PxMat33 ret; unsafe { ret = *(PxMat33*)ptr; }
        return ret;
    }

  public static  PxMat33  rotateInertia( PxMat33  inertia,  PxQuat  q) {
        global::System.IntPtr ptr = NativePINVOKE.PxMassProperties_rotateInertia( inertia.swigCPtr ,  q.swigCPtr );
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
        //PxMat33 ret = global::System.Runtime.InteropServices.Marshal.PtrToStructure<PxMat33>(ptr);
        PxMat33 ret; unsafe { ret = *(PxMat33*)ptr; }
        return ret;
    }

  public static  PxMat33  scaleInertia( PxMat33  inertia,  PxQuat  scaleRotation,  PxVec3  scale) {
        global::System.IntPtr ptr = NativePINVOKE.PxMassProperties_scaleInertia( inertia.swigCPtr ,  scaleRotation.swigCPtr ,  scale.swigCPtr );
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
        //PxMat33 ret = global::System.Runtime.InteropServices.Marshal.PtrToStructure<PxMat33>(ptr);
        PxMat33 ret; unsafe { ret = *(PxMat33*)ptr; }
        return ret;
    }

  public static  PxMassProperties  sum( PxMassProperties[]  props,  PxTransform[]  transforms, uint count) {
        global::System.IntPtr ptr = NativePINVOKE.PxMassProperties_sum( props ,  transforms , count);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
        //PxMassProperties ret = global::System.Runtime.InteropServices.Marshal.PtrToStructure<PxMassProperties>(ptr);
        PxMassProperties ret; unsafe { ret = *(PxMassProperties*)ptr; }
        return ret;
    }

}

}
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
public partial struct PxMat44 {

  public PxVec4 column0,column1,column2,column3;

  internal global::System.IntPtr swigCPtr {
    get { unsafe { fixed(PxMat44* p = &this) return (global::System.IntPtr)p; } }
  }

  internal PxMat44(global::System.IntPtr ptr, bool unused) {
      //this = global::System.Runtime.InteropServices.Marshal.PtrToStructure<PxMat44>(ptr);
      unsafe { this = *(PxMat44*)ptr; }
  }
    
  public PxMat44(PxIDENTITY r) : this(NativePINVOKE.new_PxMat44__SWIG_0((int)r), true) { 
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve(); }
  public PxMat44(PxZERO r) : this(NativePINVOKE.new_PxMat44__SWIG_1((int)r), true) { 
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve(); }
  public PxMat44( PxVec4  col0,  PxVec4  col1,  PxVec4  col2,  PxVec4  col3) : this(NativePINVOKE.new_PxMat44__SWIG_2( col0.swigCPtr ,  col1.swigCPtr ,  col2.swigCPtr ,  col3.swigCPtr ), true) { 
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve(); }
  public PxMat44(float r) : this(NativePINVOKE.new_PxMat44__SWIG_3(r), true) { 
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve(); }
  public PxMat44( PxVec3  col0,  PxVec3  col1,  PxVec3  col2,  PxVec3  col3) : this(NativePINVOKE.new_PxMat44__SWIG_4( col0.swigCPtr ,  col1.swigCPtr ,  col2.swigCPtr ,  col3.swigCPtr ), true) { 
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve(); }
  public PxMat44( PxQuat  q) : this(NativePINVOKE.new_PxMat44__SWIG_5( q.swigCPtr ), true) { 
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve(); }
  public PxMat44( PxVec4  diagonal) : this(NativePINVOKE.new_PxMat44__SWIG_6( diagonal.swigCPtr ), true) { 
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve(); }
  public PxMat44( PxMat33  axes,  PxVec3  position) : this(NativePINVOKE.new_PxMat44__SWIG_7( axes.swigCPtr ,  position.swigCPtr ), true) { 
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve(); }
  public PxMat44( PxTransform  t) : this(NativePINVOKE.new_PxMat44__SWIG_8( t.swigCPtr ), true) { 
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve(); }
  public  PxMat44  getTranspose() {
        global::System.IntPtr ptr = NativePINVOKE.PxMat44_getTranspose(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
        //PxMat44 ret = global::System.Runtime.InteropServices.Marshal.PtrToStructure<PxMat44>(ptr);
        PxMat44 ret; unsafe { ret = *(PxMat44*)ptr; }
        return ret;
    }

  public  PxVec4  transform( PxVec4  other) {
        global::System.IntPtr ptr = NativePINVOKE.PxMat44_transform__SWIG_0(swigCPtr,  other.swigCPtr );
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
        //PxVec4 ret = global::System.Runtime.InteropServices.Marshal.PtrToStructure<PxVec4>(ptr);
        PxVec4 ret; unsafe { ret = *(PxVec4*)ptr; }
        return ret;
    }

  public  PxVec3  transform( PxVec3  other) {
        global::System.IntPtr ptr = NativePINVOKE.PxMat44_transform__SWIG_1(swigCPtr,  other.swigCPtr );
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
        //PxVec3 ret = global::System.Runtime.InteropServices.Marshal.PtrToStructure<PxVec3>(ptr);
        PxVec3 ret; unsafe { ret = *(PxVec3*)ptr; }
        return ret;
    }

  public  PxVec4  rotate( PxVec4  other) {
        global::System.IntPtr ptr = NativePINVOKE.PxMat44_rotate__SWIG_0(swigCPtr,  other.swigCPtr );
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
        //PxVec4 ret = global::System.Runtime.InteropServices.Marshal.PtrToStructure<PxVec4>(ptr);
        PxVec4 ret; unsafe { ret = *(PxVec4*)ptr; }
        return ret;
    }

  public  PxVec3  rotate( PxVec3  other) {
        global::System.IntPtr ptr = NativePINVOKE.PxMat44_rotate__SWIG_1(swigCPtr,  other.swigCPtr );
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
        //PxVec3 ret = global::System.Runtime.InteropServices.Marshal.PtrToStructure<PxVec3>(ptr);
        PxVec3 ret; unsafe { ret = *(PxVec3*)ptr; }
        return ret;
    }

  public  PxVec3  getBasis(int num) {
        global::System.IntPtr ptr = NativePINVOKE.PxMat44_getBasis(swigCPtr, num);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
        //PxVec3 ret = global::System.Runtime.InteropServices.Marshal.PtrToStructure<PxVec3>(ptr);
        PxVec3 ret; unsafe { ret = *(PxVec3*)ptr; }
        return ret;
    }

  public  PxVec3  getPosition() {
        global::System.IntPtr ptr = NativePINVOKE.PxMat44_getPosition(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
        //PxVec3 ret = global::System.Runtime.InteropServices.Marshal.PtrToStructure<PxVec3>(ptr);
        PxVec3 ret; unsafe { ret = *(PxVec3*)ptr; }
        return ret;
    }

  public void setPosition( PxVec3  position) {
    NativePINVOKE.PxMat44_setPosition(swigCPtr,  position.swigCPtr );
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void scale( PxVec4  p) {
    NativePINVOKE.PxMat44_scale(swigCPtr,  p.swigCPtr );
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public  PxMat44  inverseRT() {
        global::System.IntPtr ptr = NativePINVOKE.PxMat44_inverseRT(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
        //PxMat44 ret = global::System.Runtime.InteropServices.Marshal.PtrToStructure<PxMat44>(ptr);
        PxMat44 ret; unsafe { ret = *(PxMat44*)ptr; }
        return ret;
    }

  public bool isFinite() {
    bool ret = NativePINVOKE.PxMat44_isFinite(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
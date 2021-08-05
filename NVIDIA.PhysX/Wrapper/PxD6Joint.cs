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

public partial class PxD6Joint : PxJoint {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal PxD6Joint(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NativePINVOKE.PxD6Joint_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PxD6Joint obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static new PxD6Joint getWrapper(global::System.IntPtr cPtr, bool cMemoryOwn) {
      var wrapper = WrapperCache.find(cPtr);
      if (!(wrapper is PxD6Joint)) {
          wrapper = new PxD6Joint(cPtr, cMemoryOwn);
          WrapperCache.add(cPtr, wrapper);
      }
      return wrapper as PxD6Joint;
  }

  public void setMotion(PxD6Axis axis, PxD6Motion type) {
    NativePINVOKE.PxD6Joint_setMotion(swigCPtr, (int)axis, (int)type);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public PxD6Motion getMotion(PxD6Axis axis) {
    PxD6Motion ret = (PxD6Motion)NativePINVOKE.PxD6Joint_getMotion(swigCPtr, (int)axis);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float getTwistAngle() {
    float ret = NativePINVOKE.PxD6Joint_getTwistAngle(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float getSwingYAngle() {
    float ret = NativePINVOKE.PxD6Joint_getSwingYAngle(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float getSwingZAngle() {
    float ret = NativePINVOKE.PxD6Joint_getSwingZAngle(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setDistanceLimit(PxJointLinearLimit limit) {
    NativePINVOKE.PxD6Joint_setDistanceLimit(swigCPtr, PxJointLinearLimit.getCPtr(limit));
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public PxJointLinearLimit getDistanceLimit() {
    PxJointLinearLimit ret = new PxJointLinearLimit(NativePINVOKE.PxD6Joint_getDistanceLimit(swigCPtr), true);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setLinearLimit(PxD6Axis axis, PxJointLinearLimitPair limit) {
    NativePINVOKE.PxD6Joint_setLinearLimit(swigCPtr, (int)axis, PxJointLinearLimitPair.getCPtr(limit));
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public PxJointLinearLimitPair getLinearLimit(PxD6Axis axis) {
    PxJointLinearLimitPair ret = new PxJointLinearLimitPair(NativePINVOKE.PxD6Joint_getLinearLimit(swigCPtr, (int)axis), true);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setTwistLimit(PxJointAngularLimitPair limit) {
    NativePINVOKE.PxD6Joint_setTwistLimit(swigCPtr, PxJointAngularLimitPair.getCPtr(limit));
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public PxJointAngularLimitPair getTwistLimit() {
    PxJointAngularLimitPair ret = new PxJointAngularLimitPair(NativePINVOKE.PxD6Joint_getTwistLimit(swigCPtr), true);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setSwingLimit(PxJointLimitCone limit) {
    NativePINVOKE.PxD6Joint_setSwingLimit(swigCPtr, PxJointLimitCone.getCPtr(limit));
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public PxJointLimitCone getSwingLimit() {
    PxJointLimitCone ret = new PxJointLimitCone(NativePINVOKE.PxD6Joint_getSwingLimit(swigCPtr), true);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setPyramidSwingLimit(PxJointLimitPyramid limit) {
    NativePINVOKE.PxD6Joint_setPyramidSwingLimit(swigCPtr, PxJointLimitPyramid.getCPtr(limit));
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public PxJointLimitPyramid getPyramidSwingLimit() {
    PxJointLimitPyramid ret = new PxJointLimitPyramid(NativePINVOKE.PxD6Joint_getPyramidSwingLimit(swigCPtr), true);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setDrive(PxD6Drive index, PxD6JointDrive drive) {
    NativePINVOKE.PxD6Joint_setDrive(swigCPtr, (int)index, PxD6JointDrive.getCPtr(drive));
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public PxD6JointDrive getDrive(PxD6Drive index) {
    PxD6JointDrive ret = new PxD6JointDrive(NativePINVOKE.PxD6Joint_getDrive(swigCPtr, (int)index), true);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setDrivePosition( PxTransform  pose, bool autowake) {
    NativePINVOKE.PxD6Joint_setDrivePosition__SWIG_0(swigCPtr,  pose.swigCPtr , autowake);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setDrivePosition( PxTransform  pose) {
    NativePINVOKE.PxD6Joint_setDrivePosition__SWIG_1(swigCPtr,  pose.swigCPtr );
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public  PxTransform  getDrivePosition() {
        global::System.IntPtr ptr = NativePINVOKE.PxD6Joint_getDrivePosition(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
        //PxTransform ret = global::System.Runtime.InteropServices.Marshal.PtrToStructure<PxTransform>(ptr);
        PxTransform ret; unsafe { ret = *(PxTransform*)ptr; }
        return ret;
    }

  public void setDriveVelocity( PxVec3  linear,  PxVec3  angular, bool autowake) {
    NativePINVOKE.PxD6Joint_setDriveVelocity__SWIG_0(swigCPtr,  linear.swigCPtr ,  angular.swigCPtr , autowake);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setDriveVelocity( PxVec3  linear,  PxVec3  angular) {
    NativePINVOKE.PxD6Joint_setDriveVelocity__SWIG_1(swigCPtr,  linear.swigCPtr ,  angular.swigCPtr );
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void getDriveVelocity( ref PxVec3  linear,  ref PxVec3  angular) {
    NativePINVOKE.PxD6Joint_getDriveVelocity(swigCPtr,  linear.swigCPtr ,  angular.swigCPtr );
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setProjectionLinearTolerance(float tolerance) {
    NativePINVOKE.PxD6Joint_setProjectionLinearTolerance(swigCPtr, tolerance);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public float getProjectionLinearTolerance() {
    float ret = NativePINVOKE.PxD6Joint_getProjectionLinearTolerance(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setProjectionAngularTolerance(float tolerance) {
    NativePINVOKE.PxD6Joint_setProjectionAngularTolerance(swigCPtr, tolerance);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public float getProjectionAngularTolerance() {
    float ret = NativePINVOKE.PxD6Joint_getProjectionAngularTolerance(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}

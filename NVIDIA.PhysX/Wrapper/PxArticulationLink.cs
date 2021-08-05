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

public partial class PxArticulationLink : PxRigidBody {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal PxArticulationLink(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NativePINVOKE.PxArticulationLink_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PxArticulationLink obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static new PxArticulationLink getWrapper(global::System.IntPtr cPtr, bool cMemoryOwn) {
      var wrapper = WrapperCache.find(cPtr);
      if (!(wrapper is PxArticulationLink)) {
          wrapper = new PxArticulationLink(cPtr, cMemoryOwn);
          WrapperCache.add(cPtr, wrapper);
      }
      return wrapper as PxArticulationLink;
  }

  public PxArticulationBase getArticulation() {
    PxArticulationBase ret = PxArticulationBase.getWrapper(NativePINVOKE.PxArticulationLink_getArticulation(swigCPtr), false);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PxArticulationJointBase getInboundJoint() {
    global::System.IntPtr cPtr = NativePINVOKE.PxArticulationLink_getInboundJoint(swigCPtr);
    PxArticulationJointBase ret = (cPtr == global::System.IntPtr.Zero) ? null : PxArticulationJointBase.getWrapper(cPtr, false);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PxArticulationJointReducedCoordinate getInboundJointReducedCoordinate() {
    global::System.IntPtr cPtr = NativePINVOKE.PxArticulationLink_getInboundJointReducedCoordinate(swigCPtr);
    PxArticulationJointReducedCoordinate ret = (cPtr == global::System.IntPtr.Zero) ? null : PxArticulationJointReducedCoordinate.getWrapper(cPtr, false);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getInboundJointDof() {
    uint ret = NativePINVOKE.PxArticulationLink_getInboundJointDof(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getNbChildren() {
    uint ret = NativePINVOKE.PxArticulationLink_getNbChildren(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getLinkIndex() {
    uint ret = NativePINVOKE.PxArticulationLink_getLinkIndex(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PxArticulationLink getChild(uint index) {
    global::System.IntPtr cPtr = NativePINVOKE.PxArticulationLink_getChild(swigCPtr, index);
    PxArticulationLink ret = (cPtr == global::System.IntPtr.Zero) ? null : PxArticulationLink.getWrapper(cPtr, false);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}

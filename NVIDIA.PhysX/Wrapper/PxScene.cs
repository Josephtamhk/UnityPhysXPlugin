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

public partial class PxScene {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;
  public object userData;

  internal PxScene(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PxScene obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static PxScene getWrapper(global::System.IntPtr cPtr, bool cMemoryOwn) {
      var wrapper = WrapperCache.find(cPtr);
      if (!(wrapper is PxScene)) {
          wrapper = new PxScene(cPtr, cMemoryOwn);
          WrapperCache.add(cPtr, wrapper);
      }
      return wrapper as PxScene;
  }

  ~PxScene() {
    WrapperCache.remove(swigCPtr.Handle, this);
  }

  public void release() {
    NativePINVOKE.PxScene_release(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setFlag(PxSceneFlag flag, bool value) {
    NativePINVOKE.PxScene_setFlag(swigCPtr, (int)flag, value);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public PxSceneFlag getFlags() {
    PxSceneFlag ret = (PxSceneFlag)NativePINVOKE.PxScene_getFlags(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setLimits(PxSceneLimits limits) {
    NativePINVOKE.PxScene_setLimits(swigCPtr, PxSceneLimits.getCPtr(limits));
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public PxSceneLimits getLimits() {
    PxSceneLimits ret = new PxSceneLimits(NativePINVOKE.PxScene_getLimits(swigCPtr), true);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PxPhysics getPhysics() {
    PxPhysics ret = PxPhysics.getWrapper(NativePINVOKE.PxScene_getPhysics(swigCPtr), false);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getTimestamp() {
    uint ret = NativePINVOKE.PxScene_getTimestamp(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void addArticulation(PxArticulationBase articulation) {
    NativePINVOKE.PxScene_addArticulation(swigCPtr, PxArticulationBase.getCPtr(articulation));
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void removeArticulation(PxArticulationBase articulation, bool wakeOnLostTouch) {
    NativePINVOKE.PxScene_removeArticulation__SWIG_0(swigCPtr, PxArticulationBase.getCPtr(articulation), wakeOnLostTouch);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void removeArticulation(PxArticulationBase articulation) {
    NativePINVOKE.PxScene_removeArticulation__SWIG_1(swigCPtr, PxArticulationBase.getCPtr(articulation));
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void addActor(PxActor actor, PxBVHStructure bvhStructure) {
    NativePINVOKE.PxScene_addActor__SWIG_0(swigCPtr, PxActor.getCPtr(actor), PxBVHStructure.getCPtr(bvhStructure));
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void addActor(PxActor actor) {
    NativePINVOKE.PxScene_addActor__SWIG_1(swigCPtr, PxActor.getCPtr(actor));
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void addActors(PxActor[] actors, uint nbActors) {
    NativePINVOKE.PxScene_addActors__SWIG_0(swigCPtr, global::System.Array.ConvertAll(actors, x => PxActor.getCPtr(x)), nbActors);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void addActors(PxPruningStructure pruningStructure) {
    NativePINVOKE.PxScene_addActors__SWIG_1(swigCPtr, PxPruningStructure.getCPtr(pruningStructure));
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void removeActor(PxActor actor, bool wakeOnLostTouch) {
    NativePINVOKE.PxScene_removeActor__SWIG_0(swigCPtr, PxActor.getCPtr(actor), wakeOnLostTouch);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void removeActor(PxActor actor) {
    NativePINVOKE.PxScene_removeActor__SWIG_1(swigCPtr, PxActor.getCPtr(actor));
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void removeActors(PxActor[] actors, uint nbActors, bool wakeOnLostTouch) {
    NativePINVOKE.PxScene_removeActors__SWIG_0(swigCPtr, global::System.Array.ConvertAll(actors, x => PxActor.getCPtr(x)), nbActors, wakeOnLostTouch);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void removeActors(PxActor[] actors, uint nbActors) {
    NativePINVOKE.PxScene_removeActors__SWIG_1(swigCPtr, global::System.Array.ConvertAll(actors, x => PxActor.getCPtr(x)), nbActors);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void addAggregate(PxAggregate aggregate) {
    NativePINVOKE.PxScene_addAggregate(swigCPtr, PxAggregate.getCPtr(aggregate));
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void removeAggregate(PxAggregate aggregate, bool wakeOnLostTouch) {
    NativePINVOKE.PxScene_removeAggregate__SWIG_0(swigCPtr, PxAggregate.getCPtr(aggregate), wakeOnLostTouch);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void removeAggregate(PxAggregate aggregate) {
    NativePINVOKE.PxScene_removeAggregate__SWIG_1(swigCPtr, PxAggregate.getCPtr(aggregate));
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public uint getNbActors() {
    uint ret = NativePINVOKE.PxScene_getNbActors(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PxActor getActor(uint index) {
    global::System.IntPtr cPtr = NativePINVOKE.PxScene_getActor(swigCPtr, index);
    PxActor ret = (cPtr == global::System.IntPtr.Zero) ? null : PxActor.getWrapper(cPtr, false);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getNbStaticActors() {
    uint ret = NativePINVOKE.PxScene_getNbStaticActors(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PxActor getStaticActor(uint index) {
    global::System.IntPtr cPtr = NativePINVOKE.PxScene_getStaticActor(swigCPtr, index);
    PxActor ret = (cPtr == global::System.IntPtr.Zero) ? null : PxActor.getWrapper(cPtr, false);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getNbDynamicActors() {
    uint ret = NativePINVOKE.PxScene_getNbDynamicActors(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PxActor getDynamicActor(uint index) {
    global::System.IntPtr cPtr = NativePINVOKE.PxScene_getDynamicActor(swigCPtr, index);
    PxActor ret = (cPtr == global::System.IntPtr.Zero) ? null : PxActor.getWrapper(cPtr, false);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getNbArticulations() {
    uint ret = NativePINVOKE.PxScene_getNbArticulations(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PxArticulationBase getArticulation(uint index) {
    global::System.IntPtr cPtr = NativePINVOKE.PxScene_getArticulation(swigCPtr, index);
    PxArticulationBase ret = (cPtr == global::System.IntPtr.Zero) ? null : PxArticulationBase.getWrapper(cPtr, false);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getNbConstraints() {
    uint ret = NativePINVOKE.PxScene_getNbConstraints(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PxConstraint getConstraint(uint index) {
    global::System.IntPtr cPtr = NativePINVOKE.PxScene_getConstraint(swigCPtr, index);
    PxConstraint ret = (cPtr == global::System.IntPtr.Zero) ? null : PxConstraint.getWrapper(cPtr, false);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getNbAggregates() {
    uint ret = NativePINVOKE.PxScene_getNbAggregates(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PxAggregate getAggregate(uint index) {
    global::System.IntPtr cPtr = NativePINVOKE.PxScene_getAggregate(swigCPtr, index);
    PxAggregate ret = (cPtr == global::System.IntPtr.Zero) ? null : PxAggregate.getWrapper(cPtr, false);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setDominanceGroupPair(byte group1, byte group2, PxDominanceGroupPair dominance) {
    NativePINVOKE.PxScene_setDominanceGroupPair(swigCPtr, group1, group2, PxDominanceGroupPair.getCPtr(dominance));
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public PxDominanceGroupPair getDominanceGroupPair(byte group1, byte group2) {
    PxDominanceGroupPair ret = new PxDominanceGroupPair(NativePINVOKE.PxScene_getDominanceGroupPair(swigCPtr, group1, group2), true);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PxCpuDispatcher getCpuDispatcher() {
    global::System.IntPtr cPtr = NativePINVOKE.PxScene_getCpuDispatcher(swigCPtr);
    PxCpuDispatcher ret = (cPtr == global::System.IntPtr.Zero) ? null : PxCpuDispatcher.getWrapper(cPtr, false);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public byte createClient() {
    byte ret = NativePINVOKE.PxScene_createClient(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setSimulationEventCallback(PxSimulationEventCallback callback) {
    NativePINVOKE.PxScene_setSimulationEventCallback(swigCPtr, PxSimulationEventCallback.getCPtr(callback));
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public PxSimulationEventCallback getSimulationEventCallback() {
    global::System.IntPtr cPtr = NativePINVOKE.PxScene_getSimulationEventCallback(swigCPtr);
    PxSimulationEventCallback ret = (cPtr == global::System.IntPtr.Zero) ? null : new PxSimulationEventCallback(cPtr, false);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setBroadPhaseCallback(PxBroadPhaseCallback callback) {
    NativePINVOKE.PxScene_setBroadPhaseCallback(swigCPtr, PxBroadPhaseCallback.getCPtr(callback));
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public PxBroadPhaseCallback getBroadPhaseCallback() {
    global::System.IntPtr cPtr = NativePINVOKE.PxScene_getBroadPhaseCallback(swigCPtr);
    PxBroadPhaseCallback ret = (cPtr == global::System.IntPtr.Zero) ? null : new PxBroadPhaseCallback(cPtr, false);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setFilterShaderData(global::System.IntPtr data, uint dataSize) {
    NativePINVOKE.PxScene_setFilterShaderData(swigCPtr, data, dataSize);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public global::System.IntPtr getFilterShaderData() {
    global::System.IntPtr ret = NativePINVOKE.PxScene_getFilterShaderData(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getFilterShaderDataSize() {
    uint ret = NativePINVOKE.PxScene_getFilterShaderDataSize(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public  PxSimulationFilterShader  getFilterShader() {
        global::System.IntPtr ptr = NativePINVOKE.PxScene_getFilterShader(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
        //PxSimulationFilterShader ret = global::System.Runtime.InteropServices.Marshal.PtrToStructure<PxSimulationFilterShader>(ptr);
        PxSimulationFilterShader ret; unsafe { ret = *(PxSimulationFilterShader*)ptr; }
        return ret;
    }

  public PxSimulationFilterCallback getFilterCallback() {
    global::System.IntPtr cPtr = NativePINVOKE.PxScene_getFilterCallback(swigCPtr);
    PxSimulationFilterCallback ret = (cPtr == global::System.IntPtr.Zero) ? null : new PxSimulationFilterCallback(cPtr, false);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void resetFiltering(PxActor actor) {
    NativePINVOKE.PxScene_resetFiltering__SWIG_0(swigCPtr, PxActor.getCPtr(actor));
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void resetFiltering(PxRigidActor actor, PxShape[] shapes, uint shapeCount) {
    NativePINVOKE.PxScene_resetFiltering__SWIG_1(swigCPtr, PxRigidActor.getCPtr(actor), global::System.Array.ConvertAll(shapes, x => PxShape.getCPtr(x)), shapeCount);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public PxPairFilteringMode getKinematicKinematicFilteringMode() {
    PxPairFilteringMode ret = (PxPairFilteringMode)NativePINVOKE.PxScene_getKinematicKinematicFilteringMode(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PxPairFilteringMode getStaticKinematicFilteringMode() {
    PxPairFilteringMode ret = (PxPairFilteringMode)NativePINVOKE.PxScene_getStaticKinematicFilteringMode(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void simulate(float elapsedTime) {
    NativePINVOKE.PxScene_simulate(swigCPtr, elapsedTime);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void advance() {
    NativePINVOKE.PxScene_advance(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void collide(float elapsedTime) {
    NativePINVOKE.PxScene_collide(swigCPtr, elapsedTime);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool checkResults(bool block) {
    bool ret = NativePINVOKE.PxScene_checkResults__SWIG_0(swigCPtr, block);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool checkResults() {
    bool ret = NativePINVOKE.PxScene_checkResults__SWIG_1(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool fetchCollision(bool block) {
    bool ret = NativePINVOKE.PxScene_fetchCollision__SWIG_0(swigCPtr, block);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool fetchCollision() {
    bool ret = NativePINVOKE.PxScene_fetchCollision__SWIG_1(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool fetchResults(bool block, out uint errorState) {
    bool ret = NativePINVOKE.PxScene_fetchResults__SWIG_0(swigCPtr, block, out errorState);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool fetchResults(bool block) {
    bool ret = NativePINVOKE.PxScene_fetchResults__SWIG_1(swigCPtr, block);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool fetchResults() {
    bool ret = NativePINVOKE.PxScene_fetchResults__SWIG_2(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void flushSimulation(bool sendPendingReports) {
    NativePINVOKE.PxScene_flushSimulation__SWIG_0(swigCPtr, sendPendingReports);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void flushSimulation() {
    NativePINVOKE.PxScene_flushSimulation__SWIG_1(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setGravity( PxVec3  vec) {
    NativePINVOKE.PxScene_setGravity(swigCPtr,  vec.swigCPtr );
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public  PxVec3  getGravity() {
        global::System.IntPtr ptr = NativePINVOKE.PxScene_getGravity(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
        //PxVec3 ret = global::System.Runtime.InteropServices.Marshal.PtrToStructure<PxVec3>(ptr);
        PxVec3 ret; unsafe { ret = *(PxVec3*)ptr; }
        return ret;
    }

  public void setBounceThresholdVelocity(float t) {
    NativePINVOKE.PxScene_setBounceThresholdVelocity(swigCPtr, t);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public float getBounceThresholdVelocity() {
    float ret = NativePINVOKE.PxScene_getBounceThresholdVelocity(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setCCDMaxPasses(uint ccdMaxPasses) {
    NativePINVOKE.PxScene_setCCDMaxPasses(swigCPtr, ccdMaxPasses);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public uint getCCDMaxPasses() {
    uint ret = NativePINVOKE.PxScene_getCCDMaxPasses(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float getFrictionOffsetThreshold() {
    float ret = NativePINVOKE.PxScene_getFrictionOffsetThreshold(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setFrictionType(PxFrictionType frictionType) {
    NativePINVOKE.PxScene_setFrictionType(swigCPtr, (int)frictionType);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public PxFrictionType getFrictionType() {
    PxFrictionType ret = (PxFrictionType)NativePINVOKE.PxScene_getFrictionType(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void getSimulationStatistics(PxSimulationStatistics stats) {
    NativePINVOKE.PxScene_getSimulationStatistics(swigCPtr, PxSimulationStatistics.getCPtr(stats));
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public PxPruningStructureType getStaticStructure() {
    PxPruningStructureType ret = (PxPruningStructureType)NativePINVOKE.PxScene_getStaticStructure(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PxPruningStructureType getDynamicStructure() {
    PxPruningStructureType ret = (PxPruningStructureType)NativePINVOKE.PxScene_getDynamicStructure(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void flushQueryUpdates() {
    NativePINVOKE.PxScene_flushQueryUpdates(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setDynamicTreeRebuildRateHint(uint dynamicTreeRebuildRateHint) {
    NativePINVOKE.PxScene_setDynamicTreeRebuildRateHint(swigCPtr, dynamicTreeRebuildRateHint);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public uint getDynamicTreeRebuildRateHint() {
    uint ret = NativePINVOKE.PxScene_getDynamicTreeRebuildRateHint(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void forceDynamicTreeRebuild(bool rebuildStaticStructure, bool rebuildDynamicStructure) {
    NativePINVOKE.PxScene_forceDynamicTreeRebuild(swigCPtr, rebuildStaticStructure, rebuildDynamicStructure);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setSceneQueryUpdateMode(PxSceneQueryUpdateMode updateMode) {
    NativePINVOKE.PxScene_setSceneQueryUpdateMode(swigCPtr, (int)updateMode);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public PxSceneQueryUpdateMode getSceneQueryUpdateMode() {
    PxSceneQueryUpdateMode ret = (PxSceneQueryUpdateMode)NativePINVOKE.PxScene_getSceneQueryUpdateMode(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void sceneQueriesUpdate() {
    NativePINVOKE.PxScene_sceneQueriesUpdate(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool checkQueries(bool block) {
    bool ret = NativePINVOKE.PxScene_checkQueries__SWIG_0(swigCPtr, block);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool checkQueries() {
    bool ret = NativePINVOKE.PxScene_checkQueries__SWIG_1(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool fetchQueries(bool block) {
    bool ret = NativePINVOKE.PxScene_fetchQueries__SWIG_0(swigCPtr, block);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool fetchQueries() {
    bool ret = NativePINVOKE.PxScene_fetchQueries__SWIG_1(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool raycast( PxVec3  origin,  PxVec3  unitDir, float distance, PxRaycastCallback hitCall, PxHitFlag hitFlags, PxQueryFilterData filterData, PxQueryCache cache) {
    bool ret = NativePINVOKE.PxScene_raycast__SWIG_0(swigCPtr,  origin.swigCPtr ,  unitDir.swigCPtr , distance, PxRaycastCallback.getCPtr(hitCall), (int)hitFlags, PxQueryFilterData.getCPtr(filterData), PxQueryCache.getCPtr(cache));
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool raycast( PxVec3  origin,  PxVec3  unitDir, float distance, PxRaycastCallback hitCall, PxHitFlag hitFlags, PxQueryFilterData filterData) {
    bool ret = NativePINVOKE.PxScene_raycast__SWIG_1(swigCPtr,  origin.swigCPtr ,  unitDir.swigCPtr , distance, PxRaycastCallback.getCPtr(hitCall), (int)hitFlags, PxQueryFilterData.getCPtr(filterData));
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool raycast( PxVec3  origin,  PxVec3  unitDir, float distance, PxRaycastCallback hitCall, PxHitFlag hitFlags) {
    bool ret = NativePINVOKE.PxScene_raycast__SWIG_2(swigCPtr,  origin.swigCPtr ,  unitDir.swigCPtr , distance, PxRaycastCallback.getCPtr(hitCall), (int)hitFlags);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool raycast( PxVec3  origin,  PxVec3  unitDir, float distance, PxRaycastCallback hitCall) {
    bool ret = NativePINVOKE.PxScene_raycast__SWIG_3(swigCPtr,  origin.swigCPtr ,  unitDir.swigCPtr , distance, PxRaycastCallback.getCPtr(hitCall));
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool sweep(PxGeometry geometry,  PxTransform  pose,  PxVec3  unitDir, float distance, PxSweepCallback hitCall, PxHitFlag hitFlags, PxQueryFilterData filterData, PxQueryCache cache, float inflation) {
    bool ret = NativePINVOKE.PxScene_sweep__SWIG_0(swigCPtr, PxGeometry.getCPtr(geometry),  pose.swigCPtr ,  unitDir.swigCPtr , distance, PxSweepCallback.getCPtr(hitCall), (int)hitFlags, PxQueryFilterData.getCPtr(filterData), PxQueryCache.getCPtr(cache), inflation);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool sweep(PxGeometry geometry,  PxTransform  pose,  PxVec3  unitDir, float distance, PxSweepCallback hitCall, PxHitFlag hitFlags, PxQueryFilterData filterData, PxQueryCache cache) {
    bool ret = NativePINVOKE.PxScene_sweep__SWIG_1(swigCPtr, PxGeometry.getCPtr(geometry),  pose.swigCPtr ,  unitDir.swigCPtr , distance, PxSweepCallback.getCPtr(hitCall), (int)hitFlags, PxQueryFilterData.getCPtr(filterData), PxQueryCache.getCPtr(cache));
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool sweep(PxGeometry geometry,  PxTransform  pose,  PxVec3  unitDir, float distance, PxSweepCallback hitCall, PxHitFlag hitFlags, PxQueryFilterData filterData) {
    bool ret = NativePINVOKE.PxScene_sweep__SWIG_2(swigCPtr, PxGeometry.getCPtr(geometry),  pose.swigCPtr ,  unitDir.swigCPtr , distance, PxSweepCallback.getCPtr(hitCall), (int)hitFlags, PxQueryFilterData.getCPtr(filterData));
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool sweep(PxGeometry geometry,  PxTransform  pose,  PxVec3  unitDir, float distance, PxSweepCallback hitCall, PxHitFlag hitFlags) {
    bool ret = NativePINVOKE.PxScene_sweep__SWIG_3(swigCPtr, PxGeometry.getCPtr(geometry),  pose.swigCPtr ,  unitDir.swigCPtr , distance, PxSweepCallback.getCPtr(hitCall), (int)hitFlags);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool sweep(PxGeometry geometry,  PxTransform  pose,  PxVec3  unitDir, float distance, PxSweepCallback hitCall) {
    bool ret = NativePINVOKE.PxScene_sweep__SWIG_4(swigCPtr, PxGeometry.getCPtr(geometry),  pose.swigCPtr ,  unitDir.swigCPtr , distance, PxSweepCallback.getCPtr(hitCall));
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool overlap(PxGeometry geometry,  PxTransform  pose, PxOverlapCallback hitCall, PxQueryFilterData filterData) {
    bool ret = NativePINVOKE.PxScene_overlap__SWIG_0(swigCPtr, PxGeometry.getCPtr(geometry),  pose.swigCPtr , PxOverlapCallback.getCPtr(hitCall), PxQueryFilterData.getCPtr(filterData));
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool overlap(PxGeometry geometry,  PxTransform  pose, PxOverlapCallback hitCall) {
    bool ret = NativePINVOKE.PxScene_overlap__SWIG_1(swigCPtr, PxGeometry.getCPtr(geometry),  pose.swigCPtr , PxOverlapCallback.getCPtr(hitCall));
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getSceneQueryStaticTimestamp() {
    uint ret = NativePINVOKE.PxScene_getSceneQueryStaticTimestamp(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PxBroadPhaseType getBroadPhaseType() {
    PxBroadPhaseType ret = (PxBroadPhaseType)NativePINVOKE.PxScene_getBroadPhaseType(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool getBroadPhaseCaps(PxBroadPhaseCaps caps) {
    bool ret = NativePINVOKE.PxScene_getBroadPhaseCaps(swigCPtr, PxBroadPhaseCaps.getCPtr(caps));
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getNbBroadPhaseRegions() {
    uint ret = NativePINVOKE.PxScene_getNbBroadPhaseRegions(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PxBroadPhaseRegionInfo getBroadPhaseRegion(uint index) {
    PxBroadPhaseRegionInfo ret = new PxBroadPhaseRegionInfo(NativePINVOKE.PxScene_getBroadPhaseRegion(swigCPtr, index), true);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint addBroadPhaseRegion(PxBroadPhaseRegion region, bool populateRegion) {
    uint ret = NativePINVOKE.PxScene_addBroadPhaseRegion__SWIG_0(swigCPtr, PxBroadPhaseRegion.getCPtr(region), populateRegion);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint addBroadPhaseRegion(PxBroadPhaseRegion region) {
    uint ret = NativePINVOKE.PxScene_addBroadPhaseRegion__SWIG_1(swigCPtr, PxBroadPhaseRegion.getCPtr(region));
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool removeBroadPhaseRegion(uint handle) {
    bool ret = NativePINVOKE.PxScene_removeBroadPhaseRegion(swigCPtr, handle);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PxTaskManager getTaskManager() {
    global::System.IntPtr cPtr = NativePINVOKE.PxScene_getTaskManager(swigCPtr);
    PxTaskManager ret = (cPtr == global::System.IntPtr.Zero) ? null : PxTaskManager.getWrapper(cPtr, false);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void lockRead(string file, uint line) {
    NativePINVOKE.PxScene_lockRead__SWIG_0(swigCPtr, file, line);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void lockRead(string file) {
    NativePINVOKE.PxScene_lockRead__SWIG_1(swigCPtr, file);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void lockRead() {
    NativePINVOKE.PxScene_lockRead__SWIG_2(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void unlockRead() {
    NativePINVOKE.PxScene_unlockRead(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void lockWrite(string file, uint line) {
    NativePINVOKE.PxScene_lockWrite__SWIG_0(swigCPtr, file, line);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void lockWrite(string file) {
    NativePINVOKE.PxScene_lockWrite__SWIG_1(swigCPtr, file);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void lockWrite() {
    NativePINVOKE.PxScene_lockWrite__SWIG_2(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void unlockWrite() {
    NativePINVOKE.PxScene_unlockWrite(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setNbContactDataBlocks(uint numBlocks) {
    NativePINVOKE.PxScene_setNbContactDataBlocks(swigCPtr, numBlocks);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public uint getNbContactDataBlocksUsed() {
    uint ret = NativePINVOKE.PxScene_getNbContactDataBlocksUsed(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getMaxNbContactDataBlocksUsed() {
    uint ret = NativePINVOKE.PxScene_getMaxNbContactDataBlocksUsed(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getContactReportStreamBufferSize() {
    uint ret = NativePINVOKE.PxScene_getContactReportStreamBufferSize(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setSolverBatchSize(uint solverBatchSize) {
    NativePINVOKE.PxScene_setSolverBatchSize(swigCPtr, solverBatchSize);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public uint getSolverBatchSize() {
    uint ret = NativePINVOKE.PxScene_getSolverBatchSize(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setSolverArticulationBatchSize(uint solverBatchSize) {
    NativePINVOKE.PxScene_setSolverArticulationBatchSize(swigCPtr, solverBatchSize);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public uint getSolverArticulationBatchSize() {
    uint ret = NativePINVOKE.PxScene_getSolverArticulationBatchSize(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float getWakeCounterResetValue() {
    float ret = NativePINVOKE.PxScene_getWakeCounterResetValue(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void shiftOrigin( PxVec3  shift) {
    NativePINVOKE.PxScene_shiftOrigin(swigCPtr,  shift.swigCPtr );
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public PxPvdSceneClient getScenePvdClient() {
    global::System.IntPtr cPtr = NativePINVOKE.PxScene_getScenePvdClient(swigCPtr);
    PxPvdSceneClient ret = (cPtr == global::System.IntPtr.Zero) ? null : new PxPvdSceneClient(cPtr, false);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}

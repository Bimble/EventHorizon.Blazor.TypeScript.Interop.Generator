/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter))]
    public class ParticleSystem : BaseParticleSystem, IDisposable
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static decimal BILLBOARDMODE_Y
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    ".ParticleSystem.BILLBOARDMODE_Y"
                );
            }
        }

        
        public static decimal BILLBOARDMODE_ALL
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    ".ParticleSystem.BILLBOARDMODE_ALL"
                );
            }
        }

        
        public static decimal BILLBOARDMODE_STRETCHED
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    ".ParticleSystem.BILLBOARDMODE_STRETCHED"
                );
            }
        }
        #endregion

        #region Static Methods
        public static ParticleSystem Parse(object parsedParticleSystem, Scene scene, string rootUrl, System.Nullable<bool> doNotStart = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<ParticleSystem>(
                entity => new ParticleSystem(entity),
                new object[] 
                {
                    new string[] { "BABYLON", "ParticleSystem", "Parse" }, parsedParticleSystem, scene, rootUrl, doNotStart
                }
            );
        }
        #endregion

        #region Accessors
        
        public bool useRampGradients
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "useRampGradients"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "useRampGradients",
                    value
                );
            }
        }

        
        public Particle[] particles
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArrayClass<Particle>(
                    this.___guid,
                    "particles",
                    (entity) =>
                    {
                        return new Particle(entity);
                    }
                );
            }
        }
        #endregion

        #region Properties
        private Observable __onDisposeObservable;
        public Observable onDisposeObservable
        {
            get
            {
            if(__onDisposeObservable == null)
            {
                __onDisposeObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onDisposeObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onDisposeObservable;
            }
            set
            {
__onDisposeObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onDisposeObservable",
                    value
                );
            }
        }

        
        public SubEmitter[] subEmitters
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArrayClass<SubEmitter>(
                    this.___guid,
                    "subEmitters",
                    (entity) =>
                    {
                        return new SubEmitter(entity);
                    }
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "subEmitters",
                    value
                );
            }
        }

        
        public ParticleSystem[] activeSubSystems
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArrayClass<ParticleSystem>(
                    this.___guid,
                    "activeSubSystems",
                    (entity) =>
                    {
                        return new ParticleSystem(entity);
                    }
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "activeSubSystems",
                    value
                );
            }
        }

        
        public bool isLocal
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "isLocal"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "isLocal",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public ParticleSystem() : base() { }

        public ParticleSystem(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public ParticleSystem(
            string name, decimal capacity, Scene scene, Effect customEffect = null, System.Nullable<bool> isAnimationSheetEnabled = null, System.Nullable<decimal> epsilon = null
        ) : base()
        {
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { "BABYLON", "ParticleSystem" },
                name, capacity, scene, customEffect, isAnimationSheetEnabled, epsilon
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        #region updateFunction TODO: Get Comments as metadata identification
        private bool _isUpdateFunctionEnabled = false;
        private readonly IDictionary<string, Func<Task>> _updateFunctionActionMap = new Dictionary<string, Func<Task>>();

        public string updateFunction(
            Func<Task> callback
        )
        {
            SetupUpdateFunctionLoop();

            var handle = Guid.NewGuid().ToString();
            _updateFunctionActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupUpdateFunctionLoop()
        {
            if (_isUpdateFunctionEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "updateFunction",
                "CallUpdateFunctionActions",
                _invokableReference
            );
            _isUpdateFunctionEnabled = true;
        }

        [JSInvokable]
        public async Task CallUpdateFunctionActions()
        {
            foreach (var action in _updateFunctionActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region startDirectionFunction TODO: Get Comments as metadata identification
        private bool _isStartDirectionFunctionEnabled = false;
        private readonly IDictionary<string, Func<Task>> _startDirectionFunctionActionMap = new Dictionary<string, Func<Task>>();

        public string startDirectionFunction(
            Func<Task> callback
        )
        {
            SetupStartDirectionFunctionLoop();

            var handle = Guid.NewGuid().ToString();
            _startDirectionFunctionActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupStartDirectionFunctionLoop()
        {
            if (_isStartDirectionFunctionEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "startDirectionFunction",
                "CallStartDirectionFunctionActions",
                _invokableReference
            );
            _isStartDirectionFunctionEnabled = true;
        }

        [JSInvokable]
        public async Task CallStartDirectionFunctionActions()
        {
            foreach (var action in _startDirectionFunctionActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region startPositionFunction TODO: Get Comments as metadata identification
        private bool _isStartPositionFunctionEnabled = false;
        private readonly IDictionary<string, Func<Task>> _startPositionFunctionActionMap = new Dictionary<string, Func<Task>>();

        public string startPositionFunction(
            Func<Task> callback
        )
        {
            SetupStartPositionFunctionLoop();

            var handle = Guid.NewGuid().ToString();
            _startPositionFunctionActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupStartPositionFunctionLoop()
        {
            if (_isStartPositionFunctionEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "startPositionFunction",
                "CallStartPositionFunctionActions",
                _invokableReference
            );
            _isStartPositionFunctionEnabled = true;
        }

        [JSInvokable]
        public async Task CallStartPositionFunctionActions()
        {
            foreach (var action in _startPositionFunctionActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public string getClassName()
        {
            return EventHorizonBlazorInteropt.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

        public IParticleSystem addLifeTimeGradient(decimal gradient, decimal factor, System.Nullable<decimal> factor2 = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<IParticleSystem>(
                entity => new IParticleSystemCachedEntity(entity),
                new object[] 
                {
                    new string[] { this.___guid, "addLifeTimeGradient" }, gradient, factor, factor2
                }
            );
        }

        public IParticleSystem removeLifeTimeGradient(decimal gradient)
        {
            return EventHorizonBlazorInteropt.FuncClass<IParticleSystem>(
                entity => new IParticleSystemCachedEntity(entity),
                new object[] 
                {
                    new string[] { this.___guid, "removeLifeTimeGradient" }, gradient
                }
            );
        }

        public IParticleSystem addSizeGradient(decimal gradient, decimal factor, System.Nullable<decimal> factor2 = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<IParticleSystem>(
                entity => new IParticleSystemCachedEntity(entity),
                new object[] 
                {
                    new string[] { this.___guid, "addSizeGradient" }, gradient, factor, factor2
                }
            );
        }

        public IParticleSystem removeSizeGradient(decimal gradient)
        {
            return EventHorizonBlazorInteropt.FuncClass<IParticleSystem>(
                entity => new IParticleSystemCachedEntity(entity),
                new object[] 
                {
                    new string[] { this.___guid, "removeSizeGradient" }, gradient
                }
            );
        }

        public IParticleSystem addColorRemapGradient(decimal gradient, decimal min, decimal max)
        {
            return EventHorizonBlazorInteropt.FuncClass<IParticleSystem>(
                entity => new IParticleSystemCachedEntity(entity),
                new object[] 
                {
                    new string[] { this.___guid, "addColorRemapGradient" }, gradient, min, max
                }
            );
        }

        public IParticleSystem removeColorRemapGradient(decimal gradient)
        {
            return EventHorizonBlazorInteropt.FuncClass<IParticleSystem>(
                entity => new IParticleSystemCachedEntity(entity),
                new object[] 
                {
                    new string[] { this.___guid, "removeColorRemapGradient" }, gradient
                }
            );
        }

        public IParticleSystem addAlphaRemapGradient(decimal gradient, decimal min, decimal max)
        {
            return EventHorizonBlazorInteropt.FuncClass<IParticleSystem>(
                entity => new IParticleSystemCachedEntity(entity),
                new object[] 
                {
                    new string[] { this.___guid, "addAlphaRemapGradient" }, gradient, min, max
                }
            );
        }

        public IParticleSystem removeAlphaRemapGradient(decimal gradient)
        {
            return EventHorizonBlazorInteropt.FuncClass<IParticleSystem>(
                entity => new IParticleSystemCachedEntity(entity),
                new object[] 
                {
                    new string[] { this.___guid, "removeAlphaRemapGradient" }, gradient
                }
            );
        }

        public IParticleSystem addAngularSpeedGradient(decimal gradient, decimal factor, System.Nullable<decimal> factor2 = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<IParticleSystem>(
                entity => new IParticleSystemCachedEntity(entity),
                new object[] 
                {
                    new string[] { this.___guid, "addAngularSpeedGradient" }, gradient, factor, factor2
                }
            );
        }

        public IParticleSystem removeAngularSpeedGradient(decimal gradient)
        {
            return EventHorizonBlazorInteropt.FuncClass<IParticleSystem>(
                entity => new IParticleSystemCachedEntity(entity),
                new object[] 
                {
                    new string[] { this.___guid, "removeAngularSpeedGradient" }, gradient
                }
            );
        }

        public IParticleSystem addVelocityGradient(decimal gradient, decimal factor, System.Nullable<decimal> factor2 = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<IParticleSystem>(
                entity => new IParticleSystemCachedEntity(entity),
                new object[] 
                {
                    new string[] { this.___guid, "addVelocityGradient" }, gradient, factor, factor2
                }
            );
        }

        public IParticleSystem removeVelocityGradient(decimal gradient)
        {
            return EventHorizonBlazorInteropt.FuncClass<IParticleSystem>(
                entity => new IParticleSystemCachedEntity(entity),
                new object[] 
                {
                    new string[] { this.___guid, "removeVelocityGradient" }, gradient
                }
            );
        }

        public IParticleSystem addLimitVelocityGradient(decimal gradient, decimal factor, System.Nullable<decimal> factor2 = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<IParticleSystem>(
                entity => new IParticleSystemCachedEntity(entity),
                new object[] 
                {
                    new string[] { this.___guid, "addLimitVelocityGradient" }, gradient, factor, factor2
                }
            );
        }

        public IParticleSystem removeLimitVelocityGradient(decimal gradient)
        {
            return EventHorizonBlazorInteropt.FuncClass<IParticleSystem>(
                entity => new IParticleSystemCachedEntity(entity),
                new object[] 
                {
                    new string[] { this.___guid, "removeLimitVelocityGradient" }, gradient
                }
            );
        }

        public IParticleSystem addDragGradient(decimal gradient, decimal factor, System.Nullable<decimal> factor2 = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<IParticleSystem>(
                entity => new IParticleSystemCachedEntity(entity),
                new object[] 
                {
                    new string[] { this.___guid, "addDragGradient" }, gradient, factor, factor2
                }
            );
        }

        public IParticleSystem removeDragGradient(decimal gradient)
        {
            return EventHorizonBlazorInteropt.FuncClass<IParticleSystem>(
                entity => new IParticleSystemCachedEntity(entity),
                new object[] 
                {
                    new string[] { this.___guid, "removeDragGradient" }, gradient
                }
            );
        }

        public IParticleSystem addEmitRateGradient(decimal gradient, decimal factor, System.Nullable<decimal> factor2 = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<IParticleSystem>(
                entity => new IParticleSystemCachedEntity(entity),
                new object[] 
                {
                    new string[] { this.___guid, "addEmitRateGradient" }, gradient, factor, factor2
                }
            );
        }

        public IParticleSystem removeEmitRateGradient(decimal gradient)
        {
            return EventHorizonBlazorInteropt.FuncClass<IParticleSystem>(
                entity => new IParticleSystemCachedEntity(entity),
                new object[] 
                {
                    new string[] { this.___guid, "removeEmitRateGradient" }, gradient
                }
            );
        }

        public IParticleSystem addStartSizeGradient(decimal gradient, decimal factor, System.Nullable<decimal> factor2 = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<IParticleSystem>(
                entity => new IParticleSystemCachedEntity(entity),
                new object[] 
                {
                    new string[] { this.___guid, "addStartSizeGradient" }, gradient, factor, factor2
                }
            );
        }

        public IParticleSystem removeStartSizeGradient(decimal gradient)
        {
            return EventHorizonBlazorInteropt.FuncClass<IParticleSystem>(
                entity => new IParticleSystemCachedEntity(entity),
                new object[] 
                {
                    new string[] { this.___guid, "removeStartSizeGradient" }, gradient
                }
            );
        }

        public Color3Gradient[] getRampGradients()
        {
            return EventHorizonBlazorInteropt.FuncArrayClass<Color3Gradient>(
                entity => new Color3Gradient(entity),
                new object[]
                {
                    new string[] { this.___guid, "getRampGradients" }
                }
            );
        }

        public ParticleSystem addRampGradient(decimal gradient, Color3 color)
        {
            return EventHorizonBlazorInteropt.FuncClass<ParticleSystem>(
                entity => new ParticleSystem(entity),
                new object[] 
                {
                    new string[] { this.___guid, "addRampGradient" }, gradient, color
                }
            );
        }

        public ParticleSystem removeRampGradient(decimal gradient)
        {
            return EventHorizonBlazorInteropt.FuncClass<ParticleSystem>(
                entity => new ParticleSystem(entity),
                new object[] 
                {
                    new string[] { this.___guid, "removeRampGradient" }, gradient
                }
            );
        }

        public IParticleSystem addColorGradient(decimal gradient, Color4 color1, Color4 color2 = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<IParticleSystem>(
                entity => new IParticleSystemCachedEntity(entity),
                new object[] 
                {
                    new string[] { this.___guid, "addColorGradient" }, gradient, color1, color2
                }
            );
        }

        public IParticleSystem removeColorGradient(decimal gradient)
        {
            return EventHorizonBlazorInteropt.FuncClass<IParticleSystem>(
                entity => new IParticleSystemCachedEntity(entity),
                new object[] 
                {
                    new string[] { this.___guid, "removeColorGradient" }, gradient
                }
            );
        }

        public decimal getCapacity()
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getCapacity" }
                }
            );
        }

        public bool isAlive()
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isAlive" }
                }
            );
        }

        public bool isStarted()
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isStarted" }
                }
            );
        }

        public void start(System.Nullable<decimal> delay = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "start" }, delay
                }
            );
        }

        public void stop(System.Nullable<bool> stopSubEmitters = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "stop" }, stopSubEmitters
                }
            );
        }

        public void reset()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "reset" }
                }
            );
        }

        #region recycleParticle TODO: Get Comments as metadata identification
        private bool _isRecycleParticleEnabled = false;
        private readonly IDictionary<string, Func<Task>> _recycleParticleActionMap = new Dictionary<string, Func<Task>>();

        public string recycleParticle(
            Func<Task> callback
        )
        {
            SetupRecycleParticleLoop();

            var handle = Guid.NewGuid().ToString();
            _recycleParticleActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupRecycleParticleLoop()
        {
            if (_isRecycleParticleEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "recycleParticle",
                "CallRecycleParticleActions",
                _invokableReference
            );
            _isRecycleParticleEnabled = true;
        }

        [JSInvokable]
        public async Task CallRecycleParticleActions()
        {
            foreach (var action in _recycleParticleActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public void animate(System.Nullable<bool> preWarmOnly = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "animate" }, preWarmOnly
                }
            );
        }

        public void rebuild()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "rebuild" }
                }
            );
        }

        public bool isReady()
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isReady" }
                }
            );
        }

        public decimal render()
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "render" }
                }
            );
        }

        public void dispose(System.Nullable<bool> disposeTexture = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "dispose" }, disposeTexture
                }
            );
        }

        public ParticleSystem clone(string name, object newEmitter)
        {
            return EventHorizonBlazorInteropt.FuncClass<ParticleSystem>(
                entity => new ParticleSystem(entity),
                new object[] 
                {
                    new string[] { this.___guid, "clone" }, name, newEmitter
                }
            );
        }

        public CachedEntity serialize()
        {
            return EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "serialize" }
                }
            );
        }
        #endregion
    }
}
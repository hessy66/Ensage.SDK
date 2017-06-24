// <copyright file="IServiceContext.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.Service
{
    using System;
    using System.Collections.Generic;

    using Ensage.SDK.Input;
    using Ensage.SDK.Inventory;
    using Ensage.SDK.Orbwalker;
    using Ensage.SDK.Renderer;
    using Ensage.SDK.Renderer.Particle;
    using Ensage.SDK.TargetSelector;

    using PlaySharp.Toolkit.Helper.Annotations;

    public interface IServiceContext : IDisposable
    {
        ContextContainer<IServiceContext> Container { get; }

        Lazy<IInputManager> Input { get; }

        Lazy<IInventoryManager> Inventory { get; }

        Lazy<IOrbwalkerManager> Orbwalker { get; }

        Unit Owner { get; }

        Lazy<IParticleManager> Particle { get; }

        Lazy<IRendererManager> Renderer { get; }

        Lazy<ITargetSelectorManager> TargetSelector { get; }

        T Get<T>([CanBeNull] string contract = null);

        IEnumerable<T> GetAll<T>([CanBeNull] string contract = null);

        Lazy<T> GetExport<T>([CanBeNull] string contract = null);

        IEnumerable<Lazy<T, TMetadata>> GetExports<T, TMetadata>([CanBeNull] string contract = null);
    }
}
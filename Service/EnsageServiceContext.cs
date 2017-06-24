// <copyright file="EnsageServiceContext.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.Service
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Composition;

    using Ensage.SDK.Input;
    using Ensage.SDK.Inventory;
    using Ensage.SDK.Orbwalker;
    using Ensage.SDK.Renderer;
    using Ensage.SDK.Renderer.Particle;
    using Ensage.SDK.TargetSelector;

    public sealed class EnsageServiceContext : IServiceContext
    {
        private bool disposed;

        public EnsageServiceContext(Unit unit)
        {
            if (unit == null || !unit.IsValid)
            {
                throw new ArgumentNullException(nameof(unit));
            }

            this.Name = unit.Name;
            this.Owner = unit;
            this.Container = ContainerFactory.CreateContainer(this);
        }

        public ContextContainer<IServiceContext> Container { get; }

        [Import]
        public Lazy<IInputManager> Input { get; }

        [Import]
        public Lazy<IInventoryManager> Inventory { get; }

        public string Name { get; }

        [Import]
        public Lazy<IOrbwalkerManager> Orbwalker { get; }

        public Unit Owner { get; }

        [Import]
        public Lazy<IParticleManager> Particle { get; }

        [Import]
        public Lazy<IRendererManager> Renderer { get; }

        [Import]
        public Lazy<ITargetSelectorManager> TargetSelector { get; }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        public bool Equals(Unit other)
        {
            return this.Owner.Equals(other);
        }

        public T Get<T>(string contract = null)
        {
            return this.Container.Get<T>(contract);
        }

        public IEnumerable<T> GetAll<T>(string contract = null)
        {
            return this.Container.GetAll<T>(contract);
        }

        public Lazy<T> GetExport<T>(string contract = null)
        {
            return this.Container.GetExport<T>(contract);
        }

        public IEnumerable<Lazy<T, TMetadata>> GetExports<T, TMetadata>(string contract = null)
        {
            return this.Container.GetExports<T, TMetadata>(contract);
        }

        public override string ToString()
        {
            return $"Context({this.Name})";
        }

        private void Dispose(bool disposing)
        {
            if (this.disposed)
            {
                return;
            }

            if (disposing)
            {
                this.Container.Dispose();
            }

            this.disposed = true;
        }
    }
}
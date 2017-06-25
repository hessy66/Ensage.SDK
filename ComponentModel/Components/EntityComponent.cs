// <copyright file="EntityComponent.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Components
{
    using System;

    using Ensage.SDK.Service;

    using PlaySharp.Toolkit.Helper.Annotations;

    public abstract class EntityComponent<T>
        where T : Entity
    {
        protected EntityComponent([NotNull] IServiceContext context, [NotNull] T instance)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            if (instance == null)
            {
                throw new ArgumentNullException(nameof(instance));
            }

            this.Context = context;
            this.Instance = instance;
            this.Owner = context.Owner;
        }

        public IServiceContext Context { get; }

        public T Instance { get; protected set; }

        public Unit Owner { get; }
    }
}
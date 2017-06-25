// <copyright file="HeroComponent.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Components
{
    using System;

    using Ensage.SDK.Service;

    using PlaySharp.Toolkit.Helper.Annotations;

    public class HeroComponent : IHeroComponent
    {
        public HeroComponent([NotNull] IServiceContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            this.Context = context;
            this.Owner = (Hero)context.Owner;
        }

        public IServiceContext Context { get; }

        public Hero Owner { get; }
    }
}
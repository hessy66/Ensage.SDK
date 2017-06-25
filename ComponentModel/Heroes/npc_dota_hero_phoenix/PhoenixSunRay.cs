// <copyright file="PhoenixSunRay.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_phoenix
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.phoenix_sun_ray)]
    public class PhoenixSunRay : IAbilityComponent
    {
        [ImportingConstructor]
        public PhoenixSunRay([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.phoenix_sun_ray))
        {
        }

        public PhoenixSunRay(IServiceContext context, IAbilityComponent ability)
        {
            this.Context = context;
            this.Ability = ability;
        }

        public IAbilityComponent Ability { get; }

        public IServiceContext Context { get; }

        public Ability Instance
        {
            get
            {
                return this.Ability.Instance;
            }
        }
    }
}
// <copyright file="TuskIceShards.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_tusk
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.tusk_ice_shards)]
    public class TuskIceShards : IAbilityComponent
    {
        [ImportingConstructor]
        public TuskIceShards([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.tusk_ice_shards))
        {
        }

        public TuskIceShards(IServiceContext context, IAbilityComponent ability)
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
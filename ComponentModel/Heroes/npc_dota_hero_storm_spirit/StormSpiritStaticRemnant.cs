// <copyright file="StormSpiritStaticRemnant.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_storm_spirit
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.storm_spirit_static_remnant)]
    public class StormSpiritStaticRemnant : IAbilityComponent
    {
        [ImportingConstructor]
        public StormSpiritStaticRemnant([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.storm_spirit_static_remnant))
        {
        }

        public StormSpiritStaticRemnant(IServiceContext context, IAbilityComponent ability)
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
// <copyright file="SvenStormBolt.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_sven
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.sven_storm_bolt)]
    public class SvenStormBolt : IAbilityComponent
    {
        [ImportingConstructor]
        public SvenStormBolt([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.sven_storm_bolt))
        {
        }

        public SvenStormBolt(IServiceContext context, IAbilityComponent ability)
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
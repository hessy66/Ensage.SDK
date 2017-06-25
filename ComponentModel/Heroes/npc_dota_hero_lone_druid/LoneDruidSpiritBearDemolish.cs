// <copyright file="LoneDruidSpiritBearDemolish.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_lone_druid
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.lone_druid_spirit_bear_demolish)]
    public class LoneDruidSpiritBearDemolish : IAbilityComponent
    {
        [ImportingConstructor]
        public LoneDruidSpiritBearDemolish([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.lone_druid_spirit_bear_demolish))
        {
        }

        public LoneDruidSpiritBearDemolish(IServiceContext context, IAbilityComponent ability)
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
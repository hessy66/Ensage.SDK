// <copyright file="LoneDruidSpiritBearEntangle.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_lone_druid
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.lone_druid_spirit_bear_entangle)]
    public class LoneDruidSpiritBearEntangle : IAbilityComponent
    {
        [ImportingConstructor]
        public LoneDruidSpiritBearEntangle([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.lone_druid_spirit_bear_entangle))
        {
        }

        public LoneDruidSpiritBearEntangle(IServiceContext context, IAbilityComponent ability)
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
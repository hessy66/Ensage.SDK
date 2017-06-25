// <copyright file="DeathProphetSpiritSiphon.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_death_prophet
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.death_prophet_spirit_siphon)]
    public class DeathProphetSpiritSiphon : IAbilityComponent
    {
        [ImportingConstructor]
        public DeathProphetSpiritSiphon([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.death_prophet_spirit_siphon))
        {
        }

        public DeathProphetSpiritSiphon(IServiceContext context, IAbilityComponent ability)
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
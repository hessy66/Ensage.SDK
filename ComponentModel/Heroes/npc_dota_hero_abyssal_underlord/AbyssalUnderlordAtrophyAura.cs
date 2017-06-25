// <copyright file="AbyssalUnderlordAtrophyAura.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_abyssal_underlord
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.abyssal_underlord_atrophy_aura)]
    public class AbyssalUnderlordAtrophyAura : IAbilityComponent
    {
        [ImportingConstructor]
        public AbyssalUnderlordAtrophyAura([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.abyssal_underlord_atrophy_aura))
        {
        }

        public AbyssalUnderlordAtrophyAura(IServiceContext context, IAbilityComponent ability)
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
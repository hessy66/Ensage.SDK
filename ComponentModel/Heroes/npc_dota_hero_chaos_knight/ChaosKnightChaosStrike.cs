// <copyright file="ChaosKnightChaosStrike.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_chaos_knight
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.chaos_knight_chaos_strike)]
    public class ChaosKnightChaosStrike : IAbilityComponent
    {
        [ImportingConstructor]
        public ChaosKnightChaosStrike([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.chaos_knight_chaos_strike))
        {
        }

        public ChaosKnightChaosStrike(IServiceContext context, IAbilityComponent ability)
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
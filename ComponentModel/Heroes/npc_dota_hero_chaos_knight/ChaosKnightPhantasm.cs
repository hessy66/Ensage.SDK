// <copyright file="ChaosKnightPhantasm.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_chaos_knight
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.chaos_knight_phantasm)]
    public class ChaosKnightPhantasm : IAbilityComponent
    {
        [ImportingConstructor]
        public ChaosKnightPhantasm([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.chaos_knight_phantasm))
        {
        }

        public ChaosKnightPhantasm(IServiceContext context, IAbilityComponent ability)
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
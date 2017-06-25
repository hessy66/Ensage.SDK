// <copyright file="ClinkzSearingArrows.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_clinkz
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.clinkz_searing_arrows)]
    public class ClinkzSearingArrows : IAbilityComponent
    {
        [ImportingConstructor]
        public ClinkzSearingArrows([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.clinkz_searing_arrows))
        {
        }

        public ClinkzSearingArrows(IServiceContext context, IAbilityComponent ability)
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
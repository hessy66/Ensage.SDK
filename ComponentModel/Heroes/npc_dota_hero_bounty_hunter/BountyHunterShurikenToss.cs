// <copyright file="BountyHunterShurikenToss.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_bounty_hunter
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.bounty_hunter_shuriken_toss)]
    public class BountyHunterShurikenToss : IAbilityComponent
    {
        [ImportingConstructor]
        public BountyHunterShurikenToss([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.bounty_hunter_shuriken_toss))
        {
        }

        public BountyHunterShurikenToss(IServiceContext context, IAbilityComponent ability)
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
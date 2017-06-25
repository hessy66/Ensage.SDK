// <copyright file="BountyHunterTrack.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_bounty_hunter
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.bounty_hunter_track)]
    public class BountyHunterTrack : IAbilityComponent
    {
        [ImportingConstructor]
        public BountyHunterTrack([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.bounty_hunter_track))
        {
        }

        public BountyHunterTrack(IServiceContext context, IAbilityComponent ability)
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
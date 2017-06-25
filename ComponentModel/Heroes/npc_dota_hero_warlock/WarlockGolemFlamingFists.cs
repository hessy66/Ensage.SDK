// <copyright file="WarlockGolemFlamingFists.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_warlock
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.warlock_golem_flaming_fists)]
    public class WarlockGolemFlamingFists : IAbilityComponent
    {
        [ImportingConstructor]
        public WarlockGolemFlamingFists([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.warlock_golem_flaming_fists))
        {
        }

        public WarlockGolemFlamingFists(IServiceContext context, IAbilityComponent ability)
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
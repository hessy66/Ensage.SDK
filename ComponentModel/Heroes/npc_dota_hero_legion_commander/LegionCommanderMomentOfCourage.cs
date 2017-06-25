// <copyright file="LegionCommanderMomentOfCourage.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_legion_commander
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.legion_commander_moment_of_courage)]
    public class LegionCommanderMomentOfCourage : IAbilityComponent
    {
        [ImportingConstructor]
        public LegionCommanderMomentOfCourage([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.legion_commander_moment_of_courage))
        {
        }

        public LegionCommanderMomentOfCourage(IServiceContext context, IAbilityComponent ability)
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
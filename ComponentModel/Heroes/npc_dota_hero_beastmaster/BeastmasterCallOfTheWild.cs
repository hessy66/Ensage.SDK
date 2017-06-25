// <copyright file="BeastmasterCallOfTheWild.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_beastmaster
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.beastmaster_call_of_the_wild)]
    public class BeastmasterCallOfTheWild : IAbilityComponent
    {
        [ImportingConstructor]
        public BeastmasterCallOfTheWild([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.beastmaster_call_of_the_wild))
        {
        }

        public BeastmasterCallOfTheWild(IServiceContext context, IAbilityComponent ability)
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
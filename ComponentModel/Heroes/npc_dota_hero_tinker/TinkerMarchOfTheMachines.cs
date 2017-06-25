// <copyright file="TinkerMarchOfTheMachines.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_tinker
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.tinker_march_of_the_machines)]
    public class TinkerMarchOfTheMachines : IAbilityComponent
    {
        [ImportingConstructor]
        public TinkerMarchOfTheMachines([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.tinker_march_of_the_machines))
        {
        }

        public TinkerMarchOfTheMachines(IServiceContext context, IAbilityComponent ability)
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
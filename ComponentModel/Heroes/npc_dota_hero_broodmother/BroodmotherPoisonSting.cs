// <copyright file="BroodmotherPoisonSting.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_broodmother
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.broodmother_poison_sting)]
    public class BroodmotherPoisonSting : IAbilityComponent
    {
        [ImportingConstructor]
        public BroodmotherPoisonSting([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.broodmother_poison_sting))
        {
        }

        public BroodmotherPoisonSting(IServiceContext context, IAbilityComponent ability)
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
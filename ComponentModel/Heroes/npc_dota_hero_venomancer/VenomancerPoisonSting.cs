// <copyright file="VenomancerPoisonSting.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_venomancer
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.venomancer_poison_sting)]
    public class VenomancerPoisonSting : IAbilityComponent
    {
        [ImportingConstructor]
        public VenomancerPoisonSting([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.venomancer_poison_sting))
        {
        }

        public VenomancerPoisonSting(IServiceContext context, IAbilityComponent ability)
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
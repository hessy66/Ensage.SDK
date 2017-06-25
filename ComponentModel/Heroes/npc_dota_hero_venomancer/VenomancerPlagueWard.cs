// <copyright file="VenomancerPlagueWard.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_venomancer
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.venomancer_plague_ward)]
    public class VenomancerPlagueWard : IAbilityComponent
    {
        [ImportingConstructor]
        public VenomancerPlagueWard([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.venomancer_plague_ward))
        {
        }

        public VenomancerPlagueWard(IServiceContext context, IAbilityComponent ability)
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
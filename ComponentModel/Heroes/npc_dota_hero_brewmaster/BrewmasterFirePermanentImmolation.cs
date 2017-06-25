// <copyright file="BrewmasterFirePermanentImmolation.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_brewmaster
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.brewmaster_fire_permanent_immolation)]
    public class BrewmasterFirePermanentImmolation : IAbilityComponent
    {
        [ImportingConstructor]
        public BrewmasterFirePermanentImmolation([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.brewmaster_fire_permanent_immolation))
        {
        }

        public BrewmasterFirePermanentImmolation(IServiceContext context, IAbilityComponent ability)
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
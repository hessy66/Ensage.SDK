// <copyright file="BrewmasterStormWindWalk.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_brewmaster
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.brewmaster_storm_wind_walk)]
    public class BrewmasterStormWindWalk : IAbilityComponent
    {
        [ImportingConstructor]
        public BrewmasterStormWindWalk([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.brewmaster_storm_wind_walk))
        {
        }

        public BrewmasterStormWindWalk(IServiceContext context, IAbilityComponent ability)
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
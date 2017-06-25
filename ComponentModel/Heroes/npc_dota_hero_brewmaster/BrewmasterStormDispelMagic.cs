// <copyright file="BrewmasterStormDispelMagic.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_brewmaster
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.brewmaster_storm_dispel_magic)]
    public class BrewmasterStormDispelMagic : IAbilityComponent
    {
        [ImportingConstructor]
        public BrewmasterStormDispelMagic([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.brewmaster_storm_dispel_magic))
        {
        }

        public BrewmasterStormDispelMagic(IServiceContext context, IAbilityComponent ability)
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
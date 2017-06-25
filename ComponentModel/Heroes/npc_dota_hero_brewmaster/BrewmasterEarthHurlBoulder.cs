// <copyright file="BrewmasterEarthHurlBoulder.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_brewmaster
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.brewmaster_earth_hurl_boulder)]
    public class BrewmasterEarthHurlBoulder : IAbilityComponent
    {
        [ImportingConstructor]
        public BrewmasterEarthHurlBoulder([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.brewmaster_earth_hurl_boulder))
        {
        }

        public BrewmasterEarthHurlBoulder(IServiceContext context, IAbilityComponent ability)
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
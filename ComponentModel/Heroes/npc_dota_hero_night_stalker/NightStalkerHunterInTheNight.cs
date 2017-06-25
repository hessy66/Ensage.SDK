// <copyright file="NightStalkerHunterInTheNight.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_night_stalker
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.night_stalker_hunter_in_the_night)]
    public class NightStalkerHunterInTheNight : IAbilityComponent
    {
        [ImportingConstructor]
        public NightStalkerHunterInTheNight([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.night_stalker_hunter_in_the_night))
        {
        }

        public NightStalkerHunterInTheNight(IServiceContext context, IAbilityComponent ability)
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
// <copyright file="EarthshakerFissure.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_earthshaker
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.earthshaker_fissure)]
    public class EarthshakerFissure : IAbilityComponent
    {
        [ImportingConstructor]
        public EarthshakerFissure([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.earthshaker_fissure))
        {
        }

        public EarthshakerFissure(IServiceContext context, IAbilityComponent ability)
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
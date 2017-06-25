// <copyright file="StormSpiritElectricVortex.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_storm_spirit
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.storm_spirit_electric_vortex)]
    public class StormSpiritElectricVortex : IAbilityComponent
    {
        [ImportingConstructor]
        public StormSpiritElectricVortex([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.storm_spirit_electric_vortex))
        {
        }

        public StormSpiritElectricVortex(IServiceContext context, IAbilityComponent ability)
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
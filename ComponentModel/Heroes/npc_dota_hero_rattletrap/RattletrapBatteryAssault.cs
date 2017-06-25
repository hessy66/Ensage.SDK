// <copyright file="RattletrapBatteryAssault.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_rattletrap
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.rattletrap_battery_assault)]
    public class RattletrapBatteryAssault : IAbilityComponent
    {
        [ImportingConstructor]
        public RattletrapBatteryAssault([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.rattletrap_battery_assault))
        {
        }

        public RattletrapBatteryAssault(IServiceContext context, IAbilityComponent ability)
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
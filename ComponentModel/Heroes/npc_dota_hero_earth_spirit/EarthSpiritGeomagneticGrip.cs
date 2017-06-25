// <copyright file="EarthSpiritGeomagneticGrip.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_earth_spirit
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.earth_spirit_geomagnetic_grip)]
    public class EarthSpiritGeomagneticGrip : IAbilityComponent
    {
        [ImportingConstructor]
        public EarthSpiritGeomagneticGrip([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.earth_spirit_geomagnetic_grip))
        {
        }

        public EarthSpiritGeomagneticGrip(IServiceContext context, IAbilityComponent ability)
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
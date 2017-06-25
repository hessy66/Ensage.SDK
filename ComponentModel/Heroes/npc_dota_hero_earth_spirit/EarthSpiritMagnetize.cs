// <copyright file="EarthSpiritMagnetize.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_earth_spirit
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.earth_spirit_magnetize)]
    public class EarthSpiritMagnetize : IAbilityComponent
    {
        [ImportingConstructor]
        public EarthSpiritMagnetize([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.earth_spirit_magnetize))
        {
        }

        public EarthSpiritMagnetize(IServiceContext context, IAbilityComponent ability)
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
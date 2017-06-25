// <copyright file="StormSpiritOverload.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_storm_spirit
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.storm_spirit_overload)]
    public class StormSpiritOverload : IAbilityComponent
    {
        [ImportingConstructor]
        public StormSpiritOverload([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.storm_spirit_overload))
        {
        }

        public StormSpiritOverload(IServiceContext context, IAbilityComponent ability)
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
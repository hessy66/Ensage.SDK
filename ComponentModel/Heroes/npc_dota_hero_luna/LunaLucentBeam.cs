// <copyright file="LunaLucentBeam.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_luna
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.luna_lucent_beam)]
    public class LunaLucentBeam : IAbilityComponent
    {
        [ImportingConstructor]
        public LunaLucentBeam([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.luna_lucent_beam))
        {
        }

        public LunaLucentBeam(IServiceContext context, IAbilityComponent ability)
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
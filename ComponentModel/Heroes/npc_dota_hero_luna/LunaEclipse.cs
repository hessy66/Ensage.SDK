// <copyright file="LunaEclipse.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_luna
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.luna_eclipse)]
    public class LunaEclipse : IAbilityComponent
    {
        [ImportingConstructor]
        public LunaEclipse([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.luna_eclipse))
        {
        }

        public LunaEclipse(IServiceContext context, IAbilityComponent ability)
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
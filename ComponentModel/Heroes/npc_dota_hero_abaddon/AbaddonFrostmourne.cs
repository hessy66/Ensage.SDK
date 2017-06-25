// <copyright file="AbaddonFrostmourne.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_abaddon
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.abaddon_frostmourne)]
    public class AbaddonFrostmourne : IAbilityComponent
    {
        [ImportingConstructor]
        public AbaddonFrostmourne([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.abaddon_frostmourne))
        {
        }

        public AbaddonFrostmourne(IServiceContext context, IAbilityComponent ability)
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
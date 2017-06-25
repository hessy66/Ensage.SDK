// <copyright file="DazzleShadowWave.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_dazzle
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.dazzle_shadow_wave)]
    public class DazzleShadowWave : IAbilityComponent
    {
        [ImportingConstructor]
        public DazzleShadowWave([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.dazzle_shadow_wave))
        {
        }

        public DazzleShadowWave(IServiceContext context, IAbilityComponent ability)
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
// <copyright file="MagnataurShockwave.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_magnataur
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.magnataur_shockwave)]
    public class MagnataurShockwave : IAbilityComponent
    {
        [ImportingConstructor]
        public MagnataurShockwave([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.magnataur_shockwave))
        {
        }

        public MagnataurShockwave(IServiceContext context, IAbilityComponent ability)
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
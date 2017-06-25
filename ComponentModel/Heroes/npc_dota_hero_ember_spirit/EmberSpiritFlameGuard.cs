// <copyright file="EmberSpiritFlameGuard.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_ember_spirit
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.ember_spirit_flame_guard)]
    public class EmberSpiritFlameGuard : IAbilityComponent
    {
        [ImportingConstructor]
        public EmberSpiritFlameGuard([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.ember_spirit_flame_guard))
        {
        }

        public EmberSpiritFlameGuard(IServiceContext context, IAbilityComponent ability)
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
// <copyright file="TemplarAssassinTrap.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_templar_assassin
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.templar_assassin_trap)]
    public class TemplarAssassinTrap : IAbilityComponent
    {
        [ImportingConstructor]
        public TemplarAssassinTrap([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.templar_assassin_trap))
        {
        }

        public TemplarAssassinTrap(IServiceContext context, IAbilityComponent ability)
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
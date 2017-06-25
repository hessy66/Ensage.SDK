// <copyright file="NyxAssassinVendetta.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_nyx_assassin
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.nyx_assassin_vendetta)]
    public class NyxAssassinVendetta : IAbilityComponent
    {
        [ImportingConstructor]
        public NyxAssassinVendetta([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.nyx_assassin_vendetta))
        {
        }

        public NyxAssassinVendetta(IServiceContext context, IAbilityComponent ability)
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
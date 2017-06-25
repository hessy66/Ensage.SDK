// <copyright file="NyxAssassinImpale.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_nyx_assassin
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.nyx_assassin_impale)]
    public class NyxAssassinImpale : IAbilityComponent
    {
        [ImportingConstructor]
        public NyxAssassinImpale([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.nyx_assassin_impale))
        {
        }

        public NyxAssassinImpale(IServiceContext context, IAbilityComponent ability)
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
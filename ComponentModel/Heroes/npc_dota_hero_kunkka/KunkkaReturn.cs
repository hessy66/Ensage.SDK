// <copyright file="KunkkaReturn.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_kunkka
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.kunkka_return)]
    public class KunkkaReturn : IAbilityComponent
    {
        [ImportingConstructor]
        public KunkkaReturn([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.kunkka_return))
        {
        }

        public KunkkaReturn(IServiceContext context, IAbilityComponent ability)
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
// <copyright file="TechiesMinefieldSign.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_techies
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.techies_minefield_sign)]
    public class TechiesMinefieldSign : IAbilityComponent
    {
        [ImportingConstructor]
        public TechiesMinefieldSign([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.techies_minefield_sign))
        {
        }

        public TechiesMinefieldSign(IServiceContext context, IAbilityComponent ability)
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
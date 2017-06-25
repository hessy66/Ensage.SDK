// <copyright file="CentaurReturn.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_centaur
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.centaur_return)]
    public class CentaurReturn : IAbilityComponent
    {
        [ImportingConstructor]
        public CentaurReturn([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.centaur_return))
        {
        }

        public CentaurReturn(IServiceContext context, IAbilityComponent ability)
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
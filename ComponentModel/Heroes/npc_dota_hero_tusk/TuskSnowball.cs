// <copyright file="TuskSnowball.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_tusk
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.tusk_snowball)]
    public class TuskSnowball : IAbilityComponent
    {
        [ImportingConstructor]
        public TuskSnowball([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.tusk_snowball))
        {
        }

        public TuskSnowball(IServiceContext context, IAbilityComponent ability)
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
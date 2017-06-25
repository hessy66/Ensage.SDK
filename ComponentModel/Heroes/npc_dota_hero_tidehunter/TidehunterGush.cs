// <copyright file="TidehunterGush.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_tidehunter
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.tidehunter_gush)]
    public class TidehunterGush : IAbilityComponent
    {
        [ImportingConstructor]
        public TidehunterGush([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.tidehunter_gush))
        {
        }

        public TidehunterGush(IServiceContext context, IAbilityComponent ability)
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
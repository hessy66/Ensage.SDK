// <copyright file="TreantEyesInTheForest.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_treant
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.treant_eyes_in_the_forest)]
    public class TreantEyesInTheForest : IAbilityComponent
    {
        [ImportingConstructor]
        public TreantEyesInTheForest([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.treant_eyes_in_the_forest))
        {
        }

        public TreantEyesInTheForest(IServiceContext context, IAbilityComponent ability)
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
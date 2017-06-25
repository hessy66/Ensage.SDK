// <copyright file="QueenofpainScreamOfPain.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_queenofpain
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.queenofpain_scream_of_pain)]
    public class QueenofpainScreamOfPain : IAbilityComponent
    {
        [ImportingConstructor]
        public QueenofpainScreamOfPain([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.queenofpain_scream_of_pain))
        {
        }

        public QueenofpainScreamOfPain(IServiceContext context, IAbilityComponent ability)
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
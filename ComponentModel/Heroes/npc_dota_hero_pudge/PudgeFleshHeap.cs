// <copyright file="PudgeFleshHeap.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_pudge
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.pudge_flesh_heap)]
    public class PudgeFleshHeap : IAbilityComponent
    {
        [ImportingConstructor]
        public PudgeFleshHeap([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.pudge_flesh_heap))
        {
        }

        public PudgeFleshHeap(IServiceContext context, IAbilityComponent ability)
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
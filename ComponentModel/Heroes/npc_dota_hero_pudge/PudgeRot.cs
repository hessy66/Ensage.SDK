// <copyright file="PudgeRot.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_pudge
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.pudge_rot)]
    public class PudgeRot : IAbilityComponent
    {
        [ImportingConstructor]
        public PudgeRot([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.pudge_rot))
        {
        }

        public PudgeRot(IServiceContext context, IAbilityComponent ability)
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
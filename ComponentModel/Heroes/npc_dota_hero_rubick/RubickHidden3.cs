// <copyright file="RubickHidden3.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_rubick
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.rubick_hidden3)]
    public class RubickHidden3 : IAbilityComponent
    {
        [ImportingConstructor]
        public RubickHidden3([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.rubick_hidden3))
        {
        }

        public RubickHidden3(IServiceContext context, IAbilityComponent ability)
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
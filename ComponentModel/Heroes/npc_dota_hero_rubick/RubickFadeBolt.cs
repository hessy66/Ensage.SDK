// <copyright file="RubickFadeBolt.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_rubick
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.rubick_fade_bolt)]
    public class RubickFadeBolt : IAbilityComponent
    {
        [ImportingConstructor]
        public RubickFadeBolt([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.rubick_fade_bolt))
        {
        }

        public RubickFadeBolt(IServiceContext context, IAbilityComponent ability)
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
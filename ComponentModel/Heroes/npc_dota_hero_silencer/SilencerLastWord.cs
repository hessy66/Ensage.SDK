// <copyright file="SilencerLastWord.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_silencer
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.silencer_last_word)]
    public class SilencerLastWord : IAbilityComponent
    {
        [ImportingConstructor]
        public SilencerLastWord([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.silencer_last_word))
        {
        }

        public SilencerLastWord(IServiceContext context, IAbilityComponent ability)
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
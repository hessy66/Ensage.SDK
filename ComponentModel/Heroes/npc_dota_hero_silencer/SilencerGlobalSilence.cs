// <copyright file="SilencerGlobalSilence.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_silencer
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.silencer_global_silence)]
    public class SilencerGlobalSilence : IAbilityComponent
    {
        [ImportingConstructor]
        public SilencerGlobalSilence([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.silencer_global_silence))
        {
        }

        public SilencerGlobalSilence(IServiceContext context, IAbilityComponent ability)
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
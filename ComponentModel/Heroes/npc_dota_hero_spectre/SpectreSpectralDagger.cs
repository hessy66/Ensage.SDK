// <copyright file="SpectreSpectralDagger.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_spectre
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.spectre_spectral_dagger)]
    public class SpectreSpectralDagger : IAbilityComponent
    {
        [ImportingConstructor]
        public SpectreSpectralDagger([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.spectre_spectral_dagger))
        {
        }

        public SpectreSpectralDagger(IServiceContext context, IAbilityComponent ability)
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
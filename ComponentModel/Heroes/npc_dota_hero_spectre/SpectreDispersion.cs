// <copyright file="SpectreDispersion.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_spectre
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.spectre_dispersion)]
    public class SpectreDispersion : IAbilityComponent
    {
        [ImportingConstructor]
        public SpectreDispersion([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.spectre_dispersion))
        {
        }

        public SpectreDispersion(IServiceContext context, IAbilityComponent ability)
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
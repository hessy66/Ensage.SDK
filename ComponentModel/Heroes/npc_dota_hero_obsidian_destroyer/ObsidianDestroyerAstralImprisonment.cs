// <copyright file="ObsidianDestroyerAstralImprisonment.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_obsidian_destroyer
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.obsidian_destroyer_astral_imprisonment)]
    public class ObsidianDestroyerAstralImprisonment : IAbilityComponent
    {
        [ImportingConstructor]
        public ObsidianDestroyerAstralImprisonment([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.obsidian_destroyer_astral_imprisonment))
        {
        }

        public ObsidianDestroyerAstralImprisonment(IServiceContext context, IAbilityComponent ability)
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
// <copyright file="ObsidianDestroyerEssenceAura.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_obsidian_destroyer
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.obsidian_destroyer_essence_aura)]
    public class ObsidianDestroyerEssenceAura : IAbilityComponent
    {
        [ImportingConstructor]
        public ObsidianDestroyerEssenceAura([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.obsidian_destroyer_essence_aura))
        {
        }

        public ObsidianDestroyerEssenceAura(IServiceContext context, IAbilityComponent ability)
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
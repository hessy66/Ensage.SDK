// <copyright file="ObsidianDestroyer.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_obsidian_destroyer
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_obsidian_destroyer)]
    public class ObsidianDestroyer : IHeroComponent
    {
        [ImportingConstructor]
        public ObsidianDestroyer([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public ObsidianDestroyer(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.ArcaneOrb = new ObsidianDestroyerArcaneOrb(context);
            this.AstralImprisonment = new ObsidianDestroyerAstralImprisonment(context);
            this.EssenceAura = new ObsidianDestroyerEssenceAura(context);
            this.SanityEclipse = new ObsidianDestroyerSanityEclipse(context);
            this.MindOverMatter = new ObsidianDestroyerMindOverMatter(context);
        }

        public ObsidianDestroyerArcaneOrb ArcaneOrb { get; }

        public ObsidianDestroyerAstralImprisonment AstralImprisonment { get; }

        public ObsidianDestroyerEssenceAura EssenceAura { get; }

        public IHeroComponent Hero { get; }

        public ObsidianDestroyerMindOverMatter MindOverMatter { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public ObsidianDestroyerSanityEclipse SanityEclipse { get; }
    }
}
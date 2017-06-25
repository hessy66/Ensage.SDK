// <copyright file="ShadowDemon.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_shadow_demon
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_shadow_demon)]
    public class ShadowDemon : IHeroComponent
    {
        [ImportingConstructor]
        public ShadowDemon([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public ShadowDemon(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.Disruption = new ShadowDemonDisruption(context);
            this.SoulCatcher = new ShadowDemonSoulCatcher(context);
            this.ShadowPoison = new ShadowDemonShadowPoison(context);
            this.ShadowPoisonRelease = new ShadowDemonShadowPoisonRelease(context);
            this.DemonicPurge = new ShadowDemonDemonicPurge(context);
        }

        public ShadowDemonDemonicPurge DemonicPurge { get; }

        public ShadowDemonDisruption Disruption { get; }

        public IHeroComponent Hero { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public ShadowDemonShadowPoison ShadowPoison { get; }

        public ShadowDemonShadowPoisonRelease ShadowPoisonRelease { get; }

        public ShadowDemonSoulCatcher SoulCatcher { get; }
    }
}
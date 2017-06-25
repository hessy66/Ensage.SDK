// <copyright file="SkywrathMage.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_skywrath_mage
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_skywrath_mage)]
    public class SkywrathMage : IHeroComponent
    {
        [ImportingConstructor]
        public SkywrathMage([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public SkywrathMage(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.ArcaneBolt = new SkywrathMageArcaneBolt(context);
            this.ConcussiveShot = new SkywrathMageConcussiveShot(context);
            this.AncientSeal = new SkywrathMageAncientSeal(context);
            this.MysticFlare = new SkywrathMageMysticFlare(context);
        }

        public SkywrathMageAncientSeal AncientSeal { get; }

        public SkywrathMageArcaneBolt ArcaneBolt { get; }

        public SkywrathMageConcussiveShot ConcussiveShot { get; }

        public IHeroComponent Hero { get; }

        public SkywrathMageMysticFlare MysticFlare { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }
    }
}
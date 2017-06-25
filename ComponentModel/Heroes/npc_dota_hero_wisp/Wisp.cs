// <copyright file="Wisp.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_wisp
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_wisp)]
    public class Wisp : IHeroComponent
    {
        [ImportingConstructor]
        public Wisp([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Wisp(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.Tether = new WispTether(context);
            this.Spirits = new WispSpirits(context);
            this.Overcharge = new WispOvercharge(context);
            this.Relocate = new WispRelocate(context);
            this.TetherBreak = new WispTetherBreak(context);
            this.SpiritsIn = new WispSpiritsIn(context);
            this.SpiritsOut = new WispSpiritsOut(context);
        }

        public IHeroComponent Hero { get; }

        public WispOvercharge Overcharge { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public WispRelocate Relocate { get; }

        public WispSpirits Spirits { get; }

        public WispSpiritsIn SpiritsIn { get; }

        public WispSpiritsOut SpiritsOut { get; }

        public WispTether Tether { get; }

        public WispTetherBreak TetherBreak { get; }
    }
}
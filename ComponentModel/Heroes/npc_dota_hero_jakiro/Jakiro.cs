// <copyright file="Jakiro.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_jakiro
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_jakiro)]
    public class Jakiro : IHeroComponent
    {
        [ImportingConstructor]
        public Jakiro([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Jakiro(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.DualBreath = new JakiroDualBreath(context);
            this.IcePath = new JakiroIcePath(context);
            this.LiquidFire = new JakiroLiquidFire(context);
            this.Macropyre = new JakiroMacropyre(context);
        }

        public JakiroDualBreath DualBreath { get; }

        public IHeroComponent Hero { get; }

        public JakiroIcePath IcePath { get; }

        public JakiroLiquidFire LiquidFire { get; }

        public JakiroMacropyre Macropyre { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }
    }
}
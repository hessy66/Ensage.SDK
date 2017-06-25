// <copyright file="Visage.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_visage
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_visage)]
    public class Visage : IHeroComponent
    {
        [ImportingConstructor]
        public Visage([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Visage(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.GraveChill = new VisageGraveChill(context);
            this.SoulAssumption = new VisageSoulAssumption(context);
            this.GravekeepersCloak = new VisageGravekeepersCloak(context);
            this.SummonFamiliars = new VisageSummonFamiliars(context);
            this.SummonFamiliarsStoneForm = new VisageSummonFamiliarsStoneForm(context);
        }

        public VisageGraveChill GraveChill { get; }

        public VisageGravekeepersCloak GravekeepersCloak { get; }

        public IHeroComponent Hero { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public VisageSoulAssumption SoulAssumption { get; }

        public VisageSummonFamiliars SummonFamiliars { get; }

        public VisageSummonFamiliarsStoneForm SummonFamiliarsStoneForm { get; }
    }
}
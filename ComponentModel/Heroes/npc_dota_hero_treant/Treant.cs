// <copyright file="Treant.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_treant
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_treant)]
    public class Treant : IHeroComponent
    {
        [ImportingConstructor]
        public Treant([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Treant(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.NaturesGuise = new TreantNaturesGuise(context);
            this.LeechSeed = new TreantLeechSeed(context);
            this.LivingArmor = new TreantLivingArmor(context);
            this.Overgrowth = new TreantOvergrowth(context);
            this.EyesInTheForest = new TreantEyesInTheForest(context);
        }

        public TreantEyesInTheForest EyesInTheForest { get; }

        public IHeroComponent Hero { get; }

        public TreantLeechSeed LeechSeed { get; }

        public TreantLivingArmor LivingArmor { get; }

        public TreantNaturesGuise NaturesGuise { get; }

        public TreantOvergrowth Overgrowth { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }
    }
}
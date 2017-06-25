// <copyright file="MonkeyKing.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_monkey_king
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_monkey_king)]
    public class MonkeyKing : IHeroComponent
    {
        [ImportingConstructor]
        public MonkeyKing([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public MonkeyKing(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.BoundlessStrike = new MonkeyKingBoundlessStrike(context);
            this.Mischief = new MonkeyKingMischief(context);
            this.TreeDance = new MonkeyKingTreeDance(context);
            this.Untransform = new MonkeyKingUntransform(context);
            this.JinguMastery = new MonkeyKingJinguMastery(context);
            this.PrimalSpring = new MonkeyKingPrimalSpring(context);
            this.WukongsCommand = new MonkeyKingWukongsCommand(context);
            this.PrimalSpringEarly = new MonkeyKingPrimalSpringEarly(context);
        }

        public MonkeyKingBoundlessStrike BoundlessStrike { get; }

        public IHeroComponent Hero { get; }

        public MonkeyKingJinguMastery JinguMastery { get; }

        public MonkeyKingMischief Mischief { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public MonkeyKingPrimalSpring PrimalSpring { get; }

        public MonkeyKingPrimalSpringEarly PrimalSpringEarly { get; }

        public MonkeyKingTreeDance TreeDance { get; }

        public MonkeyKingUntransform Untransform { get; }

        public MonkeyKingWukongsCommand WukongsCommand { get; }
    }
}
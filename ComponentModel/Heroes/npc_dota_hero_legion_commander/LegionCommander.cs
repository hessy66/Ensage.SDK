// <copyright file="LegionCommander.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_legion_commander
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_legion_commander)]
    public class LegionCommander : IHeroComponent
    {
        [ImportingConstructor]
        public LegionCommander([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public LegionCommander(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.OverwhelmingOdds = new LegionCommanderOverwhelmingOdds(context);
            this.PressTheAttack = new LegionCommanderPressTheAttack(context);
            this.MomentOfCourage = new LegionCommanderMomentOfCourage(context);
            this.Duel = new LegionCommanderDuel(context);
        }

        public LegionCommanderDuel Duel { get; }

        public IHeroComponent Hero { get; }

        public LegionCommanderMomentOfCourage MomentOfCourage { get; }

        public LegionCommanderOverwhelmingOdds OverwhelmingOdds { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public LegionCommanderPressTheAttack PressTheAttack { get; }
    }
}
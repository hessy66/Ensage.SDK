// <copyright file="Medusa.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_medusa
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_medusa)]
    public class Medusa : IHeroComponent
    {
        [ImportingConstructor]
        public Medusa([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Medusa(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.SplitShot = new MedusaSplitShot(context);
            this.MysticSnake = new MedusaMysticSnake(context);
            this.ManaShield = new MedusaManaShield(context);
            this.StoneGaze = new MedusaStoneGaze(context);
        }

        public IHeroComponent Hero { get; }

        public MedusaManaShield ManaShield { get; }

        public MedusaMysticSnake MysticSnake { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public MedusaSplitShot SplitShot { get; }

        public MedusaStoneGaze StoneGaze { get; }
    }
}
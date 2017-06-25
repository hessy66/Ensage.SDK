// <copyright file="Sven.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_sven
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_sven)]
    public class Sven : IHeroComponent
    {
        [ImportingConstructor]
        public Sven([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Sven(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.StormBolt = new SvenStormBolt(context);
            this.GreatCleave = new SvenGreatCleave(context);
            this.Warcry = new SvenWarcry(context);
            this.GodsStrength = new SvenGodsStrength(context);
        }

        public SvenGodsStrength GodsStrength { get; }

        public SvenGreatCleave GreatCleave { get; }

        public IHeroComponent Hero { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public SvenStormBolt StormBolt { get; }

        public SvenWarcry Warcry { get; }
    }
}
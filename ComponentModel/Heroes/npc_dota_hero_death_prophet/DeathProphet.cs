// <copyright file="DeathProphet.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_death_prophet
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_death_prophet)]
    public class DeathProphet : IHeroComponent
    {
        [ImportingConstructor]
        public DeathProphet([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public DeathProphet(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.CarrionSwarm = new DeathProphetCarrionSwarm(context);
            this.Silence = new DeathProphetSilence(context);
            this.Witchcraft = new DeathProphetWitchcraft(context);
            this.Exorcism = new DeathProphetExorcism(context);
            this.SpiritSiphon = new DeathProphetSpiritSiphon(context);
        }

        public DeathProphetCarrionSwarm CarrionSwarm { get; }

        public DeathProphetExorcism Exorcism { get; }

        public IHeroComponent Hero { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public DeathProphetSilence Silence { get; }

        public DeathProphetSpiritSiphon SpiritSiphon { get; }

        public DeathProphetWitchcraft Witchcraft { get; }
    }
}
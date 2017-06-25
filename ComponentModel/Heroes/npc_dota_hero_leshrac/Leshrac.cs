// <copyright file="Leshrac.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_leshrac
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_leshrac)]
    public class Leshrac : IHeroComponent
    {
        [ImportingConstructor]
        public Leshrac([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Leshrac(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.SplitEarth = new LeshracSplitEarth(context);
            this.DiabolicEdict = new LeshracDiabolicEdict(context);
            this.LightningStorm = new LeshracLightningStorm(context);
            this.PulseNova = new LeshracPulseNova(context);
        }

        public LeshracDiabolicEdict DiabolicEdict { get; }

        public IHeroComponent Hero { get; }

        public LeshracLightningStorm LightningStorm { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public LeshracPulseNova PulseNova { get; }

        public LeshracSplitEarth SplitEarth { get; }
    }
}
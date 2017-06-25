// <copyright file="Enigma.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_enigma
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_enigma)]
    public class Enigma : IHeroComponent
    {
        [ImportingConstructor]
        public Enigma([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Enigma(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.Malefice = new EnigmaMalefice(context);
            this.DemonicConversion = new EnigmaDemonicConversion(context);
            this.MidnightPulse = new EnigmaMidnightPulse(context);
            this.BlackHole = new EnigmaBlackHole(context);
        }

        public EnigmaBlackHole BlackHole { get; }

        public EnigmaDemonicConversion DemonicConversion { get; }

        public IHeroComponent Hero { get; }

        public EnigmaMalefice Malefice { get; }

        public EnigmaMidnightPulse MidnightPulse { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }
    }
}
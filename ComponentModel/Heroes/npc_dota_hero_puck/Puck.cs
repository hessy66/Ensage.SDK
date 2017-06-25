// <copyright file="Puck.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_puck
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_puck)]
    public class Puck : IHeroComponent
    {
        [ImportingConstructor]
        public Puck([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Puck(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.IllusoryOrb = new PuckIllusoryOrb(context);
            this.EtherealJaunt = new PuckEtherealJaunt(context);
            this.WaningRift = new PuckWaningRift(context);
            this.PhaseShift = new PuckPhaseShift(context);
            this.DreamCoil = new PuckDreamCoil(context);
        }

        public PuckDreamCoil DreamCoil { get; }

        public PuckEtherealJaunt EtherealJaunt { get; }

        public IHeroComponent Hero { get; }

        public PuckIllusoryOrb IllusoryOrb { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public PuckPhaseShift PhaseShift { get; }

        public PuckWaningRift WaningRift { get; }
    }
}
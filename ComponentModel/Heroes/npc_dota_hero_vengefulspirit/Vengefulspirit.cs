// <copyright file="Vengefulspirit.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_vengefulspirit
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_vengefulspirit)]
    public class Vengefulspirit : IHeroComponent
    {
        [ImportingConstructor]
        public Vengefulspirit([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Vengefulspirit(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.MagicMissile = new VengefulspiritMagicMissile(context);
            this.CommandAura = new VengefulspiritCommandAura(context);
            this.WaveOfTerror = new VengefulspiritWaveOfTerror(context);
            this.NetherSwap = new VengefulspiritNetherSwap(context);
        }

        public VengefulspiritCommandAura CommandAura { get; }

        public IHeroComponent Hero { get; }

        public VengefulspiritMagicMissile MagicMissile { get; }

        public VengefulspiritNetherSwap NetherSwap { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public VengefulspiritWaveOfTerror WaveOfTerror { get; }
    }
}
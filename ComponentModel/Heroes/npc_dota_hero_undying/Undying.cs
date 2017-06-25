// <copyright file="Undying.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_undying
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_undying)]
    public class Undying : IHeroComponent
    {
        [ImportingConstructor]
        public Undying([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Undying(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.Decay = new UndyingDecay(context);
            this.SoulRip = new UndyingSoulRip(context);
            this.Tombstone = new UndyingTombstone(context);
            this.TombstoneZombieAura = new UndyingTombstoneZombieAura(context);
            this.TombstoneZombieDeathstrike = new UndyingTombstoneZombieDeathstrike(context);
            this.FleshGolem = new UndyingFleshGolem(context);
        }

        public UndyingDecay Decay { get; }

        public UndyingFleshGolem FleshGolem { get; }

        public IHeroComponent Hero { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public UndyingSoulRip SoulRip { get; }

        public UndyingTombstone Tombstone { get; }

        public UndyingTombstoneZombieAura TombstoneZombieAura { get; }

        public UndyingTombstoneZombieDeathstrike TombstoneZombieDeathstrike { get; }
    }
}
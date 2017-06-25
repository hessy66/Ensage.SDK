// <copyright file="Abaddon.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_abaddon
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_abaddon)]
    public class Abaddon : IHeroComponent
    {
        [ImportingConstructor]
        public Abaddon([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Abaddon(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.DeathCoil = new AbaddonDeathCoil(context);
            this.AphoticShield = new AbaddonAphoticShield(context);
            this.Frostmourne = new AbaddonFrostmourne(context);
            this.BorrowedTime = new AbaddonBorrowedTime(context);
        }

        public AbaddonAphoticShield AphoticShield { get; }

        public AbaddonBorrowedTime BorrowedTime { get; }

        public AbaddonDeathCoil DeathCoil { get; }

        public AbaddonFrostmourne Frostmourne { get; }

        public IHeroComponent Hero { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }
    }
}
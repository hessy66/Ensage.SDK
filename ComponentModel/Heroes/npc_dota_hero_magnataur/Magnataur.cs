// <copyright file="Magnataur.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_magnataur
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_magnataur)]
    public class Magnataur : IHeroComponent
    {
        [ImportingConstructor]
        public Magnataur([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Magnataur(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.Shockwave = new MagnataurShockwave(context);
            this.Empower = new MagnataurEmpower(context);
            this.Skewer = new MagnataurSkewer(context);
            this.ReversePolarity = new MagnataurReversePolarity(context);
        }

        public MagnataurEmpower Empower { get; }

        public IHeroComponent Hero { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public MagnataurReversePolarity ReversePolarity { get; }

        public MagnataurShockwave Shockwave { get; }

        public MagnataurSkewer Skewer { get; }
    }
}
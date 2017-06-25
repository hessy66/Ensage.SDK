// <copyright file="Spectre.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_spectre
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_spectre)]
    public class Spectre : IHeroComponent
    {
        [ImportingConstructor]
        public Spectre([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Spectre(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.SpectralDagger = new SpectreSpectralDagger(context);
            this.Desolate = new SpectreDesolate(context);
            this.Dispersion = new SpectreDispersion(context);
            this.Haunt = new SpectreHaunt(context);
            this.Reality = new SpectreReality(context);
        }

        public SpectreDesolate Desolate { get; }

        public SpectreDispersion Dispersion { get; }

        public SpectreHaunt Haunt { get; }

        public IHeroComponent Hero { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public SpectreReality Reality { get; }

        public SpectreSpectralDagger SpectralDagger { get; }
    }
}
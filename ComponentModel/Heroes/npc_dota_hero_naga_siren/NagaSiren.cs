// <copyright file="NagaSiren.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_naga_siren
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_naga_siren)]
    public class NagaSiren : IHeroComponent
    {
        [ImportingConstructor]
        public NagaSiren([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public NagaSiren(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.MirrorImage = new NagaSirenMirrorImage(context);
            this.Ensnare = new NagaSirenEnsnare(context);
            this.RipTide = new NagaSirenRipTide(context);
            this.SongOfTheSiren = new NagaSirenSongOfTheSiren(context);
            this.SongOfTheSirenCancel = new NagaSirenSongOfTheSirenCancel(context);
        }

        public NagaSirenEnsnare Ensnare { get; }

        public IHeroComponent Hero { get; }

        public NagaSirenMirrorImage MirrorImage { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public NagaSirenRipTide RipTide { get; }

        public NagaSirenSongOfTheSiren SongOfTheSiren { get; }

        public NagaSirenSongOfTheSirenCancel SongOfTheSirenCancel { get; }
    }
}
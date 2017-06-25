// <copyright file="Morphling.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_morphling
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_morphling)]
    public class Morphling : IHeroComponent
    {
        [ImportingConstructor]
        public Morphling([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Morphling(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.Waveform = new MorphlingWaveform(context);
            this.AdaptiveStrike = new MorphlingAdaptiveStrike(context);
            this.Morph = new MorphlingMorph(context);
            this.MorphAgi = new MorphlingMorphAgi(context);
            this.MorphStr = new MorphlingMorphStr(context);
            this.Replicate = new MorphlingReplicate(context);
            this.MorphReplicate = new MorphlingMorphReplicate(context);
            this.Hybrid = new MorphlingHybrid(context);
        }

        public MorphlingAdaptiveStrike AdaptiveStrike { get; }

        public IHeroComponent Hero { get; }

        public MorphlingHybrid Hybrid { get; }

        public MorphlingMorph Morph { get; }

        public MorphlingMorphAgi MorphAgi { get; }

        public MorphlingMorphReplicate MorphReplicate { get; }

        public MorphlingMorphStr MorphStr { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public MorphlingReplicate Replicate { get; }

        public MorphlingWaveform Waveform { get; }
    }
}
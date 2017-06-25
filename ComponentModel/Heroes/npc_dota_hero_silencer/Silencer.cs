// <copyright file="Silencer.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_silencer
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_silencer)]
    public class Silencer : IHeroComponent
    {
        [ImportingConstructor]
        public Silencer([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Silencer(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.CurseOfTheSilent = new SilencerCurseOfTheSilent(context);
            this.GlaivesOfWisdom = new SilencerGlaivesOfWisdom(context);
            this.LastWord = new SilencerLastWord(context);
            this.GlobalSilence = new SilencerGlobalSilence(context);
        }

        public SilencerCurseOfTheSilent CurseOfTheSilent { get; }

        public SilencerGlaivesOfWisdom GlaivesOfWisdom { get; }

        public SilencerGlobalSilence GlobalSilence { get; }

        public IHeroComponent Hero { get; }

        public SilencerLastWord LastWord { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }
    }
}
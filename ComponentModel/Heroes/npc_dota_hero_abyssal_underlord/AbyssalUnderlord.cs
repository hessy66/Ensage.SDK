// <copyright file="AbyssalUnderlord.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_abyssal_underlord
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_abyssal_underlord)]
    public class AbyssalUnderlord : IHeroComponent
    {
        [ImportingConstructor]
        public AbyssalUnderlord([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public AbyssalUnderlord(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.Firestorm = new AbyssalUnderlordFirestorm(context);
            this.PitOfMalice = new AbyssalUnderlordPitOfMalice(context);
            this.AtrophyAura = new AbyssalUnderlordAtrophyAura(context);
            this.DarkRift = new AbyssalUnderlordDarkRift(context);
            this.CancelDarkRift = new AbyssalUnderlordCancelDarkRift(context);
        }

        public AbyssalUnderlordAtrophyAura AtrophyAura { get; }

        public AbyssalUnderlordCancelDarkRift CancelDarkRift { get; }

        public AbyssalUnderlordDarkRift DarkRift { get; }

        public AbyssalUnderlordFirestorm Firestorm { get; }

        public IHeroComponent Hero { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public AbyssalUnderlordPitOfMalice PitOfMalice { get; }
    }
}
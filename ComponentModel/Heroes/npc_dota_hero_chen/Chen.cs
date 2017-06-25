// <copyright file="Chen.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_chen
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_chen)]
    public class Chen : IHeroComponent
    {
        [ImportingConstructor]
        public Chen([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Chen(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.Penitence = new ChenPenitence(context);
            this.TestOfFaith = new ChenTestOfFaith(context);
            this.HolyPersuasion = new ChenHolyPersuasion(context);
            this.HandOfGod = new ChenHandOfGod(context);
            this.TestOfFaithTeleport = new ChenTestOfFaithTeleport(context);
        }

        public ChenHandOfGod HandOfGod { get; }

        public IHeroComponent Hero { get; }

        public ChenHolyPersuasion HolyPersuasion { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public ChenPenitence Penitence { get; }

        public ChenTestOfFaith TestOfFaith { get; }

        public ChenTestOfFaithTeleport TestOfFaithTeleport { get; }
    }
}
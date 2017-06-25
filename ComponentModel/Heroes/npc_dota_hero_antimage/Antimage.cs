// <copyright file="Antimage.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_antimage
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_antimage)]
    public class Antimage : IHeroComponent
    {
        [ImportingConstructor]
        public Antimage([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Antimage(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.ManaBreak = new AntimageManaBreak(context);
            this.Blink = new AntimageBlink(context);
            this.SpellShield = new AntimageSpellShield(context);
            this.ManaVoid = new AntimageManaVoid(context);
        }

        public AntimageBlink Blink { get; }

        public IHeroComponent Hero { get; }

        public AntimageManaBreak ManaBreak { get; }

        public AntimageManaVoid ManaVoid { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public AntimageSpellShield SpellShield { get; }
    }
}
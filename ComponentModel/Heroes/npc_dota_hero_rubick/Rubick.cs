// <copyright file="Rubick.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_rubick
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_rubick)]
    public class Rubick : IHeroComponent
    {
        [ImportingConstructor]
        public Rubick([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Rubick(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.Telekinesis = new RubickTelekinesis(context);
            this.TelekinesisLand = new RubickTelekinesisLand(context);
            this.FadeBolt = new RubickFadeBolt(context);
            this.NullField = new RubickNullField(context);
            this.SpellSteal = new RubickSpellSteal(context);
            this.Empty1 = new RubickEmpty1(context);
            this.Empty2 = new RubickEmpty2(context);
            this.Hidden1 = new RubickHidden1(context);
            this.Hidden2 = new RubickHidden2(context);
            this.Hidden3 = new RubickHidden3(context);
        }

        public RubickEmpty1 Empty1 { get; }

        public RubickEmpty2 Empty2 { get; }

        public RubickFadeBolt FadeBolt { get; }

        public IHeroComponent Hero { get; }

        public RubickHidden1 Hidden1 { get; }

        public RubickHidden2 Hidden2 { get; }

        public RubickHidden3 Hidden3 { get; }

        public RubickNullField NullField { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public RubickSpellSteal SpellSteal { get; }

        public RubickTelekinesis Telekinesis { get; }

        public RubickTelekinesisLand TelekinesisLand { get; }
    }
}
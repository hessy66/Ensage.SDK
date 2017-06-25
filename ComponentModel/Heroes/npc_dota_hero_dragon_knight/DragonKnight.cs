// <copyright file="DragonKnight.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_dragon_knight
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_dragon_knight)]
    public class DragonKnight : IHeroComponent
    {
        [ImportingConstructor]
        public DragonKnight([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public DragonKnight(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.BreatheFire = new DragonKnightBreatheFire(context);
            this.DragonTail = new DragonKnightDragonTail(context);
            this.DragonBlood = new DragonKnightDragonBlood(context);
            this.ElderDragonForm = new DragonKnightElderDragonForm(context);
            this.FrostBreath = new DragonKnightFrostBreath(context);
        }

        public DragonKnightBreatheFire BreatheFire { get; }

        public DragonKnightDragonBlood DragonBlood { get; }

        public DragonKnightDragonTail DragonTail { get; }

        public DragonKnightElderDragonForm ElderDragonForm { get; }

        public DragonKnightFrostBreath FrostBreath { get; }

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
// <copyright file="LoneDruid.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_lone_druid
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_lone_druid)]
    public class LoneDruid : IHeroComponent
    {
        [ImportingConstructor]
        public LoneDruid([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public LoneDruid(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.SpiritBear = new LoneDruidSpiritBear(context);
            this.Rabid = new LoneDruidRabid(context);
            this.SavageRoar = new LoneDruidSavageRoar(context);
            this.TrueForm = new LoneDruidTrueForm(context);
            this.TrueFormDruid = new LoneDruidTrueFormDruid(context);
            this.TrueFormBattleCry = new LoneDruidTrueFormBattleCry(context);
            this.SpiritBearReturn = new LoneDruidSpiritBearReturn(context);
            this.SpiritBearEntangle = new LoneDruidSpiritBearEntangle(context);
            this.SpiritBearDemolish = new LoneDruidSpiritBearDemolish(context);
            this.SavageRoarBear = new LoneDruidSavageRoarBear(context);
        }

        public IHeroComponent Hero { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public LoneDruidRabid Rabid { get; }

        public LoneDruidSavageRoar SavageRoar { get; }

        public LoneDruidSavageRoarBear SavageRoarBear { get; }

        public LoneDruidSpiritBear SpiritBear { get; }

        public LoneDruidSpiritBearDemolish SpiritBearDemolish { get; }

        public LoneDruidSpiritBearEntangle SpiritBearEntangle { get; }

        public LoneDruidSpiritBearReturn SpiritBearReturn { get; }

        public LoneDruidTrueForm TrueForm { get; }

        public LoneDruidTrueFormBattleCry TrueFormBattleCry { get; }

        public LoneDruidTrueFormDruid TrueFormDruid { get; }
    }
}
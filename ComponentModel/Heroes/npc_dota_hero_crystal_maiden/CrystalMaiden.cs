// <copyright file="CrystalMaiden.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_crystal_maiden
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_crystal_maiden)]
    public class CrystalMaiden : IHeroComponent
    {
        [ImportingConstructor]
        public CrystalMaiden([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public CrystalMaiden(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.CrystalNova = new CrystalMaidenCrystalNova(context);
            this.Frostbite = new CrystalMaidenFrostbite(context);
            this.BrillianceAura = new CrystalMaidenBrillianceAura(context);
            this.FreezingField = new CrystalMaidenFreezingField(context);
        }

        public CrystalMaidenBrillianceAura BrillianceAura { get; }

        public CrystalMaidenCrystalNova CrystalNova { get; }

        public CrystalMaidenFreezingField FreezingField { get; }

        public CrystalMaidenFrostbite Frostbite { get; }

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
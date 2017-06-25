// <copyright file="Broodmother.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_broodmother
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_broodmother)]
    public class Broodmother : IHeroComponent
    {
        [ImportingConstructor]
        public Broodmother([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Broodmother(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.SpawnSpiderlings = new BroodmotherSpawnSpiderlings(context);
            this.SpinWeb = new BroodmotherSpinWeb(context);
            this.IncapacitatingBite = new BroodmotherIncapacitatingBite(context);
            this.InsatiableHunger = new BroodmotherInsatiableHunger(context);
            this.SpawnSpiderite = new BroodmotherSpawnSpiderite(context);
            this.PoisonSting = new BroodmotherPoisonSting(context);
            this.SpinWebDestroy = new BroodmotherSpinWebDestroy(context);
        }

        public IHeroComponent Hero { get; }

        public BroodmotherIncapacitatingBite IncapacitatingBite { get; }

        public BroodmotherInsatiableHunger InsatiableHunger { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public BroodmotherPoisonSting PoisonSting { get; }

        public BroodmotherSpawnSpiderite SpawnSpiderite { get; }

        public BroodmotherSpawnSpiderlings SpawnSpiderlings { get; }

        public BroodmotherSpinWeb SpinWeb { get; }

        public BroodmotherSpinWebDestroy SpinWebDestroy { get; }
    }
}
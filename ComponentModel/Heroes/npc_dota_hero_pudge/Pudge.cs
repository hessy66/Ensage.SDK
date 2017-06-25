// <copyright file="Pudge.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_pudge
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_pudge)]
    public class Pudge : IHeroComponent
    {
        [ImportingConstructor]
        public Pudge([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Pudge(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.FleshHeap = new PudgeFleshHeap(context);
            this.MeatHook = new PudgeMeatHook(context);
            this.Rot = new PudgeRot(context);
            this.Dismember = new PudgeDismember(context);
        }

        public PudgeDismember Dismember { get; }

        public PudgeFleshHeap FleshHeap { get; }

        public IHeroComponent Hero { get; }

        public PudgeMeatHook MeatHook { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public PudgeRot Rot { get; }
    }
}
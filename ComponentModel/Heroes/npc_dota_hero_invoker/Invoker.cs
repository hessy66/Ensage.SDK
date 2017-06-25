// <copyright file="Invoker.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_invoker
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_invoker)]
    public class Invoker : IHeroComponent
    {
        [ImportingConstructor]
        public Invoker([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Invoker(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.Quas = new InvokerQuas(context);
            this.Wex = new InvokerWex(context);
            this.Exort = new InvokerExort(context);
            this.Empty1 = new InvokerEmpty1(context);
            this.Empty2 = new InvokerEmpty2(context);
            this.Invoke = new InvokerInvoke(context);
            this.ColdSnap = new InvokerColdSnap(context);
            this.GhostWalk = new InvokerGhostWalk(context);
            this.Tornado = new InvokerTornado(context);
            this.Emp = new InvokerEmp(context);
            this.Alacrity = new InvokerAlacrity(context);
            this.ChaosMeteor = new InvokerChaosMeteor(context);
            this.SunStrike = new InvokerSunStrike(context);
            this.ForgeSpirit = new InvokerForgeSpirit(context);
            this.IceWall = new InvokerIceWall(context);
            this.DeafeningBlast = new InvokerDeafeningBlast(context);
            this.AttributeBonus = new InvokerAttributeBonus(context);
        }

        public InvokerAlacrity Alacrity { get; }

        public InvokerAttributeBonus AttributeBonus { get; }

        public InvokerChaosMeteor ChaosMeteor { get; }

        public InvokerColdSnap ColdSnap { get; }

        public InvokerDeafeningBlast DeafeningBlast { get; }

        public InvokerEmp Emp { get; }

        public InvokerEmpty1 Empty1 { get; }

        public InvokerEmpty2 Empty2 { get; }

        public InvokerExort Exort { get; }

        public InvokerForgeSpirit ForgeSpirit { get; }

        public InvokerGhostWalk GhostWalk { get; }

        public IHeroComponent Hero { get; }

        public InvokerIceWall IceWall { get; }

        public InvokerInvoke Invoke { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public InvokerQuas Quas { get; }

        public InvokerSunStrike SunStrike { get; }

        public InvokerTornado Tornado { get; }

        public InvokerWex Wex { get; }
    }
}
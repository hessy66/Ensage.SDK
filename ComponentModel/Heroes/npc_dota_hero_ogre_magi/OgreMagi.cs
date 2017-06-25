// <copyright file="OgreMagi.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_ogre_magi
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_ogre_magi)]
    public class OgreMagi : IHeroComponent
    {
        [ImportingConstructor]
        public OgreMagi([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public OgreMagi(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.FrostArmor = new OgreMagiFrostArmor(context);
            this.Fireblast = new OgreMagiFireblast(context);
            this.Ignite = new OgreMagiIgnite(context);
            this.Bloodlust = new OgreMagiBloodlust(context);
            this.Multicast = new OgreMagiMulticast(context);
            this.UnrefinedFireblast = new OgreMagiUnrefinedFireblast(context);
        }

        public OgreMagiBloodlust Bloodlust { get; }

        public OgreMagiFireblast Fireblast { get; }

        public OgreMagiFrostArmor FrostArmor { get; }

        public IHeroComponent Hero { get; }

        public OgreMagiIgnite Ignite { get; }

        public OgreMagiMulticast Multicast { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public OgreMagiUnrefinedFireblast UnrefinedFireblast { get; }
    }
}
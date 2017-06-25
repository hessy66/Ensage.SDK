// <copyright file="Tusk.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_tusk
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_tusk)]
    public class Tusk : IHeroComponent
    {
        [ImportingConstructor]
        public Tusk([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Tusk(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.IceShards = new TuskIceShards(context);
            this.Snowball = new TuskSnowball(context);
            this.FrozenSigil = new TuskFrozenSigil(context);
            this.WalrusPunch = new TuskWalrusPunch(context);
            this.LaunchSnowball = new TuskLaunchSnowball(context);
            this.IceShardsStop = new TuskIceShardsStop(context);
            this.WalrusKick = new TuskWalrusKick(context);
        }

        public TuskFrozenSigil FrozenSigil { get; }

        public IHeroComponent Hero { get; }

        public TuskIceShards IceShards { get; }

        public TuskIceShardsStop IceShardsStop { get; }

        public TuskLaunchSnowball LaunchSnowball { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public TuskSnowball Snowball { get; }

        public TuskWalrusKick WalrusKick { get; }

        public TuskWalrusPunch WalrusPunch { get; }
    }
}
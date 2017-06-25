// <copyright file="MiranaStarfall.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_mirana
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.mirana_starfall)]
    public class MiranaStarfall : IAbilityComponent
    {
        [ImportingConstructor]
        public MiranaStarfall([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.mirana_starfall))
        {
        }

        public MiranaStarfall(IServiceContext context, IAbilityComponent ability)
        {
            this.Context = context;
            this.Ability = ability;
        }

        public IAbilityComponent Ability { get; }

        public IServiceContext Context { get; }

        public Ability Instance
        {
            get
            {
                return this.Ability.Instance;
            }
        }
    }
}
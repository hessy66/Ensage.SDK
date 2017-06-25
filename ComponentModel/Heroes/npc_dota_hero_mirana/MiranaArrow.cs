// <copyright file="MiranaArrow.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_mirana
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.mirana_arrow)]
    public class MiranaArrow : IAbilityComponent
    {
        [ImportingConstructor]
        public MiranaArrow([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.mirana_arrow))
        {
        }

        public MiranaArrow(IServiceContext context, IAbilityComponent ability)
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
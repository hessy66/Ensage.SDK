// <copyright file="MiranaInvis.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_mirana
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.mirana_invis)]
    public class MiranaInvis : IAbilityComponent
    {
        [ImportingConstructor]
        public MiranaInvis([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.mirana_invis))
        {
        }

        public MiranaInvis(IServiceContext context, IAbilityComponent ability)
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
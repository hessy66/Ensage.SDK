// <copyright file="LycanHowl.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_lycan
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.lycan_howl)]
    public class LycanHowl : IAbilityComponent
    {
        [ImportingConstructor]
        public LycanHowl([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.lycan_howl))
        {
        }

        public LycanHowl(IServiceContext context, IAbilityComponent ability)
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
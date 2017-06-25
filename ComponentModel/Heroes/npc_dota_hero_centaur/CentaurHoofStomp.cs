// <copyright file="CentaurHoofStomp.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_centaur
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.centaur_hoof_stomp)]
    public class CentaurHoofStomp : IAbilityComponent
    {
        [ImportingConstructor]
        public CentaurHoofStomp([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.centaur_hoof_stomp))
        {
        }

        public CentaurHoofStomp(IServiceContext context, IAbilityComponent ability)
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
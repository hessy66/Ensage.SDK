// <copyright file="WeaverGeminateAttack.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_weaver
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.weaver_geminate_attack)]
    public class WeaverGeminateAttack : IAbilityComponent
    {
        [ImportingConstructor]
        public WeaverGeminateAttack([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.weaver_geminate_attack))
        {
        }

        public WeaverGeminateAttack(IServiceContext context, IAbilityComponent ability)
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
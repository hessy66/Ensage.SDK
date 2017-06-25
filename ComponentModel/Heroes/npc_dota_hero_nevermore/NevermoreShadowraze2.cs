// <copyright file="NevermoreShadowraze2.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_nevermore
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.nevermore_shadowraze2)]
    public class NevermoreShadowraze2 : IAbilityComponent
    {
        [ImportingConstructor]
        public NevermoreShadowraze2([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.nevermore_shadowraze2))
        {
        }

        public NevermoreShadowraze2(IServiceContext context, IAbilityComponent ability)
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
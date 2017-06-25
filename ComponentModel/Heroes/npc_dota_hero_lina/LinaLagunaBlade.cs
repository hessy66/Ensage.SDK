// <copyright file="LinaLagunaBlade.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_lina
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.lina_laguna_blade)]
    public class LinaLagunaBlade : IAbilityComponent
    {
        [ImportingConstructor]
        public LinaLagunaBlade([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.lina_laguna_blade))
        {
        }

        public LinaLagunaBlade(IServiceContext context, IAbilityComponent ability)
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
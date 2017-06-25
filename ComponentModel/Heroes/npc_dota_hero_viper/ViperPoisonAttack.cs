// <copyright file="ViperPoisonAttack.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_viper
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.viper_poison_attack)]
    public class ViperPoisonAttack : IAbilityComponent
    {
        [ImportingConstructor]
        public ViperPoisonAttack([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.viper_poison_attack))
        {
        }

        public ViperPoisonAttack(IServiceContext context, IAbilityComponent ability)
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
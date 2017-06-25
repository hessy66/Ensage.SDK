// <copyright file="ShredderReturnChakram2.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_shredder
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.shredder_return_chakram_2)]
    public class ShredderReturnChakram2 : IAbilityComponent
    {
        [ImportingConstructor]
        public ShredderReturnChakram2([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.shredder_return_chakram_2))
        {
        }

        public ShredderReturnChakram2(IServiceContext context, IAbilityComponent ability)
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
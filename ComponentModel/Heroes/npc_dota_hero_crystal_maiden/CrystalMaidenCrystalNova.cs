// <copyright file="CrystalMaidenCrystalNova.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_crystal_maiden
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.crystal_maiden_crystal_nova)]
    public class CrystalMaidenCrystalNova : IAbilityComponent
    {
        [ImportingConstructor]
        public CrystalMaidenCrystalNova([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.crystal_maiden_crystal_nova))
        {
        }

        public CrystalMaidenCrystalNova(IServiceContext context, IAbilityComponent ability)
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
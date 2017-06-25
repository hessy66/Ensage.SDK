// <copyright file="VengefulspiritMagicMissile.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_vengefulspirit
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.vengefulspirit_magic_missile)]
    public class VengefulspiritMagicMissile : IAbilityComponent
    {
        [ImportingConstructor]
        public VengefulspiritMagicMissile([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.vengefulspirit_magic_missile))
        {
        }

        public VengefulspiritMagicMissile(IServiceContext context, IAbilityComponent ability)
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
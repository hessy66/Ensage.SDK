// <copyright file="EntityComponent.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel
{
    using System;
    using System.ComponentModel;
    using System.ComponentModel.Composition;

    using Ensage.SDK.Service;

    using PlaySharp.Toolkit.Helper.Annotations;

    public abstract class EntityComponent<T>
        where T : Entity
    {
        protected EntityComponent([NotNull] IServiceContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            this.Context = context;
            this.Owner = context.Owner;
        }

        public IServiceContext Context { get; }

        public T[] Instances { get; protected set; } = new T[0];

        public Unit Owner { get; }
    }

    public abstract class HeroComponent : IHeroComponent
    {
        protected HeroComponent([NotNull] IServiceContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            this.Context = context;
            this.Owner = (Hero)context.Owner;
        }

        public IServiceContext Context { get; }

        public Hero Owner { get; }
    }

    public abstract class AbilityComponent : EntityComponent<Ability>, IAbilityComponent
    {
        protected AbilityComponent([NotNull] IServiceContext context, AbilityId id)
            : base(context)
        {
            if (id.ToString().StartsWith("item_"))
            {
                throw new InvalidEnumArgumentException($"Invalid Ability: {id}");
            }

            this.Id = id;
        }

        public AbilityId Id { get; }
    }

    public interface IAbilityComponent
    {
    }

    public abstract class ItemComponent : EntityComponent<Item>, IItemComponent
    {
        protected ItemComponent([NotNull] IServiceContext context, AbilityId id)
            : base(context)
        {
            if (!id.ToString().StartsWith("item_"))
            {
                throw new InvalidEnumArgumentException($"Invalid Item: {id}");
            }

            this.Id = id;
        }

        public AbilityId Id { get; }
    }

    [Export(typeof(IRangedComponent))]
    public class RangedComponent : IRangedComponent
    {
    }

    public interface IRangedComponent
    {
    }

    [Export(typeof(IToggleComponent))]
    public class ToggleComponent : IToggleComponent
    {
    }

    public interface IToggleComponent
    {
    }

    [Export(typeof(IPredictionComponent))]
    public class PredictionComponent : IPredictionComponent
    {
    }

    public interface IPredictionComponent
    {
    }

    [Export(typeof(IPassiveComponent))]
    public class PassiveComponent : IPassiveComponent
    {
    }

    public interface IPassiveComponent
    {
    }

    [Export(typeof(IOrbComponent))]
    public class OrbComponent : IOrbComponent
    {
    }

    public interface IOrbComponent
    {
    }

    [Export(typeof(ILineComponent))]
    public class LineComponent : ILineComponent
    {
    }

    public interface ILineComponent
    {
    }

    [Export(typeof(IDotComponent))]
    public class DotComponent : IDotComponent
    {
    }

    public interface IDotComponent
    {
    }

    [Export(typeof(IAuraComponent))]
    public class AuraComponent : IAuraComponent
    {
    }

    public interface IAuraComponent
    {
    }

    [Export(typeof(IChannableComponent))]
    public class ChannableComponent : IChannableComponent
    {
    }

    public interface IChannableComponent
    {
    }

    [Export(typeof(IModifierComponent))]
    public class ModifierComponent : IModifierComponent
    {
    }

    public interface IModifierComponent
    {
    }

    [Export(typeof(IModifierTextureComponent))]
    public class ModifierTextureComponent : IModifierTextureComponent
    {
    }

    public interface IModifierTextureComponent
    {
    }

    [Export(typeof(ITargetModifierComponent))]
    public class TargetModifierComponent : ITargetModifierComponent
    {
    }

    public interface ITargetModifierComponent
    {
    }

    [Export(typeof(ITargetModifierTextureComponent))]
    public class TargetModifierTextureComponent : ITargetModifierTextureComponent
    {
    }

    public interface ITargetModifierTextureComponent
    {
    }

    [Export(typeof(IActiveComponent))]
    public class ActiveComponent : IActiveComponent
    {
    }

    public interface IActiveComponent
    {
    }

    [Export(typeof(ICircleComponent))]
    public class CircleComponent : ICircleComponent
    {
    }

    public interface ICircleComponent
    {
    }

    [Export(typeof(IConeComponent))]
    public class ConeComponent : IConeComponent
    {
    }

    public interface IConeComponent
    {
    }

    [Export(typeof(IAutocastComponent))]
    public class AutocastComponent : IAutocastComponent
    {
    }

    public interface IAutocastComponent
    {
    }

    [Export(typeof(IAreaOfEffectComponent))]
    public class AreaOfEffectComponent : IAreaOfEffectComponent
    {
    }

    public interface IAreaOfEffectComponent
    {
    }
}
// <copyright file="IActiveComponent.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Components
{
    using SharpDX;

    public interface IActiveComponent
    {
        bool CanBeCasted { get; }

        float CastPoint { get; }

        bool IsActivated { get; }

        float Speed { get; }

        bool CanHit(params Unit[] targets);

        int GetCastDelay();

        int GetCastDelay(Unit target);

        int GetCastDelay(Vector3 position);

        float GetDamage(params Unit[] targets);

        int GetHitTime(Unit target);

        int GetHitTime(Vector3 position);

        bool UseAbility();

        bool UseAbility(Rune target);

        bool UseAbility(Tree target);

        bool UseAbility(Unit target);

        bool UseAbility(Vector3 position);
    }
}
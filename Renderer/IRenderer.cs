// <copyright file="IRenderer.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.Renderer
{
    using System;

    using SharpDX;

    using Color = System.Drawing.Color;

    public interface IRenderer
    {
        event EventHandler Draw;

        void DrawCircle(Vector2 center, float radius, Color color);

        void DrawLine(Vector2 start, Vector2 end, Color color, float width = 1.0f);

        void DrawRectangle(RectangleF rect, Color color, float width = 1.0f);

        void DrawText(Vector2 position, string text, Color color, string fontFamily = "Calibri", float fontSize = 13f);
    }
}
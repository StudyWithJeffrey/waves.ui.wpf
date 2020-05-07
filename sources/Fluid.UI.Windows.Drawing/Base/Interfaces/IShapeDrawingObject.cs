﻿using Fluid.Core.Base;

namespace Fluid.UI.Windows.Drawing.Base.Interfaces
{
    /// <summary>
    /// Interface of primitive drawing object.
    /// </summary>
    public interface IShapeDrawingObject : IDrawingObject
    {
        /// <summary>
        /// Gets or sets height.
        /// </summary>
        float Height { get; set; }

        /// <summary>
        /// Gets or sets width.
        /// </summary>
        float Width { get; set; }

        /// <summary>
        /// Gets or sets location.
        /// </summary>
        Point Location { get; set; }
    }
}
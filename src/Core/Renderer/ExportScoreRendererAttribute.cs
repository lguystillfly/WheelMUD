﻿//-----------------------------------------------------------------------------
// <copyright file="ExportScoreRendererAttribute.cs" company="WheelMUD Development Team">
//   Copyright (c) WheelMUD Development Team.  See LICENSE.txt.  This file is 
//   subject to the Microsoft Public License.  All other rights reserved.
// </copyright>
//-----------------------------------------------------------------------------

namespace WheelMUD.Core.Renderer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Composition;
    using WheelMUD.Interfaces;
    using WheelMUD.Utilities;

    /// <summary>Class for exporting a Score renderer for composition into the WheelMUD framework.</summary>
    [MetadataAttribute]
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class ExportScoreRendererAttribute : ExportAttribute, IExportWithPriority
    {
        /// <summary>Initializes a new instance of the class.</summary>
        /// <param name="rendererPriority">The priority for this renderer. Highest number among composed renderers gets used.</param>
        /// <remarks></remarks>
        public ExportScoreRendererAttribute(int rendererPriority)
            : base(typeof(RendererDefinitions.Score))
        {
            this.Priority = rendererPriority;
        }

        /// <summary>Initializes a new instance of the class.</summary>
        /// <param name="metadata">The metadata.</param>
        public ExportScoreRendererAttribute(IDictionary<string, object> metadata)
        {
            PropertyTools.SetProperties(this, metadata);
        }

        /// <summary>Gets or sets the priority of the exported renderer; the renderer with the highest priority will be used.</summary>
        public int Priority { get; set; }
    }
}
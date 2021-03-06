﻿using System;
using System.Collections.Generic;
using System.Windows;
using Waves.Core.Base;

namespace Waves.UI.WPF.Base
{
    /// <summary>
    /// Accent color set.
    /// </summary>
    public class AccentColorSet : UI.Services.AccentColorSet
    {
        private const string ColorKey = "Accent-Color";
        private const string ForegroundColorKey = "Accent-Color-Foreground";

        private readonly int[] _colorWeights = { 100, 200, 300, 400, 500, 600, 700, 800, 900 };
        private readonly int[] _foregroundColorWeights = { 100, 500, 900 };

        /// <summary>
        /// Creates new instance of <see cref="AccentColorSet"/>.
        /// </summary>
        /// <param name="id">Color set's id.</param>
        /// <param name="name">Color set's name.</param>
        /// <param name="resourceDictionary">Resource dictionary.</param>
        public AccentColorSet(Guid id, string name, ResourceDictionary resourceDictionary) : base(id, name)
        {
            ResourceDictionary = resourceDictionary;

            InitializeColors();
        }

        /// <summary>
        /// Gets color resource dictionary.
        /// </summary>
        public ResourceDictionary ResourceDictionary { get; private set; }

        /// <summary>
        /// Initializes colors.
        /// </summary>
        private void InitializeColors()
        {
            ColorDictionary.Clear();
            ForegroundColorDictionary.Clear();

            var colorDictionary = Extensions.ResourceDictionary.GetColorsDictionary(ResourceDictionary, ColorKey, _colorWeights);
            var foregroundColorDictionary = Extensions.ResourceDictionary.GetColorsDictionary(ResourceDictionary, ForegroundColorKey, _foregroundColorWeights);

            foreach (var pair in colorDictionary) 
                ColorDictionary.Add(pair.Key, pair.Value);

            foreach (var pair in foregroundColorDictionary)
                ForegroundColorDictionary.Add(pair.Key, pair.Value);
        }
    }
}
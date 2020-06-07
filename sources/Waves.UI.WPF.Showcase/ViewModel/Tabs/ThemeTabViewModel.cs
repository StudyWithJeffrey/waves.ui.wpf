﻿using Waves.Presentation.Base;
using Waves.UI.Services.Interfaces;

namespace Waves.UI.WPF.Showcase.ViewModel.Tabs
{
    /// <summary>
    /// Theme tab view model.
    /// </summary>
    public class ThemeTabViewModel : PresentationViewModel
    {
        /// <summary>
        /// Gets theme service.
        /// </summary>
        public IThemeService ThemeService { get; private set; }

        /// <inheritdoc />
        public override void Initialize()
        {
            ThemeService = App.Core.GetService<IThemeService>();
        }
    }
}
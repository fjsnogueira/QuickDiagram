﻿using System.Windows;

namespace Codartis.SoftVis.UI.Wpf.View
{
    /// <summary>
    /// Defines properties for zoomable visual elements.
    /// </summary>
    public class ZoomableVisual : DependencyObject
    {
        private const double MinZoomDefault = .1;
        private const double MaxZoomDefault = 10;
        private const double InitialZoomDefault = 1;

        public static readonly DependencyProperty MinZoomProperty =
            DependencyProperty.RegisterAttached("MinZoom", typeof(double), typeof(ZoomableVisual), 
                new FrameworkPropertyMetadata(MinZoomDefault, FrameworkPropertyMetadataOptions.Inherits));

        public static readonly DependencyProperty MaxZoomProperty =
            DependencyProperty.RegisterAttached("MaxZoom", typeof(double), typeof(ZoomableVisual),
                new FrameworkPropertyMetadata(MaxZoomDefault, FrameworkPropertyMetadataOptions.Inherits));

        public static readonly DependencyProperty InitialZoomProperty =
            DependencyProperty.RegisterAttached("InitialZoom", typeof(double), typeof(ZoomableVisual),
                new FrameworkPropertyMetadata(InitialZoomDefault, FrameworkPropertyMetadataOptions.Inherits));

        public static void SetMinZoom(UIElement element, double value) => element.SetValue(MinZoomProperty, value);
        public static double GetMinZoom(UIElement element) => (double)element.GetValue(MinZoomProperty);

        public static void SetMaxZoom(UIElement element, double value) => element.SetValue(MaxZoomProperty, value);
        public static double GetMaxZoom(UIElement element) => (double)element.GetValue(MaxZoomProperty);

        public static void SetInitialZoom(UIElement element, double value) => element.SetValue(InitialZoomProperty, value);
        public static double GetInitialZoom(UIElement element) => (double)element.GetValue(InitialZoomProperty);

        public double MinZoom
        {
            get { return (double)GetValue(MinZoomProperty); }
            set { SetValue(MinZoomProperty, value); }
        }

        public double MaxZoom
        {
            get { return (double)GetValue(MaxZoomProperty); }
            set { SetValue(MaxZoomProperty, value); }
        }

        public double InitialZoom
        {
            get { return (double)GetValue(InitialZoomProperty); }
            set { SetValue(InitialZoomProperty, value); }
        }
    }
}

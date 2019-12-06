using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SlidersLib
{
    /// <summary>
    /// Interaktionslogik für DoubleThumbSlider.xaml
    /// </summary>
    public partial class DoubleThumbSlider : UserControl
    {
        public static readonly DependencyProperty MinimumProperty = DependencyProperty.Register("Minimum", typeof(double), typeof(DoubleThumbSlider), new PropertyMetadata());
        public static readonly DependencyProperty MaximumProperty = DependencyProperty.Register("Maximum", typeof(double), typeof(DoubleThumbSlider), new PropertyMetadata());
        public static readonly DependencyProperty FirstSliderValueProperty = DependencyProperty.Register("FirstSliderValue", typeof(double), typeof(DoubleThumbSlider), new PropertyMetadata());
        public static readonly DependencyProperty SecondSliderValueProperty = DependencyProperty.Register("SecondSliderValue", typeof(double), typeof(DoubleThumbSlider), new PropertyMetadata());
        public static readonly DependencyProperty IsSnapToTickEnabledProperty = DependencyProperty.Register("IsSnapToTickEnabled", typeof(bool), typeof(DoubleThumbSlider), new PropertyMetadata());
        public static readonly DependencyProperty TickFrequencyProperty = DependencyProperty.Register("TickFrequency", typeof(double), typeof(DoubleThumbSlider), new PropertyMetadata());
        public static readonly DependencyProperty TickPlacementProperty = DependencyProperty.Register("TickPlacement", typeof(TickPlacement), typeof(DoubleThumbSlider), new PropertyMetadata());
        public static readonly DependencyProperty TicksProperty = DependencyProperty.Register("Ticks", typeof(DoubleCollection), typeof(DoubleThumbSlider), new PropertyMetadata());

        public double Minimum
        {
            get => (double)GetValue(MinimumProperty);
            set => SetValue(MinimumProperty, value);
        }

        public double Maximum
        {
            get => (double)GetValue(MaximumProperty);
            set => SetValue(MaximumProperty, value);
        }

        public double FirstSliderValue
        {
            get => (double)GetValue(FirstSliderValueProperty);
            set => SetValue(FirstSliderValueProperty, value);
        }

        public double SecondSliderValue
        {
            get => (double)GetValue(SecondSliderValueProperty);
            set => SetValue(SecondSliderValueProperty, value);
        }

        public bool IsSnapToTickEnabled
        {
            get => (bool)GetValue(IsSnapToTickEnabledProperty);
            set => SetValue(IsSnapToTickEnabledProperty, value);
        }

        public double TickFrequency
        {
            get => (double)GetValue(TickFrequencyProperty);
            set => SetValue(TickFrequencyProperty, value);
        }

        public TickPlacement TickPlacement
        {
            get => (TickPlacement)GetValue(TickPlacementProperty);
            set => SetValue(TickPlacementProperty, value);
        }

        public DoubleCollection Ticks
        {
            get => (DoubleCollection)GetValue(TicksProperty);
            set => SetValue(TicksProperty, value);
        }

        public DoubleThumbSlider()
        {
            InitializeComponent();
        }
    }
}

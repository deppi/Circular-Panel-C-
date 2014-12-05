using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Threading;
using System.Windows.Shapes;
using System.Windows.Media;

namespace CircularPanel
{
    class MyCircularPanel : Canvas
    {
        private double _a = 0.0, _b = 0.0;
        System.Windows.Size window_size;
        Rectangle _selectedRectangle;

        public double Angle
        {
            get { return (double)GetValue(AngleProperty); }
            set { SetValue(AngleProperty, value); }
        }

        public static readonly DependencyProperty AngleProperty =
               DependencyProperty.Register("Angle", typeof(double), typeof(MyCircularPanel), 
               new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsArrange));

        protected override Size ArrangeOverride(System.Windows.Size finalSize)
        {
            base.ArrangeOverride(finalSize);

            var anglePerItem = 2*Math.PI/InternalChildren.Count;
            var convertedangle = DegToRad(Angle);

            foreach (UIElement internalChild in InternalChildren)
            {
                double x = _a * Math.Cos(convertedangle) + finalSize.Width / 2 - internalChild.DesiredSize.Width / 2;
                double y = _b * Math.Sin(convertedangle) + finalSize.Height / 2 - internalChild.DesiredSize.Height / 2;

                internalChild.Arrange(new Rect(new Point(x, y), internalChild.DesiredSize));
                convertedangle += anglePerItem;
            }

            return finalSize;
        }

        private double DegToRad(double deg)
        {
            return deg * (Math.PI / 180);
        }

        public void addElement(Rectangle elem)
        {
            this.Children.Add(elem);
        }

        public void removeElement()
        {
            if (this.Children.Count > 0)
            {
                this.Children.Remove(_selectedRectangle);
            }
        }

        protected override Size MeasureOverride(System.Windows.Size availableSize)
        {
            base.MeasureOverride(availableSize);

            if (window_size != availableSize) // avoid re-doing this same calculation if the window is the same size
            {
                double maxWidth = 0, maxHeight = 0;
                foreach (Rectangle internalChild in InternalChildren)
                {
                    internalChild.Measure(availableSize);
                    if (maxWidth < internalChild.DesiredSize.Width)
                    {
                        maxWidth = internalChild.DesiredSize.Width;
                    }
                    if (maxHeight < internalChild.DesiredSize.Height)
                    {
                        maxHeight = internalChild.DesiredSize.Height;
                    }
                }
                _a = availableSize.Width / 2 - maxWidth / 2; // WIDTH of the ellipse
                _b = availableSize.Height / 2 - maxHeight / 2; // HEIGHT of the ellipse
            }
            window_size = availableSize;
            return availableSize;
        }

        internal void selectRectangle(Rectangle rectangle)
        {
            if (rectangle != null)
            {
                if (_selectedRectangle != null) _selectedRectangle.StrokeThickness = 0;
                _selectedRectangle = rectangle;
                _selectedRectangle.Stroke = new SolidColorBrush(Colors.Black);
                _selectedRectangle.StrokeThickness = 5;
            }
            else if (_selectedRectangle != null)
            {
                _selectedRectangle.StrokeThickness = 0;
                _selectedRectangle = null;
            }
        }
    }
}

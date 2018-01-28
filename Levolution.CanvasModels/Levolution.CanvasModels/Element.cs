using Levolution.Data.Plane;
using System.ComponentModel;

namespace Levolution.CanvasModels
{
    public class Element : INotifyPropertyChanged
    {
        /// <summary>
        /// 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged { add => _propertyChangedEventHandler += value; remove => _propertyChangedEventHandler -= value; }
        protected PropertyChangedEventHandler PropertyChangedEventHandler { get => _propertyChangedEventHandler; }
        private PropertyChangedEventHandler _propertyChangedEventHandler;

        /// <summary>
        /// 
        /// </summary>
        public IRectangle<double> Bounds { get => _bounds; set { _bounds = value; PropertyChangedEventHandler?.Invoke(this, _boundsPropertyChangedEventArgs); } }
        private IRectangle<double> _bounds = null;
        private PropertyChangedEventArgs _boundsPropertyChangedEventArgs = new PropertyChangedEventArgs(nameof(Bounds));
        
        /// <summary>
        /// Gets or sets the element opacity.
        /// </summary>
        public bool Visibility { get => _visibility; set { _visibility = value; PropertyChangedEventHandler?.Invoke(this, _visibilityPropertyChangedEventArgs); } }
        private bool _visibility = true;
        private PropertyChangedEventArgs _visibilityPropertyChangedEventArgs = new PropertyChangedEventArgs(nameof(Visibility));

        /// <summary>
        /// Gets or sets the element opacity.
        /// </summary>
        public double Opacity { get => _opacity; set { _opacity = value; PropertyChangedEventHandler?.Invoke(this, _opacityPropertyChangedEventArgs); } }
        private double _opacity = 1;
        private PropertyChangedEventArgs _opacityPropertyChangedEventArgs = new PropertyChangedEventArgs(nameof(Opacity));

        public Element()
        {
            PropertyChanged += OnPropertyChanged;
        }

        /// <summary>
        /// Invoked when any property changed.
        /// </summary>
        /// <param name="name">Property name.</param>
        protected virtual void OnPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
        }
    }
}

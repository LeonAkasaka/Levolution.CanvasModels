using System.ComponentModel;

namespace Levolution.CanvasModels
{
    /// <summary>
    /// 
    /// </summary>
    public class Image : Element
    {
        /// <summary>
        /// Gets or sets the image source.
        /// </summary>
        public string Source { get => _source; set { _source = value; PropertyChangedEventHandler?.Invoke(this, _sourcePropertyChangedEventArgs); } }
        private string _source;
        private PropertyChangedEventArgs _sourcePropertyChangedEventArgs = new PropertyChangedEventArgs(nameof(Source));

        /// <summary>
        /// 
        /// </summary>
        public Image() { }
    }
}

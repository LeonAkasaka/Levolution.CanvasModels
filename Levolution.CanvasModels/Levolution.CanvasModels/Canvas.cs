namespace Levolution.CanvasModels
{
    /// <summary>
    /// 
    /// </summary>
    public class Canvas
    {
        /// <summary>
        /// Gets virtual width.
        /// </summary>
        public double Width { get; }

        /// <summary>
        /// Gets virtual height.
        /// </summary>
        public double Height { get; }

        /// <summary>
        /// Gets or sets the <see cref="Element"/>.
        /// </summary>
        public Element Element { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Canvas() : this(1, 1) { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="width">Canvas virtual width.</param>
        /// <param name="height">Canvas virtual  height.</param>
        public Canvas(double width, double height)
        {

        }
    }
}

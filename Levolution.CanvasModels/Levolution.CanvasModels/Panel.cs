using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Levolution.CanvasModels
{
    /// <summary>
    /// 
    /// </summary>
    public class Panel : Element
    {
        /// <summary>
        /// Gets 
        /// </summary>
        public ICollection<Element> Children => _children;
        private ObservableCollection<Element> _children = new ObservableCollection<Element>();

        public Panel()
        {
            _children.CollectionChanged += OnChildrenCollectionChanged;
        }

        protected virtual void OnChildrenCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
        }
    }
}

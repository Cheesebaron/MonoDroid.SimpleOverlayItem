using System.Collections.Generic;
using System.Linq;

using Android.Content;
using Android.GoogleMaps;
using Android.Graphics.Drawables;
using Android.Graphics;

namespace MonoDroid.TestOverlayItem
{
    class MyItemizedOverlay : ItemizedOverlay
    {
        private List<MyOverlayItem> overlayItems = new List<MyOverlayItem>();
        private Context context;

        public MyItemizedOverlay(Context context, Drawable drawable)
            : base(BoundCenterBottom(drawable))
        {
            this.context = context;
            Populate();
        }

        public override int Size()
        {
            return overlayItems.Count;
        }

        public List<MyOverlayItem> OverlayItems
        {
            get { return overlayItems; }
        }

        protected override MyOverlayItem CreateItem(int index)
        {
            return overlayItems.ElementAt(index);
        }
    }
}
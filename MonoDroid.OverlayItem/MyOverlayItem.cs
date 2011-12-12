using Android.GoogleMaps;

namespace MonoDroid.SimpleOverlayItem
{
    class MyOverlayItem : OverlayItem
    {
        private float[] color;

        public MyOverlayItem(GeoPoint point, string title, string snippet, float[] color) 
            : base(point, title, snippet)
        {
		    this.color = color;
	    }

        public float[] Color
        {
            get { return color; }
        }
    }
}
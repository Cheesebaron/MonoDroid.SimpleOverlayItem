using System;

using Android.App;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.GoogleMaps;
using Android.Graphics.Drawables;

namespace MonoDroid.TestOverlayItem
{
    [Activity(Label = "MonoDroid.TestOverlayItem", MainLauncher = true, Icon = "@drawable/icon")]
    public class Activity1 : MapActivity
    {
        MapView mapView;
        MyItemizedOverlay myItemizedOverlay;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            mapView = new MapView(this, "<your key here>");
            mapView.LayoutParameters = new ViewGroup.LayoutParams(ViewGroup.LayoutParams.FillParent, ViewGroup.LayoutParams.FillParent);
            mapView.Satellite = true;

            SetContentView(mapView);

            Drawable marker = Resources.GetDrawable(Resource.Drawable.Icon); //these are the markers put on the map
            myItemizedOverlay = new MyItemizedOverlay(this, marker);
            mapView.Overlays.Add(myItemizedOverlay);
            mapView.PostInvalidate();
        }

        protected override bool IsRouteDisplayed
        {
            get { return false; }
        }
    }
}


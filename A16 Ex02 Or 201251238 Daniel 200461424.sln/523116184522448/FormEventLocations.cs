using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using GMap.NET.WindowsForms;
using GMap.NET;

namespace _523116184522448
{
    public partial class EventLocationsForm : Form
    {
        private FBAdapter m_FBAdapter;
        private GMapOverlay m_MarkersOverlay;

        public FBAdapter FBUtilities 
        {
            set { m_FBAdapter = value; }
        }

        public EventLocationsForm()
        {
            InitializeComponent();
        }

        private void loadMap()
        {
            gMapControl.Invoke(new Action(() => gMapControl.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance));
            gMapControl.Invoke(new Action(() => gMapControl.SetPositionByKeywords("dubnov, Tel Aviv, Israel")));
            m_MarkersOverlay = new GMapOverlay("markers");
            foreach (object obj in m_FBAdapter.Events)
            {
                if (m_FBAdapter.HasLocationEvent(obj))
                {
                    PointLatLng point = getLatLong(m_FBAdapter.GetLatLong(obj));
                    GMap.NET.WindowsForms.Markers.GMarkerGoogle marker = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(
                        point,
                        GMap.NET.WindowsForms.Markers.GMarkerGoogleType.red_small);
                    marker.ToolTipText = m_FBAdapter.GetEventName(obj);
                    m_MarkersOverlay.Markers.Add(marker);
                }
            }

            gMapControl.Invoke(new Action(() => gMapControl.Overlays.Add(m_MarkersOverlay)));
            gMapControl.Invoke(new Action(() => gMapControl.ZoomAndCenterMarkers(null)));
        }

        private void buttonFetchEvents_Click(object sender, EventArgs e)
        {
            new Thread(() => m_FBAdapter.fetchCollectionAsync(listBoxEvents, m_FBAdapter.Events, "Name")).Start();
            new Thread(() => loadMap()).Start();
        }

        private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {       
            if (m_FBAdapter.HasLocationEvent(listBoxEvents.SelectedItem))
            {
                gMapControl.Position = getLatLong(m_FBAdapter.GetLatLong(listBoxEvents.SelectedItem));
            }
            else
            {
                gMapControl.ZoomAndCenterMarkers(null);
            }
        }

        private PointLatLng getLatLong(PointD i_location)
        {
            PointLatLng coordinates;
            coordinates = new PointLatLng(i_location.X, i_location.Y);

            return coordinates;
        } 
    }
}

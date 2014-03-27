using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MissionPlanner
{
    class FieldHandler
    {
        /*
        void saveField()
        {
            if (drawnpolygon.Points.Count == 0)
            {
                return;
            }


            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Polygon (*.poly)|*.poly";
            sf.ShowDialog();
            if (sf.FileName != "")
            {
                try
                {
                    StreamWriter sw = new StreamWriter(sf.OpenFile());

                    sw.WriteLine("#saved by Mission Planner " + Application.ProductVersion);

                    if (drawnpolygon.Points.Count > 0)
                    {
                        foreach (var pll in drawnpolygon.Points)
                        {
                            sw.WriteLine(pll.Lat + " " + pll.Lng);
                        }

                        PointLatLng pll2 = drawnpolygon.Points[0];

                        sw.WriteLine(pll2.Lat + " " + pll2.Lng);
                    }

                    sw.Close();
                }
                catch { CustomMessageBox.Show("Failed to write fence file"); }
            }
        }*/
    }
}

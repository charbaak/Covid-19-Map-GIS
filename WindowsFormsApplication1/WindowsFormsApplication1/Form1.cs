using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MapWinGIS;
using AxMapWinGIS;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        int providerid;
        TileProviders providers;
        Shapefile _shape;
        int _idshape;
        public Form1()
        {
            InitializeComponent();
        }
       

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            axMap1.KnownExtents = tkKnownExtents.keUSA;

            providers = axMap1.Tiles.Providers;
            providerid = (int)tkTileProvider.ProviderCustom + 1017;

            providers.Add(providerid, "Bing_sat", "http://127.0.0.1/BING_GH/z{zoom}/{y}/{x}.jpg", tkTileProjection.SphericalMercator, 0, 10);

            axMap1.Tiles.ProviderId = providerid;
            axMap1.ZoomOut(1);
            axMap1.ZoomIn(1);
            GeoProjection proj = new GeoProjection();
            proj.SetGoogleMercator();

            _shape = new Shapefile();
           _shape.Open(@"D:\BD\level_2_administrative_areas.shp");
        
              //  _shape.Open(@"D:\WD\Countries_WGS84.shp");
            _shape = _shape.Reproject(proj, 1);
            _idshape=axMap1.AddLayer(_shape, true);


            _shape.DefaultDrawingOptions.FillTransparency = 0;
            for (int i = 0; i < _shape.NumFields; i++)
            {
                dataGridView1.Columns.Add(_shape.Field[i].Name, _shape.Field[i].Name);

            }

            for (int i = 0; i < _shape.NumFields; i++)
            {
                dataGridView1.Rows.Add();

                for (int j = 0; j < _shape.NumFields; j++)
                {

                    dataGridView1.Rows[i].Cells[j].Value = _shape.CellValue[j, i];
                }

            }

            showattribut();







        }
        public void showattribut()
        {

            axMap1.SendMouseDown = true;
            axMap1.CursorMode = tkCursorMode.cmIdentify;
            axMap1.ShapeIdentified += axmapshapeidentified;

        }
        void axmapshapeidentified(object sender, _DMapEvents_ShapeIdentifiedEvent e)
        {

            
         
            
             label1.Text = _shape.get_CellValue(1, e.shapeIndex).ToString();

             label2.Text = _shape.get_CellValue(2, e.shapeIndex).ToString();
             label3.Text = _shape.get_CellValue(3, e.shapeIndex).ToString();

             label4.Text = _shape.get_CellValue(3, e.shapeIndex).ToString();
       
             label5.Text = _shape.get_CellValue(4, e.shapeIndex).ToString();

             label6.Text = _shape.get_CellValue(5, e.shapeIndex).ToString();



        }


        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            //axMap1.TileProvider = MapWinGIS.tkTileProvider.OpenStreetMap;
            axMap1.KnownExtents = tkKnownExtents.keUSA;

            providers = axMap1.Tiles.Providers;
            providerid = (int)tkTileProvider.ProviderCustom + 1017;

            providers.Add(providerid, "Bing_sat", "http://127.0.0.1/BING_MH/z{zoom}/{y}/{x}.jpg", tkTileProjection.SphericalMercator, 0, 10);

            axMap1.Tiles.ProviderId = providerid;
            axMap1.ZoomOut(1);
            axMap1.ZoomIn(1);
            GeoProjection proj = new GeoProjection();
            proj.SetGoogleMercator();

            _shape = new Shapefile();
          //  _shape.Open(@"D:\BD\level_2_administrative_areas.shp");

             _shape.Open(@"D:\USA\ne_10m_admin_0_countries.shp");
            _shape = _shape.Reproject(proj, 1);
            _idshape = axMap1.AddLayer(_shape, true);


            _shape.DefaultDrawingOptions.FillTransparency = 0;
            for (int i = 0; i < _shape.NumFields; i++)
            {
                dataGridView1.Columns.Add(_shape.Field[i].Name, _shape.Field[i].Name);

            }

            for (int i = 0; i < _shape.NumFields; i++)
            {
                dataGridView1.Rows.Add();

                for (int j = 0; j < _shape.NumFields; j++)
                {

                    dataGridView1.Rows[i].Cells[j].Value = _shape.CellValue[j, i];
                }

            }

            showattribut();


        }



        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            axMap1.TileProvider = MapWinGIS.tkTileProvider.OpenHumanitarianMap;
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            axMap1.CursorMode = MapWinGIS.tkCursorMode.cmPan;
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            axMap1.CursorMode = MapWinGIS.tkCursorMode.cmZoomOut;
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            axMap1.CursorMode = MapWinGIS.tkCursorMode.cmMeasure;
        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            axMap1.CursorMode = MapWinGIS.tkCursorMode.cmMeasure;
            axMap1.Measuring.MeasuringType = MapWinGIS.tkMeasuringType.MeasureArea;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
   
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void axMap1_MouseDownEvent(object sender, _DMapEvents_MouseDownEvent e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {

        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

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
        string lab;
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
            panel6.Height = 2;
            panel6.Top = 1;
            panel7.Visible = false;
        }
        private void customizeDesign()
        {
            panel5.Visible = false;
            panel4.Visible = false;
        }
        private void hideSubmenu()
        {
            if (panel5.Visible == true)
                panel5.Visible = false;
            if (panel4.Visible == true)
                panel4.Visible = false;
        }
        private void showSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubmenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }
        public void showattribut()
        {
            //axMap1.ShapeIdentified -= axmapshapeidentified;
            axMap1.SendMouseDown = true;
            axMap1.CursorMode = tkCursorMode.cmIdentify;
            //axMap1.ShapeHighlighted += null;

            axMap1.ShapeIdentified += axmapshapeidentified;

        }
        void axmapshapeidentified(object sender, _DMapEvents_ShapeIdentifiedEvent e)
        {
      
            panel7.Visible=true;

            button11.Text = "Region: "+_shape.get_CellValue(2, e.shapeIndex).ToString();

            button12.Text = "Total Cases: " + _shape.get_CellValue(3, e.shapeIndex).ToString();
            button13.Text = _shape.get_CellValue(4, e.shapeIndex).ToString();

            button14.Text = _shape.get_CellValue(5, e.shapeIndex).ToString();
            button15.Text = "Active Cases: " + _shape.get_CellValue(6, e.shapeIndex).ToString();
            button16.Text = "New Cases: " + _shape.get_CellValue(7, e.shapeIndex).ToString();


            /*label3.Text = "Region: " + _shape.get_CellValue(1, e.shapeIndex).ToString();
            label4.Text = "Total Cases: " + _shape.get_CellValue(1, e.shapeIndex).ToString();
            label5.Text = _shape.get_CellValue(2, e.shapeIndex).ToString();
            label7.Text = _shape.get_CellValue(3, e.shapeIndex).ToString();*/
            bunifuCircleProgressbar1.Value = (Convert.ToInt32(_shape.get_CellValue(4, e.shapeIndex)) / (Convert.ToInt32(_shape.get_CellValue(4, e.shapeIndex))+ Convert.ToInt32(_shape.get_CellValue(5, e.shapeIndex)))) * 100;
            bunifuCircleProgressbar2.Value = (Convert.ToInt32(_shape.get_CellValue(5, e.shapeIndex)) / (Convert.ToInt32(_shape.get_CellValue(4, e.shapeIndex)) + Convert.ToInt32(_shape.get_CellValue(5, e.shapeIndex)))) * 100;
            //(current / maximum) * 100





        }
        public void showattribut2()
        {

            axMap2.SendMouseDown = true;
            axMap2.CursorMode = tkCursorMode.cmIdentify;
            //axMap1.CursorMode = tkCursorMode.cmNone;
            
            axMap2.ShapeIdentified += axmapshapeidentified2;

        }
        void axmapshapeidentified2(object sender, _DMapEvents_ShapeIdentifiedEvent e)
        {

            panel7.Visible = true;

            button11.Text = "Region: "+_shape.get_CellValue(4, e.shapeIndex).ToString();

            button12.Text = "Total Cases: " + _shape.get_CellValue(5, e.shapeIndex).ToString() + "71";
            button13.Text = _shape.get_CellValue(6, e.shapeIndex).ToString() + "3";

            button14.Text = _shape.get_CellValue(7, e.shapeIndex).ToString() + "83";
            button15.Text = "Active Cases: " + _shape.get_CellValue(8, e.shapeIndex).ToString() + "94";
            button16.Text = "New Cases: " + _shape.get_CellValue(9, e.shapeIndex).ToString();


            // label8.Text = "Region: " + _shape.get_CellValue(1, e.shapeIndex).ToString();
            //label10.Text = "Total Cases: " + _shape.get_CellValue(1, e.shapeIndex).ToString();
            //label11.Text = _shape.get_CellValue(2, e.shapeIndex).ToString();
            //label12.Text = _shape.get_CellValue(3, e.shapeIndex).ToString();






        }
        public void showattribut3()
        {

            axMap2.SendMouseDown = true;
            axMap2.CursorMode = tkCursorMode.cmIdentify;
            //axMap1.CursorMode = tkCursorMode.cmNone;

            axMap2.ShapeIdentified += axmapshapeidentified3;

        }
        void axmapshapeidentified3(object sender, _DMapEvents_ShapeIdentifiedEvent e)
        {

            panel7.Visible = true;

            button11.Text = "Region: " + _shape.get_CellValue(4, e.shapeIndex).ToString();

            button12.Text = "Total Cases: " + _shape.get_CellValue(5, e.shapeIndex).ToString() + "71";
            button13.Text = _shape.get_CellValue(6, e.shapeIndex).ToString() + "3";

            button14.Text = _shape.get_CellValue(7, e.shapeIndex).ToString() + "83";
            button15.Text = "Active Cases: " + _shape.get_CellValue(8, e.shapeIndex).ToString() + "94";
            button16.Text = "New Cases: " + _shape.get_CellValue(9, e.shapeIndex).ToString();


            // label8.Text = "Region: " + _shape.get_CellValue(1, e.shapeIndex).ToString();
            //label10.Text = "Total Cases: " + _shape.get_CellValue(1, e.shapeIndex).ToString();
            //label11.Text = _shape.get_CellValue(2, e.shapeIndex).ToString();
            //label12.Text = _shape.get_CellValue(3, e.shapeIndex).ToString();






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

        private void button1_Click(object sender, EventArgs e)
        {
            panel6.Height = button1.Height;
            panel6.Top = button1.Top;
            showSubmenu(panel4);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            showSubmenu(panel5);
            panel6.Height = button6.Height;
            panel6.Top = button6.Top;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            axMap2.Visible = false;
            axMap1.Visible = true;
            axMap1.Redraw();
            //button14.Text = "0";
            //axMap1.KnownExtents = tkKnownExtents.keUSA;

            providers = axMap1.Tiles.Providers;
            providerid = (int)tkTileProvider.ProviderCustom + 1009;

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
            _idshape = axMap1.AddLayer(_shape, true);


            _shape.DefaultDrawingOptions.FillTransparency = 0;
            /* for (int i = 0; i < _shape.NumFields; i++)
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

             }*/
            hideSubmenu();
            panel6.Height = button1.Height;
            panel6.Top = button1.Top;


            showattribut();


           
           // bunifuCircleProgressbar2.Margin = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axMap2.Visible = false;
            axMap1.Visible = true;
            axMap1.Redraw();
            //button14.Text = "0";
            //axMap1.KnownExtents = tkKnownExtents.keUSA;

            providers = axMap1.Tiles.Providers;
            providerid = (int)tkTileProvider.ProviderCustom + 1049;

            providers.Add(providerid, "Bing_sata", "http://127.0.0.1/BING_DMP/z{zoom}/{y}/{x}.jpg", tkTileProjection.SphericalMercator, 0, 13);

            axMap1.Tiles.ProviderId = providerid;
            axMap1.ZoomOut(1);
            axMap1.ZoomIn(1);
            GeoProjection proj = new GeoProjection();
            proj.SetGoogleMercator();

            _shape = new Shapefile();
            _shape.Open(@"D:\BD\dhaka_metropolitan_area_wasa_jurisdiction\dhaka_metropolitan_area_wasa_jurisdiction.shp");

            //  _shape.Open(@"D:\WD\Countries_WGS84.shp");
            _shape = _shape.Reproject(proj, 1);
            _idshape = axMap1.AddLayer(_shape, true);


            _shape.DefaultDrawingOptions.FillTransparency = 0;
            //_shape.DefaultDrawingOptions.FillVisible = true;
            /* for (int i = 0; i < _shape.NumFields; i++)
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

             }*/
            hideSubmenu();
            panel6.Height = button1.Height;
            panel6.Top = button1.Top;


            showattribut3();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            axMap2.Visible = false;
            axMap1.Visible = true;
            axMap1.Redraw();
            //button14.Text = "0";
            //axMap1.KnownExtents = tkKnownExtents.keUSA;

            providers = axMap1.Tiles.Providers;
            providerid = (int)tkTileProvider.ProviderCustom + 1089;

            providers.Add(providerid, "Bing_satap", "http://127.0.0.1/BTING_DMP/z{zoom}/{y}/{x}.png", tkTileProjection.SphericalMercator, 0, 15);

            axMap1.Tiles.ProviderId = providerid;
            axMap1.ZoomOut(1);
            axMap1.ZoomIn(1);
            GeoProjection proj = new GeoProjection();
            proj.SetGoogleMercator();

            _shape = new Shapefile();
            _shape.Open(@"D:\BD\dhaka_metropolitan_area_wasa_jurisdiction\dhaka_metropolitan_area_wasa_jurisdiction.shp");

            //  _shape.Open(@"D:\WD\Countries_WGS84.shp");
            _shape = _shape.Reproject(proj, 1);
            _idshape = axMap1.AddLayer(_shape, true);


            _shape.DefaultDrawingOptions.FillTransparency = 0;
            //_shape.DefaultDrawingOptions.FillVisible = true;
            /* for (int i = 0; i < _shape.NumFields; i++)
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

             }*/
            hideSubmenu();
            panel6.Height = button1.Height;
            panel6.Top = button1.Top;


            showattribut();
        }
        void label()
        {
            _shape.Labels.Generate("[" + lab + "]", tkLabelPositioning.lpCenter, false);
            _shape.Labels.FrameVisible = true;
            _shape.Labels.FrameType = tkLabelFrameType.lfRectangle;
            _shape.Labels.FrameBackColor = Convert.ToUInt32(ColorTranslator.ToOle(Color.Yellow));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            axMap1.Visible = false;
            axMap2.Visible = true;
            //axMap1.TileProvider = MapWinGIS.tkTileProvider.OpenStreetMap;
            // axMap2.KnownExtents = tkKnownExtents.keUSA;

            //bdddddddddddddddddddddd
            providers = axMap1.Tiles.Providers;
            providerid = (int)tkTileProvider.ProviderCustom + 1027;

            providers.Add(providerid, "Gmap_un", "http://127.0.0.1/BING_DMP/z{zoom}/{y}/{x}.jpg", tkTileProjection.SphericalMercator, 0, 10);

            axMap1.Tiles.ProviderId = providerid;
            axMap1.ZoomOut(1);
            axMap1.ZoomIn(1);
            GeoProjection proj1 = new GeoProjection();
            proj1.SetGoogleMercator();

            _shape = new Shapefile();
            _shape.Open(@"D:\BD\level_2_administrative_areas.shp");
            //_shape.Open(@"D:\USA\Dip2\ne_10m_admin_0_countries.shp");
            //  _shape.Open(@"D:\WD\Countries_WGS84.shp");
            _shape = _shape.Reproject(proj1, 1);
            _idshape = axMap1.AddLayer(_shape, true);


            _shape.DefaultDrawingOptions.FillTransparency = 0;
            showattribut();
            //bddddddddddddddddddddddddddddddd


            providers = axMap2.Tiles.Providers;
            providerid = (int)tkTileProvider.ProviderCustom + 1027;

            providers.Add(providerid, "Gmap_un", "http://127.0.0.1/BING_DMP/z{zoom}/{y}/{x}.jpg", tkTileProjection.SphericalMercator, 0, 10);

            axMap2.Tiles.ProviderId = providerid;
            axMap2.ZoomOut(1);
            axMap2.ZoomIn(1);
            GeoProjection proj = new GeoProjection();
            proj.SetGoogleMercator();

            _shape = new Shapefile();
            //  _shape.Open(@"D:\BD\level_2_administrative_areas.shp");

            _shape.Open(@"D:\BD\dhaka_metropolitan_area_wasa_jurisdiction.shp");
            _shape = _shape.Reproject(proj, 1);
            _idshape = axMap2.AddLayer(_shape, true);


            //_shape.DefaultDrawingOptions.FillTransparency = 0;
            /*for (int i = 0; i < _shape.NumFields; i++)
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

            }*/

            showattribut2();
            hideSubmenu();
            panel6.Height = button6.Height;
            panel6.Top = button6.Top;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            axMap1.Visible = false;
            axMap2.Visible = true;
            //axMap1.TileProvider = MapWinGIS.tkTileProvider.OpenStreetMap;
            // axMap2.KnownExtents = tkKnownExtents.keUSA;

            //bdddddddddddddddddddddd
            providers = axMap1.Tiles.Providers;
            providerid = (int)tkTileProvider.ProviderCustom + 1017;

            providers.Add(providerid, "Bing_sat", "http://127.0.0.1/BING_GH/z{zoom}/{y}/{x}.jpg", tkTileProjection.SphericalMercator, 0, 10);

            axMap1.Tiles.ProviderId = providerid;
            axMap1.ZoomOut(1);
            axMap1.ZoomIn(1);
            GeoProjection proj1 = new GeoProjection();
            proj1.SetGoogleMercator();

            _shape = new Shapefile();
            _shape.Open(@"D:\BD\level_2_administrative_areas.shp");
            //_shape.Open(@"D:\USA\Dip2\ne_10m_admin_0_countries.shp");
            //  _shape.Open(@"D:\WD\Countries_WGS84.shp");
            _shape = _shape.Reproject(proj1, 1);
            _idshape = axMap1.AddLayer(_shape, true);


            _shape.DefaultDrawingOptions.FillTransparency = 0;
            showattribut();
            //bddddddddddddddddddddddddddddddd


            providers = axMap2.Tiles.Providers;
            providerid = (int)tkTileProvider.ProviderCustom + 1017;

            providers.Add(providerid, "Bing_sat", "http://127.0.0.1/BING_MH/z{zoom}/{y}/{x}.jpg", tkTileProjection.SphericalMercator, 0, 10);

            axMap2.Tiles.ProviderId = providerid;
            axMap2.ZoomOut(1);
            axMap2.ZoomIn(1);
            GeoProjection proj = new GeoProjection();
            proj.SetGoogleMercator();

            _shape = new Shapefile();
            //  _shape.Open(@"D:\BD\level_2_administrative_areas.shp");

            _shape.Open(@"D:\USA\Dip2\ne_10m_admin_0_countries.shp");
            _shape = _shape.Reproject(proj, 1);
            _idshape = axMap2.AddLayer(_shape, true);


            _shape.DefaultDrawingOptions.FillTransparency = 0;
            /*for (int i = 0; i < _shape.NumFields; i++)
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

            }*/

            showattribut2();
            hideSubmenu();
            panel6.Height = button6.Height;
            panel6.Top = button6.Top;
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) lab = _shape.Field[3].Name;
            label();
            axMap1.Redraw();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked) lab = _shape.Field[6].Name;
            label();
            axMap1.Redraw();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked) lab = _shape.Field[7].Name;
            label();
            axMap1.Redraw();
        }

        private void bunifuTileButton4_Click_1(object sender, EventArgs e)
        {
            //Form2 optionForm = new Form2();
            //optionForm.Show();
            //this.Hide();
        }
    }
}

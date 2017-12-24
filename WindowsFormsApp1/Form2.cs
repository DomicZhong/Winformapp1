using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DotSpatial.Controls;
using DotSpatial.Plugins.Measure;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void map_Load(object sender, EventArgs e)
        {
  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlmap1.AddLayer();
        }

        private void btclean_Click(object sender, EventArgs e)
        {
            pnlmap1.ClearLayers();
        }

        private void btzoomin_Click(object sender, EventArgs e)
        {
            pnlmap1.ZoomIn();
        }

        private void btzoomout_Click(object sender, EventArgs e)
        {
            pnlmap1.ZoomOut();
        }

        private void btextend_Click(object sender, EventArgs e)
        {
            pnlmap1.ZoomToMaxExtent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pnlmap1.FunctionMode = DotSpatial.Controls.FunctionMode.Info;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //pnlmap1.GetMapFunction(DotSpatial.Plugins.Measure.MeasureMode.Distance;
            pnlmap1.FunctionMode = FunctionMode.Label;
        }

        private void btSelect_Click(object sender, EventArgs e)
        {
            pnlmap1.FunctionMode = DotSpatial.Controls.FunctionMode.Select;
        }

        private void btNone_Click(object sender, EventArgs e)
        {
            pnlmap1.FunctionMode = DotSpatial.Controls.FunctionMode.None;
        }

        private void btPan_Click_1(object sender, EventArgs e)
        {
            pnlmap1.FunctionMode = FunctionMode.Pan;
        }
    }
}

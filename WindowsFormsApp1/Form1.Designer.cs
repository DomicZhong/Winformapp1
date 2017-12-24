namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            DotSpatial.Controls.Legend legend3;
            this.spatialStatusStrip4 = new DotSpatial.Controls.SpatialStatusStrip();
            this.map3 = new DotSpatial.Controls.Map();
            this.spatialStatusStrip3 = new DotSpatial.Controls.SpatialStatusStrip();
            this.spatialToolStrip3 = new DotSpatial.Controls.SpatialToolStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            legend3 = new DotSpatial.Controls.Legend();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // legend3
            // 
            legend3.BackColor = System.Drawing.Color.White;
            legend3.ControlRectangle = new System.Drawing.Rectangle(0, 0, 176, 436);
            legend3.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.DocumentRectangle = new System.Drawing.Rectangle(0, 0, 187, 428);
            legend3.HorizontalScrollEnabled = true;
            legend3.Indentation = 30;
            legend3.IsInitialized = false;
            legend3.Location = new System.Drawing.Point(0, 0);
            legend3.MinimumSize = new System.Drawing.Size(5, 5);
            legend3.Name = "legend3";
            legend3.ProgressHandler = this.spatialStatusStrip4;
            legend3.ResetOnResize = false;
            legend3.SelectionFontColor = System.Drawing.Color.Black;
            legend3.SelectionHighlight = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            legend3.Size = new System.Drawing.Size(176, 436);
            legend3.TabIndex = 1;
            legend3.Text = "legend3";
            legend3.VerticalScrollEnabled = true;
            // 
            // spatialStatusStrip4
            // 
            this.spatialStatusStrip4.Location = new System.Drawing.Point(0, 396);
            this.spatialStatusStrip4.Name = "spatialStatusStrip4";
            this.spatialStatusStrip4.ProgressBar = null;
            this.spatialStatusStrip4.ProgressLabel = null;
            this.spatialStatusStrip4.Size = new System.Drawing.Size(712, 22);
            this.spatialStatusStrip4.TabIndex = 4;
            this.spatialStatusStrip4.Text = "spatialStatusStrip4";
            // 
            // map3
            // 
            this.map3.AllowDrop = true;
            this.map3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.map3.BackColor = System.Drawing.Color.White;
            this.map3.CollectAfterDraw = false;
            this.map3.CollisionDetection = false;
            this.map3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.map3.ExtendBuffer = false;
            this.map3.FunctionMode = DotSpatial.Controls.FunctionMode.None;
            this.map3.IsBusy = false;
            this.map3.IsZoomedToMaxExtent = false;
            this.map3.Legend = legend3;
            this.map3.Location = new System.Drawing.Point(0, 0);
            this.map3.Name = "map3";
            this.map3.ProgressHandler = this.spatialStatusStrip3;
            this.map3.ProjectionModeDefine = DotSpatial.Controls.ActionMode.Prompt;
            this.map3.ProjectionModeReproject = DotSpatial.Controls.ActionMode.Prompt;
            this.map3.RedrawLayersWhileResizing = false;
            this.map3.SelectionEnabled = true;
            this.map3.Size = new System.Drawing.Size(532, 436);
            this.map3.TabIndex = 0;
            this.map3.Load += new System.EventHandler(this.map3_Load);
            // 
            // spatialStatusStrip3
            // 
            this.spatialStatusStrip3.Location = new System.Drawing.Point(0, 418);
            this.spatialStatusStrip3.Name = "spatialStatusStrip3";
            this.spatialStatusStrip3.ProgressBar = null;
            this.spatialStatusStrip3.ProgressLabel = null;
            this.spatialStatusStrip3.Size = new System.Drawing.Size(712, 22);
            this.spatialStatusStrip3.TabIndex = 3;
            this.spatialStatusStrip3.Text = "spatialStatusStrip3";
            // 
            // spatialToolStrip3
            // 
            this.spatialToolStrip3.ApplicationManager = null;
            this.spatialToolStrip3.Location = new System.Drawing.Point(0, 0);
            this.spatialToolStrip3.Map = this.map3;
            this.spatialToolStrip3.Name = "spatialToolStrip3";
            this.spatialToolStrip3.Size = new System.Drawing.Size(712, 25);
            this.spatialToolStrip3.Stretch = true;
            this.spatialToolStrip3.TabIndex = 2;
            this.spatialToolStrip3.Text = "spatialToolStrip3";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(legend3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.map3);
            this.splitContainer1.Size = new System.Drawing.Size(712, 436);
            this.splitContainer1.SplitterDistance = 176;
            this.splitContainer1.TabIndex = 5;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(712, 440);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.spatialStatusStrip4);
            this.Controls.Add(this.spatialStatusStrip3);
            this.Controls.Add(this.spatialToolStrip3);
            this.Name = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DotSpatial.Controls.SpatialToolStrip spatialToolStrip1;
        private DotSpatial.Controls.Map map1;
        private DotSpatial.Controls.Legend legend1;
        private DotSpatial.Controls.SpatialStatusStrip spatialStatusStrip1;
        private DotSpatial.Controls.Map map2;
        private DotSpatial.Controls.Legend legend2;
        private DotSpatial.Controls.SpatialStatusStrip spatialStatusStrip2;
        private DotSpatial.Controls.SpatialToolStrip spatialToolStrip2;
        private DotSpatial.Controls.Map map3;
        private DotSpatial.Controls.SpatialStatusStrip spatialStatusStrip3;
        private DotSpatial.Controls.SpatialToolStrip spatialToolStrip3;
        private DotSpatial.Controls.SpatialStatusStrip spatialStatusStrip4;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}


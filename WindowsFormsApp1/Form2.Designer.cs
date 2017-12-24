namespace WindowsFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlOperation = new System.Windows.Forms.Panel();
            this.grbOperation = new System.Windows.Forms.GroupBox();
            this.btNone = new System.Windows.Forms.Button();
            this.btMeasure = new System.Windows.Forms.Button();
            this.btSelect = new System.Windows.Forms.Button();
            this.btInfo = new System.Windows.Forms.Button();
            this.btPan = new System.Windows.Forms.Button();
            this.btextend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btzoomout = new System.Windows.Forms.Button();
            this.btzoomin = new System.Windows.Forms.Button();
            this.btclean = new System.Windows.Forms.Button();
            this.btload = new System.Windows.Forms.Button();
            this.pnlMap = new System.Windows.Forms.Panel();
            this.pnlmap1 = new DotSpatial.Controls.Map();
            this.pnlOperation.SuspendLayout();
            this.grbOperation.SuspendLayout();
            this.pnlMap.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOperation
            // 
            this.pnlOperation.Controls.Add(this.grbOperation);
            this.pnlOperation.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOperation.Location = new System.Drawing.Point(0, 0);
            this.pnlOperation.Name = "pnlOperation";
            this.pnlOperation.Size = new System.Drawing.Size(657, 146);
            this.pnlOperation.TabIndex = 0;
            // 
            // grbOperation
            // 
            this.grbOperation.Controls.Add(this.btNone);
            this.grbOperation.Controls.Add(this.btMeasure);
            this.grbOperation.Controls.Add(this.btSelect);
            this.grbOperation.Controls.Add(this.btInfo);
            this.grbOperation.Controls.Add(this.btPan);
            this.grbOperation.Controls.Add(this.btextend);
            this.grbOperation.Controls.Add(this.label1);
            this.grbOperation.Controls.Add(this.btzoomout);
            this.grbOperation.Controls.Add(this.btzoomin);
            this.grbOperation.Controls.Add(this.btclean);
            this.grbOperation.Controls.Add(this.btload);
            this.grbOperation.Location = new System.Drawing.Point(12, 10);
            this.grbOperation.Name = "grbOperation";
            this.grbOperation.Size = new System.Drawing.Size(580, 128);
            this.grbOperation.TabIndex = 0;
            this.grbOperation.TabStop = false;
            this.grbOperation.Text = "工具";
            // 
            // btNone
            // 
            this.btNone.Location = new System.Drawing.Point(475, 89);
            this.btNone.Name = "btNone";
            this.btNone.Size = new System.Drawing.Size(75, 23);
            this.btNone.TabIndex = 6;
            this.btNone.Text = "&None";
            this.btNone.UseVisualStyleBackColor = true;
            this.btNone.Click += new System.EventHandler(this.btNone_Click);
            // 
            // btMeasure
            // 
            this.btMeasure.Location = new System.Drawing.Point(266, 89);
            this.btMeasure.Name = "btMeasure";
            this.btMeasure.Size = new System.Drawing.Size(75, 23);
            this.btMeasure.TabIndex = 6;
            this.btMeasure.Text = "&Measure";
            this.btMeasure.UseVisualStyleBackColor = true;
            this.btMeasure.Click += new System.EventHandler(this.button2_Click);
            // 
            // btSelect
            // 
            this.btSelect.Location = new System.Drawing.Point(372, 89);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(75, 23);
            this.btSelect.TabIndex = 6;
            this.btSelect.Text = "&Select";
            this.btSelect.UseVisualStyleBackColor = true;
            this.btSelect.Click += new System.EventHandler(this.btSelect_Click);
            // 
            // btInfo
            // 
            this.btInfo.Location = new System.Drawing.Point(163, 89);
            this.btInfo.Name = "btInfo";
            this.btInfo.Size = new System.Drawing.Size(75, 23);
            this.btInfo.TabIndex = 6;
            this.btInfo.Text = "In&fo";
            this.btInfo.UseVisualStyleBackColor = true;
            this.btInfo.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btPan
            // 
            this.btPan.Location = new System.Drawing.Point(60, 89);
            this.btPan.Name = "btPan";
            this.btPan.Size = new System.Drawing.Size(75, 23);
            this.btPan.TabIndex = 6;
            this.btPan.Text = "&Pan";
            this.btPan.UseVisualStyleBackColor = true;
            this.btPan.Click += new System.EventHandler(this.btPan_Click_1);
            // 
            // btextend
            // 
            this.btextend.Location = new System.Drawing.Point(475, 40);
            this.btextend.Name = "btextend";
            this.btextend.Size = new System.Drawing.Size(97, 23);
            this.btextend.TabIndex = 5;
            this.btextend.Text = "Zoom To &Extend";
            this.btextend.UseVisualStyleBackColor = true;
            this.btextend.Click += new System.EventHandler(this.btextend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F);
            this.label1.Location = new System.Drawing.Point(178, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Basic Map Operations";
            // 
            // btzoomout
            // 
            this.btzoomout.Location = new System.Drawing.Point(372, 40);
            this.btzoomout.Name = "btzoomout";
            this.btzoomout.Size = new System.Drawing.Size(75, 23);
            this.btzoomout.TabIndex = 3;
            this.btzoomout.Text = "Zoom &Out";
            this.btzoomout.UseVisualStyleBackColor = true;
            this.btzoomout.Click += new System.EventHandler(this.btzoomout_Click);
            // 
            // btzoomin
            // 
            this.btzoomin.Location = new System.Drawing.Point(266, 41);
            this.btzoomin.Name = "btzoomin";
            this.btzoomin.Size = new System.Drawing.Size(75, 23);
            this.btzoomin.TabIndex = 2;
            this.btzoomin.Text = "Zoom &In";
            this.btzoomin.UseVisualStyleBackColor = true;
            this.btzoomin.Click += new System.EventHandler(this.btzoomin_Click);
            // 
            // btclean
            // 
            this.btclean.Location = new System.Drawing.Point(149, 41);
            this.btclean.Name = "btclean";
            this.btclean.Size = new System.Drawing.Size(75, 23);
            this.btclean.TabIndex = 1;
            this.btclean.Text = "&Clear Map";
            this.btclean.UseVisualStyleBackColor = true;
            this.btclean.Click += new System.EventHandler(this.btclean_Click);
            // 
            // btload
            // 
            this.btload.Location = new System.Drawing.Point(36, 41);
            this.btload.Name = "btload";
            this.btload.Size = new System.Drawing.Size(75, 23);
            this.btload.TabIndex = 0;
            this.btload.Text = "Load Map &L";
            this.btload.UseVisualStyleBackColor = true;
            this.btload.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlMap
            // 
            this.pnlMap.Controls.Add(this.pnlmap1);
            this.pnlMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMap.Location = new System.Drawing.Point(0, 146);
            this.pnlMap.Name = "pnlMap";
            this.pnlMap.Size = new System.Drawing.Size(657, 272);
            this.pnlMap.TabIndex = 1;
            // 
            // pnlmap1
            // 
            this.pnlmap1.AllowDrop = true;
            this.pnlmap1.BackColor = System.Drawing.Color.White;
            this.pnlmap1.CollectAfterDraw = false;
            this.pnlmap1.CollisionDetection = false;
            this.pnlmap1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlmap1.ExtendBuffer = false;
            this.pnlmap1.FunctionMode = DotSpatial.Controls.FunctionMode.None;
            this.pnlmap1.IsBusy = false;
            this.pnlmap1.IsZoomedToMaxExtent = false;
            this.pnlmap1.Legend = null;
            this.pnlmap1.Location = new System.Drawing.Point(0, 0);
            this.pnlmap1.Name = "pnlmap1";
            this.pnlmap1.ProgressHandler = null;
            this.pnlmap1.ProjectionModeDefine = DotSpatial.Controls.ActionMode.Prompt;
            this.pnlmap1.ProjectionModeReproject = DotSpatial.Controls.ActionMode.Prompt;
            this.pnlmap1.RedrawLayersWhileResizing = false;
            this.pnlmap1.SelectionEnabled = true;
            this.pnlmap1.Size = new System.Drawing.Size(657, 272);
            this.pnlmap1.TabIndex = 0;
            this.pnlmap1.Load += new System.EventHandler(this.map_Load);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 418);
            this.Controls.Add(this.pnlMap);
            this.Controls.Add(this.pnlOperation);
            this.Name = "Form2";
            this.Text = "Form2";
            this.pnlOperation.ResumeLayout(false);
            this.grbOperation.ResumeLayout(false);
            this.grbOperation.PerformLayout();
            this.pnlMap.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOperation;
        private System.Windows.Forms.Panel pnlMap;
        private DotSpatial.Controls.Map pnlmap1;
        private System.Windows.Forms.GroupBox grbOperation;
        private System.Windows.Forms.Button btzoomout;
        private System.Windows.Forms.Button btload;
        private System.Windows.Forms.Button btextend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btzoomin;
        private System.Windows.Forms.Button btclean;
        private System.Windows.Forms.Button btNone;
        private System.Windows.Forms.Button btMeasure;
        private System.Windows.Forms.Button btSelect;
        private System.Windows.Forms.Button btInfo;
        private System.Windows.Forms.Button btPan;
    }
}
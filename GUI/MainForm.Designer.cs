/*

  This Source Code Form is subject to the terms of the Mozilla Public
  License, v. 2.0. If a copy of the MPL was not distributed with this
  file, You can obtain one at http://mozilla.org/MPL/2.0/.

  Copyright (C) 2009-2013 Michael Möller <mmoeller@openhardwaremonitor.org>

*/

namespace OpenHardwareMonitor.GUI {
  partial class MainForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.sensor = new Aga.Controls.Tree.TreeColumn();
      this.value = new Aga.Controls.Tree.TreeColumn();
      this.min = new Aga.Controls.Tree.TreeColumn();
      this.max = new Aga.Controls.Tree.TreeColumn();
      this.nodeImage = new Aga.Controls.Tree.NodeControls.NodeIcon();
      this.nodeCheckBox = new Aga.Controls.Tree.NodeControls.NodeCheckBox();
      this.nodeTextBoxText = new Aga.Controls.Tree.NodeControls.NodeTextBox();
      this.nodeTextBoxValue = new Aga.Controls.Tree.NodeControls.NodeTextBox();
      this.nodeTextBoxMin = new Aga.Controls.Tree.NodeControls.NodeTextBox();
      this.nodeTextBoxMax = new Aga.Controls.Tree.NodeControls.NodeTextBox();
      this.mainMenu = new System.Windows.Forms.MenuStrip();
      this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveReportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.sumbitReportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.MenuItem2 = new System.Windows.Forms.ToolStripSeparator();
      this.resetMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuItem5 = new System.Windows.Forms.ToolStripMenuItem();
      this.mainboardMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.cpuMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.ramMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.gpuMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.fanControllerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.hddMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuItem6 = new System.Windows.Forms.ToolStripSeparator();
      this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.viewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.resetMinMaxMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.MenuItem3 = new System.Windows.Forms.ToolStripSeparator();
      this.hiddenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.plotMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.gadgetMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.MenuItem1 = new System.Windows.Forms.ToolStripSeparator();
      this.columnsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.valueMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.minMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.maxMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.optionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.startMinMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.minTrayMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.minCloseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.startupMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.separatorMenuItem = new System.Windows.Forms.ToolStripSeparator();
      this.temperatureUnitsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.celsiusMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.fahrenheitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.plotLocationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.plotWindowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.plotBottomMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.plotRightMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.webMenuItemSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.webMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.runWebServerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.serverPortMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.logSensorsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.treeContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
      this.timer = new System.Windows.Forms.Timer(this.components);
      this.splitContainer = new OpenHardwareMonitor.GUI.SplitContainerAdv();
      this.treeView = new Aga.Controls.Tree.TreeViewAdv();
      this.logSeparatorMenuItem = new System.Windows.Forms.ToolStripSeparator();
      this.loggingIntervalMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.log1sMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.log5sMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.log10sMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.log30sMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.log1minMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.log5minMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.log10minMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.log30minMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.log2sMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.log2minMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.log1hMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.log2hMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.log6hMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.mainMenu.SuspendLayout();
      this.splitContainer.Panel1.SuspendLayout();
      this.splitContainer.SuspendLayout();
      this.SuspendLayout();
      //
      // sensor
      //
      this.sensor.Header = "Sensor";
      this.sensor.SortOrder = System.Windows.Forms.SortOrder.None;
      this.sensor.TooltipText = null;
      //
      // value
      //
      this.value.Header = "Value";
      this.value.SortOrder = System.Windows.Forms.SortOrder.None;
      this.value.TooltipText = null;
      //
      // min
      //
      this.min.Header = "Min";
      this.min.SortOrder = System.Windows.Forms.SortOrder.None;
      this.min.TooltipText = null;
      //
      // max
      //
      this.max.Header = "Max";
      this.max.SortOrder = System.Windows.Forms.SortOrder.None;
      this.max.TooltipText = null;

      //
      // nodeImage
      //
      this.nodeImage.DataPropertyName = "Image";
      this.nodeImage.LeftMargin = 1;
      this.nodeImage.ParentColumn = this.sensor;
      this.nodeImage.ScaleMode = Aga.Controls.Tree.ImageScaleMode.Fit;
      //
      // nodeCheckBox
      //
      this.nodeCheckBox.DataPropertyName = "Plot";
      this.nodeCheckBox.EditEnabled = true;
      this.nodeCheckBox.LeftMargin = 3;
      this.nodeCheckBox.ParentColumn = this.sensor;
      //
      // nodeTextBoxText
      //
      this.nodeTextBoxText.DataPropertyName = "Text";
      this.nodeTextBoxText.EditEnabled = true;
      this.nodeTextBoxText.IncrementalSearchEnabled = true;
      this.nodeTextBoxText.LeftMargin = 3;
      this.nodeTextBoxText.ParentColumn = this.sensor;
      this.nodeTextBoxText.Trimming = System.Drawing.StringTrimming.EllipsisCharacter;
      this.nodeTextBoxText.UseCompatibleTextRendering = true;
      //
      // nodeTextBoxValue
      //
      this.nodeTextBoxValue.DataPropertyName = "Value";
      this.nodeTextBoxValue.IncrementalSearchEnabled = true;
      this.nodeTextBoxValue.LeftMargin = 3;
      this.nodeTextBoxValue.ParentColumn = this.value;
      this.nodeTextBoxValue.Trimming = System.Drawing.StringTrimming.EllipsisCharacter;
      this.nodeTextBoxValue.UseCompatibleTextRendering = true;
      //
      // nodeTextBoxMin
      //
      this.nodeTextBoxMin.DataPropertyName = "Min";
      this.nodeTextBoxMin.IncrementalSearchEnabled = true;
      this.nodeTextBoxMin.LeftMargin = 3;
      this.nodeTextBoxMin.ParentColumn = this.min;
      this.nodeTextBoxMin.Trimming = System.Drawing.StringTrimming.EllipsisCharacter;
      this.nodeTextBoxMin.UseCompatibleTextRendering = true;
      //
      // nodeTextBoxMax
      //
      this.nodeTextBoxMax.DataPropertyName = "Max";
      this.nodeTextBoxMax.IncrementalSearchEnabled = true;
      this.nodeTextBoxMax.LeftMargin = 3;
      this.nodeTextBoxMax.ParentColumn = this.max;
      this.nodeTextBoxMax.Trimming = System.Drawing.StringTrimming.EllipsisCharacter;
      this.nodeTextBoxMax.UseCompatibleTextRendering = true;
      //
      // mainMenu
      //
      this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.viewMenuItem,
            this.optionsMenuItem,
            this.helpMenuItem});
      this.mainMenu.Location = new System.Drawing.Point(0, 0);
      this.mainMenu.Name = "mainMenu";
      //
      // fileMenuItem
      //
      this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveReportMenuItem,
            this.sumbitReportMenuItem,
            this.MenuItem2,
            this.resetMenuItem,
            this.menuItem5,
            this.menuItem6,
            this.exitMenuItem});
      this.fileMenuItem.Text = "File";
      //
      // saveReportMenuItem
      //
      this.saveReportMenuItem.Text = "Save Report...";
      this.saveReportMenuItem.Click += new System.EventHandler(this.saveReportMenuItem_Click);
      //
      // sumbitReportMenuItem
      //
      this.sumbitReportMenuItem.Text = "Submit Report...";
      this.sumbitReportMenuItem.Click += new System.EventHandler(this.sumbitReportMenuItem_Click);
      //
      // resetMenuItem
      //
      this.resetMenuItem.Text = "Reset";
      this.resetMenuItem.Click += new System.EventHandler(this.resetClick);
      //
      // menuItem5
      //
      this.menuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainboardMenuItem,
            this.cpuMenuItem,
            this.ramMenuItem,
            this.gpuMenuItem,
            this.fanControllerMenuItem,
            this.hddMenuItem});
      this.menuItem5.Text = "Hardware";
      //
      // mainboardMenuItem
      //
      this.mainboardMenuItem.Text = "Mainboard";
      //
      // cpuMenuItem
      //
      this.cpuMenuItem.Text = "CPU";
      //
      // ramMenuItem
      //
      this.ramMenuItem.Text = "RAM";
      //
      // gpuMenuItem
      //
      this.gpuMenuItem.Text = "GPU";
      //
      // fanControllerMenuItem
      //
      this.fanControllerMenuItem.Text = "Fan Controllers";
      //
      // hddMenuItem
      //
      this.hddMenuItem.Text = "Hard Disk Drives";
      //
      // exitMenuItem
      //
      this.exitMenuItem.Text = "Exit";
      this.exitMenuItem.Click += new System.EventHandler(this.exitClick);
      //
      // viewMenuItem
      //
      this.viewMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetMinMaxMenuItem,
            this.MenuItem3,
            this.hiddenMenuItem,
            this.plotMenuItem,
            this.gadgetMenuItem,
            this.MenuItem1,
            this.columnsMenuItem});
      this.viewMenuItem.Text = "View";
      //
      // resetMinMaxMenuItem
      //
      this.resetMinMaxMenuItem.Text = "Reset Min/Max";
      this.resetMinMaxMenuItem.Click += new System.EventHandler(this.resetMinMaxMenuItem_Click);
      //
      // hiddenMenuItem
      //
      this.hiddenMenuItem.Text = "Show Hidden Sensors";
      //
      // plotMenuItem
      //
      this.plotMenuItem.Text = "Show Plot";
      //
      // gadgetMenuItem
      //
      this.gadgetMenuItem.Text = "Show Gadget";
      //
      // columnsMenuItem
      //
      this.columnsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.valueMenuItem,
            this.minMenuItem,
            this.maxMenuItem});
      this.columnsMenuItem.Text = "Columns";
      //
      // valueMenuItem
      //
      this.valueMenuItem.Text = "Value";
      //
      // minMenuItem
      //
      this.minMenuItem.Text = "Min";
      //
      // maxMenuItem
      //
      this.maxMenuItem.Text = "Max";
      //
      // optionsMenuItem
      //
      this.optionsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startMinMenuItem,
            this.minTrayMenuItem,
            this.minCloseMenuItem,
            this.startupMenuItem,
            this.separatorMenuItem,
            this.temperatureUnitsMenuItem,
            this.plotLocationMenuItem,
            this.logSeparatorMenuItem,
            this.logSensorsMenuItem,
            this.loggingIntervalMenuItem,
            this.webMenuItemSeparator,
            this.webMenuItem});
      this.optionsMenuItem.Text = "Options";
      //
      // startMinMenuItem
      //
      this.startMinMenuItem.Text = "Start Minimized";
      //
      // minTrayMenuItem
      //
      this.minTrayMenuItem.Text = "Minimize To Tray";
      //
      // minCloseMenuItem
      //
      this.minCloseMenuItem.Text = "Minimize On Close";
      //
      // startupMenuItem
      //
      this.startupMenuItem.Text = "Run On Windows Startup";
      //
      // temperatureUnitsMenuItem
      //
      this.temperatureUnitsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.celsiusMenuItem,
            this.fahrenheitMenuItem});
      this.temperatureUnitsMenuItem.Text = "Temperature Unit";
      //
      // celsiusMenuItem
      //
      this.celsiusMenuItem.Text = "Celsius";
      this.celsiusMenuItem.Click += new System.EventHandler(this.celsiusMenuItem_Click);
      //
      // fahrenheitMenuItem
      //
      this.fahrenheitMenuItem.Text = "Fahrenheit";
      this.fahrenheitMenuItem.Click += new System.EventHandler(this.fahrenheitMenuItem_Click);
      //
      // plotLocationMenuItem
      //
      this.plotLocationMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plotWindowMenuItem,
            this.plotBottomMenuItem,
            this.plotRightMenuItem});
      this.plotLocationMenuItem.Text = "Plot Location";
      //
      // plotWindowMenuItem
      //
      this.plotWindowMenuItem.Text = "Window";
      //
      // plotBottomMenuItem
      //
      this.plotBottomMenuItem.Text = "Bottom";
      //
      // plotRightMenuItem
      //
      this.plotRightMenuItem.Text = "Right";
      //
      // webMenuItem
      //
      this.webMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runWebServerMenuItem,
            this.serverPortMenuItem});
      this.webMenuItem.Text = "Remote Web Server";
      //
      // runWebServerMenuItem
      //
      this.runWebServerMenuItem.Text = "Run";
      //
      // serverPortMenuItem
      //
      this.serverPortMenuItem.Text = "Port";
      this.serverPortMenuItem.Click += new System.EventHandler(this.serverPortMenuItem_Click);
      //
      // logSensorsMenuItem
      //
      this.logSensorsMenuItem.Text = "Log Sensors";
      //
      // helpMenuItem
      //
      this.helpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenuItem});
      this.helpMenuItem.Text = "Help";
      //
      // aboutMenuItem
      //
      this.aboutMenuItem.Text = "About";
      this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
      //
      // treeContextMenu
      //
      this.treeContextMenu.Name = "treeContextMenu";
      //
      // saveFileDialog
      //
      this.saveFileDialog.DefaultExt = "txt";
      this.saveFileDialog.FileName = "OpenHardwareMonitor.Report.txt";
      this.saveFileDialog.Filter = "Text Documents|*.txt|All Files|*.*";
      this.saveFileDialog.RestoreDirectory = true;
      this.saveFileDialog.Title = "Save Report As";
      //
      // timer
      //
      this.timer.Interval = 1000;
      this.timer.Tick += new System.EventHandler(this.timer_Tick);
      //
      // splitContainer
      //
      this.splitContainer.Border3DStyle = System.Windows.Forms.Border3DStyle.Raised;
      this.splitContainer.Color = System.Drawing.SystemColors.Control;
      this.splitContainer.Cursor = System.Windows.Forms.Cursors.Default;
      this.splitContainer.Location = new System.Drawing.Point(12, 12);
      this.splitContainer.Name = "splitContainer";
      this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
      //
      // splitContainer.Panel1
      //
      this.splitContainer.Panel1.Controls.Add(this.treeView);
      //
      // splitContainer.Panel2
      //
      this.splitContainer.Panel2.Cursor = System.Windows.Forms.Cursors.Default;
      this.splitContainer.Size = new System.Drawing.Size(386, 483);
      this.splitContainer.SplitterDistance = 354;
      this.splitContainer.SplitterWidth = 5;
      this.splitContainer.TabIndex = 3;
      //
      // treeView
      //
      this.treeView.BackColor = System.Drawing.SystemColors.Window;
      this.treeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.treeView.Columns.Add(this.sensor);
      this.treeView.Columns.Add(this.value);
      this.treeView.Columns.Add(this.min);
      this.treeView.Columns.Add(this.max);
      this.treeView.DefaultToolTipProvider = null;
      this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.treeView.DragDropMarkColor = System.Drawing.Color.Black;
      this.treeView.FullRowSelect = true;
      this.treeView.GridLineStyle = Aga.Controls.Tree.GridLineStyle.Horizontal;
      this.treeView.LineColor = System.Drawing.SystemColors.ControlDark;
      this.treeView.Location = new System.Drawing.Point(0, 0);
      this.treeView.Model = null;
      this.treeView.Name = "treeView";
      this.treeView.NodeControls.Add(this.nodeImage);
      this.treeView.NodeControls.Add(this.nodeCheckBox);
      this.treeView.NodeControls.Add(this.nodeTextBoxText);
      this.treeView.NodeControls.Add(this.nodeTextBoxValue);
      this.treeView.NodeControls.Add(this.nodeTextBoxMin);
      this.treeView.NodeControls.Add(this.nodeTextBoxMax);
      this.treeView.SelectedNode = null;
      this.treeView.Size = new System.Drawing.Size(386, 354);
      this.treeView.TabIndex = 0;
      this.treeView.Text = "treeView";
      this.treeView.UseColumns = true;
      this.treeView.NodeMouseDoubleClick += new System.EventHandler<Aga.Controls.Tree.TreeNodeAdvMouseEventArgs>(this.treeView_NodeMouseDoubleClick);
      this.treeView.Click += new System.EventHandler(this.treeView_Click);
      this.treeView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeView_MouseDown);
      this.treeView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.treeView_MouseMove);
      this.treeView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.treeView_MouseUp);
      //
      // loggingIntervalMenuItem
      //
      this.loggingIntervalMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.log1sMenuItem,
            this.log2sMenuItem,
            this.log5sMenuItem,
            this.log10sMenuItem,
            this.log30sMenuItem,
            this.log1minMenuItem,
            this.log2minMenuItem,
            this.log5minMenuItem,
            this.log10minMenuItem,
            this.log30minMenuItem,
            this.log1hMenuItem,
            this.log2hMenuItem,
            this.log6hMenuItem});
      this.loggingIntervalMenuItem.Text = "Logging Interval";
      //
      // log1sMenuItem
      //
      this.log1sMenuItem.Text = "1s";
      //
      // log5sMenuItem
      //
      this.log5sMenuItem.Text = "5s";
      //
      // log10sMenuItem
      //
      this.log10sMenuItem.Text = "10s";
      //
      // log30sMenuItem
      //
      this.log30sMenuItem.Text = "30s";
      //
      // log1minMenuItem
      //
      this.log1minMenuItem.Text = "1min";
      //
      // log5minMenuItem
      //
      this.log5minMenuItem.Text = "5min";
      //
      // log10minMenuItem
      //
      this.log10minMenuItem.Text = "10min";
      //
      // log30minMenuItem
      //
      this.log30minMenuItem.Text = "30min";
      //
      // log2sMenuItem
      //
      this.log2sMenuItem.Text = "2s";
      //
      // log2minMenuItem
      //
      this.log2minMenuItem.Text = "2min";
      //
      // log1hMenuItem
      //
      this.log1hMenuItem.Text = "1h";
      //
      // log2hMenuItem
      //
      this.log2hMenuItem.Text = "2h";
      //
      // log6hMenuItem
      //
      this.log6hMenuItem.Text = "6h";
      //
      // MainForm
      //
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(418, 554);
      this.Controls.Add(this.splitContainer);
      this.Controls.Add(this.mainMenu);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.mainMenu;
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
      this.Text = "Open Hardware Monitor";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.ResizeEnd += new System.EventHandler(this.MainForm_MoveOrResize);
      this.Move += new System.EventHandler(this.MainForm_MoveOrResize);
      this.mainMenu.ResumeLayout(false);
      this.mainMenu.PerformLayout();
      this.splitContainer.Panel1.ResumeLayout(false);
      this.splitContainer.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Aga.Controls.Tree.TreeViewAdv treeView;
    private System.Windows.Forms.MenuStrip mainMenu;
    private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
    private Aga.Controls.Tree.TreeColumn sensor;
    private Aga.Controls.Tree.TreeColumn value;
    private Aga.Controls.Tree.TreeColumn min;
    private Aga.Controls.Tree.TreeColumn max;
    private Aga.Controls.Tree.NodeControls.NodeIcon nodeImage;
    private Aga.Controls.Tree.NodeControls.NodeTextBox nodeTextBoxText;
    private Aga.Controls.Tree.NodeControls.NodeTextBox nodeTextBoxValue;
    private Aga.Controls.Tree.NodeControls.NodeTextBox nodeTextBoxMin;
    private Aga.Controls.Tree.NodeControls.NodeTextBox nodeTextBoxMax;
    private SplitContainerAdv splitContainer;
    private System.Windows.Forms.ToolStripMenuItem viewMenuItem;
    private System.Windows.Forms.ToolStripMenuItem plotMenuItem;
    private Aga.Controls.Tree.NodeControls.NodeCheckBox nodeCheckBox;
    private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveReportMenuItem;
    private System.Windows.Forms.ToolStripMenuItem optionsMenuItem;
    private System.Windows.Forms.ToolStripMenuItem hddMenuItem;
    private System.Windows.Forms.ToolStripMenuItem minTrayMenuItem;
    private System.Windows.Forms.ToolStripSeparator separatorMenuItem;
    private System.Windows.Forms.ContextMenuStrip treeContextMenu;
    private System.Windows.Forms.ToolStripMenuItem startMinMenuItem;
    private System.Windows.Forms.ToolStripMenuItem startupMenuItem;
    private System.Windows.Forms.SaveFileDialog saveFileDialog;
    private System.Windows.Forms.Timer timer;
    private System.Windows.Forms.ToolStripMenuItem hiddenMenuItem;
    private System.Windows.Forms.ToolStripSeparator MenuItem1;
    private System.Windows.Forms.ToolStripMenuItem columnsMenuItem;
    private System.Windows.Forms.ToolStripMenuItem valueMenuItem;
    private System.Windows.Forms.ToolStripMenuItem minMenuItem;
    private System.Windows.Forms.ToolStripMenuItem maxMenuItem;
    private System.Windows.Forms.ToolStripMenuItem temperatureUnitsMenuItem;
    private System.Windows.Forms.ToolStripSeparator webMenuItemSeparator;
    private System.Windows.Forms.ToolStripMenuItem celsiusMenuItem;
    private System.Windows.Forms.ToolStripMenuItem fahrenheitMenuItem;
    private System.Windows.Forms.ToolStripMenuItem sumbitReportMenuItem;
    private System.Windows.Forms.ToolStripSeparator MenuItem2;
    private System.Windows.Forms.ToolStripMenuItem resetMinMaxMenuItem;
    private System.Windows.Forms.ToolStripSeparator MenuItem3;
    private System.Windows.Forms.ToolStripMenuItem gadgetMenuItem;
    private System.Windows.Forms.ToolStripMenuItem minCloseMenuItem;
    private System.Windows.Forms.ToolStripMenuItem resetMenuItem;
    private System.Windows.Forms.ToolStripSeparator menuItem6;
    private System.Windows.Forms.ToolStripMenuItem plotLocationMenuItem;
    private System.Windows.Forms.ToolStripMenuItem plotWindowMenuItem;
    private System.Windows.Forms.ToolStripMenuItem plotBottomMenuItem;
    private System.Windows.Forms.ToolStripMenuItem plotRightMenuItem;
    private System.Windows.Forms.ToolStripMenuItem webMenuItem;
    private System.Windows.Forms.ToolStripMenuItem runWebServerMenuItem;
    private System.Windows.Forms.ToolStripMenuItem serverPortMenuItem;
    private System.Windows.Forms.ToolStripMenuItem menuItem5;
    private System.Windows.Forms.ToolStripMenuItem mainboardMenuItem;
    private System.Windows.Forms.ToolStripMenuItem cpuMenuItem;
    private System.Windows.Forms.ToolStripMenuItem gpuMenuItem;
    private System.Windows.Forms.ToolStripMenuItem fanControllerMenuItem;
    private System.Windows.Forms.ToolStripMenuItem ramMenuItem;
    private System.Windows.Forms.ToolStripMenuItem logSensorsMenuItem;
    private System.Windows.Forms.ToolStripSeparator logSeparatorMenuItem;
    private System.Windows.Forms.ToolStripMenuItem loggingIntervalMenuItem;
    private System.Windows.Forms.ToolStripMenuItem log1sMenuItem;
    private System.Windows.Forms.ToolStripMenuItem log2sMenuItem;
    private System.Windows.Forms.ToolStripMenuItem log5sMenuItem;
    private System.Windows.Forms.ToolStripMenuItem log10sMenuItem;
    private System.Windows.Forms.ToolStripMenuItem log30sMenuItem;
    private System.Windows.Forms.ToolStripMenuItem log1minMenuItem;
    private System.Windows.Forms.ToolStripMenuItem log2minMenuItem;
    private System.Windows.Forms.ToolStripMenuItem log5minMenuItem;
    private System.Windows.Forms.ToolStripMenuItem log10minMenuItem;
    private System.Windows.Forms.ToolStripMenuItem log30minMenuItem;
    private System.Windows.Forms.ToolStripMenuItem log1hMenuItem;
    private System.Windows.Forms.ToolStripMenuItem log2hMenuItem;
    private System.Windows.Forms.ToolStripMenuItem log6hMenuItem;
  }
}

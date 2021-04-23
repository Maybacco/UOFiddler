/***************************************************************************
 *
 * $Author: Turley
 * 
 * "THE BEER-WARE LICENSE"
 * As long as you retain this notice you can do whatever you want with 
 * this stuff. If we meet some day, and you think this stuff is worth it,
 * you can buy me a beer in return.
 *
 ***************************************************************************/

namespace UoFiddler.Controls.UserControls
{
    partial class MapControl
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
            if (disposing)
            {

            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapControl));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.CoordsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ClientLocLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ZoomLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.SelectedAreaLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.getMapInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertMarkerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.gotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TextBoxGoto = new System.Windows.Forms.ToolStripTextBox();
            this.sendClientToPosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hScrollBar = new System.Windows.Forms.HScrollBar();
            this.vScrollBar = new System.Windows.Forms.VScrollBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PreloadWorker = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gotoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.switchVisibleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OverlayObjectTree = new System.Windows.Forms.TreeView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton4 = new System.Windows.Forms.ToolStripDropDownButton();
            this.feluccaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trammelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilshenarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.malasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tokunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terMurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.showStaticsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.showCenterCrossToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.showMarkersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showClientCrossToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowRectanglesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.PreloadMap = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.defragStaticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defragAndRemoveDuplicatesStToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importStaticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meltStaticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearStaticsinMemoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportStaticsUnderMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.rewriteMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertDiffDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.replaceTilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton5 = new System.Windows.Forms.ToolStripDropDownButton();
            this.exportMapImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asBitmapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asTiffToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.asJpegToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asPngToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exportDiffPackageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportJsonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton6 = new System.Windows.Forms.ToolStripDropDownButton();
            this.importTBTDIFFPackageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importJsonPackageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiTBTDiffImportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton7 = new System.Windows.Forms.ToolStripDropDownButton();
            this.addSelectionToRegionAreasListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearRegionAreasListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exportAreasListToRegionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.exportResourceRegionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.showClientLocToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.gotoClientLocToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sendClientToCenterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.collapsibleSplitter2 = new UoFiddler.Controls.UserControls.CollapsibleSplitter();
            this.collapsibleSplitter1 = new UoFiddler.Controls.UserControls.CollapsibleSplitter();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.statusStrip.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CoordsLabel,
            this.ClientLocLabel,
            this.ZoomLabel,
            this.SelectedAreaLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 296);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(623, 33);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // CoordsLabel
            // 
            this.CoordsLabel.AutoSize = false;
            this.CoordsLabel.Name = "CoordsLabel";
            this.CoordsLabel.Size = new System.Drawing.Size(120, 28);
            this.CoordsLabel.Text = "Coords: 0,0";
            this.CoordsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ClientLocLabel
            // 
            this.ClientLocLabel.AutoSize = false;
            this.ClientLocLabel.Name = "ClientLocLabel";
            this.ClientLocLabel.Size = new System.Drawing.Size(160, 28);
            this.ClientLocLabel.Text = "ClientLoc: 0,0";
            this.ClientLocLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ZoomLabel
            // 
            this.ZoomLabel.AutoSize = false;
            this.ZoomLabel.Name = "ZoomLabel";
            this.ZoomLabel.Size = new System.Drawing.Size(100, 28);
            this.ZoomLabel.Text = "Zoom: ";
            this.ZoomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SelectedAreaLabel
            // 
            this.SelectedAreaLabel.Name = "SelectedAreaLabel";
            this.SelectedAreaLabel.Size = new System.Drawing.Size(141, 28);
            this.SelectedAreaLabel.Text = "Selected Area: (0,0) - (0,0)";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getMapInfoToolStripMenuItem,
            this.insertMarkerToolStripMenuItem,
            this.toolStripSeparator4,
            this.gotoToolStripMenuItem,
            this.sendClientToPosToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(172, 98);
            this.contextMenuStrip1.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(this.OnContextClosed);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.OnOpenContext);
            // 
            // getMapInfoToolStripMenuItem
            // 
            this.getMapInfoToolStripMenuItem.Name = "getMapInfoToolStripMenuItem";
            this.getMapInfoToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.getMapInfoToolStripMenuItem.Text = "GetMapInfo";
            this.getMapInfoToolStripMenuItem.Click += new System.EventHandler(this.GetMapInfo);
            // 
            // insertMarkerToolStripMenuItem
            // 
            this.insertMarkerToolStripMenuItem.Name = "insertMarkerToolStripMenuItem";
            this.insertMarkerToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.insertMarkerToolStripMenuItem.Text = "Insert Marker";
            this.insertMarkerToolStripMenuItem.Click += new System.EventHandler(this.OnClickInsertMarker);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(168, 6);
            // 
            // gotoToolStripMenuItem
            // 
            this.gotoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TextBoxGoto});
            this.gotoToolStripMenuItem.Name = "gotoToolStripMenuItem";
            this.gotoToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.gotoToolStripMenuItem.Text = "Goto...";
            this.gotoToolStripMenuItem.DropDownClosed += new System.EventHandler(this.OnDropDownClosed);
            // 
            // TextBoxGoto
            // 
            this.TextBoxGoto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxGoto.Name = "TextBoxGoto";
            this.TextBoxGoto.Size = new System.Drawing.Size(100, 23);
            this.TextBoxGoto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDownGoto);
            // 
            // sendClientToPosToolStripMenuItem
            // 
            this.sendClientToPosToolStripMenuItem.Name = "sendClientToPosToolStripMenuItem";
            this.sendClientToPosToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.sendClientToPosToolStripMenuItem.Text = "Send Client To Pos";
            this.sendClientToPosToolStripMenuItem.Click += new System.EventHandler(this.OnClickSendClientToPos);
            // 
            // hScrollBar
            // 
            this.hScrollBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hScrollBar.Location = new System.Drawing.Point(0, 279);
            this.hScrollBar.Name = "hScrollBar";
            this.hScrollBar.Size = new System.Drawing.Size(398, 17);
            this.hScrollBar.TabIndex = 2;
            this.hScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HandleScroll);
            // 
            // vScrollBar
            // 
            this.vScrollBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar.Location = new System.Drawing.Point(398, 35);
            this.vScrollBar.Name = "vScrollBar";
            this.vScrollBar.Size = new System.Drawing.Size(17, 261);
            this.vScrollBar.TabIndex = 3;
            this.vScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HandleScroll);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.SyncClientTimer);
            // 
            // PreloadWorker
            // 
            this.PreloadWorker.WorkerReportsProgress = true;
            this.PreloadWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.PreLoadDoWork);
            this.PreloadWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.PreLoadProgressChanged);
            this.PreloadWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.PreLoadCompleted);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gotoToolStripMenuItem1,
            this.removeToolStripMenuItem,
            this.switchVisibleToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(157, 70);
            this.contextMenuStrip2.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(this.OnContextClosed);
            // 
            // gotoToolStripMenuItem1
            // 
            this.gotoToolStripMenuItem1.Name = "gotoToolStripMenuItem1";
            this.gotoToolStripMenuItem1.Size = new System.Drawing.Size(156, 22);
            this.gotoToolStripMenuItem1.Text = "Goto";
            this.gotoToolStripMenuItem1.Click += new System.EventHandler(this.OnClickGotoMarker);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.OnClickRemoveMarker);
            // 
            // switchVisibleToolStripMenuItem
            // 
            this.switchVisibleToolStripMenuItem.Name = "switchVisibleToolStripMenuItem";
            this.switchVisibleToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.switchVisibleToolStripMenuItem.Text = "Switch Visibility";
            this.switchVisibleToolStripMenuItem.Click += new System.EventHandler(this.OnClickSwitchVisible);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.OverlayObjectTree);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(423, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 261);
            this.panel1.TabIndex = 5;
            // 
            // OverlayObjectTree
            // 
            this.OverlayObjectTree.ContextMenuStrip = this.contextMenuStrip2;
            this.OverlayObjectTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OverlayObjectTree.Location = new System.Drawing.Point(0, 0);
            this.OverlayObjectTree.Name = "OverlayObjectTree";
            this.OverlayObjectTree.Size = new System.Drawing.Size(200, 261);
            this.OverlayObjectTree.TabIndex = 5;
            this.OverlayObjectTree.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.OnDoubleClickMarker);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton4,
            this.toolStripDropDownButton1,
            this.ProgressBar,
            this.PreloadMap,
            this.toolStripDropDownButton3,
            this.toolStripSeparator8,
            this.toolStripLabel1,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator9,
            this.toolStripDropDownButton5,
            this.toolStripDropDownButton6,
            this.toolStripSeparator10,
            this.toolStripDropDownButton7,
            this.toolStripSeparator12,
            this.toolStripDropDownButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(623, 27);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton4
            // 
            this.toolStripDropDownButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.feluccaToolStripMenuItem,
            this.trammelToolStripMenuItem,
            this.ilshenarToolStripMenuItem,
            this.malasToolStripMenuItem,
            this.tokunoToolStripMenuItem,
            this.terMurToolStripMenuItem});
            this.toolStripDropDownButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton4.Name = "toolStripDropDownButton4";
            this.toolStripDropDownButton4.Size = new System.Drawing.Size(44, 24);
            this.toolStripDropDownButton4.Text = "Map";
            // 
            // feluccaToolStripMenuItem
            // 
            this.feluccaToolStripMenuItem.Name = "feluccaToolStripMenuItem";
            this.feluccaToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.feluccaToolStripMenuItem.Text = "Felucca";
            this.feluccaToolStripMenuItem.Click += new System.EventHandler(this.ChangeMapFelucca);
            // 
            // trammelToolStripMenuItem
            // 
            this.trammelToolStripMenuItem.Name = "trammelToolStripMenuItem";
            this.trammelToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.trammelToolStripMenuItem.Text = "Trammel";
            this.trammelToolStripMenuItem.Click += new System.EventHandler(this.ChangeMapTrammel);
            // 
            // ilshenarToolStripMenuItem
            // 
            this.ilshenarToolStripMenuItem.Name = "ilshenarToolStripMenuItem";
            this.ilshenarToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.ilshenarToolStripMenuItem.Text = "Ilshenar";
            this.ilshenarToolStripMenuItem.Click += new System.EventHandler(this.ChangeMapIlshenar);
            // 
            // malasToolStripMenuItem
            // 
            this.malasToolStripMenuItem.Name = "malasToolStripMenuItem";
            this.malasToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.malasToolStripMenuItem.Text = "Malas";
            this.malasToolStripMenuItem.Click += new System.EventHandler(this.ChangeMapMalas);
            // 
            // tokunoToolStripMenuItem
            // 
            this.tokunoToolStripMenuItem.Name = "tokunoToolStripMenuItem";
            this.tokunoToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.tokunoToolStripMenuItem.Text = "Tokuno";
            this.tokunoToolStripMenuItem.Click += new System.EventHandler(this.ChangeMapTokuno);
            // 
            // terMurToolStripMenuItem
            // 
            this.terMurToolStripMenuItem.Name = "terMurToolStripMenuItem";
            this.terMurToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.terMurToolStripMenuItem.Text = "TerMur";
            this.terMurToolStripMenuItem.Click += new System.EventHandler(this.ChangeMapTerMur);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showStaticsToolStripMenuItem1,
            this.showCenterCrossToolStripMenuItem1,
            this.showMarkersToolStripMenuItem,
            this.showClientCrossToolStripMenuItem,
            this.ShowRectanglesMenuItem});
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(45, 24);
            this.toolStripDropDownButton1.Text = "View";
            this.toolStripDropDownButton1.DropDownClosed += new System.EventHandler(this.OnDropDownClosed);
            // 
            // showStaticsToolStripMenuItem1
            // 
            this.showStaticsToolStripMenuItem1.Checked = true;
            this.showStaticsToolStripMenuItem1.CheckOnClick = true;
            this.showStaticsToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showStaticsToolStripMenuItem1.Name = "showStaticsToolStripMenuItem1";
            this.showStaticsToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.showStaticsToolStripMenuItem1.Text = "Show Statics";
            this.showStaticsToolStripMenuItem1.Click += new System.EventHandler(this.OnChangeView);
            // 
            // showCenterCrossToolStripMenuItem1
            // 
            this.showCenterCrossToolStripMenuItem1.Checked = true;
            this.showCenterCrossToolStripMenuItem1.CheckOnClick = true;
            this.showCenterCrossToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showCenterCrossToolStripMenuItem1.Name = "showCenterCrossToolStripMenuItem1";
            this.showCenterCrossToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.showCenterCrossToolStripMenuItem1.Text = "Show Center Cross";
            this.showCenterCrossToolStripMenuItem1.Click += new System.EventHandler(this.OnChangeView);
            // 
            // showMarkersToolStripMenuItem
            // 
            this.showMarkersToolStripMenuItem.Checked = true;
            this.showMarkersToolStripMenuItem.CheckOnClick = true;
            this.showMarkersToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showMarkersToolStripMenuItem.Name = "showMarkersToolStripMenuItem";
            this.showMarkersToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.showMarkersToolStripMenuItem.Text = "Show Markers";
            this.showMarkersToolStripMenuItem.Click += new System.EventHandler(this.OnChangeView);
            // 
            // showClientCrossToolStripMenuItem
            // 
            this.showClientCrossToolStripMenuItem.Checked = true;
            this.showClientCrossToolStripMenuItem.CheckOnClick = true;
            this.showClientCrossToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showClientCrossToolStripMenuItem.Name = "showClientCrossToolStripMenuItem";
            this.showClientCrossToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.showClientCrossToolStripMenuItem.Text = "Show Client Cross";
            // 
            // ShowRectanglesMenuItem
            // 
            this.ShowRectanglesMenuItem.CheckOnClick = true;
            this.ShowRectanglesMenuItem.Name = "ShowRectanglesMenuItem";
            this.ShowRectanglesMenuItem.Size = new System.Drawing.Size(173, 22);
            this.ShowRectanglesMenuItem.Text = "Show Region Rect";
            // 
            // ProgressBar
            // 
            this.ProgressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(100, 24);
            // 
            // PreloadMap
            // 
            this.PreloadMap.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.PreloadMap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.PreloadMap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PreloadMap.Name = "PreloadMap";
            this.PreloadMap.Size = new System.Drawing.Size(78, 24);
            this.PreloadMap.Text = "Preload Map";
            this.PreloadMap.Click += new System.EventHandler(this.OnClickPreloadMap);
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defragStaticsToolStripMenuItem,
            this.defragAndRemoveDuplicatesStToolStripMenuItem,
            this.importStaticsToolStripMenuItem,
            this.meltStaticsToolStripMenuItem,
            this.clearStaticsinMemoryToolStripMenuItem,
            this.reportStaticsUnderMapToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripSeparator3,
            this.rewriteMapToolStripMenuItem,
            this.toolStripSeparator6,
            this.copyToolStripMenuItem,
            this.insertDiffDataToolStripMenuItem,
            this.toolStripSeparator7,
            this.replaceTilesToolStripMenuItem});
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(45, 24);
            this.toolStripDropDownButton3.Text = "Misc";
            this.toolStripDropDownButton3.DropDownClosed += new System.EventHandler(this.OnDropDownClosed);
            // 
            // defragStaticsToolStripMenuItem
            // 
            this.defragStaticsToolStripMenuItem.Name = "defragStaticsToolStripMenuItem";
            this.defragStaticsToolStripMenuItem.Size = new System.Drawing.Size(308, 22);
            this.defragStaticsToolStripMenuItem.Text = "Defrag Statics";
            this.defragStaticsToolStripMenuItem.Click += new System.EventHandler(this.OnClickDefragStatics);
            // 
            // defragAndRemoveDuplicatesStToolStripMenuItem
            // 
            this.defragAndRemoveDuplicatesStToolStripMenuItem.Name = "defragAndRemoveDuplicatesStToolStripMenuItem";
            this.defragAndRemoveDuplicatesStToolStripMenuItem.Size = new System.Drawing.Size(308, 22);
            this.defragAndRemoveDuplicatesStToolStripMenuItem.Text = "Defrag and Remove Duplicates Statics";
            this.defragAndRemoveDuplicatesStToolStripMenuItem.Click += new System.EventHandler(this.OnClickDefragRemoveStatics);
            // 
            // importStaticsToolStripMenuItem
            // 
            this.importStaticsToolStripMenuItem.Name = "importStaticsToolStripMenuItem";
            this.importStaticsToolStripMenuItem.Size = new System.Drawing.Size(308, 22);
            this.importStaticsToolStripMenuItem.Text = "Freeze Statics.. (in Memory)";
            this.importStaticsToolStripMenuItem.Click += new System.EventHandler(this.OnClickStaticImport);
            // 
            // meltStaticsToolStripMenuItem
            // 
            this.meltStaticsToolStripMenuItem.Name = "meltStaticsToolStripMenuItem";
            this.meltStaticsToolStripMenuItem.Size = new System.Drawing.Size(308, 22);
            this.meltStaticsToolStripMenuItem.Text = "Melt Statics.. (in Memory)";
            this.meltStaticsToolStripMenuItem.ToolTipText = "Clears a block of statics from memory. Also generates an Export File of the items" +
    " removed.";
            this.meltStaticsToolStripMenuItem.Click += new System.EventHandler(this.OnClickMeltStatics);
            // 
            // clearStaticsinMemoryToolStripMenuItem
            // 
            this.clearStaticsinMemoryToolStripMenuItem.Name = "clearStaticsinMemoryToolStripMenuItem";
            this.clearStaticsinMemoryToolStripMenuItem.Size = new System.Drawing.Size(308, 22);
            this.clearStaticsinMemoryToolStripMenuItem.Text = "Clear Statics..(in Memory)";
            this.clearStaticsinMemoryToolStripMenuItem.ToolTipText = "Clears a block of statics from memory. Unlike the Melt Statics, this does not cre" +
    "ate an export file of the static items removed.";
            this.clearStaticsinMemoryToolStripMenuItem.Click += new System.EventHandler(this.OnClickClearStatics);
            // 
            // reportStaticsUnderMapToolStripMenuItem
            // 
            this.reportStaticsUnderMapToolStripMenuItem.Name = "reportStaticsUnderMapToolStripMenuItem";
            this.reportStaticsUnderMapToolStripMenuItem.Size = new System.Drawing.Size(308, 22);
            this.reportStaticsUnderMapToolStripMenuItem.Text = "Report Statics below Map (possible invisible)";
            this.reportStaticsUnderMapToolStripMenuItem.Click += new System.EventHandler(this.OnClickReportInvisStatics);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(308, 22);
            this.toolStripMenuItem1.Text = "Report Invalid Map IDs";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.OnClickReportInvalidMapIDs);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(305, 6);
            // 
            // rewriteMapToolStripMenuItem
            // 
            this.rewriteMapToolStripMenuItem.Name = "rewriteMapToolStripMenuItem";
            this.rewriteMapToolStripMenuItem.Size = new System.Drawing.Size(308, 22);
            this.rewriteMapToolStripMenuItem.Text = "Rewrite Map";
            this.rewriteMapToolStripMenuItem.Click += new System.EventHandler(this.OnClickRewriteMap);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(305, 6);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(308, 22);
            this.copyToolStripMenuItem.Text = "Map and Statics Copy...";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.OnClickCopy);
            // 
            // insertDiffDataToolStripMenuItem
            // 
            this.insertDiffDataToolStripMenuItem.Name = "insertDiffDataToolStripMenuItem";
            this.insertDiffDataToolStripMenuItem.Size = new System.Drawing.Size(308, 22);
            this.insertDiffDataToolStripMenuItem.Text = "Diff to Map Copy...";
            this.insertDiffDataToolStripMenuItem.Click += new System.EventHandler(this.OnClickInsertDiffData);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(305, 6);
            // 
            // replaceTilesToolStripMenuItem
            // 
            this.replaceTilesToolStripMenuItem.Name = "replaceTilesToolStripMenuItem";
            this.replaceTilesToolStripMenuItem.Size = new System.Drawing.Size(308, 22);
            this.replaceTilesToolStripMenuItem.Text = "Replace Tiles..";
            this.replaceTilesToolStripMenuItem.Click += new System.EventHandler(this.OnClickReplaceTiles);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(39, 24);
            this.toolStripLabel1.Text = "Zoom";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::UoFiddler.Controls.Properties.Resources.ZoomIn_16x;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "+Zoom";
            this.toolStripButton1.Click += new System.EventHandler(this.OnZoomPlus);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::UoFiddler.Controls.Properties.Resources.ZoomOut_16x;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton2.Text = "-Zoom";
            this.toolStripButton2.Click += new System.EventHandler(this.OnZoomMinus);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripDropDownButton5
            // 
            this.toolStripDropDownButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportMapImageToolStripMenuItem,
            this.toolStripSeparator1,
            this.exportDiffPackageToolStripMenuItem,
            this.exportJsonToolStripMenuItem});
            this.toolStripDropDownButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton5.Name = "toolStripDropDownButton5";
            this.toolStripDropDownButton5.Size = new System.Drawing.Size(54, 24);
            this.toolStripDropDownButton5.Text = "Export";
            // 
            // exportMapImageToolStripMenuItem
            // 
            this.exportMapImageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asBitmapToolStripMenuItem,
            this.asTiffToolStripMenuItem1,
            this.asJpegToolStripMenuItem,
            this.asPngToolStripMenuItem1});
            this.exportMapImageToolStripMenuItem.Name = "exportMapImageToolStripMenuItem";
            this.exportMapImageToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.exportMapImageToolStripMenuItem.Text = "Extract Map IMAGE...";
            // 
            // asBitmapToolStripMenuItem
            // 
            this.asBitmapToolStripMenuItem.Name = "asBitmapToolStripMenuItem";
            this.asBitmapToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.asBitmapToolStripMenuItem.Text = "As Bmp";
            this.asBitmapToolStripMenuItem.Click += new System.EventHandler(this.ExtractMapBmp);
            // 
            // asTiffToolStripMenuItem1
            // 
            this.asTiffToolStripMenuItem1.Name = "asTiffToolStripMenuItem1";
            this.asTiffToolStripMenuItem1.Size = new System.Drawing.Size(115, 22);
            this.asTiffToolStripMenuItem1.Text = "As Tiff";
            this.asTiffToolStripMenuItem1.Click += new System.EventHandler(this.ExtractMapTiff);
            // 
            // asJpegToolStripMenuItem
            // 
            this.asJpegToolStripMenuItem.Name = "asJpegToolStripMenuItem";
            this.asJpegToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.asJpegToolStripMenuItem.Text = "As Jpg";
            this.asJpegToolStripMenuItem.Click += new System.EventHandler(this.ExtractMapJpg);
            // 
            // asPngToolStripMenuItem1
            // 
            this.asPngToolStripMenuItem1.Name = "asPngToolStripMenuItem1";
            this.asPngToolStripMenuItem1.Size = new System.Drawing.Size(115, 22);
            this.asPngToolStripMenuItem1.Text = "As Png";
            this.asPngToolStripMenuItem1.Click += new System.EventHandler(this.ExtractMapPng);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(187, 6);
            // 
            // exportDiffPackageToolStripMenuItem
            // 
            this.exportDiffPackageToolStripMenuItem.Name = "exportDiffPackageToolStripMenuItem";
            this.exportDiffPackageToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.exportDiffPackageToolStripMenuItem.Text = "Export TBTDiff Patch...";
            this.exportDiffPackageToolStripMenuItem.Click += new System.EventHandler(this.OnClickExportDiff);
            // 
            // exportJsonToolStripMenuItem
            // 
            this.exportJsonToolStripMenuItem.Name = "exportJsonToolStripMenuItem";
            this.exportJsonToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.exportJsonToolStripMenuItem.Text = "Export Json...";
            this.exportJsonToolStripMenuItem.Click += new System.EventHandler(this.OnClickExportJson);
            // 
            // toolStripDropDownButton6
            // 
            this.toolStripDropDownButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton6.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importTBTDIFFPackageToolStripMenuItem,
            this.multiTBTDiffImportToolStripMenuItem,
            this.importJsonPackageToolStripMenuItem});
            this.toolStripDropDownButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton6.Name = "toolStripDropDownButton6";
            this.toolStripDropDownButton6.Size = new System.Drawing.Size(56, 24);
            this.toolStripDropDownButton6.Text = "Import";
            // 
            // importTBTDIFFPackageToolStripMenuItem
            // 
            this.importTBTDIFFPackageToolStripMenuItem.Name = "importTBTDIFFPackageToolStripMenuItem";
            this.importTBTDIFFPackageToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.importTBTDIFFPackageToolStripMenuItem.Text = "Import TBTDiff Patch";
            this.importTBTDIFFPackageToolStripMenuItem.Click += new System.EventHandler(this.OnClickImportDiff);
            // 
            // importJsonPackageToolStripMenuItem
            // 
            this.importJsonPackageToolStripMenuItem.Name = "importJsonPackageToolStripMenuItem";
            this.importJsonPackageToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.importJsonPackageToolStripMenuItem.Text = "Import Json";
            this.importJsonPackageToolStripMenuItem.Click += new System.EventHandler(this.OnClickImportJson);
            // 
            // multiTBTDiffImportToolStripMenuItem
            // 
            this.multiTBTDiffImportToolStripMenuItem.Name = "multiTBTDiffImportToolStripMenuItem";
            this.multiTBTDiffImportToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.multiTBTDiffImportToolStripMenuItem.Text = "Multi TBTDiff Import";
            this.multiTBTDiffImportToolStripMenuItem.Click += new System.EventHandler(this.OnClickMultiImportDiff);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripDropDownButton7
            // 
            this.toolStripDropDownButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton7.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSelectionToRegionAreasListToolStripMenuItem,
            this.clearRegionAreasListToolStripMenuItem,
            this.toolStripSeparator2,
            this.exportAreasListToRegionToolStripMenuItem,
            this.toolStripSeparator11,
            this.exportResourceRegionToolStripMenuItem});
            this.toolStripDropDownButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton7.Image")));
            this.toolStripDropDownButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton7.Name = "toolStripDropDownButton7";
            this.toolStripDropDownButton7.Size = new System.Drawing.Size(62, 24);
            this.toolStripDropDownButton7.Text = "Regions";
            // 
            // addSelectionToRegionAreasListToolStripMenuItem
            // 
            this.addSelectionToRegionAreasListToolStripMenuItem.Name = "addSelectionToRegionAreasListToolStripMenuItem";
            this.addSelectionToRegionAreasListToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.addSelectionToRegionAreasListToolStripMenuItem.Text = "Add Selection to Rect List";
            this.addSelectionToRegionAreasListToolStripMenuItem.Click += new System.EventHandler(this.OnClickAddSelectedToRectList);
            // 
            // clearRegionAreasListToolStripMenuItem
            // 
            this.clearRegionAreasListToolStripMenuItem.Name = "clearRegionAreasListToolStripMenuItem";
            this.clearRegionAreasListToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.clearRegionAreasListToolStripMenuItem.Text = "Clear Rect List";
            this.clearRegionAreasListToolStripMenuItem.Click += new System.EventHandler(this.ClearRegionAreas_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(215, 6);
            // 
            // exportAreasListToRegionToolStripMenuItem
            // 
            this.exportAreasListToRegionToolStripMenuItem.Name = "exportAreasListToRegionToolStripMenuItem";
            this.exportAreasListToRegionToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.exportAreasListToRegionToolStripMenuItem.Text = "Export Rect List to Region...";
            this.exportAreasListToRegionToolStripMenuItem.Click += new System.EventHandler(this.OnClickRegionExport);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(215, 6);
            // 
            // exportResourceRegionToolStripMenuItem
            // 
            this.exportResourceRegionToolStripMenuItem.Name = "exportResourceRegionToolStripMenuItem";
            this.exportResourceRegionToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.exportResourceRegionToolStripMenuItem.Text = "Export Resource Region...";
            this.exportResourceRegionToolStripMenuItem.Click += new System.EventHandler(this.ExportRegionResource_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showClientLocToolStripMenuItem1,
            this.toolStripSeparator5,
            this.gotoClientLocToolStripMenuItem1,
            this.sendClientToCenterToolStripMenuItem});
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(94, 19);
            this.toolStripDropDownButton2.Text = "Client Interact";
            this.toolStripDropDownButton2.DropDownClosed += new System.EventHandler(this.OnDropDownClosed);
            // 
            // showClientLocToolStripMenuItem1
            // 
            this.showClientLocToolStripMenuItem1.CheckOnClick = true;
            this.showClientLocToolStripMenuItem1.Name = "showClientLocToolStripMenuItem1";
            this.showClientLocToolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
            this.showClientLocToolStripMenuItem1.Text = "Show Client Loc";
            this.showClientLocToolStripMenuItem1.Click += new System.EventHandler(this.OnClick_ShowClientLoc);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(183, 6);
            // 
            // gotoClientLocToolStripMenuItem1
            // 
            this.gotoClientLocToolStripMenuItem1.Name = "gotoClientLocToolStripMenuItem1";
            this.gotoClientLocToolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
            this.gotoClientLocToolStripMenuItem1.Text = "Goto Client Loc";
            this.gotoClientLocToolStripMenuItem1.Click += new System.EventHandler(this.OnClick_GotoClientLoc);
            // 
            // sendClientToCenterToolStripMenuItem
            // 
            this.sendClientToCenterToolStripMenuItem.Name = "sendClientToCenterToolStripMenuItem";
            this.sendClientToCenterToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.sendClientToCenterToolStripMenuItem.Text = "Send Client to Center";
            this.sendClientToCenterToolStripMenuItem.Click += new System.EventHandler(this.OnClickSendClient);
            // 
            // collapsibleSplitter2
            // 
            this.collapsibleSplitter2.AnimationDelay = 20;
            this.collapsibleSplitter2.AnimationStep = 20;
            this.collapsibleSplitter2.BorderStyle3D = System.Windows.Forms.Border3DStyle.Flat;
            this.collapsibleSplitter2.ControlToHide = this.panel1;
            this.collapsibleSplitter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.collapsibleSplitter2.ExpandParentForm = false;
            this.collapsibleSplitter2.Location = new System.Drawing.Point(415, 35);
            this.collapsibleSplitter2.Name = "collapsibleSplitter2";
            this.collapsibleSplitter2.TabIndex = 8;
            this.collapsibleSplitter2.TabStop = false;
            this.toolTip1.SetToolTip(this.collapsibleSplitter2, "Click to Show/Hide Marker list");
            this.collapsibleSplitter2.UseAnimations = true;
            this.collapsibleSplitter2.VisualStyle = UoFiddler.Controls.UserControls.VisualStyles.DoubleDots;
            // 
            // collapsibleSplitter1
            // 
            this.collapsibleSplitter1.AnimationDelay = 20;
            this.collapsibleSplitter1.AnimationStep = 20;
            this.collapsibleSplitter1.BorderStyle3D = System.Windows.Forms.Border3DStyle.Flat;
            this.collapsibleSplitter1.ControlToHide = this.toolStrip1;
            this.collapsibleSplitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.collapsibleSplitter1.ExpandParentForm = false;
            this.collapsibleSplitter1.Location = new System.Drawing.Point(0, 27);
            this.collapsibleSplitter1.Name = "collapsibleSplitter1";
            this.collapsibleSplitter1.TabIndex = 6;
            this.collapsibleSplitter1.TabStop = false;
            this.toolTip1.SetToolTip(this.collapsibleSplitter1, "Click To Show/Hide Toolbar");
            this.collapsibleSplitter1.UseAnimations = false;
            this.collapsibleSplitter1.VisualStyle = UoFiddler.Controls.UserControls.VisualStyles.DoubleDots;
            // 
            // pictureBox
            // 
            this.pictureBox.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 35);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(398, 244);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            this.pictureBox.Resize += new System.EventHandler(this.OnResizeMap);
            // 
            // MapControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.hScrollBar);
            this.Controls.Add(this.vScrollBar);
            this.Controls.Add(this.collapsibleSplitter2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.collapsibleSplitter1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "MapControl";
            this.Size = new System.Drawing.Size(623, 329);
            this.Load += new System.EventHandler(this.OnLoad);
            this.SizeChanged += new System.EventHandler(this.OnResize);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem clearStaticsinMemoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel ClientLocLabel;
        private UoFiddler.Controls.UserControls.CollapsibleSplitter collapsibleSplitter1;
        private UoFiddler.Controls.UserControls.CollapsibleSplitter collapsibleSplitter2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripStatusLabel CoordsLabel;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defragAndRemoveDuplicatesStToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defragStaticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getMapInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gotoClientLocToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gotoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gotoToolStripMenuItem1;
        private System.Windows.Forms.HScrollBar hScrollBar;
        private System.Windows.Forms.ToolStripMenuItem importStaticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertDiffDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertMarkerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meltStaticsToolStripMenuItem;
        private System.Windows.Forms.TreeView OverlayObjectTree;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ToolStripButton PreloadMap;
        private System.ComponentModel.BackgroundWorker PreloadWorker;
        private System.Windows.Forms.ToolStripProgressBar ProgressBar;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaceTilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportStaticsUnderMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rewriteMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendClientToCenterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendClientToPosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showCenterCrossToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem showClientCrossToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showClientLocToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem showMarkersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showStaticsToolStripMenuItem1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripMenuItem switchVisibleToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox TextBoxGoto;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.VScrollBar vScrollBar;
        private System.Windows.Forms.ToolStripStatusLabel ZoomLabel;
        private System.Windows.Forms.ToolStripStatusLabel SelectedAreaLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton4;
        private System.Windows.Forms.ToolStripMenuItem feluccaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trammelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilshenarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem malasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tokunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terMurToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton5;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton6;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripMenuItem exportMapImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asBitmapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asTiffToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem asJpegToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asPngToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem exportDiffPackageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportJsonToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem importTBTDIFFPackageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importJsonPackageToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton7;
        private System.Windows.Forms.ToolStripMenuItem addSelectionToRegionAreasListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearRegionAreasListToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exportAreasListToRegionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripMenuItem ShowRectanglesMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripMenuItem exportResourceRegionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiTBTDiffImportToolStripMenuItem;
    }
}

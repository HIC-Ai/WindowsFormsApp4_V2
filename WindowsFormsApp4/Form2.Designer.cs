
namespace WindowsFormsApp4
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
        [System.Obsolete]
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.PnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.btnClose = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuImageButton1 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.txtMessage = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.PnlContainer = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuFormDock1 = new Bunifu.UI.WinForms.BunifuFormDock();
            this.incomming1 = new WindowsFormsApp4.chat.Incomming();
            this.outgoing1 = new WindowsFormsApp4.chat.Outgoing();
            this.PnlHeader.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            this.PnlContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlHeader
            // 
            this.PnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(89)))), ((int)(((byte)(205)))));
            this.PnlHeader.Controls.Add(this.btnClose);
            this.PnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlHeader.Location = new System.Drawing.Point(0, 0);
            this.PnlHeader.Name = "PnlHeader";
            this.PnlHeader.ShadowDecoration.Parent = this.PnlHeader;
            this.PnlHeader.Size = new System.Drawing.Size(446, 107);
            this.PnlHeader.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.ActiveImage = null;
            this.btnClose.AllowAnimations = true;
            this.btnClose.AllowBuffering = false;
            this.btnClose.AllowToggling = false;
            this.btnClose.AllowZooming = true;
            this.btnClose.AllowZoomingOnFocus = false;
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnClose.ErrorImage")));
            this.btnClose.FadeWhenInactive = false;
            this.btnClose.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnClose.Image = global::WindowsFormsApp4.Properties.Resources.pngwing_com;
            this.btnClose.ImageActive = null;
            this.btnClose.ImageLocation = null;
            this.btnClose.ImageMargin = 10;
            this.btnClose.ImageSize = new System.Drawing.Size(92, 19);
            this.btnClose.ImageZoomSize = new System.Drawing.Size(102, 29);
            this.btnClose.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnClose.InitialImage")));
            this.btnClose.Location = new System.Drawing.Point(344, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Rotation = 0;
            this.btnClose.ShowActiveImage = true;
            this.btnClose.ShowCursorChanges = true;
            this.btnClose.ShowImageBorders = false;
            this.btnClose.ShowSizeMarkers = false;
            this.btnClose.Size = new System.Drawing.Size(102, 29);
            this.btnClose.TabIndex = 0;
            this.btnClose.ToolTipText = "";
            this.btnClose.WaitOnLoad = false;
            this.btnClose.Zoom = 10;
            this.btnClose.ZoomSpeed = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.bunifuImageButton1);
            this.bunifuPanel1.Controls.Add(this.txtMessage);
            this.bunifuPanel1.Controls.Add(this.bunifuSeparator1);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 509);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(446, 92);
            this.bunifuPanel1.TabIndex = 1;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.ActiveImage = null;
            this.bunifuImageButton1.AllowAnimations = true;
            this.bunifuImageButton1.AllowBuffering = false;
            this.bunifuImageButton1.AllowToggling = false;
            this.bunifuImageButton1.AllowZooming = true;
            this.bunifuImageButton1.AllowZoomingOnFocus = false;
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ErrorImage")));
            this.bunifuImageButton1.FadeWhenInactive = false;
            this.bunifuImageButton1.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton1.Image = global::WindowsFormsApp4.Properties.Resources.stethoscope_99px;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.ImageLocation = null;
            this.bunifuImageButton1.ImageMargin = 40;
            this.bunifuImageButton1.ImageSize = new System.Drawing.Size(26, 32);
            this.bunifuImageButton1.ImageZoomSize = new System.Drawing.Size(66, 72);
            this.bunifuImageButton1.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.InitialImage")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(368, 8);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Rotation = 0;
            this.bunifuImageButton1.ShowActiveImage = true;
            this.bunifuImageButton1.ShowCursorChanges = true;
            this.bunifuImageButton1.ShowImageBorders = true;
            this.bunifuImageButton1.ShowSizeMarkers = false;
            this.bunifuImageButton1.Size = new System.Drawing.Size(66, 72);
            this.bunifuImageButton1.TabIndex = 2;
            this.bunifuImageButton1.ToolTipText = "";
            this.bunifuImageButton1.WaitOnLoad = false;
            this.bunifuImageButton1.Zoom = 40;
            this.bunifuImageButton1.ZoomSpeed = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.AcceptsReturn = false;
            this.txtMessage.AcceptsTab = false;
            this.txtMessage.AnimationSpeed = 200;
            this.txtMessage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtMessage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtMessage.BackColor = System.Drawing.Color.White;
            this.txtMessage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtMessage.BackgroundImage")));
            this.txtMessage.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtMessage.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtMessage.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtMessage.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtMessage.BorderRadius = 1;
            this.txtMessage.BorderThickness = 2;
            this.txtMessage.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMessage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMessage.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtMessage.DefaultText = "";
            this.txtMessage.FillColor = System.Drawing.Color.White;
            this.txtMessage.HideSelection = true;
            this.txtMessage.IconLeft = null;
            this.txtMessage.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMessage.IconPadding = 10;
            this.txtMessage.IconRight = null;
            this.txtMessage.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMessage.Lines = new string[0];
            this.txtMessage.Location = new System.Drawing.Point(50, 30);
            this.txtMessage.MaxLength = 32767;
            this.txtMessage.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtMessage.Modified = false;
            this.txtMessage.Multiline = false;
            this.txtMessage.Name = "txtMessage";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtMessage.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtMessage.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtMessage.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtMessage.OnIdleState = stateProperties8;
            this.txtMessage.Padding = new System.Windows.Forms.Padding(3);
            this.txtMessage.PasswordChar = '\0';
            this.txtMessage.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtMessage.PlaceholderText = "ادخل رسالتك ";
            this.txtMessage.ReadOnly = false;
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMessage.SelectedText = "";
            this.txtMessage.SelectionLength = 0;
            this.txtMessage.SelectionStart = 0;
            this.txtMessage.ShortcutsEnabled = true;
            this.txtMessage.Size = new System.Drawing.Size(260, 37);
            this.txtMessage.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.txtMessage.TabIndex = 1;
            this.txtMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMessage.TextMarginBottom = 0;
            this.txtMessage.TextMarginLeft = 3;
            this.txtMessage.TextMarginTop = 0;
            this.txtMessage.TextPlaceholder = "ادخل رسالتك ";
            this.txtMessage.UseSystemPasswordChar = false;
            this.txtMessage.WordWrap = true;
            this.txtMessage.TextChanged += new System.EventHandler(this.txtMessage_TextChanged);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.DoubleEdgeFaded;
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 0);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(446, 14);
            this.bunifuSeparator1.TabIndex = 0;
            // 
            // PnlContainer
            // 
            this.PnlContainer.BackgroundColor = System.Drawing.Color.Transparent;
            this.PnlContainer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PnlContainer.BackgroundImage")));
            this.PnlContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlContainer.BorderColor = System.Drawing.Color.Transparent;
            this.PnlContainer.BorderRadius = 3;
            this.PnlContainer.BorderThickness = 1;
            this.PnlContainer.Controls.Add(this.outgoing1);
            this.PnlContainer.Controls.Add(this.incomming1);
            this.PnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlContainer.Location = new System.Drawing.Point(0, 107);
            this.PnlContainer.Name = "PnlContainer";
            this.PnlContainer.ShowBorders = true;
            this.PnlContainer.Size = new System.Drawing.Size(446, 402);
            this.PnlContainer.TabIndex = 2;
            // 
            // bunifuFormDock1
            // 
            this.bunifuFormDock1.AllowFormDragging = true;
            this.bunifuFormDock1.AllowFormDropShadow = true;
            this.bunifuFormDock1.AllowFormResizing = false;
            this.bunifuFormDock1.AllowHidingBottomRegion = true;
            this.bunifuFormDock1.AllowOpacityChangesWhileDragging = false;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.BottomBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.LeftBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.RightBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.TopBorder.ShowBorder = true;
            this.bunifuFormDock1.ContainerControl = this;
            this.bunifuFormDock1.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.bunifuFormDock1.DockingIndicatorsOpacity = 0.5D;
            this.bunifuFormDock1.DockingOptions.DockAll = true;
            this.bunifuFormDock1.DockingOptions.DockBottomLeft = true;
            this.bunifuFormDock1.DockingOptions.DockBottomRight = true;
            this.bunifuFormDock1.DockingOptions.DockFullScreen = true;
            this.bunifuFormDock1.DockingOptions.DockLeft = true;
            this.bunifuFormDock1.DockingOptions.DockRight = true;
            this.bunifuFormDock1.DockingOptions.DockTopLeft = true;
            this.bunifuFormDock1.DockingOptions.DockTopRight = true;
            this.bunifuFormDock1.FormDraggingOpacity = 0.9D;
            this.bunifuFormDock1.ParentForm = this;
            this.bunifuFormDock1.ShowCursorChanges = true;
            this.bunifuFormDock1.ShowDockingIndicators = false;
            this.bunifuFormDock1.TitleBarOptions.AllowFormDragging = true;
            this.bunifuFormDock1.TitleBarOptions.BunifuFormDock = this.bunifuFormDock1;
            this.bunifuFormDock1.TitleBarOptions.DoubleClickToExpandWindow = false;
            this.bunifuFormDock1.TitleBarOptions.TitleBarControl = this.PnlHeader;
            this.bunifuFormDock1.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // incomming1
            // 
            this.incomming1.Avatar = ((System.Drawing.Image)(resources.GetObject("incomming1.Avatar")));
            this.incomming1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.incomming1.Dock = System.Windows.Forms.DockStyle.Top;
            this.incomming1.Location = new System.Drawing.Point(0, 0);
            this.incomming1.Message = "السلام عليكم ";
            this.incomming1.Name = "incomming1";
            this.incomming1.Size = new System.Drawing.Size(446, 116);
            this.incomming1.TabIndex = 0;
            // 
            // outgoing1
            // 
            this.outgoing1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.outgoing1.Dock = System.Windows.Forms.DockStyle.Top;
            this.outgoing1.Location = new System.Drawing.Point(0, 116);
            this.outgoing1.Message = "وعليكم السلام ";
            this.outgoing1.Name = "outgoing1";
            this.outgoing1.Size = new System.Drawing.Size(446, 124);
            this.outgoing1.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(446, 601);
            this.Controls.Add(this.PnlContainer);
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.PnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.PnlHeader.ResumeLayout(false);
            this.bunifuPanel1.ResumeLayout(false);
            this.PnlContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PnlHeader;
        private Bunifu.UI.WinForms.BunifuImageButton btnClose;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuTextBox txtMessage;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuPanel PnlContainer;
        private Bunifu.UI.WinForms.BunifuFormDock bunifuFormDock1;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton1;
        private chat.Incomming incomming1;
        private chat.Outgoing outgoing1;
    }
}
namespace Modelo.UI
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuPanel3 = new Bunifu.UI.WinForms.BunifuPanel();
            this.pageControle = new Bunifu.UI.WinForms.BunifuPages();
            this.pageDashboard = new System.Windows.Forms.TabPage();
            this.pageProdutos = new System.Windows.Forms.TabPage();
            this.bunifuPanel4 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuPanel5 = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnDashboard = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnProdutos = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnClientes = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnConfig = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.pageClientes = new System.Windows.Forms.TabPage();
            this.pageConfig = new System.Windows.Forms.TabPage();
            this.bunifuPanel1.SuspendLayout();
            this.bunifuPanel3.SuspendLayout();
            this.pageControle.SuspendLayout();
            this.bunifuPanel4.SuspendLayout();
            this.bunifuPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuPanel1.BorderRadius = 5;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.bunifuPanel5);
            this.bunifuPanel1.Controls.Add(this.bunifuPanel4);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(200, 550);
            this.bunifuPanel1.TabIndex = 0;
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BorderRadius = 3;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel2.Location = new System.Drawing.Point(200, 0);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(700, 40);
            this.bunifuPanel2.TabIndex = 1;
            // 
            // bunifuPanel3
            // 
            this.bunifuPanel3.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel3.BackgroundImage")));
            this.bunifuPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel3.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel3.BorderRadius = 3;
            this.bunifuPanel3.BorderThickness = 1;
            this.bunifuPanel3.Controls.Add(this.pageControle);
            this.bunifuPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel3.Location = new System.Drawing.Point(200, 40);
            this.bunifuPanel3.Name = "bunifuPanel3";
            this.bunifuPanel3.ShowBorders = true;
            this.bunifuPanel3.Size = new System.Drawing.Size(700, 510);
            this.bunifuPanel3.TabIndex = 2;
            // 
            // pageControle
            // 
            this.pageControle.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.pageControle.AllowTransitions = true;
            this.pageControle.Controls.Add(this.pageDashboard);
            this.pageControle.Controls.Add(this.pageProdutos);
            this.pageControle.Controls.Add(this.pageClientes);
            this.pageControle.Controls.Add(this.pageConfig);
            this.pageControle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageControle.Location = new System.Drawing.Point(0, 0);
            this.pageControle.Multiline = true;
            this.pageControle.Name = "pageControle";
            this.pageControle.Page = this.pageConfig;
            this.pageControle.PageIndex = 3;
            this.pageControle.PageName = "pageConfig";
            this.pageControle.PageTitle = "Configurações";
            this.pageControle.SelectedIndex = 0;
            this.pageControle.Size = new System.Drawing.Size(700, 510);
            this.pageControle.TabIndex = 0;
            animation1.AnimateOnlyDifferences = false;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.pageControle.Transition = animation1;
            this.pageControle.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // pageDashboard
            // 
            this.pageDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pageDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pageDashboard.Location = new System.Drawing.Point(4, 4);
            this.pageDashboard.Name = "pageDashboard";
            this.pageDashboard.Padding = new System.Windows.Forms.Padding(3);
            this.pageDashboard.Size = new System.Drawing.Size(692, 484);
            this.pageDashboard.TabIndex = 0;
            this.pageDashboard.Text = "Dashboard";
            // 
            // pageProdutos
            // 
            this.pageProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pageProdutos.Location = new System.Drawing.Point(4, 4);
            this.pageProdutos.Name = "pageProdutos";
            this.pageProdutos.Padding = new System.Windows.Forms.Padding(3);
            this.pageProdutos.Size = new System.Drawing.Size(692, 484);
            this.pageProdutos.TabIndex = 1;
            this.pageProdutos.Text = "Produtos";
            // 
            // bunifuPanel4
            // 
            this.bunifuPanel4.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel4.BackgroundImage")));
            this.bunifuPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel4.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel4.BorderRadius = 3;
            this.bunifuPanel4.BorderThickness = 1;
            this.bunifuPanel4.Controls.Add(this.bunifuLabel2);
            this.bunifuPanel4.Controls.Add(this.pictureBox1);
            this.bunifuPanel4.Controls.Add(this.bunifuLabel3);
            this.bunifuPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel4.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel4.Name = "bunifuPanel4";
            this.bunifuPanel4.ShowBorders = true;
            this.bunifuPanel4.Size = new System.Drawing.Size(200, 150);
            this.bunifuPanel4.TabIndex = 1;
            // 
            // bunifuPanel5
            // 
            this.bunifuPanel5.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel5.BackgroundImage")));
            this.bunifuPanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel5.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel5.BorderRadius = 3;
            this.bunifuPanel5.BorderThickness = 1;
            this.bunifuPanel5.Controls.Add(this.bunifuLabel1);
            this.bunifuPanel5.Controls.Add(this.btnConfig);
            this.bunifuPanel5.Controls.Add(this.btnClientes);
            this.bunifuPanel5.Controls.Add(this.btnProdutos);
            this.bunifuPanel5.Controls.Add(this.btnDashboard);
            this.bunifuPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel5.Location = new System.Drawing.Point(0, 150);
            this.bunifuPanel5.Name = "bunifuPanel5";
            this.bunifuPanel5.ShowBorders = true;
            this.bunifuPanel5.Size = new System.Drawing.Size(200, 400);
            this.bunifuPanel5.TabIndex = 2;
            // 
            // btnDashboard
            // 
            this.btnDashboard.AllowAnimations = true;
            this.btnDashboard.AllowMouseEffects = true;
            this.btnDashboard.AllowToggling = false;
            this.btnDashboard.AnimationSpeed = 200;
            this.btnDashboard.AutoGenerateColors = false;
            this.btnDashboard.AutoRoundBorders = false;
            this.btnDashboard.AutoSizeLeftIcon = true;
            this.btnDashboard.AutoSizeRightIcon = true;
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.BackColor1 = System.Drawing.Color.Transparent;
            this.btnDashboard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDashboard.BackgroundImage")));
            this.btnDashboard.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDashboard.ButtonText = "Dasboard";
            this.btnDashboard.ButtonTextMarginLeft = 0;
            this.btnDashboard.ColorContrastOnClick = 45;
            this.btnDashboard.ColorContrastOnHover = 45;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnDashboard.CustomizableEdges = borderEdges4;
            this.btnDashboard.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDashboard.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.btnDashboard.DisabledFillColor = System.Drawing.Color.Transparent;
            this.btnDashboard.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.Transparent;
            this.btnDashboard.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnDashboard.IconMarginLeft = 11;
            this.btnDashboard.IconPadding = 10;
            this.btnDashboard.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDashboard.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnDashboard.IconSize = 25;
            this.btnDashboard.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnDashboard.IdleBorderRadius = 1;
            this.btnDashboard.IdleBorderThickness = 1;
            this.btnDashboard.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnDashboard.IdleIconLeftImage = null;
            this.btnDashboard.IdleIconRightImage = null;
            this.btnDashboard.IndicateFocus = false;
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.OnDisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.btnDashboard.OnDisabledState.BorderRadius = 1;
            this.btnDashboard.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDashboard.OnDisabledState.BorderThickness = 1;
            this.btnDashboard.OnDisabledState.FillColor = System.Drawing.Color.Transparent;
            this.btnDashboard.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDashboard.OnDisabledState.IconLeftImage = null;
            this.btnDashboard.OnDisabledState.IconRightImage = null;
            this.btnDashboard.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnDashboard.onHoverState.BorderRadius = 1;
            this.btnDashboard.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDashboard.onHoverState.BorderThickness = 1;
            this.btnDashboard.onHoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnDashboard.onHoverState.ForeColor = System.Drawing.Color.Violet;
            this.btnDashboard.onHoverState.IconLeftImage = null;
            this.btnDashboard.onHoverState.IconRightImage = null;
            this.btnDashboard.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnDashboard.OnIdleState.BorderRadius = 1;
            this.btnDashboard.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDashboard.OnIdleState.BorderThickness = 1;
            this.btnDashboard.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnDashboard.OnIdleState.ForeColor = System.Drawing.Color.Transparent;
            this.btnDashboard.OnIdleState.IconLeftImage = null;
            this.btnDashboard.OnIdleState.IconRightImage = null;
            this.btnDashboard.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnDashboard.OnPressedState.BorderRadius = 1;
            this.btnDashboard.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDashboard.OnPressedState.BorderThickness = 1;
            this.btnDashboard.OnPressedState.FillColor = System.Drawing.Color.Transparent;
            this.btnDashboard.OnPressedState.ForeColor = System.Drawing.Color.Violet;
            this.btnDashboard.OnPressedState.IconLeftImage = null;
            this.btnDashboard.OnPressedState.IconRightImage = null;
            this.btnDashboard.Size = new System.Drawing.Size(200, 60);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDashboard.TextMarginLeft = 0;
            this.btnDashboard.TextPadding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnDashboard.UseDefaultRadiusAndThickness = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.AllowAnimations = true;
            this.btnProdutos.AllowMouseEffects = true;
            this.btnProdutos.AllowToggling = false;
            this.btnProdutos.AnimationSpeed = 200;
            this.btnProdutos.AutoGenerateColors = false;
            this.btnProdutos.AutoRoundBorders = false;
            this.btnProdutos.AutoSizeLeftIcon = true;
            this.btnProdutos.AutoSizeRightIcon = true;
            this.btnProdutos.BackColor = System.Drawing.Color.Transparent;
            this.btnProdutos.BackColor1 = System.Drawing.Color.Transparent;
            this.btnProdutos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProdutos.BackgroundImage")));
            this.btnProdutos.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnProdutos.ButtonText = "Produtos";
            this.btnProdutos.ButtonTextMarginLeft = 0;
            this.btnProdutos.ColorContrastOnClick = 45;
            this.btnProdutos.ColorContrastOnHover = 45;
            this.btnProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnProdutos.CustomizableEdges = borderEdges3;
            this.btnProdutos.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnProdutos.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.btnProdutos.DisabledFillColor = System.Drawing.Color.Transparent;
            this.btnProdutos.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnProdutos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProdutos.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnProdutos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdutos.ForeColor = System.Drawing.Color.Transparent;
            this.btnProdutos.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProdutos.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnProdutos.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnProdutos.IconMarginLeft = 11;
            this.btnProdutos.IconPadding = 10;
            this.btnProdutos.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProdutos.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnProdutos.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnProdutos.IconSize = 25;
            this.btnProdutos.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnProdutos.IdleBorderRadius = 1;
            this.btnProdutos.IdleBorderThickness = 1;
            this.btnProdutos.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnProdutos.IdleIconLeftImage = null;
            this.btnProdutos.IdleIconRightImage = null;
            this.btnProdutos.IndicateFocus = false;
            this.btnProdutos.Location = new System.Drawing.Point(0, 60);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.OnDisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.btnProdutos.OnDisabledState.BorderRadius = 1;
            this.btnProdutos.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnProdutos.OnDisabledState.BorderThickness = 1;
            this.btnProdutos.OnDisabledState.FillColor = System.Drawing.Color.Transparent;
            this.btnProdutos.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnProdutos.OnDisabledState.IconLeftImage = null;
            this.btnProdutos.OnDisabledState.IconRightImage = null;
            this.btnProdutos.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnProdutos.onHoverState.BorderRadius = 1;
            this.btnProdutos.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnProdutos.onHoverState.BorderThickness = 1;
            this.btnProdutos.onHoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnProdutos.onHoverState.ForeColor = System.Drawing.Color.Violet;
            this.btnProdutos.onHoverState.IconLeftImage = null;
            this.btnProdutos.onHoverState.IconRightImage = null;
            this.btnProdutos.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnProdutos.OnIdleState.BorderRadius = 1;
            this.btnProdutos.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnProdutos.OnIdleState.BorderThickness = 1;
            this.btnProdutos.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnProdutos.OnIdleState.ForeColor = System.Drawing.Color.Transparent;
            this.btnProdutos.OnIdleState.IconLeftImage = null;
            this.btnProdutos.OnIdleState.IconRightImage = null;
            this.btnProdutos.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnProdutos.OnPressedState.BorderRadius = 1;
            this.btnProdutos.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnProdutos.OnPressedState.BorderThickness = 1;
            this.btnProdutos.OnPressedState.FillColor = System.Drawing.Color.Transparent;
            this.btnProdutos.OnPressedState.ForeColor = System.Drawing.Color.Violet;
            this.btnProdutos.OnPressedState.IconLeftImage = null;
            this.btnProdutos.OnPressedState.IconRightImage = null;
            this.btnProdutos.Size = new System.Drawing.Size(200, 60);
            this.btnProdutos.TabIndex = 1;
            this.btnProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProdutos.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnProdutos.TextMarginLeft = 0;
            this.btnProdutos.TextPadding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnProdutos.UseDefaultRadiusAndThickness = true;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.AllowAnimations = true;
            this.btnClientes.AllowMouseEffects = true;
            this.btnClientes.AllowToggling = false;
            this.btnClientes.AnimationSpeed = 200;
            this.btnClientes.AutoGenerateColors = false;
            this.btnClientes.AutoRoundBorders = false;
            this.btnClientes.AutoSizeLeftIcon = true;
            this.btnClientes.AutoSizeRightIcon = true;
            this.btnClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnClientes.BackColor1 = System.Drawing.Color.Transparent;
            this.btnClientes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClientes.BackgroundImage")));
            this.btnClientes.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClientes.ButtonText = "Clientes";
            this.btnClientes.ButtonTextMarginLeft = 0;
            this.btnClientes.ColorContrastOnClick = 45;
            this.btnClientes.ColorContrastOnHover = 45;
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnClientes.CustomizableEdges = borderEdges2;
            this.btnClientes.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClientes.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.btnClientes.DisabledFillColor = System.Drawing.Color.Transparent;
            this.btnClientes.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnClientes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.Transparent;
            this.btnClientes.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnClientes.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnClientes.IconMarginLeft = 11;
            this.btnClientes.IconPadding = 10;
            this.btnClientes.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClientes.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnClientes.IconSize = 25;
            this.btnClientes.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnClientes.IdleBorderRadius = 1;
            this.btnClientes.IdleBorderThickness = 1;
            this.btnClientes.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnClientes.IdleIconLeftImage = null;
            this.btnClientes.IdleIconRightImage = null;
            this.btnClientes.IndicateFocus = false;
            this.btnClientes.Location = new System.Drawing.Point(0, 120);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.OnDisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.btnClientes.OnDisabledState.BorderRadius = 1;
            this.btnClientes.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClientes.OnDisabledState.BorderThickness = 1;
            this.btnClientes.OnDisabledState.FillColor = System.Drawing.Color.Transparent;
            this.btnClientes.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClientes.OnDisabledState.IconLeftImage = null;
            this.btnClientes.OnDisabledState.IconRightImage = null;
            this.btnClientes.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnClientes.onHoverState.BorderRadius = 1;
            this.btnClientes.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClientes.onHoverState.BorderThickness = 1;
            this.btnClientes.onHoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnClientes.onHoverState.ForeColor = System.Drawing.Color.Violet;
            this.btnClientes.onHoverState.IconLeftImage = null;
            this.btnClientes.onHoverState.IconRightImage = null;
            this.btnClientes.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnClientes.OnIdleState.BorderRadius = 1;
            this.btnClientes.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClientes.OnIdleState.BorderThickness = 1;
            this.btnClientes.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnClientes.OnIdleState.ForeColor = System.Drawing.Color.Transparent;
            this.btnClientes.OnIdleState.IconLeftImage = null;
            this.btnClientes.OnIdleState.IconRightImage = null;
            this.btnClientes.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnClientes.OnPressedState.BorderRadius = 1;
            this.btnClientes.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClientes.OnPressedState.BorderThickness = 1;
            this.btnClientes.OnPressedState.FillColor = System.Drawing.Color.Transparent;
            this.btnClientes.OnPressedState.ForeColor = System.Drawing.Color.Violet;
            this.btnClientes.OnPressedState.IconLeftImage = null;
            this.btnClientes.OnPressedState.IconRightImage = null;
            this.btnClientes.Size = new System.Drawing.Size(200, 60);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClientes.TextMarginLeft = 0;
            this.btnClientes.TextPadding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnClientes.UseDefaultRadiusAndThickness = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.AllowAnimations = true;
            this.btnConfig.AllowMouseEffects = true;
            this.btnConfig.AllowToggling = false;
            this.btnConfig.AnimationSpeed = 200;
            this.btnConfig.AutoGenerateColors = false;
            this.btnConfig.AutoRoundBorders = false;
            this.btnConfig.AutoSizeLeftIcon = true;
            this.btnConfig.AutoSizeRightIcon = true;
            this.btnConfig.BackColor = System.Drawing.Color.Transparent;
            this.btnConfig.BackColor1 = System.Drawing.Color.Transparent;
            this.btnConfig.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfig.BackgroundImage")));
            this.btnConfig.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnConfig.ButtonText = "Configurações";
            this.btnConfig.ButtonTextMarginLeft = 0;
            this.btnConfig.ColorContrastOnClick = 45;
            this.btnConfig.ColorContrastOnHover = 45;
            this.btnConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnConfig.CustomizableEdges = borderEdges1;
            this.btnConfig.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnConfig.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.btnConfig.DisabledFillColor = System.Drawing.Color.Transparent;
            this.btnConfig.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConfig.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnConfig.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfig.ForeColor = System.Drawing.Color.Transparent;
            this.btnConfig.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfig.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnConfig.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnConfig.IconMarginLeft = 11;
            this.btnConfig.IconPadding = 10;
            this.btnConfig.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfig.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfig.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnConfig.IconSize = 25;
            this.btnConfig.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnConfig.IdleBorderRadius = 1;
            this.btnConfig.IdleBorderThickness = 1;
            this.btnConfig.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnConfig.IdleIconLeftImage = null;
            this.btnConfig.IdleIconRightImage = null;
            this.btnConfig.IndicateFocus = false;
            this.btnConfig.Location = new System.Drawing.Point(0, 180);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.OnDisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.btnConfig.OnDisabledState.BorderRadius = 1;
            this.btnConfig.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnConfig.OnDisabledState.BorderThickness = 1;
            this.btnConfig.OnDisabledState.FillColor = System.Drawing.Color.Transparent;
            this.btnConfig.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnConfig.OnDisabledState.IconLeftImage = null;
            this.btnConfig.OnDisabledState.IconRightImage = null;
            this.btnConfig.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnConfig.onHoverState.BorderRadius = 1;
            this.btnConfig.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnConfig.onHoverState.BorderThickness = 1;
            this.btnConfig.onHoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnConfig.onHoverState.ForeColor = System.Drawing.Color.Violet;
            this.btnConfig.onHoverState.IconLeftImage = null;
            this.btnConfig.onHoverState.IconRightImage = null;
            this.btnConfig.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnConfig.OnIdleState.BorderRadius = 1;
            this.btnConfig.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnConfig.OnIdleState.BorderThickness = 1;
            this.btnConfig.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnConfig.OnIdleState.ForeColor = System.Drawing.Color.Transparent;
            this.btnConfig.OnIdleState.IconLeftImage = null;
            this.btnConfig.OnIdleState.IconRightImage = null;
            this.btnConfig.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnConfig.OnPressedState.BorderRadius = 1;
            this.btnConfig.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnConfig.OnPressedState.BorderThickness = 1;
            this.btnConfig.OnPressedState.FillColor = System.Drawing.Color.Transparent;
            this.btnConfig.OnPressedState.ForeColor = System.Drawing.Color.Violet;
            this.btnConfig.OnPressedState.IconLeftImage = null;
            this.btnConfig.OnPressedState.IconRightImage = null;
            this.btnConfig.Size = new System.Drawing.Size(200, 60);
            this.btnConfig.TabIndex = 3;
            this.btnConfig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfig.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnConfig.TextMarginLeft = 0;
            this.btnConfig.TextPadding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnConfig.UseDefaultRadiusAndThickness = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.Violet;
            this.bunifuLabel1.Location = new System.Drawing.Point(51, 367);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(100, 21);
            this.bunifuLabel1.TabIndex = 0;
            this.bunifuLabel1.Text = "Administrador";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel3.ForeColor = System.Drawing.Color.Violet;
            this.bunifuLabel3.Location = new System.Drawing.Point(109, 96);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(39, 15);
            this.bunifuLabel3.TabIndex = 5;
            this.bunifuLabel3.Text = "Brunno";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(71, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.ForeColor = System.Drawing.Color.Violet;
            this.bunifuLabel2.Location = new System.Drawing.Point(48, 96);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(57, 15);
            this.bunifuLabel2.TabIndex = 7;
            this.bunifuLabel2.Text = "Bem vindo";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pageClientes
            // 
            this.pageClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pageClientes.Location = new System.Drawing.Point(4, 4);
            this.pageClientes.Name = "pageClientes";
            this.pageClientes.Padding = new System.Windows.Forms.Padding(3);
            this.pageClientes.Size = new System.Drawing.Size(692, 484);
            this.pageClientes.TabIndex = 2;
            this.pageClientes.Text = "Clientes";
            // 
            // pageConfig
            // 
            this.pageConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pageConfig.Location = new System.Drawing.Point(4, 4);
            this.pageConfig.Name = "pageConfig";
            this.pageConfig.Padding = new System.Windows.Forms.Padding(3);
            this.pageConfig.Size = new System.Drawing.Size(692, 484);
            this.pageConfig.TabIndex = 3;
            this.pageConfig.Text = "Configurações";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.bunifuPanel3);
            this.Controls.Add(this.bunifuPanel2);
            this.Controls.Add(this.bunifuPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel3.ResumeLayout(false);
            this.pageControle.ResumeLayout(false);
            this.bunifuPanel4.ResumeLayout(false);
            this.bunifuPanel4.PerformLayout();
            this.bunifuPanel5.ResumeLayout(false);
            this.bunifuPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel3;
        private Bunifu.UI.WinForms.BunifuPages pageControle;
        private System.Windows.Forms.TabPage pageDashboard;
        private System.Windows.Forms.TabPage pageProdutos;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel5;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDashboard;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel4;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnConfig;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnClientes;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnProdutos;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private System.Windows.Forms.TabPage pageClientes;
        private System.Windows.Forms.TabPage pageConfig;
    }
}
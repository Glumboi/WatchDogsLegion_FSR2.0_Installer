using System;

namespace Watch_Dogs_Legion_FSR_2._0_Installer
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.Textbox_Path = new Telerik.WinControls.UI.RadTextBox();
            this.DarkTheme = new Telerik.WinControls.Themes.CrystalDarkTheme();
            this.Button_Install = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Button_Browse = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Button_Uninstall = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.Textbox_Path)).BeginInit();
            this.SuspendLayout();
            // 
            // Textbox_Path
            // 
            this.Textbox_Path.AutoSize = false;
            this.Textbox_Path.Location = new System.Drawing.Point(12, 9);
            this.Textbox_Path.Name = "Textbox_Path";
            this.Textbox_Path.Size = new System.Drawing.Size(262, 38);
            this.Textbox_Path.TabIndex = 0;
            this.Textbox_Path.Text = "Enter your game path here...";
            this.Textbox_Path.ThemeName = "CrystalDark";
            this.Textbox_Path.TextChanged += new System.EventHandler(this.Textbox_Path_TextChanged);
            // 
            // Button_Install
            // 
            this.Button_Install.AllowAnimations = true;
            this.Button_Install.AllowMouseEffects = true;
            this.Button_Install.AllowToggling = false;
            this.Button_Install.AnimationSpeed = 200;
            this.Button_Install.AutoGenerateColors = false;
            this.Button_Install.AutoRoundBorders = true;
            this.Button_Install.AutoSizeLeftIcon = true;
            this.Button_Install.AutoSizeRightIcon = true;
            this.Button_Install.BackColor = System.Drawing.Color.Transparent;
            this.Button_Install.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_Install.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_Install.BackgroundImage")));
            this.Button_Install.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Button_Install.ButtonText = "Install";
            this.Button_Install.ButtonTextMarginLeft = 0;
            this.Button_Install.ColorContrastOnClick = 45;
            this.Button_Install.ColorContrastOnHover = 45;
            this.Button_Install.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.Button_Install.CustomizableEdges = borderEdges4;
            this.Button_Install.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Button_Install.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Button_Install.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Button_Install.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Button_Install.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.Button_Install.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Button_Install.ForeColor = System.Drawing.Color.White;
            this.Button_Install.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Install.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Button_Install.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.Button_Install.IconMarginLeft = 11;
            this.Button_Install.IconPadding = 10;
            this.Button_Install.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_Install.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Button_Install.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.Button_Install.IconSize = 25;
            this.Button_Install.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_Install.IdleBorderRadius = 44;
            this.Button_Install.IdleBorderThickness = 1;
            this.Button_Install.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_Install.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("Button_Install.IdleIconLeftImage")));
            this.Button_Install.IdleIconRightImage = null;
            this.Button_Install.IndicateFocus = false;
            this.Button_Install.Location = new System.Drawing.Point(12, 56);
            this.Button_Install.Name = "Button_Install";
            this.Button_Install.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Button_Install.OnDisabledState.BorderRadius = 1;
            this.Button_Install.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Button_Install.OnDisabledState.BorderThickness = 1;
            this.Button_Install.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Button_Install.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Button_Install.OnDisabledState.IconLeftImage = null;
            this.Button_Install.OnDisabledState.IconRightImage = null;
            this.Button_Install.onHoverState.BorderColor = System.Drawing.Color.Silver;
            this.Button_Install.onHoverState.BorderRadius = 1;
            this.Button_Install.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Button_Install.onHoverState.BorderThickness = 1;
            this.Button_Install.onHoverState.FillColor = System.Drawing.Color.Gray;
            this.Button_Install.onHoverState.ForeColor = System.Drawing.Color.White;
            this.Button_Install.onHoverState.IconLeftImage = null;
            this.Button_Install.onHoverState.IconRightImage = null;
            this.Button_Install.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_Install.OnIdleState.BorderRadius = 1;
            this.Button_Install.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Button_Install.OnIdleState.BorderThickness = 1;
            this.Button_Install.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_Install.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.Button_Install.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("Button_Install.OnIdleState.IconLeftImage")));
            this.Button_Install.OnIdleState.IconRightImage = null;
            this.Button_Install.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_Install.OnPressedState.BorderRadius = 1;
            this.Button_Install.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Button_Install.OnPressedState.BorderThickness = 1;
            this.Button_Install.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_Install.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.Button_Install.OnPressedState.IconLeftImage = null;
            this.Button_Install.OnPressedState.IconRightImage = null;
            this.Button_Install.Size = new System.Drawing.Size(314, 46);
            this.Button_Install.TabIndex = 1;
            this.Button_Install.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_Install.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Button_Install.TextMarginLeft = 0;
            this.Button_Install.TextPadding = new System.Windows.Forms.Padding(0);
            this.Button_Install.UseDefaultRadiusAndThickness = true;
            this.Button_Install.Click += new System.EventHandler(this.Button_Install_Click);
            // 
            // Button_Browse
            // 
            this.Button_Browse.AllowAnimations = true;
            this.Button_Browse.AllowMouseEffects = true;
            this.Button_Browse.AllowToggling = false;
            this.Button_Browse.AnimationSpeed = 200;
            this.Button_Browse.AutoGenerateColors = false;
            this.Button_Browse.AutoRoundBorders = true;
            this.Button_Browse.AutoSizeLeftIcon = true;
            this.Button_Browse.AutoSizeRightIcon = true;
            this.Button_Browse.BackColor = System.Drawing.Color.Transparent;
            this.Button_Browse.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_Browse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_Browse.BackgroundImage")));
            this.Button_Browse.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Button_Browse.ButtonText = "";
            this.Button_Browse.ButtonTextMarginLeft = 0;
            this.Button_Browse.ColorContrastOnClick = 45;
            this.Button_Browse.ColorContrastOnHover = 45;
            this.Button_Browse.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.Button_Browse.CustomizableEdges = borderEdges5;
            this.Button_Browse.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Button_Browse.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Button_Browse.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Button_Browse.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Button_Browse.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.Button_Browse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button_Browse.ForeColor = System.Drawing.Color.White;
            this.Button_Browse.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Browse.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Button_Browse.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.Button_Browse.IconMarginLeft = 11;
            this.Button_Browse.IconPadding = 10;
            this.Button_Browse.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_Browse.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Button_Browse.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.Button_Browse.IconSize = 25;
            this.Button_Browse.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_Browse.IdleBorderRadius = 41;
            this.Button_Browse.IdleBorderThickness = 1;
            this.Button_Browse.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_Browse.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("Button_Browse.IdleIconLeftImage")));
            this.Button_Browse.IdleIconRightImage = null;
            this.Button_Browse.IndicateFocus = false;
            this.Button_Browse.Location = new System.Drawing.Point(280, 7);
            this.Button_Browse.Name = "Button_Browse";
            this.Button_Browse.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Button_Browse.OnDisabledState.BorderRadius = 1;
            this.Button_Browse.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Button_Browse.OnDisabledState.BorderThickness = 1;
            this.Button_Browse.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Button_Browse.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Button_Browse.OnDisabledState.IconLeftImage = null;
            this.Button_Browse.OnDisabledState.IconRightImage = null;
            this.Button_Browse.onHoverState.BorderColor = System.Drawing.Color.Silver;
            this.Button_Browse.onHoverState.BorderRadius = 1;
            this.Button_Browse.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Button_Browse.onHoverState.BorderThickness = 1;
            this.Button_Browse.onHoverState.FillColor = System.Drawing.Color.Gray;
            this.Button_Browse.onHoverState.ForeColor = System.Drawing.Color.White;
            this.Button_Browse.onHoverState.IconLeftImage = null;
            this.Button_Browse.onHoverState.IconRightImage = null;
            this.Button_Browse.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_Browse.OnIdleState.BorderRadius = 1;
            this.Button_Browse.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Button_Browse.OnIdleState.BorderThickness = 1;
            this.Button_Browse.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_Browse.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.Button_Browse.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("Button_Browse.OnIdleState.IconLeftImage")));
            this.Button_Browse.OnIdleState.IconRightImage = null;
            this.Button_Browse.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_Browse.OnPressedState.BorderRadius = 1;
            this.Button_Browse.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Button_Browse.OnPressedState.BorderThickness = 1;
            this.Button_Browse.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_Browse.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.Button_Browse.OnPressedState.IconLeftImage = null;
            this.Button_Browse.OnPressedState.IconRightImage = null;
            this.Button_Browse.Size = new System.Drawing.Size(46, 43);
            this.Button_Browse.TabIndex = 2;
            this.Button_Browse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_Browse.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Button_Browse.TextMarginLeft = 0;
            this.Button_Browse.TextPadding = new System.Windows.Forms.Padding(0);
            this.Button_Browse.UseDefaultRadiusAndThickness = true;
            this.Button_Browse.Click += new System.EventHandler(this.Button_Browse_Click);
            // 
            // Button_Uninstall
            // 
            this.Button_Uninstall.AllowAnimations = true;
            this.Button_Uninstall.AllowMouseEffects = true;
            this.Button_Uninstall.AllowToggling = false;
            this.Button_Uninstall.AnimationSpeed = 200;
            this.Button_Uninstall.AutoGenerateColors = false;
            this.Button_Uninstall.AutoRoundBorders = true;
            this.Button_Uninstall.AutoSizeLeftIcon = true;
            this.Button_Uninstall.AutoSizeRightIcon = true;
            this.Button_Uninstall.BackColor = System.Drawing.Color.Transparent;
            this.Button_Uninstall.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_Uninstall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_Uninstall.BackgroundImage")));
            this.Button_Uninstall.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Button_Uninstall.ButtonText = "Uninstall";
            this.Button_Uninstall.ButtonTextMarginLeft = 0;
            this.Button_Uninstall.ColorContrastOnClick = 45;
            this.Button_Uninstall.ColorContrastOnHover = 45;
            this.Button_Uninstall.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.Button_Uninstall.CustomizableEdges = borderEdges6;
            this.Button_Uninstall.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Button_Uninstall.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Button_Uninstall.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Button_Uninstall.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Button_Uninstall.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.Button_Uninstall.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Button_Uninstall.ForeColor = System.Drawing.Color.White;
            this.Button_Uninstall.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Uninstall.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Button_Uninstall.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.Button_Uninstall.IconMarginLeft = 11;
            this.Button_Uninstall.IconPadding = 10;
            this.Button_Uninstall.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_Uninstall.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Button_Uninstall.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.Button_Uninstall.IconSize = 25;
            this.Button_Uninstall.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_Uninstall.IdleBorderRadius = 44;
            this.Button_Uninstall.IdleBorderThickness = 1;
            this.Button_Uninstall.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_Uninstall.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("Button_Uninstall.IdleIconLeftImage")));
            this.Button_Uninstall.IdleIconRightImage = null;
            this.Button_Uninstall.IndicateFocus = false;
            this.Button_Uninstall.Location = new System.Drawing.Point(12, 107);
            this.Button_Uninstall.Name = "Button_Uninstall";
            this.Button_Uninstall.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Button_Uninstall.OnDisabledState.BorderRadius = 1;
            this.Button_Uninstall.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Button_Uninstall.OnDisabledState.BorderThickness = 1;
            this.Button_Uninstall.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Button_Uninstall.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Button_Uninstall.OnDisabledState.IconLeftImage = null;
            this.Button_Uninstall.OnDisabledState.IconRightImage = null;
            this.Button_Uninstall.onHoverState.BorderColor = System.Drawing.Color.Silver;
            this.Button_Uninstall.onHoverState.BorderRadius = 1;
            this.Button_Uninstall.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Button_Uninstall.onHoverState.BorderThickness = 1;
            this.Button_Uninstall.onHoverState.FillColor = System.Drawing.Color.Gray;
            this.Button_Uninstall.onHoverState.ForeColor = System.Drawing.Color.White;
            this.Button_Uninstall.onHoverState.IconLeftImage = null;
            this.Button_Uninstall.onHoverState.IconRightImage = null;
            this.Button_Uninstall.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_Uninstall.OnIdleState.BorderRadius = 1;
            this.Button_Uninstall.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Button_Uninstall.OnIdleState.BorderThickness = 1;
            this.Button_Uninstall.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_Uninstall.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.Button_Uninstall.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("Button_Uninstall.OnIdleState.IconLeftImage")));
            this.Button_Uninstall.OnIdleState.IconRightImage = null;
            this.Button_Uninstall.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_Uninstall.OnPressedState.BorderRadius = 1;
            this.Button_Uninstall.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Button_Uninstall.OnPressedState.BorderThickness = 1;
            this.Button_Uninstall.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_Uninstall.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.Button_Uninstall.OnPressedState.IconLeftImage = null;
            this.Button_Uninstall.OnPressedState.IconRightImage = null;
            this.Button_Uninstall.Size = new System.Drawing.Size(314, 46);
            this.Button_Uninstall.TabIndex = 3;
            this.Button_Uninstall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_Uninstall.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Button_Uninstall.TextMarginLeft = 0;
            this.Button_Uninstall.TextPadding = new System.Windows.Forms.Padding(0);
            this.Button_Uninstall.UseDefaultRadiusAndThickness = true;
            this.Button_Uninstall.Click += new System.EventHandler(this.Button_Uninstall_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(335, 161);
            this.Controls.Add(this.Button_Uninstall);
            this.Controls.Add(this.Button_Browse);
            this.Controls.Add(this.Button_Install);
            this.Controls.Add(this.Textbox_Path);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "FSR 2.0 Installer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Textbox_Path)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox Textbox_Path;
        private Telerik.WinControls.Themes.CrystalDarkTheme DarkTheme;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Button_Install;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Button_Browse;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Button_Uninstall;
    }
}


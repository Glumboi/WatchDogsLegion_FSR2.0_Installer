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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges13 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges14 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges15 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.Textbox_Path = new Telerik.WinControls.UI.RadTextBox();
            this.DarkTheme = new Telerik.WinControls.Themes.CrystalDarkTheme();
            this.Button_Install = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
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
            this.Textbox_Path.Text = "Enter your WDL path here...";
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
            borderEdges13.BottomLeft = true;
            borderEdges13.BottomRight = true;
            borderEdges13.TopLeft = true;
            borderEdges13.TopRight = true;
            this.Button_Install.CustomizableEdges = borderEdges13;
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
            this.Button_Install.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.OnIdleState.IconLeftImage")));
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
            // bunifuButton1
            // 
            this.bunifuButton1.AllowAnimations = true;
            this.bunifuButton1.AllowMouseEffects = true;
            this.bunifuButton1.AllowToggling = false;
            this.bunifuButton1.AnimationSpeed = 200;
            this.bunifuButton1.AutoGenerateColors = false;
            this.bunifuButton1.AutoRoundBorders = true;
            this.bunifuButton1.AutoSizeLeftIcon = true;
            this.bunifuButton1.AutoSizeRightIcon = true;
            this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.ButtonText = "";
            this.bunifuButton1.ButtonTextMarginLeft = 0;
            this.bunifuButton1.ColorContrastOnClick = 45;
            this.bunifuButton1.ColorContrastOnHover = 45;
            this.bunifuButton1.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges14.BottomLeft = true;
            borderEdges14.BottomRight = true;
            borderEdges14.TopLeft = true;
            borderEdges14.TopRight = true;
            this.bunifuButton1.CustomizableEdges = borderEdges14;
            this.bunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton1.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton1.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton1.IconMarginLeft = 11;
            this.bunifuButton1.IconPadding = 10;
            this.bunifuButton1.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton1.IconSize = 25;
            this.bunifuButton1.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuButton1.IdleBorderRadius = 41;
            this.bunifuButton1.IdleBorderThickness = 1;
            this.bunifuButton1.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuButton1.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.IdleIconLeftImage")));
            this.bunifuButton1.IdleIconRightImage = null;
            this.bunifuButton1.IndicateFocus = false;
            this.bunifuButton1.Location = new System.Drawing.Point(280, 7);
            this.bunifuButton1.Name = "bunifuButton1";
            this.bunifuButton1.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton1.OnDisabledState.BorderRadius = 1;
            this.bunifuButton1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnDisabledState.BorderThickness = 1;
            this.bunifuButton1.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton1.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton1.OnDisabledState.IconLeftImage = null;
            this.bunifuButton1.OnDisabledState.IconRightImage = null;
            this.bunifuButton1.onHoverState.BorderColor = System.Drawing.Color.Silver;
            this.bunifuButton1.onHoverState.BorderRadius = 1;
            this.bunifuButton1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.onHoverState.BorderThickness = 1;
            this.bunifuButton1.onHoverState.FillColor = System.Drawing.Color.Gray;
            this.bunifuButton1.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.onHoverState.IconLeftImage = null;
            this.bunifuButton1.onHoverState.IconRightImage = null;
            this.bunifuButton1.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuButton1.OnIdleState.BorderRadius = 1;
            this.bunifuButton1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnIdleState.BorderThickness = 1;
            this.bunifuButton1.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuButton1.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.OnIdleState.IconLeftImage1")));
            this.bunifuButton1.OnIdleState.IconRightImage = null;
            this.bunifuButton1.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuButton1.OnPressedState.BorderRadius = 1;
            this.bunifuButton1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnPressedState.BorderThickness = 1;
            this.bunifuButton1.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuButton1.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnPressedState.IconLeftImage = null;
            this.bunifuButton1.OnPressedState.IconRightImage = null;
            this.bunifuButton1.Size = new System.Drawing.Size(46, 43);
            this.bunifuButton1.TabIndex = 2;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton1.TextMarginLeft = 0;
            this.bunifuButton1.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton1.UseDefaultRadiusAndThickness = true;
            this.bunifuButton1.Click += new System.EventHandler(this.bunifuButton1_Click);
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
            borderEdges15.BottomLeft = true;
            borderEdges15.BottomRight = true;
            borderEdges15.TopLeft = true;
            borderEdges15.TopRight = true;
            this.Button_Uninstall.CustomizableEdges = borderEdges15;
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
            this.Button_Uninstall.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton2.OnIdleState.IconLeftImage")));
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
            this.Controls.Add(this.bunifuButton1);
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
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Button_Uninstall;
    }
}


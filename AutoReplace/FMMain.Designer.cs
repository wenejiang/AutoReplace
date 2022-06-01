
namespace AutoReplace
{
    partial class FMMain
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
            this.components = new System.ComponentModel.Container();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.xStatus = new DevComponents.DotNetBar.Metro.MetroStatusBar();
            this.xHelp = new DevComponents.DotNetBar.LabelItem();
            this.metroToolbar1 = new DevComponents.DotNetBar.Metro.MetroToolbar();
            this.xFileName = new DevComponents.DotNetBar.LabelItem();
            this.xProjectList = new DevComponents.DotNetBar.ComboBoxItem();
            this.xConfig = new DevComponents.DotNetBar.ButtonItem();
            this.xClose = new DevComponents.DotNetBar.ButtonItem();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.xCopy = new DevComponents.DotNetBar.ButtonX();
            this.xPaste = new DevComponents.DotNetBar.ButtonX();
            this.xOutput = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.reflectionLabel2 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.xInput = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.xMultiReplace = new DevComponents.DotNetBar.CheckBoxItem();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // xStatus
            // 
            // 
            // 
            // 
            this.xStatus.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.xStatus.ContainerControlProcessDialogKey = true;
            this.xStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.xStatus.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xStatus.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.xHelp});
            this.xStatus.Location = new System.Drawing.Point(0, 435);
            this.xStatus.Name = "xStatus";
            this.xStatus.Size = new System.Drawing.Size(812, 33);
            this.xStatus.TabIndex = 1;
            this.xStatus.Text = "metroStatusBar1";
            // 
            // xHelp
            // 
            this.xHelp.Name = "xHelp";
            this.xHelp.Text = "      ";
            // 
            // metroToolbar1
            // 
            this.metroToolbar1.AutoCollapse = false;
            // 
            // 
            // 
            this.metroToolbar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroToolbar1.ContainerControlProcessDialogKey = true;
            this.metroToolbar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroToolbar1.ExtraItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.xMultiReplace});
            this.metroToolbar1.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroToolbar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.xFileName,
            this.xProjectList,
            this.xConfig,
            this.xClose});
            this.metroToolbar1.Location = new System.Drawing.Point(0, 0);
            this.metroToolbar1.Name = "metroToolbar1";
            this.metroToolbar1.Size = new System.Drawing.Size(812, 28);
            this.metroToolbar1.TabIndex = 2;
            this.metroToolbar1.Text = "metroToolbar1";
            // 
            // xFileName
            // 
            this.xFileName.Name = "xFileName";
            this.xFileName.Text = "替换方案";
            // 
            // xProjectList
            // 
            this.xProjectList.ComboWidth = 150;
            this.xProjectList.DropDownHeight = 106;
            this.xProjectList.ItemHeight = 20;
            this.xProjectList.Name = "xProjectList";
            this.xProjectList.WatermarkText = "替换方案";
            this.xProjectList.SelectedIndexChanged += new System.EventHandler(this.xProjectList_SelectedIndexChanged);
            // 
            // xConfig
            // 
            this.xConfig.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.xConfig.Name = "xConfig";
            this.xConfig.Symbol = "";
            this.xConfig.Text = "配置";
            this.xConfig.Click += new System.EventHandler(this.xConfig_Click);
            // 
            // xClose
            // 
            this.xClose.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.xClose.Name = "xClose";
            this.xClose.Symbol = "";
            this.xClose.Text = "关闭";
            this.xClose.Click += new System.EventHandler(this.xClose_Click);
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.xCopy);
            this.panelEx1.Controls.Add(this.xPaste);
            this.panelEx1.Controls.Add(this.xOutput);
            this.panelEx1.Controls.Add(this.reflectionLabel2);
            this.panelEx1.Controls.Add(this.xInput);
            this.panelEx1.Controls.Add(this.reflectionLabel1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 28);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(812, 407);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 3;
            // 
            // xCopy
            // 
            this.xCopy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.xCopy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.xCopy.Location = new System.Drawing.Point(452, 218);
            this.xCopy.Name = "xCopy";
            this.xCopy.Size = new System.Drawing.Size(168, 33);
            this.xCopy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.xCopy.TabIndex = 5;
            this.xCopy.Text = "复制(Copy)";
            this.xCopy.Click += new System.EventHandler(this.xCopy_Click);
            // 
            // xPaste
            // 
            this.xPaste.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.xPaste.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.xPaste.Location = new System.Drawing.Point(452, 18);
            this.xPaste.Name = "xPaste";
            this.xPaste.Size = new System.Drawing.Size(168, 33);
            this.xPaste.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.xPaste.TabIndex = 4;
            this.xPaste.Text = "粘贴(Paste)";
            this.xPaste.Click += new System.EventHandler(this.xPaste_Click);
            // 
            // xOutput
            // 
            this.xOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xOutput.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.xOutput.Border.Class = "TextBoxBorder";
            this.xOutput.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.xOutput.ForeColor = System.Drawing.Color.Black;
            this.xOutput.Location = new System.Drawing.Point(13, 271);
            this.xOutput.Multiline = true;
            this.xOutput.Name = "xOutput";
            this.xOutput.Size = new System.Drawing.Size(776, 122);
            this.xOutput.TabIndex = 3;
            // 
            // reflectionLabel2
            // 
            // 
            // 
            // 
            this.reflectionLabel2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel2.Location = new System.Drawing.Point(18, 206);
            this.reflectionLabel2.Name = "reflectionLabel2";
            this.reflectionLabel2.Size = new System.Drawing.Size(188, 58);
            this.reflectionLabel2.TabIndex = 2;
            this.reflectionLabel2.Text = "<b><font size=\"+6\"><font color=\"#B02B2C\"><i>替换后:</i></font>文本</font></b>";
            // 
            // xInput
            // 
            this.xInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xInput.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.xInput.Border.Class = "TextBoxBorder";
            this.xInput.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.xInput.ForeColor = System.Drawing.Color.Black;
            this.xInput.Location = new System.Drawing.Point(13, 73);
            this.xInput.Multiline = true;
            this.xInput.Name = "xInput";
            this.xInput.Size = new System.Drawing.Size(776, 122);
            this.xInput.TabIndex = 1;
            this.xInput.TextChanged += new System.EventHandler(this.xInput_TextChanged);
            // 
            // reflectionLabel1
            // 
            // 
            // 
            // 
            this.reflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel1.Location = new System.Drawing.Point(18, 8);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(188, 58);
            this.reflectionLabel1.TabIndex = 0;
            this.reflectionLabel1.Text = "<b><font size=\"+6\"><font color=\"#B02B2C\"><i>替换前:</i></font>文本</font></b>";
            // 
            // itemContainer1
            // 
            // 
            // 
            // 
            this.itemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer1.Name = "itemContainer1";
            // 
            // 
            // 
            this.itemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // xMultiReplace
            // 
            this.xMultiReplace.Name = "xMultiReplace";
            this.xMultiReplace.Text = "执行所有替换（不选则执行一次替换即停止）";
            // 
            // FMMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 468);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.metroToolbar1);
            this.Controls.Add(this.xStatus);
            this.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "FMMain";
            this.ShowIcon = false;
            this.Text = "自动文本替换工具";
            this.Load += new System.EventHandler(this.FMMain_Load);
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.Metro.MetroStatusBar xStatus;
        private DevComponents.DotNetBar.Metro.MetroToolbar metroToolbar1;
        private DevComponents.DotNetBar.LabelItem xHelp;
        private DevComponents.DotNetBar.ButtonItem xConfig;
        private DevComponents.DotNetBar.ButtonItem xClose;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.TextBoxX xOutput;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel2;
        private DevComponents.DotNetBar.Controls.TextBoxX xInput;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private DevComponents.DotNetBar.ButtonX xCopy;
        private DevComponents.DotNetBar.ButtonX xPaste;
        private DevComponents.DotNetBar.LabelItem xFileName;
        private DevComponents.DotNetBar.ComboBoxItem xProjectList;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private DevComponents.DotNetBar.CheckBoxItem xMultiReplace;
    }
}


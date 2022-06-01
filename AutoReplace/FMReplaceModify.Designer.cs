
namespace AutoReplace
{
    partial class FMReplaceModify
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroToolbar1 = new DevComponents.DotNetBar.Metro.MetroToolbar();
            this.xFileName = new DevComponents.DotNetBar.LabelItem();
            this.xProjectList = new DevComponents.DotNetBar.ComboBoxItem();
            this.xLoad = new DevComponents.DotNetBar.ButtonItem();
            this.xSave = new DevComponents.DotNetBar.ButtonItem();
            this.xSaveNew = new DevComponents.DotNetBar.ButtonItem();
            this.xClose = new DevComponents.DotNetBar.ButtonItem();
            this.xStatus = new DevComponents.DotNetBar.Metro.MetroStatusBar();
            this.xHelp = new DevComponents.DotNetBar.LabelItem();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.xDataGridView = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.xColumnOld = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xColumnNew = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xClear = new DevComponents.DotNetBar.ButtonItem();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xDataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.metroToolbar1.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroToolbar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.xFileName,
            this.xProjectList,
            this.xLoad,
            this.xSave,
            this.xSaveNew,
            this.xClear,
            this.xClose});
            this.metroToolbar1.Location = new System.Drawing.Point(0, 0);
            this.metroToolbar1.Name = "metroToolbar1";
            this.metroToolbar1.Size = new System.Drawing.Size(856, 57);
            this.metroToolbar1.TabIndex = 3;
            this.metroToolbar1.Text = "metroToolbar1";
            // 
            // xFileName
            // 
            this.xFileName.Name = "xFileName";
            this.xFileName.Text = "替换配置方案";
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
            // xLoad
            // 
            this.xLoad.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.xLoad.Name = "xLoad";
            this.xLoad.Symbol = "";
            this.xLoad.Text = "读取";
            this.xLoad.Click += new System.EventHandler(this.xLoad_Click);
            // 
            // xSave
            // 
            this.xSave.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.xSave.Name = "xSave";
            this.xSave.Symbol = "";
            this.xSave.Text = "保存";
            this.xSave.Click += new System.EventHandler(this.xSave_Click);
            // 
            // xSaveNew
            // 
            this.xSaveNew.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.xSaveNew.Name = "xSaveNew";
            this.xSaveNew.Symbol = "";
            this.xSaveNew.Text = "保存新方案";
            this.xSaveNew.Click += new System.EventHandler(this.xSaveNew_Click);
            // 
            // xClose
            // 
            this.xClose.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.xClose.Name = "xClose";
            this.xClose.Symbol = "";
            this.xClose.Text = "关闭";
            this.xClose.Click += new System.EventHandler(this.xClose_Click);
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
            this.xStatus.Location = new System.Drawing.Point(0, 417);
            this.xStatus.Name = "xStatus";
            this.xStatus.Size = new System.Drawing.Size(856, 33);
            this.xStatus.TabIndex = 4;
            this.xStatus.Text = "metroStatusBar1";
            // 
            // xHelp
            // 
            this.xHelp.Name = "xHelp";
            this.xHelp.Text = "      ";
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.xDataGridView);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 57);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(856, 360);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 5;
            this.panelEx1.Text = "panelEx1";
            // 
            // xDataGridView
            // 
            this.xDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.xDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.xDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.xDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xColumnOld,
            this.xColumnNew});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.xDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.xDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xDataGridView.EnableHeadersVisualStyles = false;
            this.xDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.xDataGridView.Location = new System.Drawing.Point(0, 0);
            this.xDataGridView.Name = "xDataGridView";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.xDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.xDataGridView.RowTemplate.Height = 23;
            this.xDataGridView.Size = new System.Drawing.Size(856, 360);
            this.xDataGridView.TabIndex = 0;
            // 
            // xColumnOld
            // 
            this.xColumnOld.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xColumnOld.FillWeight = 50F;
            this.xColumnOld.HeaderText = "被替换文本";
            this.xColumnOld.Name = "xColumnOld";
            // 
            // xColumnNew
            // 
            this.xColumnNew.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xColumnNew.FillWeight = 50F;
            this.xColumnNew.HeaderText = "新文本";
            this.xColumnNew.Name = "xColumnNew";
            // 
            // xClear
            // 
            this.xClear.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.xClear.Name = "xClear";
            this.xClear.Symbol = "";
            this.xClear.Text = "清空";
            this.xClear.Click += new System.EventHandler(this.xClear_Click);
            // 
            // FMReplaceModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 450);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.xStatus);
            this.Controls.Add(this.metroToolbar1);
            this.Name = "FMReplaceModify";
            this.ShowIcon = false;
            this.Text = "替换列表编辑";
            this.Load += new System.EventHandler(this.FMReplaceModify_Load);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Metro.MetroToolbar metroToolbar1;
        private DevComponents.DotNetBar.ButtonItem xSave;
        private DevComponents.DotNetBar.ButtonItem xClose;
        private DevComponents.DotNetBar.Metro.MetroStatusBar xStatus;
        private DevComponents.DotNetBar.LabelItem xHelp;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.DataGridViewX xDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn xColumnOld;
        private System.Windows.Forms.DataGridViewTextBoxColumn xColumnNew;
        private DevComponents.DotNetBar.LabelItem xFileName;
        private DevComponents.DotNetBar.ComboBoxItem xProjectList;
        private DevComponents.DotNetBar.ButtonItem xLoad;
        private DevComponents.DotNetBar.ButtonItem xSaveNew;
        private DevComponents.DotNetBar.ButtonItem xClear;
    }
}
namespace ExcelImageBits
{
    partial class MainRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// デザイナー変数が必要です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public MainRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary>
        /// デザイナーのサポートに必要なメソッドです。
        /// このメソッドの内容をコード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabImageBits = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.btnImageSelect = this.Factory.CreateRibbonButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabImageBits.SuspendLayout();
            this.group1.SuspendLayout();
            // 
            // tabImageBits
            // 
            this.tabImageBits.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tabImageBits.Groups.Add(this.group1);
            this.tabImageBits.Label = "画像変換";
            this.tabImageBits.Name = "tabImageBits";
            // 
            // group1
            // 
            this.group1.Items.Add(this.btnImageSelect);
            this.group1.Label = "ファイル指定";
            this.group1.Name = "group1";
            // 
            // btnImageSelect
            // 
            this.btnImageSelect.Label = "Import";
            this.btnImageSelect.Name = "btnImageSelect";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Title = "画像選択";
            // 
            // MainRibbon
            // 
            this.Name = "MainRibbon";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tabImageBits);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.MainRibbon_Load);
            this.tabImageBits.ResumeLayout(false);
            this.tabImageBits.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tabImageBits;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnImageSelect;
        public System.Windows.Forms.OpenFileDialog openFileDialog;
    }

    partial class ThisRibbonCollection
    {
        internal MainRibbon MainRibbon
        {
            get { return this.GetRibbon<MainRibbon>(); }
        }
    }
}

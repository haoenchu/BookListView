namespace BookListView
{
    partial class frmBooks
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBooks));
            this.lvwBooks = new System.Windows.Forms.ListView();
            this.ImageL = new System.Windows.Forms.ImageList(this.components);
            this.imageS = new System.Windows.Forms.ImageList(this.components);
            this.grpView = new System.Windows.Forms.GroupBox();
            this.cmbView = new System.Windows.Forms.ComboBox();
            this.grpBorrow = new System.Windows.Forms.GroupBox();
            this.lvwBorrow = new System.Windows.Forms.ListView();
            this.borrowdate = new System.Windows.Forms.DateTimePicker();
            this.pnlTools = new System.Windows.Forms.Panel();
            this.grpView.SuspendLayout();
            this.grpBorrow.SuspendLayout();
            this.pnlTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwBooks
            // 
            this.lvwBooks.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.lvwBooks.HideSelection = false;
            this.lvwBooks.LargeImageList = this.ImageL;
            this.lvwBooks.Location = new System.Drawing.Point(3, 3);
            this.lvwBooks.Name = "lvwBooks";
            this.lvwBooks.Size = new System.Drawing.Size(478, 404);
            this.lvwBooks.SmallImageList = this.imageS;
            this.lvwBooks.TabIndex = 0;
            this.lvwBooks.UseCompatibleStateImageBehavior = false;
            this.lvwBooks.ItemActivate += new System.EventHandler(this.lvwBooks_ItemActivate);
            this.lvwBooks.SelectedIndexChanged += new System.EventHandler(this.lvwBooks_SelectedIndexChanged);
            // 
            // ImageL
            // 
            this.ImageL.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageL.ImageStream")));
            this.ImageL.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageL.Images.SetKeyName(0, "Book1.bmp");
            this.ImageL.Images.SetKeyName(1, "Book2.bmp");
            this.ImageL.Images.SetKeyName(2, "Book3.bmp");
            this.ImageL.Images.SetKeyName(3, "Book4.bmp");
            this.ImageL.Images.SetKeyName(4, "Book5.bmp");
            this.ImageL.Images.SetKeyName(5, "Book6.bmp");
            this.ImageL.Images.SetKeyName(6, "Book7.bmp");
            this.ImageL.Images.SetKeyName(7, "Book8.bmp");
            // 
            // imageS
            // 
            this.imageS.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageS.ImageStream")));
            this.imageS.TransparentColor = System.Drawing.Color.Transparent;
            this.imageS.Images.SetKeyName(0, "Book1.bmp");
            this.imageS.Images.SetKeyName(1, "Book2.bmp");
            this.imageS.Images.SetKeyName(2, "Book3.bmp");
            this.imageS.Images.SetKeyName(3, "Book4.bmp");
            this.imageS.Images.SetKeyName(4, "Book5.bmp");
            this.imageS.Images.SetKeyName(5, "Book6.bmp");
            this.imageS.Images.SetKeyName(6, "Book7.bmp");
            this.imageS.Images.SetKeyName(7, "Book8.bmp");
            // 
            // grpView
            // 
            this.grpView.Controls.Add(this.cmbView);
            this.grpView.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpView.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpView.Location = new System.Drawing.Point(0, 0);
            this.grpView.Name = "grpView";
            this.grpView.Size = new System.Drawing.Size(359, 70);
            this.grpView.TabIndex = 3;
            this.grpView.TabStop = false;
            this.grpView.Text = "檢視方式";
            this.grpView.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmbView
            // 
            this.cmbView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbView.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmbView.FormattingEnabled = true;
            this.cmbView.Location = new System.Drawing.Point(3, 25);
            this.cmbView.Name = "cmbView";
            this.cmbView.Size = new System.Drawing.Size(353, 28);
            this.cmbView.TabIndex = 3;
            this.cmbView.SelectedIndexChanged += new System.EventHandler(this.cmbView_SelectedIndexChanged);
            // 
            // grpBorrow
            // 
            this.grpBorrow.Controls.Add(this.lvwBorrow);
            this.grpBorrow.Controls.Add(this.borrowdate);
            this.grpBorrow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBorrow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpBorrow.Location = new System.Drawing.Point(0, 70);
            this.grpBorrow.Name = "grpBorrow";
            this.grpBorrow.Size = new System.Drawing.Size(359, 334);
            this.grpBorrow.TabIndex = 4;
            this.grpBorrow.TabStop = false;
            this.grpBorrow.Text = "借書清單";
            this.grpBorrow.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lvwBorrow
            // 
            this.lvwBorrow.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.lvwBorrow.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvwBorrow.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lvwBorrow.HideSelection = false;
            this.lvwBorrow.Location = new System.Drawing.Point(3, 60);
            this.lvwBorrow.Name = "lvwBorrow";
            this.lvwBorrow.Size = new System.Drawing.Size(353, 271);
            this.lvwBorrow.TabIndex = 5;
            this.lvwBorrow.UseCompatibleStateImageBehavior = false;
            this.lvwBorrow.View = System.Windows.Forms.View.Details;
            this.lvwBorrow.SelectedIndexChanged += new System.EventHandler(this.lvwBorrow_ItemActivate);
            // 
            // borrowdate
            // 
            this.borrowdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.borrowdate.Location = new System.Drawing.Point(3, 25);
            this.borrowdate.Name = "borrowdate";
            this.borrowdate.Size = new System.Drawing.Size(353, 29);
            this.borrowdate.TabIndex = 4;
            this.borrowdate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // pnlTools
            // 
            this.pnlTools.Controls.Add(this.grpBorrow);
            this.pnlTools.Controls.Add(this.grpView);
            this.pnlTools.Location = new System.Drawing.Point(487, 3);
            this.pnlTools.Name = "pnlTools";
            this.pnlTools.Size = new System.Drawing.Size(359, 404);
            this.pnlTools.TabIndex = 3;
            this.pnlTools.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTools_Paint);
            // 
            // frmBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 411);
            this.Controls.Add(this.lvwBooks);
            this.Controls.Add(this.pnlTools);
            this.Name = "frmBooks";
            this.Text = "圖書管理";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpView.ResumeLayout(false);
            this.grpBorrow.ResumeLayout(false);
            this.pnlTools.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwBooks;
        private System.Windows.Forms.GroupBox grpView;
        private System.Windows.Forms.ComboBox cmbView;
        private System.Windows.Forms.GroupBox grpBorrow;
        private System.Windows.Forms.Panel pnlTools;
        private System.Windows.Forms.ImageList ImageL;
        private System.Windows.Forms.ImageList imageS;
        private System.Windows.Forms.DateTimePicker borrowdate;
        private System.Windows.Forms.ListView lvwBorrow;
    }
}


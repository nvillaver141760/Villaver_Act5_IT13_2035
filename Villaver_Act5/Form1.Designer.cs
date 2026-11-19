using System.Drawing;
using System.Windows.Forms;

namespace Villaver_Act5
{
    partial class Form1
    {
        private void InitializeComponent()
        {
            this.pnlHeader = new Panel();
            this.lblTitle = new Label();
            this.pnlEntry = new Panel();
            this.lblEntry = new Label();
            this.lblInitial = new Label();
            this.txtBoxInitial = new TextBox();
            this.lblSalespeople = new Label();
            this.lblAmount = new Label();
            this.txtBoxAmount = new TextBox();
            this.btnSubmit = new Button();
            this.btnClear = new Button();
            this.pnlHistory = new Panel();
            this.lblHistory = new Label();
            this.btnPrint = new Button();
            this.txtSalesLog = new TextBox();
            this.pnlHeader.SuspendLayout();
            this.pnlEntry.SuspendLayout();
            this.pnlHistory.SuspendLayout();
            this.SuspendLayout();

            this.pnlHeader.Location = new Point(0, 0);
            this.pnlHeader.Size = new Size(924, 110);
            this.pnlHeader.BackColor = Color.FromArgb(18, 35, 56);
            this.pnlHeader.TabStop = false;
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Controls.Add(this.lblTitle);

            this.lblTitle.Location = new Point(32, 26);
            this.lblTitle.Size = new Size(860, 52);
            this.lblTitle.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.White;
            this.lblTitle.Text = "Home Sales Tracker";
            this.lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            this.lblTitle.Name = "lblTitle";

            this.pnlEntry.Location = new Point(28, 134);
            this.pnlEntry.Size = new Size(288, 394);
            this.pnlEntry.BackColor = Color.White;
            this.pnlEntry.TabIndex = 0;
            this.pnlEntry.Name = "pnlEntry";
            this.pnlEntry.Controls.Add(this.lblEntry);
            this.pnlEntry.Controls.Add(this.lblInitial);
            this.pnlEntry.Controls.Add(this.txtBoxInitial);
            this.pnlEntry.Controls.Add(this.lblSalespeople);
            this.pnlEntry.Controls.Add(this.lblAmount);
            this.pnlEntry.Controls.Add(this.txtBoxAmount);
            this.pnlEntry.Controls.Add(this.btnSubmit);
            this.pnlEntry.Controls.Add(this.btnClear);

            this.lblEntry.Location = new Point(24, 20);
            this.lblEntry.Size = new Size(240, 35);
            this.lblEntry.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            this.lblEntry.ForeColor = Color.FromArgb(24, 43, 61);
            this.lblEntry.Text = "Record a sale";
            this.lblEntry.TextAlign = ContentAlignment.MiddleLeft;
            this.lblEntry.Name = "lblEntry";

            this.lblInitial.Location = new Point(24, 73);
            this.lblInitial.Size = new Size(240, 24);
            this.lblInitial.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblInitial.ForeColor = Color.FromArgb(24, 43, 61);
            this.lblInitial.Text = "Salesperson initial";
            this.lblInitial.TextAlign = ContentAlignment.MiddleLeft;
            this.lblInitial.Name = "lblInitial";

            this.txtBoxInitial.Location = new Point(24, 102);
            this.txtBoxInitial.Size = new Size(240, 29);
            this.txtBoxInitial.AccessibleName = "Salesperson initial";
            this.txtBoxInitial.BackColor = Color.FromArgb(245, 249, 252);
            this.txtBoxInitial.BorderStyle = BorderStyle.FixedSingle;
            this.txtBoxInitial.Font = new Font("Segoe UI", 12F, FontStyle.Regular);
            this.txtBoxInitial.ForeColor = Color.FromArgb(24, 43, 61);
            this.txtBoxInitial.TabIndex = 0;
            this.txtBoxInitial.Name = "txtBoxInitial";

            this.lblSalespeople.Location = new Point(24, 139);
            this.lblSalespeople.Size = new Size(240, 22);
            this.lblSalespeople.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.lblSalespeople.ForeColor = Color.FromArgb(70, 93, 112);
            this.lblSalespeople.Text = "D  Danielle    /    E  Edward    /    F  Fatima";
            this.lblSalespeople.TextAlign = ContentAlignment.MiddleLeft;
            this.lblSalespeople.Name = "lblSalespeople";

            this.lblAmount.Location = new Point(24, 180);
            this.lblAmount.Size = new Size(240, 24);
            this.lblAmount.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblAmount.ForeColor = Color.FromArgb(24, 43, 61);
            this.lblAmount.Text = "Sale amount (₱)";
            this.lblAmount.TextAlign = ContentAlignment.MiddleLeft;
            this.lblAmount.Name = "lblAmount";

            this.txtBoxAmount.Location = new Point(24, 209);
            this.txtBoxAmount.Size = new Size(240, 29);
            this.txtBoxAmount.AccessibleName = "Sale amount in pesos";
            this.txtBoxAmount.BackColor = Color.FromArgb(245, 249, 252);
            this.txtBoxAmount.BorderStyle = BorderStyle.FixedSingle;
            this.txtBoxAmount.Font = new Font("Segoe UI", 12F, FontStyle.Regular);
            this.txtBoxAmount.ForeColor = Color.FromArgb(24, 43, 61);
            this.txtBoxAmount.TabIndex = 1;
            this.txtBoxAmount.Name = "txtBoxAmount";

            this.btnSubmit.Location = new Point(24, 263);
            this.btnSubmit.Size = new Size(240, 40);
            this.btnSubmit.BackColor = Color.FromArgb(10, 105, 96);
            this.btnSubmit.FlatAppearance.BorderColor = Color.FromArgb(215, 227, 236);
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatAppearance.MouseDownBackColor = Color.FromArgb(8, 78, 73);
            this.btnSubmit.FlatAppearance.MouseOverBackColor = Color.FromArgb(8, 88, 81);
            this.btnSubmit.FlatStyle = FlatStyle.Flat;
            this.btnSubmit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnSubmit.ForeColor = Color.White;
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit sale";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);

            this.btnClear.Location = new Point(24, 315);
            this.btnClear.Size = new Size(240, 40);
            this.btnClear.BackColor = Color.FromArgb(245, 249, 252);
            this.btnClear.FlatAppearance.BorderColor = Color.FromArgb(215, 227, 236);
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseDownBackColor = Color.FromArgb(211, 227, 237);
            this.btnClear.FlatAppearance.MouseOverBackColor = Color.FromArgb(225, 237, 244);
            this.btnClear.FlatStyle = FlatStyle.Flat;
            this.btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnClear.ForeColor = Color.FromArgb(24, 43, 61);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Name = "btnClear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            this.pnlHistory.Location = new Point(336, 134);
            this.pnlHistory.Size = new Size(560, 394);
            this.pnlHistory.BackColor = Color.White;
            this.pnlHistory.TabIndex = 1;
            this.pnlHistory.Name = "pnlHistory";
            this.pnlHistory.Controls.Add(this.lblHistory);
            this.pnlHistory.Controls.Add(this.btnPrint);
            this.pnlHistory.Controls.Add(this.txtSalesLog);

            this.lblHistory.Location = new Point(24, 20);
            this.lblHistory.Size = new Size(330, 35);
            this.lblHistory.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            this.lblHistory.ForeColor = Color.FromArgb(24, 43, 61);
            this.lblHistory.Text = "Transaction history";
            this.lblHistory.TextAlign = ContentAlignment.MiddleLeft;
            this.lblHistory.Name = "lblHistory";

            this.btnPrint.Location = new Point(391, 19);
            this.btnPrint.Size = new Size(145, 40);
            this.btnPrint.BackColor = Color.White;
            this.btnPrint.FlatAppearance.BorderColor = Color.FromArgb(215, 227, 236);
            this.btnPrint.FlatAppearance.BorderSize = 1;
            this.btnPrint.FlatAppearance.MouseDownBackColor = Color.FromArgb(211, 227, 237);
            this.btnPrint.FlatAppearance.MouseOverBackColor = Color.FromArgb(225, 237, 244);
            this.btnPrint.FlatStyle = FlatStyle.Flat;
            this.btnPrint.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnPrint.ForeColor = Color.FromArgb(24, 43, 61);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Print summary";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);

            this.txtSalesLog.Location = new Point(24, 76);
            this.txtSalesLog.Size = new Size(512, 294);
            this.txtSalesLog.AccessibleName = "Sales transaction history";
            this.txtSalesLog.BackColor = Color.FromArgb(245, 249, 252);
            this.txtSalesLog.BorderStyle = BorderStyle.FixedSingle;
            this.txtSalesLog.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            this.txtSalesLog.ForeColor = Color.FromArgb(24, 43, 61);
            this.txtSalesLog.Multiline = true;
            this.txtSalesLog.ReadOnly = true;
            this.txtSalesLog.ScrollBars = ScrollBars.Vertical;
            this.txtSalesLog.TabIndex = 1;
            this.txtSalesLog.Name = "txtSalesLog";

            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(234, 241, 247);
            this.AcceptButton = this.btnSubmit;
            this.ClientSize = new Size(924, 554);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Home Sales Tracker";
            this.Name = "Form1";
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlEntry);
            this.Controls.Add(this.pnlHistory);
            this.pnlHeader.ResumeLayout(false);
            this.pnlEntry.ResumeLayout(false);
            this.pnlEntry.PerformLayout();
            this.pnlHistory.ResumeLayout(false);
            this.pnlHistory.PerformLayout();
            this.ResumeLayout(false);
        }

        private Panel pnlHeader;
        private Label lblTitle;
        private Panel pnlEntry;
        private Label lblEntry;
        private Label lblInitial;
        private TextBox txtBoxInitial;
        private Label lblSalespeople;
        private Label lblAmount;
        private TextBox txtBoxAmount;
        private Button btnSubmit;
        private Button btnClear;
        private Panel pnlHistory;
        private Label lblHistory;
        private Button btnPrint;
        private TextBox txtSalesLog;
    }
}

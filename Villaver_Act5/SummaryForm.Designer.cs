using System.Drawing;
using System.Windows.Forms;

namespace Villaver_Act5
{
    partial class SummaryForm
    {
        private void InitializeComponent()
        {
            this.pnlHeader = new Panel();
            this.lblTitle = new Label();
            this.pnlTotals = new Panel();
            this.lblDanielleName = new Label();
            this.lblDanielle = new Label();
            this.pnlDanielleDivider = new Panel();
            this.lblEdwardName = new Label();
            this.lblEdward = new Label();
            this.pnlEdwardDivider = new Panel();
            this.lblFatimaName = new Label();
            this.lblFatima = new Label();
            this.pnlGrandTotal = new Panel();
            this.lblTotalCaption = new Label();
            this.lblTotal = new Label();
            this.btnClose = new Button();
            this.pnlHeader.SuspendLayout();
            this.pnlTotals.SuspendLayout();
            this.pnlGrandTotal.SuspendLayout();
            this.SuspendLayout();

            this.pnlHeader.Location = new Point(0, 0);
            this.pnlHeader.Size = new Size(560, 88);
            this.pnlHeader.BackColor = Color.FromArgb(18, 35, 56);
            this.pnlHeader.TabStop = false;
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Controls.Add(this.lblTitle);

            this.lblTitle.Location = new Point(24, 20);
            this.lblTitle.Size = new Size(512, 46);
            this.lblTitle.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.White;
            this.lblTitle.Text = "Sales Summary Report";
            this.lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            this.lblTitle.Name = "lblTitle";

            this.pnlTotals.Location = new Point(24, 108);
            this.pnlTotals.Size = new Size(512, 150);
            this.pnlTotals.BackColor = Color.White;
            this.pnlTotals.TabStop = false;
            this.pnlTotals.Name = "pnlTotals";
            this.pnlTotals.Controls.Add(this.lblDanielleName);
            this.pnlTotals.Controls.Add(this.lblDanielle);
            this.pnlTotals.Controls.Add(this.pnlDanielleDivider);
            this.pnlTotals.Controls.Add(this.lblEdwardName);
            this.pnlTotals.Controls.Add(this.lblEdward);
            this.pnlTotals.Controls.Add(this.pnlEdwardDivider);
            this.pnlTotals.Controls.Add(this.lblFatimaName);
            this.pnlTotals.Controls.Add(this.lblFatima);

            this.lblDanielleName.Location = new Point(18, 5);
            this.lblDanielleName.Size = new Size(132, 40);
            this.lblDanielleName.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblDanielleName.ForeColor = Color.FromArgb(24, 43, 61);
            this.lblDanielleName.Text = "Danielle";
            this.lblDanielleName.TextAlign = ContentAlignment.MiddleLeft;
            this.lblDanielleName.Name = "lblDanielleName";

            this.lblDanielle.Location = new Point(153, 5);
            this.lblDanielle.Size = new Size(341, 40);
            this.lblDanielle.Font = new Font("Segoe UI", 12F, FontStyle.Regular);
            this.lblDanielle.ForeColor = Color.FromArgb(24, 43, 61);
            this.lblDanielle.Text = "₱0.00";
            this.lblDanielle.TextAlign = ContentAlignment.MiddleRight;
            this.lblDanielle.Name = "lblDanielle";

            this.pnlDanielleDivider.Location = new Point(18, 49);
            this.pnlDanielleDivider.Size = new Size(476, 1);
            this.pnlDanielleDivider.BackColor = Color.FromArgb(215, 227, 236);
            this.pnlDanielleDivider.TabStop = false;
            this.pnlDanielleDivider.Name = "pnlDanielleDivider";

            this.lblEdwardName.Location = new Point(18, 55);
            this.lblEdwardName.Size = new Size(132, 40);
            this.lblEdwardName.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblEdwardName.ForeColor = Color.FromArgb(24, 43, 61);
            this.lblEdwardName.Text = "Edward";
            this.lblEdwardName.TextAlign = ContentAlignment.MiddleLeft;
            this.lblEdwardName.Name = "lblEdwardName";

            this.lblEdward.Location = new Point(153, 55);
            this.lblEdward.Size = new Size(341, 40);
            this.lblEdward.Font = new Font("Segoe UI", 12F, FontStyle.Regular);
            this.lblEdward.ForeColor = Color.FromArgb(24, 43, 61);
            this.lblEdward.Text = "₱0.00";
            this.lblEdward.TextAlign = ContentAlignment.MiddleRight;
            this.lblEdward.Name = "lblEdward";

            this.pnlEdwardDivider.Location = new Point(18, 99);
            this.pnlEdwardDivider.Size = new Size(476, 1);
            this.pnlEdwardDivider.BackColor = Color.FromArgb(215, 227, 236);
            this.pnlEdwardDivider.TabStop = false;
            this.pnlEdwardDivider.Name = "pnlEdwardDivider";

            this.lblFatimaName.Location = new Point(18, 105);
            this.lblFatimaName.Size = new Size(132, 40);
            this.lblFatimaName.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblFatimaName.ForeColor = Color.FromArgb(24, 43, 61);
            this.lblFatimaName.Text = "Fatima";
            this.lblFatimaName.TextAlign = ContentAlignment.MiddleLeft;
            this.lblFatimaName.Name = "lblFatimaName";

            this.lblFatima.Location = new Point(153, 105);
            this.lblFatima.Size = new Size(341, 40);
            this.lblFatima.Font = new Font("Segoe UI", 12F, FontStyle.Regular);
            this.lblFatima.ForeColor = Color.FromArgb(24, 43, 61);
            this.lblFatima.Text = "₱0.00";
            this.lblFatima.TextAlign = ContentAlignment.MiddleRight;
            this.lblFatima.Name = "lblFatima";

            this.pnlGrandTotal.Location = new Point(24, 274);
            this.pnlGrandTotal.Size = new Size(512, 66);
            this.pnlGrandTotal.BackColor = Color.FromArgb(18, 35, 56);
            this.pnlGrandTotal.TabStop = false;
            this.pnlGrandTotal.Name = "pnlGrandTotal";
            this.pnlGrandTotal.Controls.Add(this.lblTotalCaption);
            this.pnlGrandTotal.Controls.Add(this.lblTotal);

            this.lblTotalCaption.Location = new Point(18, 11);
            this.lblTotalCaption.Size = new Size(132, 44);
            this.lblTotalCaption.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblTotalCaption.ForeColor = Color.FromArgb(197, 232, 229);
            this.lblTotalCaption.Text = "Grand total";
            this.lblTotalCaption.TextAlign = ContentAlignment.MiddleLeft;
            this.lblTotalCaption.Name = "lblTotalCaption";

            this.lblTotal.Location = new Point(153, 11);
            this.lblTotal.Size = new Size(341, 44);
            this.lblTotal.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.lblTotal.ForeColor = Color.White;
            this.lblTotal.Text = "₱0.00";
            this.lblTotal.TextAlign = ContentAlignment.MiddleRight;
            this.lblTotal.Name = "lblTotal";

            this.btnClose.Location = new Point(410, 357);
            this.btnClose.Size = new Size(126, 40);
            this.btnClose.BackColor = Color.FromArgb(10, 105, 96);
            this.btnClose.FlatAppearance.BorderColor = Color.FromArgb(215, 227, 236);
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(8, 78, 73);
            this.btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(8, 88, 81);
            this.btnClose.FlatStyle = FlatStyle.Flat;
            this.btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnClose.ForeColor = Color.White;
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.DialogResult = DialogResult.Cancel;
            this.btnClose.Name = "btnClose";

            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(234, 241, 247);
            this.AcceptButton = this.btnClose;
            this.CancelButton = this.btnClose;
            this.ClientSize = new Size(560, 419);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Sales Summary Report";
            this.Name = "SummaryForm";
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlTotals);
            this.Controls.Add(this.pnlGrandTotal);
            this.Controls.Add(this.btnClose);
            this.pnlHeader.ResumeLayout(false);
            this.pnlTotals.ResumeLayout(false);
            this.pnlGrandTotal.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private Panel pnlHeader;
        private Label lblTitle;
        private Panel pnlTotals;
        private Label lblDanielleName;
        private Label lblDanielle;
        private Panel pnlDanielleDivider;
        private Label lblEdwardName;
        private Label lblEdward;
        private Panel pnlEdwardDivider;
        private Label lblFatimaName;
        private Label lblFatima;
        private Panel pnlGrandTotal;
        private Label lblTotalCaption;
        private Label lblTotal;
        private Button btnClose;
    }
}

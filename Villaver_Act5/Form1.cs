using System;
using System.Globalization;
using System.Windows.Forms;

namespace Villaver_Act5
{
    public partial class Form1 : Form
    {
        private static readonly CultureInfo PesoCulture = CultureInfo.GetCultureInfo("en-PH");

        private double danielleSales;
        private double edwardSales;
        private double fatimaSales;

        public Form1()
        {
            InitializeComponent();
        }

        internal static string FormatPeso(decimal amount)
        {
            return amount.ToString("₱#,##0.00", PesoCulture);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string initial = txtBoxInitial.Text.Trim().ToUpperInvariant();
            if (initial.Length == 0)
            {
                ShowWarning("Please enter the salesperson initial.", "Missing Input", txtBoxInitial);
                return;
            }

            if (initial != "D" && initial != "E" && initial != "F")
            {
                ShowWarning("Please enter D, E, or F.", "Invalid Initial", txtBoxInitial);
                return;
            }

            string amountText = txtBoxAmount.Text;
            decimal amount;
            if (!decimal.TryParse(amountText, NumberStyles.Currency, CultureInfo.CurrentCulture, out amount) &&
                !decimal.TryParse(amountText, NumberStyles.Currency, PesoCulture, out amount))
            {
                ShowWarning("Please enter a valid sale amount.", "Invalid Amount", txtBoxAmount);
                return;
            }

            if (amount <= 0)
            {
                ShowWarning("Sale amount must be greater than zero.", "Invalid Amount", txtBoxAmount);
                return;
            }

            RecordSale(initial, amount);
        }

        private void RecordSale(string initial, decimal amount)
        {
            decimal grandTotal;
            try
            {
                grandTotal = danielleSales + edwardSales + fatimaSales + amount;
            }
            catch (OverflowException)
            {
                ShowWarning("This sale would make the grand total too large.", "Invalid Amount", txtBoxAmount);
                return;
            }

            string salesperson;
            decimal salespersonTotal;
            switch (initial)
            {
                case "D":
                    salesperson = "Danielle";
                    danielleSales += amount;
                    salespersonTotal = danielleSales;
                    break;
                case "E":
                    salesperson = "Edward";
                    edwardSales += amount;
                    salespersonTotal = edwardSales;
                    break;
                case "F":
                    salesperson = "Fatima";
                    fatimaSales += amount;
                    salespersonTotal = fatimaSales;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(initial));
            }

            string separator = txtSalesLog.TextLength == 0 ? "" : Environment.NewLine + Environment.NewLine;
            txtSalesLog.AppendText(
                separator + salesperson + "'s sale recorded: " + FormatPeso(amount) + Environment.NewLine +
                "Total Sales for " + salesperson + ": " + FormatPeso(salespersonTotal) + Environment.NewLine +
                "Grand Total: " + FormatPeso(grandTotal));
            txtSalesLog.ScrollToCaret();
            ClearInputs();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSalesLog.Clear();
            ClearInputs();
        }

        private void ClearInputs()
        {
            txtBoxInitial.Clear();
            txtBoxAmount.Clear();
            txtBoxInitial.Focus();
        }

        private void ShowWarning(string message, string title, TextBox input)
        {
            MessageBox.Show(this, message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            input.Focus();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            using (var report = new SummaryForm(danielleSales, edwardSales, fatimaSales))
            {
                report.ShowDialog(this);
            }
        }
    }
}

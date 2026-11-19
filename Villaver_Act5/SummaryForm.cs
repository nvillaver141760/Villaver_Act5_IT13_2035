using System.Windows.Forms;

namespace Villaver_Act5
{
    public partial class SummaryForm : Form
    {
        public SummaryForm() : this(0m, 0m, 0m)
        {
        }

        public SummaryForm(decimal danielle, decimal edward, decimal fatima)
        {
            InitializeComponent();

            lblDanielle.Text = Form1.FormatPeso(danielle);
            lblEdward.Text = Form1.FormatPeso(edward);
            lblFatima.Text = Form1.FormatPeso(fatima);
            lblTotal.Text = Form1.FormatPeso(danielle + edward + fatima);
        }
    }
}

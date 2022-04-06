namespace WFA_BuildLink
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_Generate_Click(object sender, EventArgs e)
        {
            GenerateAnchorString();
        }

        private void GenerateAnchorString()
        {
            RTB_Result.Clear();
            RTB_Result.Text = TB_Template.Text.Replace("<FileName>", TBFilename.Text);
        }
    }
}
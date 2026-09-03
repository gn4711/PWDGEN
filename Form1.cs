namespace PWDGEN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateEntropyLabel();
            button1_Click(sender, e);
        }

        private void UpdateEntropyLabel()
        {
            var (entropy, label) = PasswordGenerator.EntropyLevels[trackBar1.Value];
            label1.Text = $"{label} ({entropy} bits)";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int entropy = PasswordGenerator.EntropyLevels[trackBar1.Value].Entropy;
            string password = PasswordGenerator.Generate(entropy);
            Clipboard.SetText(password);
            textBox1.Text = password;
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.SelectionLength = 0;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            UpdateEntropyLabel();
            button1_Click(sender, e);
        }
    }
}

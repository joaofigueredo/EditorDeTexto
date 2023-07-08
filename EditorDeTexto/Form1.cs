namespace EditorDeTexto
{
    public partial class Form1 : Form
    {
        StreamReader leitura = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void rToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btn_negrito_Click(object sender, EventArgs e)
        {

        }

        private void Novo()
        {
            richTextBox1.Clear();
            richTextBox1.Focus();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                Salvar();
            }
            Novo();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void Salvar()
        {
            try
            {
                if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //Criando o arquivo
                    FileStream arquivo = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    //Quem escreve o arquivo
                    StreamWriter cfb_streamWriter = new StreamWriter(arquivo);
                    //Preparar o buffer
                    cfb_streamWriter.Flush();
                    //Onde ele vai começar dentro do arquivo
                    cfb_streamWriter.BaseStream.Seek(0, SeekOrigin.Begin);
                    //O que será escrito no arquivo
                    cfb_streamWriter.Write(this.richTextBox1.Text);
                    cfb_streamWriter.Flush();
                    //Conclui a gravação do arquivo
                    cfb_streamWriter.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na gravação" + ex.Message, "Erro ao gravar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void Abrir()
        {
            this.openFileDialog1.Title = "Abrir arquivo";
            openFileDialog1.InitialDirectory = @"C:\\Users\\joaof\\OneDrive\\Área de Trabalho";
            openFileDialog1.Filter = "(*.TXT)|*.TXT";
            DialogResult dr = this.openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    FileStream arquivo = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    StreamReader cfb_streamReader = new StreamReader(arquivo);
                    cfb_streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                    this.richTextBox1.Text = "";
                    string linha = cfb_streamReader.ReadLine();
                    while (linha != null)
                    {
                        this.richTextBox1.Text += linha + "\n";
                        linha = cfb_streamReader.ReadLine();
                    }
                    cfb_streamReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro de leitura: " + ex.Message);
                }
            }
        }

        private void btn_abrir_Click(object sender, EventArgs e)
        {
            Abrir();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(richTextBox1.Text != "")
            {
                Salvar();
                Application.Exit();
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
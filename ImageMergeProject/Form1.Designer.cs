public partial class Form1
{
    private Label rotuloOriginal;
    private Label rotuloComposta;
    private Label rotuloBrilho;
    private Label rotuloCinza;
    private Label rotuloBinaria;
    private Label rotuloRotacionada;
    private Button botaoProcessar;
    private PictureBox quadroOriginal;
    private PictureBox quadroComposta;
    private PictureBox quadroBrilho;
    private PictureBox quadroCinza;
    private PictureBox quadroBinaria;
    private PictureBox quadroRotacionada;

    // RA7, 152 e item g. Distribui as imagens em três colunas e duas linhas.
    private void InitializeComponent()
    {
        Text = "Composição de imagens • ICG";
        ClientSize = new Size(1200, 800);
        AutoScroll = true;
        botaoProcessar = new Button();
        botaoProcessar.Name = "botaoProcessar";
        botaoProcessar.Text = "Processar";
        botaoProcessar.Bounds = new Rectangle(18, 12, 132, 36);
        botaoProcessar.Click += botaoProcessar_Click;
        Controls.Add(botaoProcessar);

        rotuloOriginal = new Label();
        rotuloOriginal.Name = "rotuloOriginal";
        rotuloOriginal.Text = "Original";
        rotuloOriginal.Bounds = new Rectangle(18, 62, 380, 22);
        Controls.Add(rotuloOriginal);
        quadroOriginal = new PictureBox();
        quadroOriginal.Name = "quadroOriginal";
        quadroOriginal.Bounds = new Rectangle(18, 86, 380, 322);
        quadroOriginal.SizeMode = PictureBoxSizeMode.Zoom;
        Controls.Add(quadroOriginal);

        rotuloComposta = new Label();
        rotuloComposta.Name = "rotuloComposta";
        rotuloComposta.Text = "Composicao E";
        rotuloComposta.Bounds = new Rectangle(408, 62, 380, 22);
        Controls.Add(rotuloComposta);
        quadroComposta = new PictureBox();
        quadroComposta.Name = "quadroComposta";
        quadroComposta.Bounds = new Rectangle(408, 86, 380, 322);
        quadroComposta.SizeMode = PictureBoxSizeMode.Zoom;
        Controls.Add(quadroComposta);

        rotuloBrilho = new Label();
        rotuloBrilho.Name = "rotuloBrilho";
        rotuloBrilho.Text = "Brilho +85";
        rotuloBrilho.Bounds = new Rectangle(798, 62, 380, 22);
        Controls.Add(rotuloBrilho);
        quadroBrilho = new PictureBox();
        quadroBrilho.Name = "quadroBrilho";
        quadroBrilho.Bounds = new Rectangle(798, 86, 380, 322);
        quadroBrilho.SizeMode = PictureBoxSizeMode.Zoom;
        Controls.Add(quadroBrilho);

        rotuloCinza = new Label();
        rotuloCinza.Name = "rotuloCinza";
        rotuloCinza.Text = "Tons de cinza";
        rotuloCinza.Bounds = new Rectangle(18, 428, 380, 22);
        Controls.Add(rotuloCinza);
        quadroCinza = new PictureBox();
        quadroCinza.Name = "quadroCinza";
        quadroCinza.Bounds = new Rectangle(18, 452, 380, 322);
        quadroCinza.SizeMode = PictureBoxSizeMode.Zoom;
        Controls.Add(quadroCinza);

        rotuloBinaria = new Label();
        rotuloBinaria.Name = "rotuloBinaria";
        rotuloBinaria.Text = "Binaria";
        rotuloBinaria.Bounds = new Rectangle(408, 428, 380, 22);
        Controls.Add(rotuloBinaria);
        quadroBinaria = new PictureBox();
        quadroBinaria.Name = "quadroBinaria";
        quadroBinaria.Bounds = new Rectangle(408, 452, 380, 322);
        quadroBinaria.SizeMode = PictureBoxSizeMode.Zoom;
        Controls.Add(quadroBinaria);

        rotuloRotacionada = new Label();
        rotuloRotacionada.Name = "rotuloRotacionada";
        rotuloRotacionada.Text = "Cinza rotacionada";
        rotuloRotacionada.Bounds = new Rectangle(798, 428, 380, 22);
        Controls.Add(rotuloRotacionada);
        quadroRotacionada = new PictureBox();
        quadroRotacionada.Name = "quadroRotacionada";
        quadroRotacionada.Bounds = new Rectangle(798, 452, 380, 322);
        quadroRotacionada.SizeMode = PictureBoxSizeMode.Zoom;
        Controls.Add(quadroRotacionada);
    }
}

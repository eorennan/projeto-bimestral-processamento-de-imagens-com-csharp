public partial class Form1 : Form
{
    
    public Form1()
    {
        InitializeComponent();
    }

    
    private void botaoProcessar_Click(object remetente, EventArgs evento)
    {
        JuntarImagens("c:\\Imagens\\Im.jpg", "c:\\Imagens\\Balao.jpg", 497, 0,
            "c:\\Imagens\\homem.jpg", 293, 511, "c:\\Imagens\\Aviao2.jpg", 195, 0, "c:\\Imagens\\E.jpg", 120, 20);
        AjustarBrilho("c:\\Imagens\\E.jpg", "c:\\Imagens\\E_brightness.jpg", 85);
        GerarImagemBinaria("c:\\Imagens\\E.jpg", "c:\\Imagens\\E_gray.jpg", "c:\\Imagens\\E_binary.jpg", 126);
        GirarImagem90GrausAntiHorario("c:\\Imagens\\E_gray.jpg", "c:\\Imagens\\E_gray_rotated.jpg");

        quadroOriginal.Load("c:\\Imagens\\Im.jpg");
        quadroComposta.Load("c:\\Imagens\\E.jpg");
        quadroBrilho.Load("c:\\Imagens\\E_brightness.jpg");
        quadroCinza.Load("c:\\Imagens\\E_gray.jpg");
        quadroBinaria.Load("c:\\Imagens\\E_binary.jpg");
        quadroRotacionada.Load("c:\\Imagens\\E_gray_rotated.jpg");
        MessageBox.Show("Processamento concluido");
    }

    
    public int LimitarIntensidade(int valor)
    {
        return Math.Min(Math.Max(valor, 0), 255);
    }

    public int CalcularTomDeCinza(Color cor)
    {
        return (30 * cor.R + 59 * cor.G + 11 * cor.B) / 100;
    }

    
    public int CalcularDiferencaDeCanal(int primeiro, int segundo)
    {
        if (primeiro > segundo)
            return primeiro - segundo;
        else
            return segundo - primeiro;
    }

   
    public int CalcularDiferencaDeCor(Color pixel, Color fundo)
    {
        return CalcularDiferencaDeCanal(pixel.R, fundo.R) + CalcularDiferencaDeCanal(pixel.G, fundo.G)
            + CalcularDiferencaDeCanal(pixel.B, fundo.B);
    }

    
    public bool EhFundo(Color pixel, Color fundo, int limite)
    {
        return CalcularDiferencaDeCor(pixel, fundo) <= limite;
    }

    public void JuntarImagens(string caminhoCenario, string caminhoBalao, int xBalao, int yBalao,
        string caminhoHomem, int xHomem, int yHomem, string caminhoAviao, int xAviao, int yAviao,
        string saida, int limiteCeu, int limitePele)
    {
        Bitmap cenario = new Bitmap(caminhoCenario);

        Bitmap balao = new Bitmap(caminhoBalao);
        Color fundoBalao = balao.GetPixel(0, 0);
        for (int i = 0; i <= balao.Width - 1; i++)
        {
            for (int j = 0; j <= balao.Height - 1; j++)
            {
                Color pixel = balao.GetPixel(i, j);
                if (EhFundo(pixel, fundoBalao, limiteCeu) == false)
                    cenario.SetPixel(i + xBalao, j + yBalao, pixel);
            }
        }

        Bitmap homem = new Bitmap(caminhoHomem);
        Color fundoHomem = homem.GetPixel(0, 0);
        for (int i = 0; i <= homem.Width - 1; i++)
        {
            for (int j = 0; j <= homem.Height - 1; j++)
            {
                Color pixel = homem.GetPixel(i, j);
                if (EhFundo(pixel, fundoHomem, limitePele) == false)
                    cenario.SetPixel(i + xHomem, j + yHomem, pixel);
            }
        }

        Bitmap aviao = new Bitmap(caminhoAviao);
        Color fundoAviao = aviao.GetPixel(0, 0);
        for (int i = 0; i <= aviao.Width - 1; i++)
        {
            for (int j = 0; j <= aviao.Height - 1; j++)
            {
                Color pixel = aviao.GetPixel(i, j);
                if (EhFundo(pixel, fundoAviao, limiteCeu) == false)
                    cenario.SetPixel(i + xAviao, j + yAviao, pixel);
            }
        }
        cenario.Save(saida);
    }

    
    public void AjustarBrilho(string entrada, string saida, int aumento)
    {
        Bitmap origem = new Bitmap(entrada);
        Bitmap resultado = new Bitmap(origem.Width, origem.Height);
        for (int i = 0; i <= origem.Width - 1; i++)
        {
            for (int j = 0; j <= origem.Height - 1; j++)
            {
                Color pixel = origem.GetPixel(i, j);
                int vermelho = LimitarIntensidade(pixel.R + aumento);
                int verde = LimitarIntensidade(pixel.G + aumento);
                int azul = LimitarIntensidade(pixel.B + aumento);
                resultado.SetPixel(i, j, Color.FromArgb(vermelho, verde, azul));
            }
        }
        resultado.Save(saida);
    }

    
    public void ConverterParaCinza(string entrada, string saida)
    {
        Bitmap origem = new Bitmap(entrada);
        Bitmap resultado = new Bitmap(origem.Width, origem.Height);
        for (int i = 0; i <= origem.Width - 1; i++)
        {
            for (int j = 0; j <= origem.Height - 1; j++)
            {
                int cinza = CalcularTomDeCinza(origem.GetPixel(i, j));
                resultado.SetPixel(i, j, Color.FromArgb(cinza, cinza, cinza));
            }
        }
        resultado.Save(saida);
    }

    
    public void GerarImagemBinaria(string entrada, string caminhoCinza, string saida, int limiar)
    {
        ConverterParaCinza(entrada, caminhoCinza);
        Bitmap origem = new Bitmap(caminhoCinza);
        Bitmap resultado = new Bitmap(origem.Width, origem.Height);
        for (int i = 0; i <= origem.Width - 1; i++)
        {
            for (int j = 0; j <= origem.Height - 1; j++)
            {
                if (origem.GetPixel(i, j).R <= limiar)
                    resultado.SetPixel(i, j, Color.FromArgb(0, 0, 0));
                else
                    resultado.SetPixel(i, j, Color.FromArgb(255, 255, 255));
            }
        }
        resultado.Save(saida);
    }

    public void GirarImagem90GrausAntiHorario(string entrada, string saida)
    {
        Bitmap origem = new Bitmap(entrada);
        Bitmap resultado = new Bitmap(origem.Height, origem.Width);
        for (int i = 0; i <= origem.Width - 1; i++)
        {
            for (int j = 0; j <= origem.Height - 1; j++)
            {
                resultado.SetPixel(j, origem.Width - 1 - i, origem.GetPixel(i, j));
            }
        }
        resultado.Save(saida);
    }
}

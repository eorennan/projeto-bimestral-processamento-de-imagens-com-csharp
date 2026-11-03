# Projeto do 4º bimestre de ICG

## Executar

1. Use o Visual Studio 2026 com a carga de trabalho **Desenvolvimento para desktop com .NET** e o SDK .NET 10.
2. Copie a pasta `Imagens` do repositório para `C:\Imagens`. Im.jpg, Balao.jpg, homem.jpg e Aviao2.jpg devem ficar diretamente nessa pasta.
3. Abra `ImageMergeProject.slnx`, pressione **F5** e clique em **Processar** uma vez. A janela exibe o cenário original e os cinco resultados.

## Saídas em C:\Imagens

| Arquivo | Conteúdo |
|---|---|
| E.jpg | Cenário com balão, homem e avião |
| E_brightness.jpg | E colorida com acréscimo de 85 por canal |
| E_gray.jpg | Luminosidade de E nos três canais |
| E_binary.jpg | Preto para cinza ≤ 126 e branco acima de 126 |
| E_gray_rotated.jpg | Cinza girada 90° no sentido anti-horário |

## Correspondência com o enunciado

| Item | Implementação |
|---|---|
| 1, a, k | JuntarImagens recebe caminhos, posições e tolerâncias. Cada laço consulta EhFundo antes de copiar o pixel para o cenário. |
| b | Form1.cs reúne o evento do botão e as primitivas de recorte, junção, brilho, cinza, binarização e rotação. Form1.Designer.cs contém os controles da tela. |
| c, f | botaoProcessar_Click executa a sequência com caminhos fixos e um botão. |
| d, l | As quatro entradas são as imagens do ZIP da Univap. |
| e | Os cinco nomes terminam em .jpg. A gravação segue o procedimento dos slides, com a limitação descrita abaixo. |
| g, m | O botão gera a composição e suas variantes e carrega os seis quadros. |
| h | AjustarBrilho soma 85 a cada canal e chama LimitarIntensidade. |
| i | ConverterParaCinza chama CalcularTomDeCinza com pesos 0,30, 0,59 e 0,11. |
| j | GerarImagemBinaria gera o cinza e aplica o limiar ao canal R. |
| n | GirarImagem90GrausAntiHorario leva (i, j) a (j, largura − 1 − i). |
| o | Todos os caminhos usados pelo botão apontam para C:\Imagens. |
| p | A comparação entre projetos de grupos diferentes cabe ao professor. |
| q | Os comentários das primitivas identificam os slides ou exercícios usados. |

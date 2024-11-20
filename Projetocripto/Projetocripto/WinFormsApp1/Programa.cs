namespace WinFormsApp1
{
    public partial class senhatexto : Form
    {
        public senhatexto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            /*====================
            -------VARIAVEIS------
            ====================*/


            string dado;
            dado = TextCripto.Text;
            string alfabeto = " '1234567890-=qwertyuiop[asdfghjklç~]zxcvbnm,.;/!@#$%¨&*()_+QWERTYUIOP`{ASDFGHJKLÇ^}|ZXCVBNM<>:?";
            int a, b;



            string palavra = dado;


            /*####################################
            ============CRIPTOGRAFIA==============
            ####################################*/


            /*====================
            ----PROCESSAMENTO-----
            ====================*/

            //criação do vetorPalavra

            int resto = palavra.Length % 4;
            int divisao = palavra.Length / 4;
            int quantidadeMatrizes;
            if (resto != 0)
            {
                quantidadeMatrizes = divisao + 1;
            }
            else
            {
                quantidadeMatrizes = divisao;
            }
            int comprimentoMatriz = quantidadeMatrizes * 4;
            char[] vetorPalavra = new char[comprimentoMatriz];

            //tradução de palavra para vetorPalavraNumerico

            int[] vetorPalavraNumerico = new int[comprimentoMatriz];
            for (a = 0; a < palavra.Length; a++)
            {
                vetorPalavraNumerico[a] = alfabeto.IndexOf(palavra[a]);
            }

            //criação de vetorChaveNumerico

            Random elementoChave = new Random();

            int[] vetorChaveNumerico = new int[comprimentoMatriz];
            for (a = 0; a < comprimentoMatriz; a += 4)
            {
                int determinante;
                do
                {
                    vetorChaveNumerico[a] = elementoChave.Next(0, alfabeto.Length);
                    vetorChaveNumerico[a + 1] = elementoChave.Next(0, alfabeto.Length);
                    vetorChaveNumerico[a + 2] = elementoChave.Next(0, alfabeto.Length);
                    vetorChaveNumerico[a + 3] = elementoChave.Next(0, alfabeto.Length);
                    determinante = (vetorChaveNumerico[a] * vetorChaveNumerico[a + 3]) - (vetorChaveNumerico[a + 1] * vetorChaveNumerico[a + 2]);
                } while (determinante != 1);
            }

            //criação de vetorSenhaNumerico (palavra * chave)

            int[] vetorSenhaNumerico = new int[comprimentoMatriz];
            a = 0;
            for (b = 0; b < quantidadeMatrizes; b++)
            {
                vetorSenhaNumerico[a] = vetorPalavraNumerico[a] * vetorChaveNumerico[a] + vetorPalavraNumerico[a + 1] * vetorChaveNumerico[a + 2];
                vetorSenhaNumerico[a + 1] = vetorPalavraNumerico[a] * vetorChaveNumerico[a + 1] + vetorPalavraNumerico[a + 1] * vetorChaveNumerico[a + 3];
                vetorSenhaNumerico[a + 2] = vetorPalavraNumerico[a + 2] * vetorChaveNumerico[a] + vetorPalavraNumerico[a + 3] * vetorChaveNumerico[a + 2];
                vetorSenhaNumerico[a + 3] = vetorPalavraNumerico[a + 2] * vetorChaveNumerico[a + 1] + vetorPalavraNumerico[a + 3] * vetorChaveNumerico[a + 3];
                a = a + 4;
            }

            //correção de vetorSenhaNumerico

            for (a = 0; a < comprimentoMatriz; a++)
            {
                while (vetorSenhaNumerico[a] >= alfabeto.Length)
                {
                    vetorSenhaNumerico[a] = vetorSenhaNumerico[a] - alfabeto.Length;
                }
            }

            //criação vetorChave e vetorSenha

            char[] vetorChave = new char[comprimentoMatriz];
            char[] vetorSenha = new char[comprimentoMatriz + 1];

            for (a = 0; a < comprimentoMatriz; a++)
            {
                vetorChave[a] = alfabeto[vetorChaveNumerico[a]];
                vetorSenha[a] = alfabeto[vetorSenhaNumerico[a]];

                if (vetorChave[a] == ' ')
                {
                    vetorChave[a] = '¶';
                }

                if (vetorSenha[a] == ' ')
                {
                    vetorSenha[a] = '¶';
                }
            }

            string numerais = "0123456789";
            vetorSenha[comprimentoMatriz] = numerais[comprimentoMatriz - palavra.Length];

            //conversão de vetorSenha e vetorChave em string

            string chave = $"{vetorChave[0]}";
            string senha = $"{vetorSenha[0]}";

            for (a = 1; a < comprimentoMatriz; a++)
            {
                chave = chave + vetorChave[a];
            }

            for (a = 1; a < comprimentoMatriz + 1; a++)
            {
                senha = senha + vetorSenha[a];
            }

            /*====================
            --------SAÍDA---------
            ====================*/


            Resposta.Text = senha;
            chavedetexto.Text = chave;


            /*#######################################
            ============DESCRIPTOGRAFIA==============
            #######################################*/



            /*====================
            -------ENTRADA--------
            ====================*/

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Resposta_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Descriptografar_Click(object sender, EventArgs e)
        {
            string alfabeto = " '1234567890-=qwertyuiop[asdfghjklç~]zxcvbnm,.;/!@#$%¨&*()_+QWERTYUIOP`{ASDFGHJKLÇ^}|ZXCVBNM<>:?";
            int a, b;
            string senha, chave;
            senha = Descripto.Text;
            chave = Chavetextodois.Text;

            /*====================
            ----PROCESSAMENTO-----
            ====================*/

            int comprimentoMatriz = chave.Length;

            //criação de vetorSenha e vetorChave

            char[] vetorSenha = new char[senha.Length];
            for (a = 0; a < senha.Length; a++)
            {
                vetorSenha[a] = senha[a];
                if (vetorSenha[a] == '¶')
                {
                    vetorSenha[a] = ' ';
                }
            }

            char[] vetorChave = new char[comprimentoMatriz];
            for (a = 0; a < comprimentoMatriz; a++)
            {
                vetorChave[a] = chave[a];
                if (vetorChave[a] == '¶')
                {
                    vetorChave[a] = ' ';
                }
            }

            //conversão char-int da senha e da chave

            int[] vetorSenhaNumerico = new int[comprimentoMatriz];
            for (a = 0; a < comprimentoMatriz; a++)
            {
                vetorSenhaNumerico[a] = alfabeto.IndexOf(vetorSenha[a]);
            }

            int[] vetorChaveNumerico = new int[comprimentoMatriz];
            a = 0;
            foreach (char letra in vetorChave)
            {
                vetorChaveNumerico[a] = alfabeto.IndexOf(vetorChave[a]);
                a++;
            }

            //cálculo da chave inversa

            int[] vetorChaveInversa = new int[comprimentoMatriz];
            int determinante;
            for (a = 0; a < comprimentoMatriz; a += 4)
            {
                determinante = (vetorChaveNumerico[a] * vetorChaveNumerico[a + 3]) - (vetorChaveNumerico[a + 1] * vetorChaveNumerico[a + 2]);
                vetorChaveInversa[a] = vetorChaveNumerico[a + 3] * determinante;
                vetorChaveInversa[a + 1] = vetorChaveNumerico[a + 1] * (-1) * determinante;
                vetorChaveInversa[a + 2] = vetorChaveNumerico[a + 2] * (-1) * determinante;
                vetorChaveInversa[a + 3] = vetorChaveNumerico[a] * determinante;
            }

            //multiplicação da senha pela chave inversa

            int[] vetorPalavraNumerico = new int[comprimentoMatriz];
            for (a = 0; a < comprimentoMatriz; a += 4)
            {
                vetorPalavraNumerico[a] = vetorSenhaNumerico[a] * vetorChaveInversa[a] + vetorSenhaNumerico[a + 1] * vetorChaveInversa[a + 2];
                vetorPalavraNumerico[a + 1] = vetorSenhaNumerico[a] * vetorChaveInversa[a + 1] + vetorSenhaNumerico[a + 1] * vetorChaveInversa[a + 3];
                vetorPalavraNumerico[a + 2] = vetorSenhaNumerico[a + 2] * vetorChaveInversa[a] + vetorSenhaNumerico[a + 3] * vetorChaveInversa[a + 2];
                vetorPalavraNumerico[a + 3] = vetorSenhaNumerico[a + 2] * vetorChaveInversa[a + 1] + vetorSenhaNumerico[a + 3] * vetorChaveInversa[a + 3];
            }

            //correção dos valores de vetorPalavraNum além dos índices do alfabeto

            for (a = 0; a < comprimentoMatriz; a++)
            {
                while (vetorPalavraNumerico[a] >= alfabeto.Length)
                {
                    vetorPalavraNumerico[a] = vetorPalavraNumerico[a] - alfabeto.Length;
                }

                while (vetorPalavraNumerico[a] < 0)
                {
                    vetorPalavraNumerico[a] = vetorPalavraNumerico[a] + alfabeto.Length;
                }
            }

            //tradução de vetorPalavraNum em char

            string numerais = "0123456789";
            int comprimentoPalavra = comprimentoMatriz - numerais.IndexOf(vetorSenha[vetorSenha.Length - 1]);
            char[] vetorPalavra = new char[comprimentoPalavra];
            for (a = 0; a < comprimentoPalavra; a++)
            {
                vetorPalavra[a] = alfabeto[vetorPalavraNumerico[a]];
            }

            //conversão de vetorPalavra em string

            string palavra = $"{vetorPalavra[0]}";
            for (a = 1; a < comprimentoPalavra; a++)
            {
                palavra = palavra + vetorPalavra[a];
            }


            /*====================
            --------SAÍDA---------
            ====================*/

            Palavradescripto.Text = palavra;


        }

        private void Descripto_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Palavra_Click(object sender, EventArgs e)
        {

        }
    }
}

using System.Security.Cryptography;

namespace ProjetoInsulina
{
    public partial class Form1 : Form
    {

        private int SegundosFaltantesRelogio;
        private int SegundosFaltantesBomba;
        private System.Windows.Forms.Timer timerRelogio;
        private System.Windows.Forms.Timer timerBomba;
        private int TDD = 50;
        private double NivelAcucarAtual;

        public Form1()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Iniciar_Click(object sender, EventArgs e)
        {

        }

        private double Calculo()
        {
            double FSI = 1800 / TDD;

            if (NivelAcucarAtual < 140)
            {
                FSI = 0;
            }
            else if (NivelAcucarAtual >= 140 && NivelAcucarAtual <= 170)
            {
            }
            else if (NivelAcucarAtual > 170 && NivelAcucarAtual < 200)
            {
                FSI = FSI * 2;
            }
            else if (NivelAcucarAtual >= 200 && NivelAcucarAtual <= 240)
            {
                FSI = FSI * 3;
            }
            else if (NivelAcucarAtual > 240)
            {
                FSI = FSI * 4;
            }
            return FSI;
        }

        private void InitializeTimer()
        {
            SegundosFaltantesRelogio = 10; // 30 Minutos.

            // Configura o timer para disparar a cada 1000 milissegundos (1 segundo)
            timerRelogio = new System.Windows.Forms.Timer();
            timerRelogio.Interval = 1000;
            timerRelogio.Tick += Timer_Tick;
            timerRelogio.Start(); // Inicia o timer
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (SegundosFaltantesRelogio > 0)
            {
                SegundosFaltantesRelogio--; // Decrementa o contador
                Relogio.Text = SegundosFaltantesRelogio.ToString(); // Atualiza o texto do label
            }
            else
            {
                timerRelogio.Stop(); // Para o timer quando o contador chegar a zero
                Relogio.Text = "Analisando...";
                NivelAcucarAtual = RandomizarNivelAcucar();
                VerificarNivelAcucar(NivelAcucarAtual);
                NivelAcucar.Text = NivelAcucarAtual.ToString("N2");
                if (NivelAcucarAtual >= 0)
                {
                    double FSI = Calculo();
                    Verificar_AtivarBomba(FSI);
                    RespostaSistema.Text = "Aplicando " + FSI + "mg/dl de insulina";
                }
                else
                {
                    RespostaSistema.Text = "Sem necessidade de aplicar insulina";
                }
                VerificarNivelAcucar(NivelAcucarAtual);
                SegundosFaltantesRelogio = 10;
                InitializeTimer();
            }
        }
        private void Timer_TickBomba(object sender, EventArgs e)
        {

            if (SegundosFaltantesBomba > 0)
            {
                SegundosFaltantesBomba--; // Decrementa o contador
                RelogioBombatxt.Text = SegundosFaltantesBomba.ToString(); // Atualiza o texto do label

            }
            else
            {
                timerBomba.Stop(); // Para o timer quando o contador chegar a zero
                Bombatxt.Text = "Desligada";
                NivelAcucar.Text = NivelAcucarAtual.ToString("N2");
                SegundosFaltantesBomba = 5;
            }
        }

        private async void Verificar_AtivarBomba(double FSI)
        {
            NivelAcucarAtual = NivelAcucarAtual = FSI;
            Bombatxt.Text = "Ligada";

            SegundosFaltantesBomba = 3;

            timerBomba = new System.Windows.Forms.Timer();
            timerBomba.Interval = 1000;
            timerBomba.Tick += Timer_TickBomba;
            timerBomba.Start();
        }

        private double RandomizarNivelAcucar()
        {
            Random numAleatorio = new Random();
            NivelAcucarAtual = ((uint)numAleatorio.Next(90, 250));

            return NivelAcucarAtual;
        }

        private void VerificarNivelAcucar(double NivelAcucar)
        {
            int Nivel;
            if (NivelAcucar < 140)
            {
                NivelTxt.Text = "Nivel Normal";
            }
            else if (NivelAcucar >= 140 && NivelAcucar <= 199)
            {
                NivelTxt.Text = "Pré-Diabetes";
            }
            else
            {
                NivelTxt.Text = "Diabetes";
            }
            return;
        }

        private void PararButton_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

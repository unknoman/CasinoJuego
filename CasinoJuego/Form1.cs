using System.Threading;
using System.Media;

namespace CasinoJuego
{
    public partial class Form1 : Form
    {


        private double saldoJugador = 1000.0; // Saldo inicial ficticio
        private double saldoCasino = 1000.0;
        public decimal multiplicador = 1.0M;
        private double saldoApostado = 0;
        private Random random = new Random(); // Objeto para generar números aleatorios
        private int contadorTicks = 0; // Contador de ticks
        private int objetivoTicks = 5; // Número objetivo de ticks antes de detenerse



        public Form1()
        {
            InitializeComponent();
            saldoj.Text = saldoJugador.ToString();
            saldoC.Text = saldoCasino.ToString();
        }




  



        private void apostarBtn_Click(object sender, EventArgs e)
        { 
            if(saldoJugador > 0)
            {
                timer1.Start();
                contadorTicks = 0; 
                objetivoTicks = rnd.Next(1000);
                if (!String.IsNullOrEmpty(valorApuesta.Text))
                 saldoApostado = Double.Parse(valorApuesta.Text);
                saldoJugador = saldoJugador - saldoApostado;
                saldoj.Text = saldoJugador.ToString();
                Apostado.Text = saldoApostado.ToString();
                this.Text = objetivoTicks.ToString();
            } else
            {
                this.Text = "No tienes saldo";
            }
           
        }

        public double Apostado2;
        public double Resultado;
        private void timer1_Tick(object sender, EventArgs e)
        {
            contadorTicks++;
                multiplicador = multiplicador + 0.10M;
                multiplicadorX.Text = multiplicador.ToString();
                Apostado2 = saldoApostado * double.Parse(multiplicadorX.Text);
                Apostado.Text = Math.Round(Apostado2, 2).ToString();

        }
        Random rnd = new Random();
        SoundPlayer player = new SoundPlayer(@"Victoria.wav");
        SoundPlayer player2 = new SoundPlayer(@"Derrota.wav");
        double ganado = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Dispose();
            Apostado.Text = "0";
            if (contadorTicks < objetivoTicks)
            {
                player.Play();
                ganado = Apostado2 + saldoApostado;
                saldoJugador = saldoJugador + ganado;
                saldoCasino = saldoCasino - Apostado2;
                estado.Text = "Ganaste: " + Math.Round(Apostado2, 2).ToString();
                saldoj.Text = saldoJugador.ToString();
                saldoC.Text = saldoCasino.ToString();
                estado.BackColor = Color.Green;
                Apostado2 = 0;
            } else
            {
                player2.Play();
                estado.Text = "Perdiste: " + saldoApostado.ToString();
                estado.BackColor = Color.Red;
                saldoCasino = saldoCasino + saldoApostado;
                saldoC.Text = saldoCasino.ToString();
                Apostado2 = 0;
            }
            multiplicadorAnterior.Text = multiplicadorX.Text;
            multiplicadorX.Text = "1.0";
        }
    }
}
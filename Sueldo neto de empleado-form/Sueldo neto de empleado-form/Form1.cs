namespace Sueldo_neto_de_empleado_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            double sueldoBruto, afp, sfs, isr, sueldoNeto;
            double afpRate = 0.0287;
            double sfsRate = 0.0304;
            double exentoISR = 499884.00;
            double tramo1 = 749822.00;
            double tramo2 = 1041224.00;


            sueldoBruto = Convert.ToDouble(sueldo.Text);


            afp = sueldoBruto * afpRate;
            sfs = sueldoBruto * sfsRate;


            double sueldoAnual = sueldoBruto * 12;


            isr = 0;


            if (sueldoAnual > exentoISR)
            {
                if (sueldoAnual <= tramo1)
                {
                    isr = (sueldoAnual - exentoISR) * 0.15;
                }
                else if (sueldoAnual <= tramo2)
                {
                    isr = (sueldoAnual - tramo1) * 0.20 + 37_491.00;
                }
                else
                {
                    isr = (sueldoAnual - tramo2) * 0.25 + 75_082.00;
                }
            }


            sueldoNeto = sueldoBruto - afp - sfs - (isr / 12);

            resultado.Text = sueldoNeto.ToString();


            double isrdividido = isr / 12;


            if (isr > 0)
            {
                isrform.Text = isrdividido.ToString();
            }
            else
            {
                isrform.Text = "isr no aplica";
            }


            afpform.Text = afp.ToString();
            sfsform.Text = sfs.ToString();

        }

        
    }
}

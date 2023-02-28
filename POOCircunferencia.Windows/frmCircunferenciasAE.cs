using POOCircunferencia.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POOCircunferencia.Windows
{
    public partial class frmCircunferenciasAE : Form
    {
        public frmCircunferenciasAE()
        {
            InitializeComponent();
        }
        //este evento modificamos como iniciamos el formulario
        //dentro hay una bifuircacion simple verifica si circunferencia tiene datos entronces que la muestre de lo contrario pasa de largo
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (circunferencia != null)
            {
                radioTextBox.Text = circunferencia.Radio.ToString();
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private Circunferencia circunferencia;
        private void okButton_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                errorProvider1.Clear();
                if (circunferencia == null)
                {
                    circunferencia = new Circunferencia();
                }
                
                circunferencia.Radio =int.Parse(radioTextBox.Text);
                if (!circunferencia.validar())
                {
                    errorProvider1.SetError(radioTextBox, "El valor ingresado debe ser mayor a cero");
                }
                DialogResult = DialogResult.OK;
            }
           
        }

        private bool validarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            //ESTO ESTA MAL DEBO ARREGLAR DONDE ALOJAR EL VALOR PARSEADo
            if (!int.TryParse(radioTextBox.Text,out int circNew))
            {
                valido = false;
                errorProvider1.SetError(radioTextBox, "Error dato invalido");
                limpiarRadioTextBox();
            }
            
            return valido;
        }

        private void limpiarRadioTextBox()
        {
            radioTextBox.Clear();
            radioTextBox.Focus();
        }

        public Circunferencia GetCircunferencia()
        {
            return circunferencia;
        }

        internal void SetCircunferencia(Circunferencia circ)
        {
            circunferencia = circ;
        }
    }
}

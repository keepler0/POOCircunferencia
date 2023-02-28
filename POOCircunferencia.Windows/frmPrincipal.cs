using POOCircunferencia.Datos;
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
    public partial class frmPrincipal : Form
    {
        //variable para controlar los cambios
        bool hayCambios=false;
        public frmPrincipal()
        {
            InitializeComponent();
        }
        //usamos la clase RepositorioDeCircunferencias en la variable "repositorio"
        private RepositorioDeCircunferencias repositorio;
        //usamos la lista del RepositorioDeCircunferencia y definimos var local "lista"
        private List<Circunferencia> lista;
        private int cantidad;

        //este evento _Load definimos que lo que hara cuando la ventana se ejecute 
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lista=new List<Circunferencia>();
            //instanciamos "repositorio" de clase RepositorioDeCircunferencias()
            repositorio = new RepositorioDeCircunferencias();
            cantidad = repositorio.GetCantidad();
            mostrarCantidad();
            
            //este es un filtro el cual mostrara el contenido si solo la lista tiene algo sino no
            if (cantidad > 0)
            {   
                //en el caso verdadero pido los datos de la lista en repositorio con el metodo GetLista() y lo alojo en List: "lista"
                lista = repositorio.GetLista();            
                //metodo para mostrar el contenido en lista
                mostrarLista();
            }
            circDataGridView.ClearSelection();
        }

        private void mostrarCantidad()
        {
            cantidad = repositorio.GetCantidad();
            cantidadLabel.Text = cantidad.ToString();
        }

        private void mostrarLista()
        {
            
            //borramos contenido en DGV
            circDataGridView.Rows.Clear();
            //con foreach recorremos la lista y hace lo siguiente
            foreach (var circ in lista)
            {
                //variable locar "r" la cual el metodo construirFila() instancia el DGV y creamos las celdas
                var r = construirFila();
                //este metodo usara "r" y "circ" la cual insertara los datos en DGV en su respectiva fila 
                setearFila(r, circ);
                //este metodo va a agregar los datos al DGV usando la var local "r"
                agregarFila(r);
            }

        }

        private void agregarFila(DataGridViewRow r)
        {
            circDataGridView.Rows.Add(r);
        }

        private void setearFila(DataGridViewRow r, Circunferencia circ)
        {
            
            r.Cells[colRadio.Index].Value = circ.Radio;
            r.Cells[colSuperficie.Index].Value = circ.GetSuperficie().ToString("N2");
            r.Cells[colPerimetro.Index].Value = circ.GetPerimetro().ToString("N2");

            r.Tag = circ;//aca guardo el objeto
            //esta property me sirve para guardar el objeto la cual usare para guardar el valor de la fila seleccionada
        }

        private DataGridViewRow construirFila()
        {
            var r = new DataGridViewRow();
            r.CreateCells(circDataGridView);
            return r;
        }

        private void nuevoToolStripButton_Click(object sender, EventArgs e)
        {
            
            frmCircunferenciasAE frm = new frmCircunferenciasAE() { Text = "Agregar circunferencia nueva" };
            DialogResult dr=frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            var circNueva = frm.GetCircunferencia();
            repositorio.Agregar(circNueva);
            var r = construirFila();
            setearFila(r, circNueva);
            agregarFila(r);
            MessageBox.Show("circunferencia agreagada");
            mostrarCantidad();
            hayCambios = true;
        }

        private void borrarToolStripButton_Click(object sender, EventArgs e)
        {
            
            //veo si tengo alguna fila seleccionada
            if (circDataGridView.SelectedRows.Count == 0)
            {
                return;
            }
            //en caso si seleccione...
            var r = circDataGridView.SelectedRows[0];//en este caso se puso indice= 0(cero) ya que en la DGV solo puedo seleccionar una fila
            Circunferencia circ =(Circunferencia) r.Tag;//usamos "as" para castear de r tipo objet a r tipo circunferencia
            DialogResult dr= MessageBox.Show($"Esta seguro de borrar el Radio: {circ.Radio} de la lista?","desea borrar?",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question,
                             MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
            {
                return;
            }
            if (repositorio.Borrar(circ))
            {
                repositorio.Borrar(circ);//aca hacemos un metodo la cual esta conectado con el repositorio la cual esta va a remover la circ seleccionada
                lista.Remove(circ);//esto borra la fila seleccionada en la lista de este frmPrincipal
                circDataGridView.Rows.Remove(r);
                MessageBox.Show($"Se ha borrado Radio: {circ.Radio} de la lista", "borrado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                mostrarCantidad();
                hayCambios = true;
            }
            else
            {
                MessageBox.Show("No se pudo borrar la fila seleccionada", "ERROR",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            
        }

        private void editarToolStripButton_Click(object sender, EventArgs e)
        {
            
            if (circDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("No ha seleccionado algúna circunferencia para editar", "mensaje",
                MessageBoxButtons.OK);
                return;

            }
            var r = circDataGridView.SelectedRows[0];
            Circunferencia circ = r.Tag as Circunferencia;
            DialogResult confirmar= MessageBox.Show($"Esta seguro de editar la circunferencia: {circ.Radio} ?", "confirmar",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question,
                             MessageBoxDefaultButton.Button2);
            if (confirmar == DialogResult.No)
            {
                MessageBox.Show($"Edicion de la circunferencia: {circ.Radio} se ha cancelado","Cancelado",
                MessageBoxButtons.OK);
                return;
            }
            frmCircunferenciasAE frm = new frmCircunferenciasAE() { Text="Editando Circunferencia"};
            frm.SetCircunferencia(circ);
            DialogResult dr= frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            circ = frm.GetCircunferencia();
            setearFila(r, circ);
            hayCambios = true;
            MessageBox.Show("Circunferencia modificada", "Editar", 
            MessageBoxButtons.OK, 
            MessageBoxIcon.Information);
            dr = DialogResult.OK;
            
        }

        private void filtrarToolStripButton_Click(object sender, EventArgs e)
        {
            //este filtro nos mostrará los valores mayores a radioFiltro
            int radioFiltro = 10;//Ejemplo para el filtro

            lista = repositorio.FiltrarDatos(radioFiltro);
            mostrarLista();
            cantidad = repositorio.GetCantidadFiltrada(radioFiltro);
            cantidadLabel.Text = cantidad.ToString();
        }

        private void recuperarToolStripButton_Click(object sender, EventArgs e)
        {
            lista = repositorio.GetLista();
            mostrarLista();
            mostrarCantidad();
        }

        private void salirToolStripButton_Click(object sender, EventArgs e)
        {
            if (hayCambios)
            {
                ManejadorArchivoSecuencial.GuardarArchivoSecuancial(repositorio.GetLista());
            }
            Application.Exit();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (hayCambios)
            {
                ManejadorArchivoSecuencial.GuardarArchivoSecuancial(repositorio.GetLista());
            }
            DialogResult cerrar = MessageBox.Show("Desea cerrar la aplicacion?", "Cerrando aplicacion",
                              MessageBoxButtons.YesNo,
                              MessageBoxIcon.Question,
                              MessageBoxDefaultButton.Button2);
            if (cerrar == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void guardarlStripButton_Click(object sender, EventArgs e)
        {
            ManejadorArchivoSecuencial.GuardarArchivoSecuancial(repositorio.GetLista());
            MessageBox.Show("Se han guardado los datos", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

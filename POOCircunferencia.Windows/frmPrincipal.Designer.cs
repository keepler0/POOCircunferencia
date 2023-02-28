
namespace POOCircunferencia.Windows
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.totalesPanel = new System.Windows.Forms.Panel();
            this.cantidadLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grillaPanel = new System.Windows.Forms.Panel();
            this.circDataGridView = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.nuevoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.borrarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.editarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.filtrarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.recuperarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.guardarlStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.colRadio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPerimetro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSuperficie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalesPanel.SuspendLayout();
            this.grillaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circDataGridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // totalesPanel
            // 
            this.totalesPanel.Controls.Add(this.cantidadLabel);
            this.totalesPanel.Controls.Add(this.label1);
            this.totalesPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.totalesPanel.Location = new System.Drawing.Point(0, 346);
            this.totalesPanel.Name = "totalesPanel";
            this.totalesPanel.Size = new System.Drawing.Size(800, 104);
            this.totalesPanel.TabIndex = 1;
            // 
            // cantidadLabel
            // 
            this.cantidadLabel.AutoSize = true;
            this.cantidadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadLabel.Location = new System.Drawing.Point(67, 48);
            this.cantidadLabel.Name = "cantidadLabel";
            this.cantidadLabel.Size = new System.Drawing.Size(14, 13);
            this.cantidadLabel.TabIndex = 0;
            this.cantidadLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad:";
            // 
            // grillaPanel
            // 
            this.grillaPanel.Controls.Add(this.circDataGridView);
            this.grillaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grillaPanel.Location = new System.Drawing.Point(0, 0);
            this.grillaPanel.Name = "grillaPanel";
            this.grillaPanel.Size = new System.Drawing.Size(800, 346);
            this.grillaPanel.TabIndex = 2;
            // 
            // circDataGridView
            // 
            this.circDataGridView.AllowUserToAddRows = false;
            this.circDataGridView.AllowUserToDeleteRows = false;
            this.circDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.circDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.circDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRadio,
            this.colPerimetro,
            this.colSuperficie});
            this.circDataGridView.Location = new System.Drawing.Point(0, 58);
            this.circDataGridView.MultiSelect = false;
            this.circDataGridView.Name = "circDataGridView";
            this.circDataGridView.ReadOnly = true;
            this.circDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.circDataGridView.Size = new System.Drawing.Size(800, 289);
            this.circDataGridView.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripButton,
            this.borrarToolStripButton,
            this.editarToolStripButton,
            this.toolStripSeparator1,
            this.filtrarToolStripButton,
            this.recuperarToolStripButton,
            this.toolStripSeparator2,
            this.guardarlStripButton,
            this.toolStripSeparator4,
            this.salirToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 58);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // nuevoToolStripButton
            // 
            this.nuevoToolStripButton.Image = global::POOCircunferencia.Windows.Properties.Resources.create_36px;
            this.nuevoToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.nuevoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nuevoToolStripButton.Name = "nuevoToolStripButton";
            this.nuevoToolStripButton.Size = new System.Drawing.Size(46, 55);
            this.nuevoToolStripButton.Text = "Nuevo";
            this.nuevoToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.nuevoToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.nuevoToolStripButton.Click += new System.EventHandler(this.nuevoToolStripButton_Click);
            // 
            // borrarToolStripButton
            // 
            this.borrarToolStripButton.Image = global::POOCircunferencia.Windows.Properties.Resources.eraser_36px;
            this.borrarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.borrarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.borrarToolStripButton.Name = "borrarToolStripButton";
            this.borrarToolStripButton.Size = new System.Drawing.Size(43, 55);
            this.borrarToolStripButton.Text = "Borrar";
            this.borrarToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.borrarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.borrarToolStripButton.Click += new System.EventHandler(this.borrarToolStripButton_Click);
            // 
            // editarToolStripButton
            // 
            this.editarToolStripButton.Image = global::POOCircunferencia.Windows.Properties.Resources.edit_36px;
            this.editarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editarToolStripButton.Name = "editarToolStripButton";
            this.editarToolStripButton.Size = new System.Drawing.Size(41, 55);
            this.editarToolStripButton.Text = "Editar";
            this.editarToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.editarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.editarToolStripButton.Click += new System.EventHandler(this.editarToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 58);
            // 
            // filtrarToolStripButton
            // 
            this.filtrarToolStripButton.Image = global::POOCircunferencia.Windows.Properties.Resources.filter_36px;
            this.filtrarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.filtrarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.filtrarToolStripButton.Name = "filtrarToolStripButton";
            this.filtrarToolStripButton.Size = new System.Drawing.Size(41, 55);
            this.filtrarToolStripButton.Text = "Filtrar";
            this.filtrarToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.filtrarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.filtrarToolStripButton.Click += new System.EventHandler(this.filtrarToolStripButton_Click);
            // 
            // recuperarToolStripButton
            // 
            this.recuperarToolStripButton.Image = global::POOCircunferencia.Windows.Properties.Resources.replay_36px;
            this.recuperarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.recuperarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.recuperarToolStripButton.Name = "recuperarToolStripButton";
            this.recuperarToolStripButton.Size = new System.Drawing.Size(64, 55);
            this.recuperarToolStripButton.Text = "Recuperar";
            this.recuperarToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.recuperarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.recuperarToolStripButton.Click += new System.EventHandler(this.recuperarToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 58);
            // 
            // guardarlStripButton
            // 
            this.guardarlStripButton.Image = global::POOCircunferencia.Windows.Properties.Resources.save_36px;
            this.guardarlStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.guardarlStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.guardarlStripButton.Name = "guardarlStripButton";
            this.guardarlStripButton.Size = new System.Drawing.Size(53, 55);
            this.guardarlStripButton.Text = "Guardar";
            this.guardarlStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.guardarlStripButton.Click += new System.EventHandler(this.guardarlStripButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 58);
            // 
            // salirToolStripButton
            // 
            this.salirToolStripButton.Image = global::POOCircunferencia.Windows.Properties.Resources.close_pane_36px;
            this.salirToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.salirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.salirToolStripButton.Name = "salirToolStripButton";
            this.salirToolStripButton.Size = new System.Drawing.Size(40, 55);
            this.salirToolStripButton.Text = "Salir";
            this.salirToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.salirToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.salirToolStripButton.Click += new System.EventHandler(this.salirToolStripButton_Click);
            // 
            // colRadio
            // 
            this.colRadio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colRadio.DefaultCellStyle = dataGridViewCellStyle1;
            this.colRadio.Frozen = true;
            this.colRadio.HeaderText = "Radio";
            this.colRadio.Name = "colRadio";
            this.colRadio.ReadOnly = true;
            this.colRadio.Width = 252;
            // 
            // colPerimetro
            // 
            this.colPerimetro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colPerimetro.DefaultCellStyle = dataGridViewCellStyle2;
            this.colPerimetro.HeaderText = "Perimetro";
            this.colPerimetro.Name = "colPerimetro";
            this.colPerimetro.ReadOnly = true;
            // 
            // colSuperficie
            // 
            this.colSuperficie.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colSuperficie.DefaultCellStyle = dataGridViewCellStyle3;
            this.colSuperficie.HeaderText = "Superficie";
            this.colSuperficie.Name = "colSuperficie";
            this.colSuperficie.ReadOnly = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.grillaPanel);
            this.Controls.Add(this.totalesPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Circunferencia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.totalesPanel.ResumeLayout(false);
            this.totalesPanel.PerformLayout();
            this.grillaPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.circDataGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel totalesPanel;
        private System.Windows.Forms.Panel grillaPanel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton nuevoToolStripButton;
        private System.Windows.Forms.ToolStripButton borrarToolStripButton;
        private System.Windows.Forms.ToolStripButton editarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton filtrarToolStripButton;
        private System.Windows.Forms.ToolStripButton recuperarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton salirToolStripButton;
        private System.Windows.Forms.DataGridView circDataGridView;
        private System.Windows.Forms.Label cantidadLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton guardarlStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRadio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPerimetro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSuperficie;
    }
}
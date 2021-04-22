
namespace ActividadSQL
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboCurso = new System.Windows.Forms.ComboBox();
            this.dataProfes = new System.Windows.Forms.DataGridView();
            this.dataAlumnos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataProfes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // comboCurso
            // 
            this.comboCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCurso.FormattingEnabled = true;
            this.comboCurso.Location = new System.Drawing.Point(57, 188);
            this.comboCurso.Name = "comboCurso";
            this.comboCurso.Size = new System.Drawing.Size(127, 21);
            this.comboCurso.TabIndex = 0;
            this.comboCurso.SelectedIndexChanged += new System.EventHandler(this.comboCurso_SelectedIndexChanged);
            // 
            // dataProfes
            // 
            this.dataProfes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProfes.Location = new System.Drawing.Point(292, 12);
            this.dataProfes.Name = "dataProfes";
            this.dataProfes.Size = new System.Drawing.Size(496, 167);
            this.dataProfes.TabIndex = 1;
            this.dataProfes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataProfes_CellContentClick);
            // 
            // dataAlumnos
            // 
            this.dataAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAlumnos.Location = new System.Drawing.Point(292, 208);
            this.dataAlumnos.Name = "dataAlumnos";
            this.dataAlumnos.Size = new System.Drawing.Size(496, 166);
            this.dataAlumnos.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataAlumnos);
            this.Controls.Add(this.dataProfes);
            this.Controls.Add(this.comboCurso);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataProfes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAlumnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboCurso;
        private System.Windows.Forms.DataGridView dataProfes;
        private System.Windows.Forms.DataGridView dataAlumnos;
    }
}



namespace Colegiodb
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
            this.GridNombres = new System.Windows.Forms.DataGridView();
            this.comboCursos = new System.Windows.Forms.ComboBox();
            this.labelProfesor = new System.Windows.Forms.Label();
            this.labelCursos = new System.Windows.Forms.Label();
            this.labelAlumnos = new System.Windows.Forms.Label();
            this.textProfesor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridNombres)).BeginInit();
            this.SuspendLayout();
            // 
            // GridNombres
            // 
            this.GridNombres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridNombres.Location = new System.Drawing.Point(31, 83);
            this.GridNombres.Name = "GridNombres";
            this.GridNombres.RowHeadersWidth = 51;
            this.GridNombres.RowTemplate.Height = 24;
            this.GridNombres.Size = new System.Drawing.Size(459, 307);
            this.GridNombres.TabIndex = 0;
            // 
            // comboCursos
            // 
            this.comboCursos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCursos.FormattingEnabled = true;
            this.comboCursos.Location = new System.Drawing.Point(657, 71);
            this.comboCursos.Name = "comboCursos";
            this.comboCursos.Size = new System.Drawing.Size(197, 28);
            this.comboCursos.TabIndex = 1;
            this.comboCursos.SelectedIndexChanged += new System.EventHandler(this.comboCursos_SelectedIndexChanged);
            // 
            // labelProfesor
            // 
            this.labelProfesor.AutoSize = true;
            this.labelProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfesor.ForeColor = System.Drawing.Color.Black;
            this.labelProfesor.Location = new System.Drawing.Point(695, 346);
            this.labelProfesor.Name = "labelProfesor";
            this.labelProfesor.Size = new System.Drawing.Size(123, 25);
            this.labelProfesor.TabIndex = 3;
            this.labelProfesor.Text = "Profesores:";
            // 
            // labelCursos
            // 
            this.labelCursos.AutoSize = true;
            this.labelCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCursos.ForeColor = System.Drawing.Color.Black;
            this.labelCursos.Location = new System.Drawing.Point(705, 31);
            this.labelCursos.Name = "labelCursos";
            this.labelCursos.Size = new System.Drawing.Size(88, 25);
            this.labelCursos.TabIndex = 4;
            this.labelCursos.Text = "Cursos:";
            // 
            // labelAlumnos
            // 
            this.labelAlumnos.AutoSize = true;
            this.labelAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlumnos.ForeColor = System.Drawing.Color.Black;
            this.labelAlumnos.Location = new System.Drawing.Point(222, 31);
            this.labelAlumnos.Name = "labelAlumnos";
            this.labelAlumnos.Size = new System.Drawing.Size(103, 25);
            this.labelAlumnos.TabIndex = 5;
            this.labelAlumnos.Text = "Alumnos:";
            // 
            // textProfesor
            // 
            this.textProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textProfesor.Location = new System.Drawing.Point(657, 386);
            this.textProfesor.Name = "textProfesor";
            this.textProfesor.Size = new System.Drawing.Size(197, 27);
            this.textProfesor.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(912, 483);
            this.Controls.Add(this.textProfesor);
            this.Controls.Add(this.labelAlumnos);
            this.Controls.Add(this.labelCursos);
            this.Controls.Add(this.labelProfesor);
            this.Controls.Add(this.comboCursos);
            this.Controls.Add(this.GridNombres);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridNombres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridNombres;
        private System.Windows.Forms.ComboBox comboCursos;
        private System.Windows.Forms.Label labelProfesor;
        private System.Windows.Forms.Label labelCursos;
        private System.Windows.Forms.Label labelAlumnos;
        private System.Windows.Forms.TextBox textProfesor;
    }
}


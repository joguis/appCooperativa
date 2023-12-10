using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appCooperativa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.tbGeestionCop = new System.Windows.Forms.TabControl();
            this.tbpRegistrarAsc = new System.Windows.Forms.TabPage();
            this.lblEmailRegAsc = new System.Windows.Forms.Label();
            this.lblMontoIniRegAsc = new System.Windows.Forms.Label();
            this.lblTelefonoRegAsc = new System.Windows.Forms.Label();
            this.lblNumDocRegAsc = new System.Windows.Forms.Label();
            this.lblApellidoRegAsc = new System.Windows.Forms.Label();
            this.lblNombreRegAsc = new System.Windows.Forms.Label();
            this.lblTipoDocRegAsc = new System.Windows.Forms.Label();
            this.cbxTipoDocRegAsc = new System.Windows.Forms.ComboBox();
            this.tbpModificarAsc = new System.Windows.Forms.TabPage();
            this.tbpConsultarAsc = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.tbGeestionCop.SuspendLayout();
            this.tbpRegistrarAsc.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbGeestionCop
            // 
            this.tbGeestionCop.Controls.Add(this.tbpRegistrarAsc);
            this.tbGeestionCop.Controls.Add(this.tbpModificarAsc);
            this.tbGeestionCop.Controls.Add(this.tbpConsultarAsc);
            this.tbGeestionCop.Location = new System.Drawing.Point(44, 48);
            this.tbGeestionCop.Name = "tbGeestionCop";
            this.tbGeestionCop.SelectedIndex = 0;
            this.tbGeestionCop.Size = new System.Drawing.Size(817, 433);
            this.tbGeestionCop.TabIndex = 0;
            // 
            // tbpRegistrarAsc
            // 
            this.tbpRegistrarAsc.Controls.Add(this.textBox6);
            this.tbpRegistrarAsc.Controls.Add(this.textBox5);
            this.tbpRegistrarAsc.Controls.Add(this.textBox4);
            this.tbpRegistrarAsc.Controls.Add(this.textBox3);
            this.tbpRegistrarAsc.Controls.Add(this.textBox2);
            this.tbpRegistrarAsc.Controls.Add(this.textBox1);
            this.tbpRegistrarAsc.Controls.Add(this.lblEmailRegAsc);
            this.tbpRegistrarAsc.Controls.Add(this.lblMontoIniRegAsc);
            this.tbpRegistrarAsc.Controls.Add(this.lblTelefonoRegAsc);
            this.tbpRegistrarAsc.Controls.Add(this.lblNumDocRegAsc);
            this.tbpRegistrarAsc.Controls.Add(this.lblApellidoRegAsc);
            this.tbpRegistrarAsc.Controls.Add(this.lblNombreRegAsc);
            this.tbpRegistrarAsc.Controls.Add(this.lblTipoDocRegAsc);
            this.tbpRegistrarAsc.Controls.Add(this.cbxTipoDocRegAsc);
            this.tbpRegistrarAsc.Location = new System.Drawing.Point(4, 25);
            this.tbpRegistrarAsc.Name = "tbpRegistrarAsc";
            this.tbpRegistrarAsc.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRegistrarAsc.Size = new System.Drawing.Size(809, 404);
            this.tbpRegistrarAsc.TabIndex = 0;
            this.tbpRegistrarAsc.Text = "Registrar Asociado";
            this.tbpRegistrarAsc.UseVisualStyleBackColor = true;
            // 
            // lblEmailRegAsc
            // 
            this.lblEmailRegAsc.AutoSize = true;
            this.lblEmailRegAsc.Location = new System.Drawing.Point(6, 225);
            this.lblEmailRegAsc.Name = "lblEmailRegAsc";
            this.lblEmailRegAsc.Size = new System.Drawing.Size(121, 16);
            this.lblEmailRegAsc.TabIndex = 7;
            this.lblEmailRegAsc.Text = "Correo Electronico:";
            // 
            // lblMontoIniRegAsc
            // 
            this.lblMontoIniRegAsc.AutoSize = true;
            this.lblMontoIniRegAsc.Location = new System.Drawing.Point(6, 311);
            this.lblMontoIniRegAsc.Name = "lblMontoIniRegAsc";
            this.lblMontoIniRegAsc.Size = new System.Drawing.Size(84, 16);
            this.lblMontoIniRegAsc.TabIndex = 6;
            this.lblMontoIniRegAsc.Text = "Monto Inicial:";
            // 
            // lblTelefonoRegAsc
            // 
            this.lblTelefonoRegAsc.AutoSize = true;
            this.lblTelefonoRegAsc.Location = new System.Drawing.Point(322, 225);
            this.lblTelefonoRegAsc.Name = "lblTelefonoRegAsc";
            this.lblTelefonoRegAsc.Size = new System.Drawing.Size(64, 16);
            this.lblTelefonoRegAsc.TabIndex = 5;
            this.lblTelefonoRegAsc.Text = "Telefono:";
            // 
            // lblNumDocRegAsc
            // 
            this.lblNumDocRegAsc.AutoSize = true;
            this.lblNumDocRegAsc.Location = new System.Drawing.Point(6, 144);
            this.lblNumDocRegAsc.Name = "lblNumDocRegAsc";
            this.lblNumDocRegAsc.Size = new System.Drawing.Size(149, 16);
            this.lblNumDocRegAsc.TabIndex = 4;
            this.lblNumDocRegAsc.Text = "Número de Documento:";
            // 
            // lblApellidoRegAsc
            // 
            this.lblApellidoRegAsc.AutoSize = true;
            this.lblApellidoRegAsc.Location = new System.Drawing.Point(585, 147);
            this.lblApellidoRegAsc.Name = "lblApellidoRegAsc";
            this.lblApellidoRegAsc.Size = new System.Drawing.Size(67, 16);
            this.lblApellidoRegAsc.TabIndex = 3;
            this.lblApellidoRegAsc.Text = "Apellidos:";
            // 
            // lblNombreRegAsc
            // 
            this.lblNombreRegAsc.AutoSize = true;
            this.lblNombreRegAsc.Location = new System.Drawing.Point(320, 144);
            this.lblNombreRegAsc.Name = "lblNombreRegAsc";
            this.lblNombreRegAsc.Size = new System.Drawing.Size(66, 16);
            this.lblNombreRegAsc.TabIndex = 2;
            this.lblNombreRegAsc.Text = "Nombres:";
            // 
            // lblTipoDocRegAsc
            // 
            this.lblTipoDocRegAsc.AutoSize = true;
            this.lblTipoDocRegAsc.Location = new System.Drawing.Point(6, 68);
            this.lblTipoDocRegAsc.Name = "lblTipoDocRegAsc";
            this.lblTipoDocRegAsc.Size = new System.Drawing.Size(127, 16);
            this.lblTipoDocRegAsc.TabIndex = 1;
            this.lblTipoDocRegAsc.Text = "Tipo de documento:";
            // 
            // cbxTipoDocRegAsc
            // 
            this.cbxTipoDocRegAsc.FormattingEnabled = true;
            this.cbxTipoDocRegAsc.Items.AddRange(new object[] {
            "TI",
            "CC",
            "CE"});
            this.cbxTipoDocRegAsc.Location = new System.Drawing.Point(175, 68);
            this.cbxTipoDocRegAsc.Name = "cbxTipoDocRegAsc";
            this.cbxTipoDocRegAsc.Size = new System.Drawing.Size(121, 24);
            this.cbxTipoDocRegAsc.TabIndex = 0;
            // 
            // tbpModificarAsc
            // 
            this.tbpModificarAsc.Location = new System.Drawing.Point(4, 25);
            this.tbpModificarAsc.Name = "tbpModificarAsc";
            this.tbpModificarAsc.Padding = new System.Windows.Forms.Padding(3);
            this.tbpModificarAsc.Size = new System.Drawing.Size(809, 404);
            this.tbpModificarAsc.TabIndex = 1;
            this.tbpModificarAsc.Text = "Modificar Usuario";
            this.tbpModificarAsc.UseVisualStyleBackColor = true;
            // 
            // tbpConsultarAsc
            // 
            this.tbpConsultarAsc.Location = new System.Drawing.Point(4, 25);
            this.tbpConsultarAsc.Name = "tbpConsultarAsc";
            this.tbpConsultarAsc.Padding = new System.Windows.Forms.Padding(3);
            this.tbpConsultarAsc.Size = new System.Drawing.Size(809, 404);
            this.tbpConsultarAsc.TabIndex = 2;
            this.tbpConsultarAsc.Text = "Consultar Usuario";
            this.tbpConsultarAsc.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(175, 144);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 22);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(418, 144);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(139, 22);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(658, 144);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(139, 22);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(175, 219);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(139, 22);
            this.textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(418, 225);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(139, 22);
            this.textBox5.TabIndex = 12;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(175, 296);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(139, 22);
            this.textBox6.TabIndex = 13;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(925, 528);
            this.Controls.Add(this.tbGeestionCop);
            this.Name = "Form1";
            this.Text = "Administrador";
            this.tbGeestionCop.ResumeLayout(false);
            this.tbpRegistrarAsc.ResumeLayout(false);
            this.tbpRegistrarAsc.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}

﻿/*
 * Criado por SharpDevelop.
 * Usuário: Fabiano
 * Data: 10/05/2020
 * Hora: 20:23
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace Bookstore.Forms
{
	partial class FmLogin
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pbIconUser;
		private System.Windows.Forms.PictureBox pbEmail;
		private System.Windows.Forms.PictureBox pbPassword;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.CheckBox cbLembrarSenha;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblRegister;
		private System.Windows.Forms.PictureBox pbIconEmail;
		private System.Windows.Forms.PictureBox pbIconPassword;
		private System.Windows.Forms.PictureBox pbExit;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmLogin));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pbIconUser = new System.Windows.Forms.PictureBox();
			this.pbEmail = new System.Windows.Forms.PictureBox();
			this.pbPassword = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.cbLembrarSenha = new System.Windows.Forms.CheckBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lblRegister = new System.Windows.Forms.Label();
			this.pbIconEmail = new System.Windows.Forms.PictureBox();
			this.pbIconPassword = new System.Windows.Forms.PictureBox();
			this.pbExit = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbIconUser)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbEmail)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbPassword)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbIconEmail)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbIconPassword)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(400, 397);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// pbIconUser
			// 
			this.pbIconUser.Image = ((System.Drawing.Image)(resources.GetObject("pbIconUser.Image")));
			this.pbIconUser.Location = new System.Drawing.Point(406, 12);
			this.pbIconUser.Name = "pbIconUser";
			this.pbIconUser.Size = new System.Drawing.Size(97, 85);
			this.pbIconUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbIconUser.TabIndex = 1;
			this.pbIconUser.TabStop = false;
			// 
			// pbEmail
			// 
			this.pbEmail.Image = ((System.Drawing.Image)(resources.GetObject("pbEmail.Image")));
			this.pbEmail.Location = new System.Drawing.Point(312, 134);
			this.pbEmail.Name = "pbEmail";
			this.pbEmail.Size = new System.Drawing.Size(298, 45);
			this.pbEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbEmail.TabIndex = 2;
			this.pbEmail.TabStop = false;
			// 
			// pbPassword
			// 
			this.pbPassword.Image = ((System.Drawing.Image)(resources.GetObject("pbPassword.Image")));
			this.pbPassword.Location = new System.Drawing.Point(312, 195);
			this.pbPassword.Name = "pbPassword";
			this.pbPassword.Size = new System.Drawing.Size(298, 45);
			this.pbPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbPassword.TabIndex = 3;
			this.pbPassword.TabStop = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("ArtBrush", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label1.Location = new System.Drawing.Point(369, 108);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(171, 23);
			this.label1.TabIndex = 4;
			this.label1.Text = "Entre e gerencie a livraria";
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.DarkGray;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.textBox1.Location = new System.Drawing.Point(369, 146);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(218, 20);
			this.textBox1.TabIndex = 5;
			this.textBox1.Text = "Type here your e-mail address";
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.Color.DarkGray;
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox2.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.textBox2.Location = new System.Drawing.Point(369, 207);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(218, 20);
			this.textBox2.TabIndex = 6;
			this.textBox2.Text = "Type here your password";
			// 
			// cbLembrarSenha
			// 
			this.cbLembrarSenha.ForeColor = System.Drawing.Color.Gray;
			this.cbLembrarSenha.Location = new System.Drawing.Point(399, 246);
			this.cbLembrarSenha.Name = "cbLembrarSenha";
			this.cbLembrarSenha.Size = new System.Drawing.Size(104, 24);
			this.cbLembrarSenha.TabIndex = 7;
			this.cbLembrarSenha.Text = "lembre de mim";
			this.cbLembrarSenha.UseVisualStyleBackColor = true;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(353, 276);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(234, 60);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox5.TabIndex = 8;
			this.pictureBox5.TabStop = false;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("ArtBrush", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label2.Location = new System.Drawing.Point(312, 348);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 23);
			this.label2.TabIndex = 9;
			this.label2.Text = "New User?";
			// 
			// lblRegister
			// 
			this.lblRegister.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblRegister.Font = new System.Drawing.Font("ArtBrush", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.lblRegister.Location = new System.Drawing.Point(399, 348);
			this.lblRegister.Name = "lblRegister";
			this.lblRegister.Size = new System.Drawing.Size(88, 23);
			this.lblRegister.TabIndex = 10;
			this.lblRegister.Text = "Register now";
			// 
			// pbIconEmail
			// 
			this.pbIconEmail.Image = ((System.Drawing.Image)(resources.GetObject("pbIconEmail.Image")));
			this.pbIconEmail.Location = new System.Drawing.Point(330, 142);
			this.pbIconEmail.Name = "pbIconEmail";
			this.pbIconEmail.Size = new System.Drawing.Size(32, 27);
			this.pbIconEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbIconEmail.TabIndex = 11;
			this.pbIconEmail.TabStop = false;
			// 
			// pbIconPassword
			// 
			this.pbIconPassword.Image = ((System.Drawing.Image)(resources.GetObject("pbIconPassword.Image")));
			this.pbIconPassword.Location = new System.Drawing.Point(331, 203);
			this.pbIconPassword.Name = "pbIconPassword";
			this.pbIconPassword.Size = new System.Drawing.Size(32, 27);
			this.pbIconPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbIconPassword.TabIndex = 12;
			this.pbIconPassword.TabStop = false;
			// 
			// pbExit
			// 
			this.pbExit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbExit.Image = ((System.Drawing.Image)(resources.GetObject("pbExit.Image")));
			this.pbExit.Location = new System.Drawing.Point(533, 342);
			this.pbExit.Name = "pbExit";
			this.pbExit.Size = new System.Drawing.Size(100, 50);
			this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbExit.TabIndex = 13;
			this.pbExit.TabStop = false;
			this.pbExit.Click += new System.EventHandler(this.PbExitClick);
			// 
			// FmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(645, 394);
			this.Controls.Add(this.pbExit);
			this.Controls.Add(this.pbIconPassword);
			this.Controls.Add(this.pbIconEmail);
			this.Controls.Add(this.lblRegister);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.pictureBox5);
			this.Controls.Add(this.cbLembrarSenha);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pbPassword);
			this.Controls.Add(this.pbEmail);
			this.Controls.Add(this.pbIconUser);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbIconUser)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbEmail)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbPassword)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbIconEmail)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbIconPassword)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}

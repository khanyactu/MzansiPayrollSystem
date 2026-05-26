namespace MzansiPayrollSystem
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHoursWorked = new System.Windows.Forms.TextBox();
            this.txtDependents = new System.Windows.Forms.TextBox();
            this.txtGrossPay = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtContractorName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPAYE = new System.Windows.Forms.TextBox();
            this.txtUIF = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMembership = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotalDeductions = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNetPay = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(419, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mzansi Tech Contractors";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(51, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Hours Worked:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(51, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Number of Dependants:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(721, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Gross Pay:";
            // 
            // txtHoursWorked
            // 
            this.txtHoursWorked.Location = new System.Drawing.Point(201, 197);
            this.txtHoursWorked.Name = "txtHoursWorked";
            this.txtHoursWorked.Size = new System.Drawing.Size(100, 29);
            this.txtHoursWorked.TabIndex = 4;
            // 
            // txtDependents
            // 
            this.txtDependents.Location = new System.Drawing.Point(276, 242);
            this.txtDependents.Name = "txtDependents";
            this.txtDependents.Size = new System.Drawing.Size(100, 29);
            this.txtDependents.TabIndex = 5;
            // 
            // txtGrossPay
            // 
            this.txtGrossPay.Location = new System.Drawing.Point(836, 146);
            this.txtGrossPay.Name = "txtGrossPay";
            this.txtGrossPay.ReadOnly = true;
            this.txtGrossPay.Size = new System.Drawing.Size(100, 29);
            this.txtGrossPay.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Navy;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(51, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Contractor Name:";
            // 
            // txtContractorName
            // 
            this.txtContractorName.Location = new System.Drawing.Point(217, 146);
            this.txtContractorName.Name = "txtContractorName";
            this.txtContractorName.Size = new System.Drawing.Size(100, 29);
            this.txtContractorName.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(721, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "PAYE Deduction:";
            // 
            // txtPAYE
            // 
            this.txtPAYE.Location = new System.Drawing.Point(885, 201);
            this.txtPAYE.Name = "txtPAYE";
            this.txtPAYE.ReadOnly = true;
            this.txtPAYE.Size = new System.Drawing.Size(100, 29);
            this.txtPAYE.TabIndex = 10;
            // 
            // txtUIF
            // 
            this.txtUIF.Location = new System.Drawing.Point(885, 255);
            this.txtUIF.Name = "txtUIF";
            this.txtUIF.ReadOnly = true;
            this.txtUIF.Size = new System.Drawing.Size(100, 29);
            this.txtUIF.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(721, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "UIF Deduction:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(721, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "Membership Fee:";
            // 
            // txtMembership
            // 
            this.txtMembership.Location = new System.Drawing.Point(892, 312);
            this.txtMembership.Name = "txtMembership";
            this.txtMembership.ReadOnly = true;
            this.txtMembership.Size = new System.Drawing.Size(100, 29);
            this.txtMembership.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(721, 370);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 25);
            this.label10.TabIndex = 15;
            this.label10.Text = "Total Deductions:";
            // 
            // txtTotalDeductions
            // 
            this.txtTotalDeductions.Location = new System.Drawing.Point(892, 370);
            this.txtTotalDeductions.Name = "txtTotalDeductions";
            this.txtTotalDeductions.ReadOnly = true;
            this.txtTotalDeductions.Size = new System.Drawing.Size(100, 29);
            this.txtTotalDeductions.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(721, 424);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 25);
            this.label11.TabIndex = 17;
            this.label11.Text = "Net Pay:";
            // 
            // txtNetPay
            // 
            this.txtNetPay.Location = new System.Drawing.Point(814, 424);
            this.txtNetPay.Name = "txtNetPay";
            this.txtNetPay.ReadOnly = true;
            this.txtNetPay.Size = new System.Drawing.Size(100, 29);
            this.txtNetPay.TabIndex = 18;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(50, 334);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(183, 45);
            this.btnCalculate.TabIndex = 19;
            this.btnCalculate.Text = "Calculate Net Pay";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(255, 334);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(96, 45);
            this.btnReset.TabIndex = 20;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(375, 334);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 45);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1074, 497);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtNetPay);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTotalDeductions);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtMembership);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtUIF);
            this.Controls.Add(this.txtPAYE);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtContractorName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGrossPay);
            this.Controls.Add(this.txtDependents);
            this.Controls.Add(this.txtHoursWorked);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHoursWorked;
        private System.Windows.Forms.TextBox txtDependents;
        private System.Windows.Forms.TextBox txtGrossPay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtContractorName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPAYE;
        private System.Windows.Forms.TextBox txtUIF;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMembership;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTotalDeductions;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNetPay;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
    }
}
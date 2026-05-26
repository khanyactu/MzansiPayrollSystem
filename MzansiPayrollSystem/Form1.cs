using System;
using System.Windows.Forms;

namespace MzansiPayrollSystem
{
    public partial class Form1 : Form
    {
        private PayrollCalculator calculator = new PayrollCalculator();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Validate contractor name
            if (string.IsNullOrWhiteSpace(txtContractorName.Text))
            {
                MessageBox.Show("Please enter the contractor name.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate hours worked
            double hours;
            if (!double.TryParse(txtHoursWorked.Text, out hours))
            {
                MessageBox.Show("Hours worked must be a valid number.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (hours < 0)
            {
                MessageBox.Show("Hours worked cannot be negative.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate dependents
            int dependents;
            if (!int.TryParse(txtDependents.Text, out dependents))
            {
                MessageBox.Show("Number of dependents must be a whole number.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dependents < 0 || dependents > 10)
            {
                MessageBox.Show("Dependents must be between 0 and 10.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Calculations
            double grossPay = calculator.CalculateGrossPay(hours);
            double uif = calculator.CalculateUIF(grossPay);
            double membershipFee = calculator.CalculateMembershipFee(grossPay);
            double paye = calculator.CalculatePAYE(grossPay, dependents);
            double totalDeductions = uif + paye + membershipFee;
            double netPay = calculator.CalculateNetPay(grossPay, uif, paye, membershipFee);

            // Display results
            txtGrossPay.Text = "R " + grossPay.ToString("F2");
            txtUIF.Text = "R " + uif.ToString("F2");
            txtMembership.Text = "R " + membershipFee.ToString("F2");
            txtPAYE.Text = "R " + paye.ToString("F2");
            txtTotalDeductions.Text = "R " + totalDeductions.ToString("F2");
            txtNetPay.Text = "R " + netPay.ToString("F2");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtContractorName.Clear();
            txtHoursWorked.Clear();
            txtDependents.Clear();
            txtGrossPay.Clear();
            txtUIF.Clear();
            txtMembership.Clear();
            txtPAYE.Clear();
            txtTotalDeductions.Clear();
            txtNetPay.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
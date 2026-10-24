using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private readonly EmployeeServiceBase service = new EmployeeService();

        public Form1()
        {
            InitializeComponent();
        }
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            string code = txtCode.Text.Trim();
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();

            if (string.IsNullOrWhiteSpace(code) || string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            {
                MessageBox.Show("Lütfən, bütün sahələri doldurun!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtAge.Text.Trim(), out int age) || age <= 0)
            {
                MessageBox.Show("Lütfən, düzgün yaş daxil edin!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Employee newEmp = new Employee(code, firstName, lastName, age);
            bool isAdded = service.AddEmployee(newEmp);

            if (isAdded)
            {
                MessageBox.Show("İşçi uğurla əlavə edildi!", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearEmployeeInputFields();
                RefreshEmployeeList();
            }
            else
            {
                MessageBox.Show("Eyni kodla işçi artıq mövcuddur və ya məlumatlar düzgün deyil!", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            string employeeCode = txtPayCode.Text.Trim();
            string title = txtPayTitle.Text.Trim();

            if (string.IsNullOrWhiteSpace(employeeCode) || string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Lütfən, bütün sahələri doldurun!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtPayAmount.Text.Trim(), out double amount) || amount <= 0)
            {
                MessageBox.Show("Lütfən, düzgün məbləğ daxil edin!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool isPaid = service.AddPayment(employeeCode, title, amount);

            if (isPaid)
            {
                MessageBox.Show("Ödəniş uğurla yazıldı!", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPayTitle.Clear();
                txtPayAmount.Clear();
            }
            else
            {
                MessageBox.Show("İşçi tapılmadı və ya daxil edilən məlumatlar yanlışdır!", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSearchStat_Click(object sender, EventArgs e)
        {
            string code = txtStatCode.Text.Trim();
            lstStatPayments.Items.Clear();

            if (string.IsNullOrWhiteSpace(code))
            {
                MessageBox.Show("Lütfən, axtarış üçün işçi kodunu daxil edin!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Employee emp = service.FindEmployee(code);

            if (emp == null)
            {
                lblStatInfo.Text = "İşçi tapılmadı.";
                MessageBox.Show("Daxil edilən koda uyğun işçi tapılmadı!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lblStatInfo.Text = $"Kod: {emp.Code} | Ad: {emp.FirstName} | Soyad: {emp.LastName} | Yaş: {emp.Age}";

            List<Payment> payments = service.GetEmployeePayments(code);
            if (payments != null && payments.Count > 0)
            {
                double total = 0;
                foreach (var p in payments)
                {
                    lstStatPayments.Items.Add($"{p.Title} — {p.Amount} AZN");
                    total += p.Amount;
                }
                lstStatPayments.Items.Add("-----------------------------");
                lstStatPayments.Items.Add($"Cəmi Ödəniş: {total} AZN");
            }
            else
            {
                lstStatPayments.Items.Add("Hələ heç bir ödəniş yazılmayıb.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Proqramdan çıxmaq istədiyinizdən əminsiniz?", "Çıxış Təsdiqi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ClearEmployeeInputFields()
        {
            txtCode.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtAge.Clear();
        }

        private void RefreshEmployeeList()
        {
            lstEmployees.Items.Clear();
            foreach (var emp in service.GetAllEmployees())
            {
                lstEmployees.Items.Add($"{emp.Code} - {emp.FirstName} {emp.LastName} ({emp.Age} yaş)");
            }
        }


    }
}
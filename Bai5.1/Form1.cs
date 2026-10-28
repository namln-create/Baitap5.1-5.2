using MySql.Data.MySqlClient;

namespace Bai51

{
    public partial class FormLogin : Form
    {
        private string connectionString = "Server=localhost;Database=ql_sinhvien;Uid=root;Pwd=;";
        public FormLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            chkShowPassword.Checked = false;
            errorProvider1.Clear();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return;
            }

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(1) FROM TaiKhoan WHERE TenDangNhap = @username AND MatKhau = @password";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count == 1)
                        {
                            MessageBox.Show("Đăng nhập qua Database thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Mở Form tiếp theo ở đây
                        }
                        else
                        {
                            MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi xác thực", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtPassword.Clear();
                            txtPassword.Focus();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult comfirm = MessageBox.Show("Xác nhận thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (comfirm == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private bool ValidateInputs()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                errorProvider1.SetError(txtUsername, "Vui lòng nhập tên đăng nhập!");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txtUsername, string.Empty);
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                errorProvider1.SetError(txtPassword, "Vui lòng nhập mật khẩu!");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txtPassword, string.Empty);
            }

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                txtUsername.Focus();
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                txtPassword.Focus();
            }

            return isValid;
        }
    }
}
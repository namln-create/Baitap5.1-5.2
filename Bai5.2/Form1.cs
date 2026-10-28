#nullable disable
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Bai53
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mtxtPhone.Mask = "(000) 000-0000";
            dtpBirthDate.Format = DateTimePickerFormat.Custom;
            dtpBirthDate.CustomFormat = "dd/MM/yyyy";

            Course[] courses = new Course[]
            {
                new Course("CS101", "Lập trình C# cơ bản"),
                new Course("WF201", "Lập trình Windows Forms nâng cao"),
                new Course("DB301", "Cơ sở dữ liệu SQL Server"),
                new Course("API401", "Xây dựng Web API với ASP.NET Core")
            };

            cboCourse.DisplayMember = "CourseName";
            cboCourse.ValueMember = "CourseId";
            cboCourse.DataSource = courses;

            if (rdoMale != null) rdoMale.Checked = true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!mtxtPhone.MaskCompleted)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ số điện thoại theo định dạng (000) 000-0000.",
                                "Thiếu thông tin",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                mtxtPhone.Focus();
                return;
            }

            string phone = mtxtPhone.Text;
            string birthDate = dtpBirthDate.Value.ToString("dd/MM/yyyy");
            string courseName = cboCourse.Text;
            string courseId = cboCourse.SelectedValue?.ToString() ?? "Chưa xác định";
            string gender = (rdoMale != null && rdoMale.Checked) ? "Nam" : "Nữ";

            string extraOptions = "";
            if (chkMaterial != null && chkMaterial.Checked) extraOptions += "Giáo trình, ";
            if (chkCertificate != null && chkCertificate.Checked) extraOptions += "Chứng chỉ, ";

            if (extraOptions.EndsWith(", ")) extraOptions = extraOptions.Substring(0, extraOptions.Length - 2);
            if (string.IsNullOrEmpty(extraOptions)) extraOptions = "Không chọn";

            // ... (Phần trên giữ nguyên code kiểm tra mtxtPhone, dtpBirthDate... của bạn)[cite: 5]

            // 1. Chuỗi kết nối trỏ tới CSDL mới (ql_khoahoc)
            string connectionString = "Server=localhost;Database=ql_khoahoc;Uid=root;Pwd=;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO DangKyKhoaHoc (SoDienThoai, NgaySinh, GioiTinh, MaKhoaHoc, TuyChonThem) VALUES (@phone, @birthdate, @gender, @course, @extra)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters.AddWithValue("@birthdate", dtpBirthDate.Value.ToString("yyyy-MM-dd")); 
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@course", courseId);
                        cmd.Parameters.AddWithValue("@extra", extraOptions);

                        cmd.ExecuteNonQuery();

                        string message = "ĐĂNG KÝ KHÓA HỌC VÀ LƯU CSDL THÀNH CÔNG!\n\n" +
                                         "• Số điện thoại: " + phone + "\n" +
                                         "• Khóa học: " + courseName + "\n" +
                                         "• Đăng ký thêm: " + extraOptions;
                        MessageBox.Show(message, "Thông báo xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi lưu dữ liệu: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void rdoFemale_CheckedChanged(object sender, EventArgs e)
        {
        }
    }

    public class Course
    {
        public string CourseId { get; set; }
        public string CourseName { get; set; }

        public Course(string id, string name)
        {
            CourseId = id;
            CourseName = name;
        }
    }
}
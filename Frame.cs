using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace IOExercise
{
    public partial class Frame : Form
    {
        public Frame()
        {
            InitializeComponent();
        }

        private List<Student> students = new List<Student>();

        private void saveFileButton_Click(object sender, System.EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                lDirectory.Visible = true;
                oDirectory.Visible = true;
                oDirectory.Text = Path.GetFullPath(saveFileDialog.FileName);

                foreach (var item in students)
                {
                    item.WriteToFile(saveFileDialog.FileName);
                }
                MessageBox.Show("Lưu thành công");
            }
            else
            {
                MessageBox.Show("Lưu thất bại");
            }
        }

        private void AddList_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(iCode.Text) || string.IsNullOrEmpty(iName.Text) || string.IsNullOrEmpty(iScore.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            if (double.Parse(iScore.Text) < 0 || double.Parse(iScore.Text) > 10)
            {
                MessageBox.Show("Điểm phải nằm trong khoảng 0 - 10");
                return;
            }
            if (iCode.Text.Length > 10)
            {
                MessageBox.Show("Mã sinh viên không được quá 10 ký tự");
                return;
            }
            ListViewItem item = new ListViewItem((students.Count + 1).ToString());
            item.SubItems.Add(iCode.Text);
            item.SubItems.Add(iName.Text);
            item.SubItems.Add(iScore.Text);
            StudentList.Items.Add(item);
            students.Add(new Student(iCode.Text, iName.Text, double.Parse(iScore.Text)));
            iCode.Text = string.Empty;
            iName.Text = string.Empty;
            iScore.Text = string.Empty;
        }

        private void openFileButton_Click(object sender, System.EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StudentList.Items.Clear();
                students.Clear();

                lDirectory.Visible = true;
                oDirectory.Visible = true;
                oDirectory.Text = Path.GetFullPath(openFileDialog.FileName);

                Student student = new Student();
                student.ReadFromFile(openFileDialog.FileName, StudentList, students);
            };
        }
    }
}
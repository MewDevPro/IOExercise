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

        private void SaveFileButton_Click(object sender, System.EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                lDirectory.Visible = true;
                oDirectory.Visible = true;
                oDirectory.Text = Path.GetFullPath(saveFileDialog.FileName);

                IOModule io = new IOModule();
                io.WriteToFile(saveFileDialog, students);
            }
            else
            {
                Msg.Info("Đã huỷ lưu tệp.");
            }
        }

        private void AddList_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(iCode.Text) || string.IsNullOrEmpty(iName.Text) || string.IsNullOrEmpty(iScore.Text))
            {
                Msg.Error("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            if (double.Parse(iScore.Text) < 0 || double.Parse(iScore.Text) > 10)
            {
                Msg.Error("Điểm phải nằm trong khoảng 0 - 10");
                return;
            }
            ListViewItem item = new ListViewItem((students.Count + 1).ToString());
            students.Add(new Student(iCode.Text, iName.Text, double.Parse(iScore.Text)));
            item.SubItems.Add(iCode.Text);
            item.SubItems.Add(iName.Text);
            item.SubItems.Add(iScore.Text);
            StudentList.Items.Add(item);
            iCode.Text = string.Empty;
            iName.Text = string.Empty;
            iScore.Text = string.Empty;
            iCode.Focus();
        }

        private void OpenFileButton_Click(object sender, System.EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StudentList.Items.Clear();
                students.Clear();

                lDirectory.Visible = true;
                oDirectory.Visible = true;
                oDirectory.Text = Path.GetFullPath(openFileDialog.FileName);

                IOModule io = new IOModule();
                io.ReadFromFile(openFileDialog.FileName, StudentList, students);
            };
        }
    }
}
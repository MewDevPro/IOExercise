using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace IOExercise
{
    internal class Student
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public double Score { get; set; }

        public Student()
        {
        }

        public Student(string code, string name, double score)
        {
            Code = code;
            Name = name;
            Score = score;
        }

        public void WriteToFile(string path)
        {
            BinaryWriter writer = null;
            try
            {
                if (Score >= 8)
                {
                    Stream stream = new FileStream(path, FileMode.Append, FileAccess.Write);
                    writer = new BinaryWriter(stream, Encoding.UTF8, false);
                    writer.Write(Code);
                    writer.Write(Name);
                    writer.Write(Score);
                }
            }
            catch (IOException e)
            {
                MessageBox.Show(e.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                writer?.Close();
            }
        }

        public void ReadFromFile(string path, ListView StudentList, List<Student> students)
        {
            BinaryReader reader = null;
            try
            {
                reader = new BinaryReader(File.Open(path, FileMode.Open), Encoding.UTF8, false);
                while (reader.PeekChar() != -1)
                {
                    string code = reader.ReadString();
                    string name = reader.ReadString();
                    double score = reader.ReadDouble();
                    ListViewItem item = new ListViewItem((students.Count + 1).ToString());
                    item.SubItems.Add(code);
                    item.SubItems.Add(name);
                    item.SubItems.Add(score.ToString());
                    StudentList.Items.Add(item);
                    students.Add(new Student(code, name, score));
                }
            }
            catch (IOException e)
            {
                MessageBox.Show(e.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                reader?.Close();
            }
        }
    }
}

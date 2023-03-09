using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace IOExercise
{
    internal class IOModule
    {
        public IOModule() { }

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
                Msg.Error(e.Message);
            }
            finally
            {
                reader?.Close();
            }
        }

        public void WriteToFile(SaveFileDialog saveFileDialog, List<Student> students)
        {
            string path = saveFileDialog.FileName;
            FileMode mode = (saveFileDialog.OverwritePrompt || saveFileDialog.CreatePrompt) ? FileMode.Create : FileMode.Append;
            foreach (var item in students)
            {
                BinaryWriter writer = null;
                try
                {
                    if (item.Score >= 8)
                    {
                        Stream stream = new FileStream(path, mode, FileAccess.Write);
                        writer = new BinaryWriter(stream, Encoding.UTF8, false);
                        writer.Write(item.Code);
                        writer.Write(item.Name);
                        writer.Write(item.Score);
                        mode = FileMode.Append;
                    }
                }
                catch (IOException e)
                {
                    Msg.Error(e.Message);
                }
                finally
                {
                    writer?.Close();
                }
            }
            Msg.Success("Đã lưu tệp thành công.");
        }
    }
}

using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SimpleImageConverterWinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.png; *.jpg)|*.png;*.jpg";
            openFileDialog.Title = "Выберите изображение";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = openFileDialog.FileName;
            }
        }

        private void btnBrowseFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.Description = "Выберите папку для перемещения";

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                txtFolderPath.Text = folderDialog.SelectedPath;
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string sourcePath = txtFilePath.Text;

            //Проверки
            if (string.IsNullOrEmpty(sourcePath))
            {
                MessageBox.Show("Ошибка: Выберите файл!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!File.Exists(sourcePath))
            {
                MessageBox.Show("Ошибка: Файл не существует!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string extension = Path.GetExtension(sourcePath).ToLower();
            if (extension != ".png" && extension != ".jpg")
            {
                MessageBox.Show("Ошибка: Поддерживаются только PNG и JPG!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Определение целевого формата
            string targetExtension;
            if (radioPngToJpg.Checked)
            {
                targetExtension = ".jpg";
            }
            else
            {
                targetExtension = ".png";
            }

            //Проверка совпадения форматов
            if (extension == targetExtension)
            {
                MessageBox.Show("Ошибка: Форматы совпадают!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Создание новыго пути
            string directory = Path.GetDirectoryName(sourcePath);
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(sourcePath);
            string newFilePath = Path.Combine(directory, fileNameWithoutExtension + targetExtension);

            //Проверка существование файла
            if (File.Exists(newFilePath))
            {
                MessageBox.Show("Ошибка: Файл с таким именем уже существует!",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                //Конвертация изображения
                using (Image image = Image.FromFile(sourcePath))
                {
                    if (targetExtension == ".jpg")
                    {
                        image.Save(newFilePath, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    else
                    {
                        image.Save(newFilePath, System.Drawing.Imaging.ImageFormat.Png);
                    }
                }

                MessageBox.Show($"Успех! Файл сохранен как:\n{newFilePath}",
                    "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            string sourcePath = txtFilePath.Text;
            string targetFolder = txtFolderPath.Text;

            //Проверки ввода пользователя
            if (string.IsNullOrEmpty(sourcePath))
            {
                MessageBox.Show("Ошибка: Выберите файл!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!File.Exists(sourcePath))
            {
                MessageBox.Show("Ошибка: Файл не существует!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string extension = Path.GetExtension(sourcePath).ToLower();
            if (extension != ".png" && extension != ".jpg")
            {
                MessageBox.Show("Ошибка: Поддерживаются только PNG и JPG!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(targetFolder))
            {
                MessageBox.Show("Ошибка: Выберите папку!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Directory.Exists(targetFolder))
            {
                MessageBox.Show("Ошибка: Папка не существует!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Создание пути для перемещения
            string fileName = Path.GetFileName(sourcePath);
            string destinationPath = Path.Combine(targetFolder, fileName);

            //Проверка существования файла
            if (File.Exists(destinationPath))
            {
                MessageBox.Show("Ошибка: Файл с таким именем уже существует в целевой папке!",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                //Перемещение файла
                File.Move(sourcePath, destinationPath);
                MessageBox.Show($"Успех! Файл перемещен в:\n{destinationPath}",
                    "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Очищение поля ввода
                txtFilePath.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioJpgToPng_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

using ImageMagick;

namespace ExifRemover
{
    public partial class Form1 : Form
    {
        private static string[] pathWithFiles = { };
        private static string destination = string.Empty;
        private static HashSet<string> filesNameWithPath = new HashSet<string>();
        public Form1()
        {
            InitializeComponent();
            Thread thread = new Thread(PathToDesktop);
            thread.Start();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Clear();

            OpenFileDialog openFileDialog1 = OpenFile();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pathWithFiles = openFileDialog1.FileNames;
            }

            if (pathWithFiles != null)
            {
                filesNameWithPath = pathWithFiles.ToHashSet();
            }

            richTextBoxImages.Text = string.Join("\n", filesNameWithPath);

            labelItems.Text = $"Items: {filesNameWithPath.Count().ToString()}";
        }
        private static OpenFileDialog OpenFile()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog()
            {
                InitialDirectory = @"C:\",
                Title = "Browse Image Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "All Files",
                Filter = "All Files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true,

                Multiselect = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true,

            };
            return openFileDialog1;
        }
        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            SaveDestination();
            textBoxDestination.Text = destination;
        }
        private void SaveDestination()
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                destination = folderBrowserDialog1.SelectedPath;
            }
        }
        private void PathToDesktop()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            textBoxDestination.Text = path;
        }
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            string selectedFile = richTextBoxImages.SelectedText;

            filesNameWithPath.Remove(selectedFile);

            richTextBoxImages.Text = string.Join("\r\n", filesNameWithPath);
            labelItems.Text = $"Items: {filesNameWithPath.Count()}";
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            Clear();

            labelItems.Text = $"Items: {filesNameWithPath.Count()}";
        }
        private void Clear()
        {
            filesNameWithPath.Clear();
            richTextBoxImages.Clear();
            destination = string.Empty;
            pathWithFiles = null!;
        }
        private async void buttonRemoveExif_Click(object sender, EventArgs e)
        {
            progressBarComplete.Minimum = 0;
            progressBarComplete.Maximum = filesNameWithPath.Count();
            progressBarComplete.Value = 0;

            foreach (var fileNameWithPath in filesNameWithPath)
            {
                string[] file = fileNameWithPath.Split('\\');

                string getFile = file[file.Length - 1];

                string output = textBoxDestination.Text + '\\';
                output += getFile;

                var image = new MagickImage(fileNameWithPath);

                // Exif profile contain information like the device that took the photo, Camera settings, GPS location, Date, Time Zone, ... etc
                var exifProfile = image.GetExifProfile();

                // IPTC profile: Copyright, Permissions and licenses, Creator's information and contact details, Rights usage terms, ...etc
                var iptcProfile = image.GetIptcProfile();

                // Xmp profile: IPTC with additionnal information
                var xmpProfile = image.GetXmpProfile();

                // Remove metadata if exists
                if (exifProfile != null)
                {
                    image.RemoveProfile(exifProfile);
                }
                if (iptcProfile != null)
                {
                    image.RemoveProfile(iptcProfile);
                }
                if (xmpProfile != null)
                {
                    image.RemoveProfile(xmpProfile);
                }

                // Finally save the image without metadata
                image.Format = MagickFormat.Jpg; // Change the output format if needed
                await image.WriteAsync(output);

                // Instead of saving the image, if you want to return an array of byte
                byte[] data = image.ToByteArray();

                //Method II
                //With Another Library SixLabors.ImageSharp
                //=======================================================
                ////using SixLabors.ImageSharp;

                //// Load the image
                //var image2 = await Image.LoadAsync(fileNameWithPath);

                //// Remove metadata
                //image2.Metadata.ExifProfile = null;
                //image2.Metadata.IptcProfile = null;
                //image2.Metadata.XmpProfile = null;

                // Save the image without metadata
                //await image.SaveAsync(output);
                //=======================================================

                progressBarComplete.Value++;
            }
            MessageBox.Show("Wating Complete!");
        }
    }
}
